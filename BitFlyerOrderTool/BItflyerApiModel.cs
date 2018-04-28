using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Net;

public class BitFlyerApiModel
{
    static readonly Uri endpointUri = new Uri("https://api.bitflyer.jp");
    static private string ApiKey { get { return BitFlyerOrderApp.Properties.Settings.Default.API_KEY; } }
    static private string ApiSecret { get { return BitFlyerOrderApp.Properties.Settings.Default.API_SECRET; } }
    static private string TimeInForce { get { return BitFlyerOrderApp.Properties.Settings.Default.DEFAULT_TIME_IN_FORCE; } }
    static private decimal OrderRetry { get { return BitFlyerOrderApp.Properties.Settings.Default.DEFAULT_ORDER_RETRY; } }

    public const string SIDE_BUY = "BUY";
    public const string SIDE_SELL = "SELL";

    public const string CHILD_ORDER_TYPE_LIMIT = "LIMIT";
    public const string CHILD_ORDER_TYPE_MARKET = "MARKET";

    public const string TIME_IN_FORCE_GTC = "GTC";
    public const string TIME_IN_FORCE_IOC = "IOC";
    public const string TIME_IN_FORCE_FOK = "FOK";

    public const string PRODUCT_CODE_BTC_JPY = "BTC_JPY";
    public const string PRODUCT_CODE_FX_BTC_JPY = "FX_BTC_JPY";
    
    public static async Task<string> Order(string side, decimal price, decimal size, int expire)
    {
        return await Order(side, price, size, expire, 0);
    }
    /**
     * 注文処理
     * {"status":-208,"error_message":"Order is not accepted. Please try again later.","data":null}
     * {"status":-204,"error_message":"Market state is closed.","data":null}
     **/
    public static async Task<string> Order(string side, decimal price, decimal size, int expire, int tryCnt)
    {
        var method = "POST";
        var path = "/v1/me/sendchildorder";
        var query = "";

        var orderInfo = new ChildOrderRequestJson();
        orderInfo.product_code = PRODUCT_CODE_FX_BTC_JPY;
        orderInfo.child_order_type = CHILD_ORDER_TYPE_LIMIT;
        orderInfo.side = side;
        orderInfo.price = price;
        orderInfo.size = size;
        orderInfo.minute_to_expire = expire;
        orderInfo.time_in_force = TimeInForce;
        var body = JsonUtility.Serialize(orderInfo);

        var response = await SendPrivateApiRequest(method, path, query, body);

        // 接続自体のエラーや、Exceptionの場合、空の場合、
        // サーバ側に通知が言っている可能性があるのでリトライしない
        if (response == null
            || response.responseBody == null
            || response.responseBody.Length == 0) return "";
        
        // 応答があったが、200以外の場合はりトライ実施(厳密にはafter messageがあるか見るべき)
        if (response.statusCode != HttpStatusCode.OK)
        {
            if(OrderRetry > 0 && OrderRetry >= tryCnt) return await Order(side, price, size, expire, tryCnt + 1);
            return "";
        }
        try
        {
            var res = JsonUtility.Deserialize<ChildOrderResponseJson>(response.responseBody);
            if (res != null && res.child_order_acceptance_id != null) return res.child_order_acceptance_id;
            return "";
        }
        catch (Exception)
        {
            return "";
        }
    }
    public static async Task<bool> CancelChildOrder(string ChildOrderAcceptanceId)
    {
        return await CancelChildOrder(ChildOrderAcceptanceId, 0);
    }

    public static async Task<bool> CancelChildOrder(string ChildOrderAcceptanceId, int tryCnt)
    {
        var method = "POST";
        var path = "/v1/me/cancelchildorder";
        var query = "";

        var reqJsonObj = new CancelChildOrderRequestJson();
        reqJsonObj.product_code = PRODUCT_CODE_FX_BTC_JPY;
        reqJsonObj.child_order_acceptance_id = ChildOrderAcceptanceId;

        var body = JsonUtility.Serialize(reqJsonObj);

        var response = await SendPrivateApiRequest(method, path, query, body);

        // エラーや、200以外の場合はりトライ実施
        if (response == null
            || response.statusCode != HttpStatusCode.OK)
        {
            if (OrderRetry > 0 && OrderRetry >= tryCnt) return await CancelChildOrder(ChildOrderAcceptanceId, tryCnt + 1);
            return false;
        }
        return true;
    }
    public static async Task<bool> CancelAllChildOrder() => await CancelAllChildOrder(0);
    public static async Task<bool> CancelAllChildOrder(int tryCnt)
    {
        var method = "POST";
        var path = "/v1/me/cancelallchildorders";
        var query = "";

        var reqJsonObj = new CancelAllChildOrderRequestJson();
        reqJsonObj.product_code = PRODUCT_CODE_FX_BTC_JPY;

        var body = JsonUtility.Serialize(reqJsonObj);

        var response = await SendPrivateApiRequest(method, path, query, body);

        // エラーや、200以外の場合はりトライ実施
        if (response == null
            || response.statusCode != HttpStatusCode.OK)
        {
            if (OrderRetry > 0 && OrderRetry >= tryCnt) return await CancelAllChildOrder(tryCnt + 1);
            return false;
        }
        return true;
    }

    /**
     * 注文一覧
     **/
    public static async Task<List<HoldOrderInfoResponseJson>> GetOrderList()
    {
        var method = "GET";
        var path = "/v1/me/getchildorders";
        var query = "?product_code=" + PRODUCT_CODE_FX_BTC_JPY + "&child_order_state=ACTIVE";
        var response = await SendPrivateApiRequest(method, path, query, "");
        if (response == null) return null;
        try
        {
            return JsonUtility.Deserialize<List<HoldOrderInfoResponseJson>>(response.responseBody);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    /**
     * 建玉一覧
     **/
    public static async Task<List<PositionInfoResponseJson>> GetPositionList()
    {
        var method = "GET";
        var path = "/v1/me/getpositions";
        var query = "?product_code=" + PRODUCT_CODE_FX_BTC_JPY;
        var response = await SendPrivateApiRequest(method, path, query, "");
        if (response == null) return null;
        try
        {
            return JsonUtility.Deserialize<List<PositionInfoResponseJson>>(response.responseBody);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    /**
     * 認証が必要なAPIリクエスト
     **/
    private static async Task<ResponseObject> SendPrivateApiRequest(string method, string path, string query, string body)
    {
        ResponseObject responseObj = null;

        using (var client = new HttpClient())
        using (var request = new HttpRequestMessage(new HttpMethod(method), path + query))
        using (var content = new StringContent(body))
        {
            client.BaseAddress = endpointUri;
            if (method == "POST")
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Content = content;
            }
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
            var data = timestamp + method + path + query + body;
            var hash = SignWithHMACSHA256(data, ApiSecret);
            request.Headers.Add("ACCESS-KEY", ApiKey);
            request.Headers.Add("ACCESS-TIMESTAMP", timestamp);
            request.Headers.Add("ACCESS-SIGN", hash);

            try
            {
                var responseMessage = await client.SendAsync(request);

                responseObj = new ResponseObject(
                    responseMessage.StatusCode
                    , responseMessage.Headers
                    , await responseMessage.Content.ReadAsStringAsync()
                );
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        return responseObj;
    }
    /**
     * HMACSHA256
     **/
    static string SignWithHMACSHA256(string data, string secret)
    {
        using (var encoder = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
        {
            var hash = encoder.ComputeHash(Encoding.UTF8.GetBytes(data));
            return ToHexString(hash);
        }
    }
    /**
     * byte=>string
     **/
    static string ToHexString(byte[] bytes)
    {
        var sb = new StringBuilder(bytes.Length * 2);
        foreach (var b in bytes)
        {
            sb.Append(b.ToString("x2"));
        }
        return sb.ToString();
    }

    private static decimal lastFxLtp = 0;
    public static decimal getLastFxLtp() => lastFxLtp;
    /**
     * 価格乖離取得
     **/
    public static async Task<decimal> GetPriceSepalationRate()
    {
        var tickInfo = await GetTickerInfo(PRODUCT_CODE_BTC_JPY);
        var tickInfoFx = await GetTickerInfo(PRODUCT_CODE_FX_BTC_JPY);
        if (tickInfo == null || tickInfoFx == null) return 0;
        if (tickInfo.ltp == 0 || tickInfoFx.ltp == 0) return 0;
        // cache
        lastFxLtp = tickInfoFx.ltp;
        return Math.Round((tickInfoFx.ltp / tickInfo.ltp) * 100 - 100, 2);
    }

    /**
     * 価格情報取得 
     **/
    public static async Task<decimal> GetFxLastPrice()
    {
        var tickerInfo = await GetTickerInfo(PRODUCT_CODE_FX_BTC_JPY);
        if (tickerInfo == null) return 0;
        return tickerInfo.ltp;
    }

    private static async Task<TickerInfoResponseJson> GetTickerInfo(string product_code)
    {
        try
        {
            return JsonUtility.Deserialize<TickerInfoResponseJson>(await SendApiRequest("/v1/getticker", " ?product_code=" + product_code));
        }
        catch (Exception)
        {
            // JsonParseエラー等が出たところで、何もできない
            // BitFlyerのAPIは重くなると、クラウドフレアのHTMLを吐き出すのでエラーになる
            return null;
        }
    }

    /**
     * サーバステータス取得 
     **/
    public static async Task<BoardStateResponseJson> GetServerStatus()
    {
        try
        {
            return JsonUtility.Deserialize<BoardStateResponseJson>(await SendApiRequest("/v1/getboardstate", "?product_code=" + PRODUCT_CODE_FX_BTC_JPY));
        }
        catch(Exception)
        {
            return null;
        }
    }

    /**
     * パブリックAPIリクエスト
     * 失敗しても困る情報はほぼないので、エラーは無視
     **/
    private static async Task<string> SendApiRequest(string path, string query)
    {
        string method = "GET";
        using (var client = new HttpClient())
        using (var request = new HttpRequestMessage(new HttpMethod(method), path + query))
        {
            try
            {
                client.BaseAddress = endpointUri;
                var message = await client.SendAsync(request);
                var response = await message.Content.ReadAsStringAsync();
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return "";
    }
}

// For .NET Framework 4.5 or before
static class DateTimeOffsetExtension
{
    static readonly DateTimeOffset unixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
    public static long ToUnixTimeSeconds(this DateTimeOffset dt)
    {
        return (long)dt.Subtract(unixEpoch).TotalSeconds;
    }
}

public class ResponseObject
{
    public System.Net.HttpStatusCode statusCode;
    public System.Net.Http.Headers.HttpResponseHeaders responseHeader;
    public string responseBody;

    public ResponseObject(HttpStatusCode statusCode, HttpResponseHeaders responseHeader, string responseBody)
    {
        this.statusCode = statusCode;
        this.responseHeader = responseHeader;
        this.responseBody = responseBody;
    }
}

[DataContract]
public class ChildOrderRequestJson
{
    [DataMember]
    public string product_code { get; set; }
    [DataMember]
    public string child_order_type { get; set; }
    [DataMember]
    public string side { get; set; }
    [DataMember]
    public decimal price { get; set; }
    [DataMember]
    public decimal size { get; set; }
    [DataMember]
    public decimal minute_to_expire { get; set; }
    [DataMember]
    public string time_in_force { get; set; }
}


[DataContract]
public class ChildOrderResponseJson
{
    [DataMember]
    public string child_order_acceptance_id { get; set; }
}

[DataContract]
public class CancelChildOrderRequestJson
{
    [DataMember]
    public string product_code { get; set; }

    [DataMember]
    public string child_order_acceptance_id { get; set; }
}
[DataContract]
public class CancelAllChildOrderRequestJson
{
    [DataMember]
    public string product_code { get; set; }
}

[DataContract]
public class BoardStateResponseJson
{
    [DataMember]
    public string health { get; set; }
    [DataMember]
    public string state { get; set; }
}

[DataContract]
public class TickerInfoResponseJson
{
    [DataMember]
    public string product_code { get; set; }
    [DataMember]
    public string timestamp { get; set; }
    [DataMember]
    public decimal tick_id { get; set; }
    [DataMember]
    public decimal best_bid { get; set; }
    [DataMember]
    public decimal best_ask { get; set; }
    [DataMember]
    public decimal best_bid_size { get; set; }
    [DataMember]
    public decimal best_ask_size { get; set; }
    [DataMember]
    public decimal total_bid_depth { get; set; }
    [DataMember]
    public decimal total_ask_depth { get; set; }
    [DataMember]
    public decimal ltp { get; set; }
    [DataMember]
    public decimal volume { get; set; }
    [DataMember]
    public decimal volume_by_product { get; set; }
}
public class HoldOrderInfoResponseJson
{
    [DataMember]
    public decimal id { get; set; }
    [DataMember]
    public string child_order_id { get; set; }
    [DataMember]
    public string product_code { get; set; }
    [DataMember]
    public string side { get; set; }
    [DataMember]
    public string child_order_type { get; set; }
    [DataMember]
    public decimal price { get; set; }
    [DataMember]
    public decimal average_price { get; set; }
    [DataMember]
    public decimal size { get; set; }
    [DataMember]
    public string child_order_state { get; set; }
    [DataMember]
    public string expire_date { get; set; }
    [DataMember]
    public string child_order_date { get; set; }
    [DataMember]
    public string child_order_acceptance_id { get; set; }
    [DataMember]
    public decimal outstanding_size { get; set; }
    [DataMember]
    public decimal cancel_size { get; set; }
    [DataMember]
    public decimal executed_size { get; set; }
    [DataMember]
    public decimal total_commission { get; set; }
}

public class PositionInfoResponseJson
{
    [DataMember]
    public string product_code { get; set; }
    [DataMember]
    public string side { get; set; }
    [DataMember]
    public decimal price { get; set; }
    [DataMember]
    public decimal size { get; set; }
    /** 手数料 */
    [DataMember]
    public decimal commission { get; set; }
    /** Swap(現物のみ?) */
    [DataMember]
    public decimal swap_point_accumulate { get; set; }
    /** 証拠金 */
    [DataMember]
    public decimal require_collateral { get; set; }
    [DataMember]
    /** exec_dateに対応 */
    public string open_date { get; set; }
    /** レバレッジ */
    [DataMember]
    public decimal leverage { get; set; }
    /** 評価金額? */
    [DataMember]
    public decimal pnl { get; set; }
    [DataMember]
    public decimal sfd { get; set; }
    /** 一覧表示拡張用 */
    public decimal PriceBand { get; set; }
    public string localDateTime { get { return Util.FormatDateIsoToLocal(open_date, Util.DATETIME_FORMAT_MDHMS); } }

    public override bool Equals(object obj)
    {
        if (obj == null || this.GetType() != obj.GetType()) return false;

        PositionInfoResponseJson c = (PositionInfoResponseJson)obj;
        if (open_date == c.open_date
            && side == c.side
            && price == c.price
            && size == c.size
            && require_collateral == c.require_collateral) return true;
        return false;
    }

    int hashCode = 0;
    public override int GetHashCode()
    {
        int hash = 0;
        if (hashCode > 0)
        {
            hash = hashCode;
        }
        else
        {
            hash =
            (open_date.GetHashCode() * 2)
            + (side.GetHashCode() * 3)
            + (price.GetHashCode() * 5)
            + (size.GetHashCode() * 7)
            + (require_collateral.GetHashCode() * 11);
        }
        return hash;
    }
}
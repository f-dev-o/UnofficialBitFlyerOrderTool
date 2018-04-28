using System;

public static class Util
{
    public const string DATETIME_FORMAT_MDHMS = "MM/dd HH:mm:ss";
    /**
        * LocalTime表示への変換
        **/
    public static string FormatDateIsoToLocal(string datetime, string format)
    {
        var srcDateTime = DateTime.Parse(datetime, null, System.Globalization.DateTimeStyles.RoundtripKind);
        return srcDateTime.ToLocalTime().ToString(format);
    }
}

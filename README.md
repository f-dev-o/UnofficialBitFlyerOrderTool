# UnofficialBitFlyerOrderTool
___

#### このアプリの目的
軽量な発注手段の確保
___
#### 注意事項

**私用なので、利用は自己責任でお願いします**  
**私用なので、雑な実装になっています**  
**APIKey/APISecretが必要になります(入出金はチェックしないでください)**  
軽量化の為、古い実装方法を採用しています  
現状では、この画面から発注して、BitFlyer公式画面で確認するという形で使用中  
一覧画面は実装中  

___
#### 動機
下記要因の回避を目的としています
- 取引価格表示更新による画面遅延  
- チャートのレンダリングによる画面遅延  
- 取引板のレンダリングによる画面遅延  
- チャット荒らしによる画面遅延  
- 注文拒否による待ち時間
- 注文前にチェック処理をリクエストしているせいで倍時間がかかるケースの回避  

___
#### 実装済み機能
- 最新価格の設定
- 単純な指値注文  
- 注文時の有効期限設定  
- 価格乖離/SFD表示  
- サーバ状態表示
- 注文リトライ機能
   - 入札拒否された際に指定回数まで自動的にリトライします  <br>
  接続エラーが発生した場合は、重複注文の可能性が高まるので、正常ケース以外はリトライしません
- 一覧からの注文キャンセル機能
   - 個別削除の要求は通っても、注文一覧のAPIからのレスポンスが古かったり、削除に成功したIDが返ってくることがある(おそらくラウンドロビンで反映遅延)  
   - 一括削除で指定した際、child_order_idが発行されていないものは、対象にならない不具合(API側のバグ)を確認  
- 建玉表示 4/29

### 実装予定機能
- 入札価格乖離確認(現在価格より数パーセント高値での買い注文、低値での売り注文への警告)
- 秒間購買Size表示
- 板情報表示
- ltp指値注文
- 指値注文時、指定価格離れた場所に自動的に損切り設定
- 入札時、注文末尾補正(板情報から、指定桁の範囲内で厚い板を回避する)  

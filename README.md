## MVC5 practice
此範例嘗試以MVC5寫一個簡易查詢網頁著手, 程式中使用json.net + linq進行資料處理後, 回傳至MVC網頁~
- [網頁圖示](https://github.com/Vida-Chen/MVC/blob/master/mvctest.png "網頁圖示")

起手式 - 資料準備是不可免的, 故先上網查找並下載一份open data(json file，此例來自於台中市政府網站上的open data)
- [Json 圖示](https://github.com/Vida-Chen/MVC/blob/master/mvctest_json.png "Json 圖示")

練習重點：
- Controller與View的data binding
  + Html.BeginForm, 以form形式將資料從view傳至controller
  + ViewData、ViewBag、TempData, 可從controller至view, 此例使用TempData並設定keep屬性為true的方式,保存跨action間資料的延續性 
  + 將查詢條件與結果拆成view及partialview進行render與各別model binding
- 使用Razor語法
  + 產生label、textbox、dropdownlist、table等常見html控制項
  + if...判斷式及for迴圈動態產生table中的tr element
- linq
  + 使用json.net讀入file反序列化成自訂的DTO物件後, 再使用linq進行資料查詢
- 引用css
  + 由於一開始是以空白MVC範本建立專案, 所以可從頭至尾練習如何引用自訂的style及js
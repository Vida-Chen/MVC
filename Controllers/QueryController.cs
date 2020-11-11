using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MVCTest.Controllers
{
	public class QueryController : Controller
	{
		public ActionResult Query(WifiInfoT wifiInfo)
		{
			if (!string.IsNullOrEmpty(wifiInfo.地址) || !string.IsNullOrEmpty(wifiInfo.鄉鎮市區))
			{
				//string baseDir = AppDomain.CurrentDomain.BaseDirectory;
				//string filePath = Path.Combine(baseDir, @"Models\Json\公眾區免費無線上網熱點資料_1.json")
				string filePath = Server.MapPath(@"~/Models/Json/公眾區免費無線上網熱點資料_1.json");
				FileInfo jsonFile = new FileInfo(filePath);
				if (jsonFile.Exists)
				{
					var jsonObj = JsonConvert.DeserializeObject<List<WifiInfoT>>(jsonFile.OpenText().ReadToEnd());
					wifiInfo.WifiInfos = jsonObj.Where(x => (string.IsNullOrEmpty(wifiInfo.地址) || x.地址.IndexOf(wifiInfo.地址) > -1) &&
					(string.IsNullOrEmpty(wifiInfo.鄉鎮市區) || x.鄉鎮市區.IndexOf(wifiInfo.鄉鎮市區) > -1)).ToList();

					//using (StreamReader file = new FileInfo(@"C:\5. Code\1.VS_Code\MVCTest\Controllers\data.json").OpenText())
					//{
					//    JsonSerializer serializer = new JsonSerializer();
					//    List<WifiInfo> wInfo = (List<WifiInfo>)serializer.Deserialize(file, typeof(List<WifiInfo>));                  
					//}
				}
			}
			else
			{
				ModelState.AddModelError("Criteria", "請至少選擇一項查詢條件!");
			}
			return View("../Home/Index", wifiInfo);
		}
	}
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Models;
using Newtonsoft.Json;

namespace MVCTest.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			Init();
			return View();
		}

		[HttpPost]
		public ActionResult Index(WifiInfoT wifiInfo)
		{
			if (!string.IsNullOrEmpty(wifiInfo.地址) || !string.IsNullOrEmpty(wifiInfo.鄉鎮市區))
			{
				return RedirectToAction("Query", "Query", wifiInfo);
			}
			else
			{
				ModelState.AddModelError("Criteria", "請至少選擇一項查詢條件!");
				return View(wifiInfo);
			}
		}

		private void Init()
		{
			List<SelectListItem> itemList = new List<SelectListItem>();
			string filePath = Server.MapPath(@"~/Models/Json/公眾區免費無線上網熱點資料_1.json");
			FileInfo jsonFile = new FileInfo(filePath);
			if (jsonFile.Exists)
			{
				var jsonObj = JsonConvert.DeserializeObject<List<WifiInfoT>>(jsonFile.OpenText().ReadToEnd());
				var townList = jsonObj.OrderBy(x=>x.鄉鎮市區_英語).Select(x => x.鄉鎮市區).Distinct();
				itemList.Add(new SelectListItem { Text = "", Value = "" });
				itemList.AddRange(townList.Select(data => new SelectListItem { Text = data, Value = data }).ToList());
			}
			TempData["Town"] = itemList;
		}
	}
}
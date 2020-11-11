using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
	public class WifiInfo
	{
		[Display(Name = "項次")]
		public string ItemNum { get; set; }

		[Display(Name = "熱點類別")]
		public string ItemType { get; set; }

		[Display(Name = "熱點名稱")]
		public string ItemName { get; set; }

		[Display(Name = "郵遞區號")]
		public string ZipCode { get; set; }

		[Display(Name = "縣市名稱")]
		public string County { get; set; }

		[Display(Name = "鄉鎮市區")]
		public string Town { get; set; }

		[Display(Name = "地址")]
		public string Address { get; set; }

		[Display(Name = "熱點類別_英語")]
		public string ItemType_EN { get; set; }

		[Display(Name = "熱點名稱_英語")]
		public string ItemName_EN { get; set; }

		[Display(Name = "縣市名稱_英語")]
		public string County_EN { get; set; }

		[Display(Name = "鄉鎮市區_英語")]
		public string Town_EN { get; set; }

		[Display(Name = "地址_英語")]
		public string Address_EN { get; set; }

		public List<WifiInfo> WifiInfos { get; set; }

		public WifiInfo()
		{
			WifiInfos = new List<WifiInfo>();
		}
	}
}
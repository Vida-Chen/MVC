using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
	public class WifiInfoT
	{
		public string 項次 { get; set; }
		public string 熱點類別 { get; set; }
		public string 熱點名稱 { get; set; }
		public string 郵遞區號 { get; set; }
		public string 縣市名稱 { get; set; }
		public string 鄉鎮市區 { get; set; }
		public string 地址 { get; set; }
		public string 熱點類別_英語 { get; set; }
		public string 熱點名稱_英語 { get; set; }
		public string 縣市名稱_英語 { get; set; }
		public string 鄉鎮市區_英語 { get; set; }
		public string 地址_英語 { get; set; }
		public List<WifiInfoT> WifiInfos { get; set; }

		public WifiInfoT()
		{
			WifiInfos = new List<WifiInfoT>();
		}
	}
}
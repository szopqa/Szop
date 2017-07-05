using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Infrastructure
{

	/// <summary>
	/// Returns path of icon for categories 
	/// </summary>
	public class AppConfig
	{
		private static string _ikonyKategoriiFolderWzgledny = ConfigurationManager.AppSettings["IkonyKategoriiFolder"];

		public static string IkonyKategoriiFolderWzgledny
		{
			get{
				return _ikonyKategoriiFolderWzgledny;
			}
		}

		private static string _obrazkiFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];
		public static string ObrazkiFolderWzgledny
		{
			get {
				return _obrazkiFolderWzgledny;
			}
		}


	}
}

using SklepInternetowy.DAL;
using SklepInternetowy.Models;
using SklepInternetowy.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {

		private KursyContext db = new KursyContext ( );
		
		// GET: Home
        public ActionResult Index() 
        {

			var kategorie = db.Kategorie.ToList ( );

			//Taking 3 courses with flag != Hidden added last
			var nowosci = db.Kursy.Where ( a => !a.Ukryte ).OrderByDescending ( a => a.DataDodania ).Take(3);

			var bestseller = db.Kursy.Where ( a => !a.Ukryte && a.Bestseller ).OrderBy(a =>	Guid.NewGuid()).Take(3).ToList();

			var vm = new HomeViewModel ( )
			{
				Kategorie = kategorie,
				Bestsellery = bestseller,
				Nowosci = nowosci
			};


            return View(vm);
        }

		public ActionResult StronyStatyczne ( string nazwa )
		{
			return View ( nazwa );
		}

    }
}
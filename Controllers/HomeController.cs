using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleWebMVC.Controllers {
	public class HomeController: Controller {
		public ActionResult Index () {
            Desharp.Debug.Dump(this.Request.Url.AbsoluteUri);
			return View();
		}

		public ActionResult About () {
			ViewBag.Message = "Your application description page.";
            Desharp.Debug.Dump(this.Request.Url.AbsoluteUri);
			return View();
		}

		public ActionResult Contact (int productId = -1) {
			ViewBag.Message = "Your contact page.";
            Desharp.Debug.Dump(this.Request.Url.AbsoluteUri);
			return View();
		}
	}
}
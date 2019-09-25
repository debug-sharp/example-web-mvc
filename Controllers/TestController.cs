using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleWebMVC.Controllers
{
    public class TestController : Controller {
		public JsonResult Test1 () {
			Desharp.Debug.Dump(
				this.Request.QueryString, 
				this.Request.RequestContext.RouteData
			);
			return Json("first", JsonRequestBehavior.AllowGet);
		}
		public JsonResult Test2 (double? second) {
			Type targetType = typeof(double);
			object retypedQueryString = null;
			try {
				targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
				retypedQueryString = Convert.ChangeType(this.Request.QueryString["second"], targetType);
			} catch { }
			Desharp.Debug.Dump(
				second,
				retypedQueryString,
				this.Request.QueryString,
				this.Request.RequestContext.RouteData
			);
			return Json("second", JsonRequestBehavior.AllowGet);
		}
		public JsonResult Test3 (double? third = 33.3) {
			Type targetType = typeof(double);
			object retypedQueryString = null;
			try {
				targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
				retypedQueryString = Convert.ChangeType(this.Request.QueryString["third"], targetType);
			} catch { }
			Desharp.Debug.Dump(
				third,
				retypedQueryString,
				this.Request.QueryString,
				this.Request.RequestContext.RouteData
			);
			return Json("third", JsonRequestBehavior.AllowGet);
		}
	}
}
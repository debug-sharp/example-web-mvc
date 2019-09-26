using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExampleWebMVC.Controllers {
    public class IndexController: Controller {
        public ActionResult Index () {
            
            Desharp.Debug.Dump(this.Request.Url.AbsoluteUri);
            //this._runSimulatedException();

            this.Session["list"] = new List<string>() { "a", "b", "c" };
			this.Session["integer"] = 123;

			return View();
        }
        public ActionResult Submit () {
			MemoryStream memstream = new MemoryStream();
			Request.InputStream.CopyTo(memstream);
			memstream.Position = 0;
			string rawPost;
			using (StreamReader reader = new StreamReader(memstream)) {
				rawPost = reader.ReadToEnd();
			}
			Desharp.Debug.Dump("submitting");
			Desharp.Debug.Dump(this.Request.Url.Query);
			Desharp.Debug.Dump(this.Request.QueryString);
			Desharp.Debug.Dump(this.Request.Form);
			Desharp.Debug.Dump(rawPost);
			return Redirect(this.Url.RouteUrl("Done"));
        }
        public ActionResult Done () {
			Desharp.Debug.Dump("done");
			Desharp.Debug.Dump(this.Request.Url.Query);
			Desharp.Debug.Dump(this.Request.QueryString);
			Desharp.Debug.Dump(this.Request.Form);
			return View();
		}
		private void _runSimulatedException () {
			Dictionary<int[], string> versionsVsEditorKeys = new Dictionary<int[], string>() {
				{ new int[] {  1, 2 }, "abc" },
			};
			int[] intsKey = new int[] { 1, 2 };
			string r = versionsVsEditorKeys[intsKey];
		}
	}
}
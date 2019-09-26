using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExampleWebMVC {
	public class RouteConfig {
        public static void RegisterRoutes (RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Index",
				url: "Index",
				defaults: new { controller = "Index", action = "Index", something = UrlParameter.Optional },
				constraints: new {
					something = @"\d*"
				}
			);
			routes.MapRoute(
                name: "Submit",
                url: "Index/Submit",
                defaults: new { controller = "Index", action = "Submit" }
            );
            routes.MapRoute(
                name: "Done",
                url: "Index/Done",
                defaults: new { controller = "Index", action = "Done" }
			);


			routes.MapRoute(
				name: "test1a",
				url: "test1a",
				defaults: new { controller = "Test", action = "Test1" }
			);
			routes.MapRoute(
				name: "test1b",
				url: "test1b",
				defaults: new { controller = "Test", action = "Test1", first = UrlParameter.Optional },
				constraints: new {
					first = @"[\d\.]*"
				}
			);
			routes.MapRoute(
				name: "test1c",
				url: "test1c/{first}",
				defaults: new { controller = "Test", action = "Test1", first = UrlParameter.Optional },
				constraints: new {
					//first = @"[\d\.]*"
				}
			);
			routes.MapRoute(
				name: "test1d",
				url: "test1d",
				defaults: new { controller = "Test", action = "Test1", first = 1 },
				constraints: new {
					first = @"[\d\.]*"
				}
			);
			routes.MapRoute(
				name: "test1e",
				url: "test1e/{first}",
				defaults: new { controller = "Test", action = "Test1", first = 1 },
				constraints: new {
					//first = @"[\d\.]*"
				}
			);


			// Exception if no param: The parameters dictionary contains a null entry for parameter 'second' of non-nullable type 'System.Int32' for method 'System.Web.Mvc.JsonResult Test2(Int32)' in 'ExampleWebMVC.Controllers.TestController'. An optional parameter must be a reference type, a nullable type, or be declared as an optional parameter.Parameter name: parameters
			routes.MapRoute(
				name: "test2a",
				url: "test2a",
				defaults: new { controller = "Test", action = "Test2" }
			);
			// Exception if no param: The parameters dictionary contains a null entry for parameter 'second' of non-nullable type 'System.Int32' for method 'System.Web.Mvc.JsonResult Test2(Int32)' in 'ExampleWebMVC.Controllers.TestController'. An optional parameter must be a reference type, a nullable type, or be declared as an optional parameter.Parameter name: parameters
			routes.MapRoute(
				name: "test2b",
				url: "test2b",
				defaults: new { controller = "Test", action = "Test2", second = UrlParameter.Optional }/*,
				constraints: new { second = @"[\d]*" }*/
			);
			routes.MapRoute(
				name: "test2c",
				url: "test2c/{second}",
				defaults: new { controller = "Test", action = "Test2", second = UrlParameter.Optional }/*,
				constraints: new { second = @"[\d]*" }*/
			);
			routes.MapRoute(
				name: "test2d",
				url: "test2d",
				defaults: new { controller = "Test", action = "Test2", second = 2 },
				constraints: new { second = @"[\d]*" }
			);
			routes.MapRoute(
				name: "test2e",
				url: "test2e/{second}",
				defaults: new { controller = "Test", action = "Test2", second = 2 }/*,
				constraints: new { second = @"[\d]*" }*/
			);


			routes.MapRoute(
				name: "test3a",
				url: "test3a",
				defaults: new { controller = "Test", action = "Test3" }
			);
			routes.MapRoute(
				name: "test3b",
				url: "test3b",
				defaults: new { controller = "Test", action = "Test3", third = UrlParameter.Optional }/*,
				constraints: new { third = @"\d*" }*/
			);
			routes.MapRoute(
				name: "test3c",
				url: "test3c/{third}",
				defaults: new { controller = "Test", action = "Test3", third = UrlParameter.Optional }/*,
				constraints: new { third = @"[\d]*" }*/
			);
			routes.MapRoute(
				name: "test3d",
				url: "test3d",
				defaults: new { controller = "Test", action = "Test3", third = 3 },
				constraints: new { third = @"[\d]*" }
			);
			routes.MapRoute(
				name: "test3e",
				url: "test3e/{third}",
				defaults: new { controller = "Test", action = "Test3", third = 3 }/*,
				constraints: new { third = @"[\d]*" }*/
			);


			routes.MapRoute(
				name: "contact",
				url: "contact",
				defaults: new { controller = "Home", action = "Contact" }
			);
            routes.MapRoute(
				name: "about",
				url: "about",
				defaults: new { controller = "Home", action = "About" }
			);
            routes.MapRoute(
				name: "home",
				url: "",
				defaults: new { controller = "Home", action = "Index" }
			);

			
			routes.MapRoute(
                name: "Mvc",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = UrlParameter.Optional, id = UrlParameter.Optional }
            );
			
        }
    }
}

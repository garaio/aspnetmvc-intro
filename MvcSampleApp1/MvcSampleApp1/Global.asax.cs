using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using MvcSampleApp1.Helpers;
using MvcSampleApp1.Models;

namespace MvcSampleApp1
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterRoutes(RouteTable.Routes);

			KontaktStore.AddKontakt(new Kontakt { Vorname = "Leo", Name = "von Wyss", Strasse = "Laupenstr. 45", PLZ = "3000", Ort = "Bern", Land = "CH" });
			KontaktStore.AddKontakt(new Kontakt { Vorname = "David", Name = "Bailey", Strasse = "Hardturmstr. 3", PLZ = "8005", Ort = "Zürich", Land = "CH" });
		}
	}
}
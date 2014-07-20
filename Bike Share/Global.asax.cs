﻿using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace BikeShare
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            RouteConfig.RegisterRoutes(routes);
        }

        /// <summary>
        /// Runs at application startup
        /// Adds App administrators to the database if not present already
        /// </summary>
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer<BikeShare.Models.BikesContext>(new BikeShare.Models.BikesContext.SettingsInitializer());
            //if (!Roles.RoleExists("superAdmin"))
            //{
            //    Roles.CreateRole("superAdmin");
            //}
            //if (!Roles.IsUserInRole("sgvp", "superAdmin"))
            //{
            //    Roles.AddUserToRole("sgvp", "superAdmin");
            //}
            //if (!Roles.IsUserInRole("sgpres", "superAdmin"))
            //{
            //    Roles.AddUserToRole("sgpres", "superAdmin");
            //}
            //if (!Roles.IsUserInRole("sgsvcs", "superAdmin"))
            //{
            //    Roles.AddUserToRole("sgsvcs", "superAdmin");
            //}
            //if (!Roles.IsUserInRole("sgprod", "superAdmin"))
            //{
            //    Roles.AddUserToRole("sgprod", "superAdmin");
            //}
        }
    }
}
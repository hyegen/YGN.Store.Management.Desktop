////using Microsoft.Owin.Security.DataHandler.Encoder;
////using Microsoft.Owin.Security.Jwt;
////using System;
////using System.Collections.Generic;
////using System.Configuration;
////using System.IO;
////using System.Linq;
////using System.Web;
////using System.Web.Configuration;
////using System.Web.Http;
////using System.Web.Mvc;
////using System.Web.Optimization;
////using System.Web.Routing;
////using Microsoft.Owin.Security;
////using Owin;
////using System.IdentityModel.Tokens;
////using Microsoft.IdentityModel.Tokens;
////using Microsoft.Owin.Builder;
////using Microsoft.Owin;
////using AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode;

////namespace YGN.Store.Management.Web.Service
////{
////    public class WebApiApplication : System.Web.HttpApplication
////    {
////        protected void Application_Start()  
////        {
////            AreaRegistration.RegisterAllAreas();
////            GlobalConfiguration.Configure(WebApiConfig.Register);
////            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
////            RouteConfig.RegisterRoutes(RouteTable.Routes);
////            BundleConfig.RegisterBundles(BundleTable.Bundles);
////        }
////    }
////}

//using Microsoft.Owin.Security.DataHandler.Encoder;
//using Microsoft.Owin.Security.Jwt;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Configuration;
//using System.Web.Http;
//using System.Web.Mvc;
//using System.Web.Optimization;
//using System.Web.Routing;
//using Microsoft.Owin.Security;
//using Owin;
//using System.IdentityModel.Tokens;
//using Microsoft.IdentityModel.Tokens;
//using Microsoft.Owin.Builder;
//using Microsoft.Owin;
//using AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode;
//using System.Text;

//[assembly: OwinStartup(typeof(YGN.Store.Management.Web.Service.WebApiApplication))]
//namespace YGN.Store.Management.Web.Service
//{
//    public class WebApiApplication : System.Web.HttpApplication
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            //ConfigureJwtAuth(app);
//            ConfigureAuth(app);
//            var config = new HttpConfiguration();
//            WebApiConfig.Register(config);

//        }

//        protected void Application_Start()
//        {
//            AreaRegistration.RegisterAllAreas();
//            GlobalConfiguration.Configure(WebApiConfig.Register);
//            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
//            RouteConfig.RegisterRoutes(RouteTable.Routes);
//            BundleConfig.RegisterBundles(BundleTable.Bundles);
//        }

//        private void ConfigureJwtAuth(IAppBuilder app)
//        {
//            var issuer = "http://192.168.43.16";
//            var audience = "http://192.168.43.16";
//            var secret = TextEncodings.Base64Url.Decode("aHVzZXlpbnllZ2Vu");

//            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
//            {
//                AuthenticationMode = AuthenticationMode.Active,
//                TokenValidationParameters = new TokenValidationParameters
//                {
//                    ValidIssuer = issuer,
//                    ValidAudience = audience,
//                    IssuerSigningKey = new SymmetricSecurityKey(secret)
//                }
//            });
//        }
//        public void ConfigureAuth(IAppBuilder app)
//        {
//            var key = Encoding.UTF8.GetBytes("aHVzZXlpbnllZ2Vu");

//            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
//            {
//                TokenValidationParameters = new TokenValidationParameters
//                {
//                    ValidateIssuer = false,
//                    ValidateAudience = false,
//                    ValidateLifetime = true,
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(key)
//                }
//            });
//        }
//    }
//}
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.Jwt;
using System;
using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin.Security;
using Owin;
using System.IdentityModel.Tokens;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(YGN.Store.Management.Web.Service.WebApiApplication))]
namespace YGN.Store.Management.Web.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            var key = Encoding.UTF8.GetBytes("aHVzZXlpbnllZ2Vu");
     
            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }
            });
        }
    }
}


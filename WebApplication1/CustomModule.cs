using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class CustomModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication ap = sender as HttpApplication;
            if (ap != null)
            {
                ap.Response.Write("汤姆大叔测试PreApplicationStartMethod通过！<br/>");
            }
        }

        public void Dispose()
        {
            //nothing to do here
        }
    }
    public class PreApplicationStartCode
    {
        private static bool hasLoaded;

        public static void PreStart()
        {
            if (!hasLoaded)
            {
                hasLoaded = true;
                //注意这里的动态注册，此静态方法在Microsoft.Web.Infrastructure.DynamicModuleHelper
                DynamicModuleUtility.RegisterModule(typeof(CustomModule));
            }
        }
    }
}
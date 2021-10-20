using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace GetIPServer.Controllers
{
    public class GetIPServerController : Controller
    {
        // GET: GetIPServer
        public string Index()
        {
            string str = "";

            str += "MachineName: " + Server.MachineName;
            str += "<br>";
            str += "IPServer:" + Request.ServerVariables["LOCAL_ADDR"];
            str += "<br><br>";
            str += "ServerName: " + System.Web.HttpContext.Current.Request.ServerVariables["SERVER_NAME"];
            str += "<br>";
            str += "IPServer: " + System.Web.HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"];
            str += "<br><br>";
            str += "HostName: " + Dns.GetHostName();
            str += "<br>";
            str += "IPServer: " + Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();

            return str;
        }
    }
}

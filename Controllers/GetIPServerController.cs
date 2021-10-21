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

            str += "HostName: " + Dns.GetHostName();
            str += "<br>";
            str += "IPServer: " + Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
            str += "<br><br>";
            str += "IPServer: " + Dns.GetHostAddresses(Dns.GetHostName()).Last().ToString(); // Local IP

            return str;
        }
    }
}

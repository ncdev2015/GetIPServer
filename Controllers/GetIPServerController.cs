using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetIPServer.Controllers
{
    public class GetIPServerController : Controller
    {
        // GET: GetIPServer
        public string Index()
        {
            return Server.MachineName + "<br>" + Request.ServerVariables["LOCAL_ADDR"];
        }
    }
}

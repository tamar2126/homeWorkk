using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebApplication1.Controllers
{
    public class CustomAuthorize : System.Web.Http.AuthorizeAttribute
    {     
        protected override bool IsAuthorized(HttpActionContext context)
        {
            var token= HttpContext.Current.Request.Headers["Authorization"];
            if(token!=null)     
                if(token=="1234")
                    return true;
            return false;


        }


    }
}
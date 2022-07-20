using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using COMMON;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/company")]
    [CustomAuthorize]
    public class CompanyController : ApiController
    {
        [Route("allCompany")]
        [HttpPost]
        public List<ComCompany> AllCompanies()
        {
            return BL.Company.AllCompanies();
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COMMON;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/employee")]
    [CustomAuthorize]
    public class EmployeeController : ApiController
    {
        [Route("numOfEmployeeAtMonth")]
        [HttpPost]
        public int[] NumOfEmployeeAtMonthByCompanyId([FromBody] int companyId)
        {
            return BL.Employee.NumOfEmployeeAtMonth(companyId);
        }
        [Route("allEmployee")]
        [HttpPost]
        public List<ComEmployee> AllEmployee([FromBody] int companyId)
        {
            return BL.Employee.AllEmployee(companyId);
        }

    }
}

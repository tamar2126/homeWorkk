using COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Company
    {
        public static  List<ComCompany> AllCompanies()
        {
         // return new List<ComCompany>();
            return  DAL.CompanyD.AllCompanies();
        }
    }
}

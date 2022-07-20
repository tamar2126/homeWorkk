using COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompanyD
    {
        private static List<ComCompany> castToCom(List<company_tbl> arrCompany)
        {
            var company = new List<ComCompany>();
            foreach (var item in arrCompany)
            {
                company.Add(new ComCompany()
                { Id = item.company_id, Name = item.company_name }
                );
            }
            return company;
        }
        public static List<ComCompany> AllCompanies()
        {
            using (employeesEntities DB = new employeesEntities())
            {
                var t = DB.company_tbl.ToList();
                return castToCom(DB.company_tbl.ToList());
            }
        }
    }
}

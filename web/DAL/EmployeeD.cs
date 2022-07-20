using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON;

namespace DAL
{
    public class EmployeeD
    {
        private static List<ComEmployee> castToCom(List<emplooyes_tbl> arrEmployee)
        {
            var employees = new List<ComEmployee>();
            foreach (var item in arrEmployee)
            {
                employees.Add(new ComEmployee()
                { Id = item.emplooye_id,
                  CompanyEmployeeId=item.company_employee_id ,
                  EmplooyeName=item.emplooye_name ,
                  EndWorkDate=item.end_work_date ,
                  StartWorkDate=item.start_work_date 
                }
                ) ;
            }
            return employees;
        }

        public static List<ComEmployee> NumOfEmployeeAtMonth(int companyId)
        {

            using (employeesEntities DB = new employeesEntities())
            {
                return castToCom(DB.emplooyes_tbl.Where(e => e.company_employee_id == companyId).ToList());
            }

        }

        public static List<ComEmployee> AllEmployee(int companyId)
        {

            using (employeesEntities DB = new employeesEntities())
            {
                return castToCom(DB.emplooyes_tbl.Where(e => e.company_employee_id == companyId).ToList());
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Employee
    {
        public static int[] NumOfEmployeeAtMonth(int companyId)
        {
            var month = new int[12];
           var employees= EmployeeD.NumOfEmployeeAtMonth(companyId);
            foreach (var item in employees)
            {
                var start = item.StartWorkDate.Month;
                var end = item.EndWorkDate.Month;
                for (int i = 0; i < month.Length; i++)
                {
                    if (i + 1 >= start && i + 1 <= end)
                        month[i]++;
                }
            }
            return month;
        }

        public static List<COMMON.ComEmployee> AllEmployee(int companyId)
        {
            return EmployeeD.AllEmployee(companyId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    public class ComEmployee
    {
        public int Id { get; set; }
        public int CompanyEmployeeId { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime EndWorkDate { get; set; }
        public string EmplooyeName { get; set; }
    }
}

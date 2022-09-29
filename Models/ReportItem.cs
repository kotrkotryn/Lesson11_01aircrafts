using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class ReportItem
    {
        public int TailNumber { get; set; }
        public int ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }

    }
}

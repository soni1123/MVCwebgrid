using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoolMVCApp.Models
{
    
    public class EmployeeViewModel
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Deptt { get; set; }

        public Int32 Page { get; set; }
        public Int32 PageSize { get; set; }
        public String Sort { get; set; }
        public String SortDir { get; set; }
        public Int32 TotalRecords { get; set; }
        public List<CoolTable> employees { get; set; }

        public EmployeeViewModel()
        {
            Page = 1;
            PageSize = 5;
            Sort = "Id";
            SortDir = "DESC";
        }
    }
}
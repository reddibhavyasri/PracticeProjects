using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmsFullStackPhaseProject.Models
{
    public class empmodel
    {
        public int EmpCode { get; set; }
        public string Email { get; set; }
        public string EmpName { get; set; }

        public int DeptCode { get; set; }

    }
}
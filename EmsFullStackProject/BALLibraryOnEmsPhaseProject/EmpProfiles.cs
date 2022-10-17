using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLibraryOnEmsPhaseProject
{
   public class EmpProfiles
    {
        [Key]
        public int EmpCode { get; set; }

        public string EmpName { get; set; }
        public string Email { get; set; }

        public int DeptCode { get; set; }


    }
}

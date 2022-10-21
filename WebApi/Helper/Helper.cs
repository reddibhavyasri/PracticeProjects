using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalLib;
using BalLib;

namespace Helper
{
    public class Helper
    {
        Dalcls dal = null;
        public Helper()
        {
            dal = new Dalcls();
        }


        public bool Addmarks(Balcls employee)
        {
            return dal.Insert(employee);

        }

        public bool Editmarks(Balcls employee)
        {
            return dal.Update(employee);
        }

        public Balcls searchmarks(int empid)
        {
            return dal.Find(empid);
        }
        public List<BAL> listmarks()
        {
            return dal.list();
        }
        public bool removemarks(int employee_id)
        {
            return dal.Delete(employee_id);
        }
    }
}

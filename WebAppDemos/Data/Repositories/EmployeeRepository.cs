using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemos.Data.Interfaces;
using WebAppDemos;

namespace WebAppDemos.Data.Repositories
{
    public class EmployeeRepository : IGetDataRepository
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Pedro";
            }
            else if (id == 2)
            {
                name = "Ana";
            }
            else if (id == 3)
            {
                name = "Laura";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}

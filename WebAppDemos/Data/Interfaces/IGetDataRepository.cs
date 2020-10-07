using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemos;

namespace WebAppDemos.Data.Interfaces
{
    public interface IGetDataRepository
    {
        string GetNameById(int id);
    }
}

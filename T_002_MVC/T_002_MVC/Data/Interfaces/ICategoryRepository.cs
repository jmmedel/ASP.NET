using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_002_MVC.Data.Model;

namespace T_002_MVC.Data.Interfaces
{
    public  interface ICategoryRepository
    {
        IEnumerable <Category> Categories { get; }
    }
}

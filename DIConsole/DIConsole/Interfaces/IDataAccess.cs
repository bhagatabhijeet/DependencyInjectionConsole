using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole.Interfaces
{
    internal interface IDataAccess
    {
        void Store(string username, string password);
    }
}

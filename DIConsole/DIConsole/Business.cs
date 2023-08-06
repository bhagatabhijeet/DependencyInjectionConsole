using DIConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole
{
    internal class Business:IBusiness
    {
        private readonly IDataAccess dataaccess;

        public Business(IDataAccess dataaccess)
        {
            this.dataaccess = dataaccess;
        }
        public void SignUp(string username, string password)
        {
            //DataAccess dal = new();
            dataaccess.Store(username, password);
        }
    }
    internal class BusinessV2 : IBusiness
    {
        public void SignUp(string username, string password)
        {
            DataAccess dal = new();
            dal.Store(username, password);
        }
    }
}

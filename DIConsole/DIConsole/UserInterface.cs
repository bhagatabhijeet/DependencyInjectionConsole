using DIConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole
{
    internal class UserInterface
    {
        IBusiness business;
        public UserInterface(IBusiness business)
        {
            this.business = business;
        }

        public IBusiness Business { get; }

        public void GetData()
        {
            Console.WriteLine("Enter your name");
            var username = Console.ReadLine(); ;
            Console.WriteLine("Enter your password");
            var password =Console.ReadLine();

            
            business.SignUp(username, password);
        }
    }
}

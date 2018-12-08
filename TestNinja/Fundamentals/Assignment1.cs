using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {
                public string UserAndHimDevice(string UserName,string UserDevice)
        {
            
            if ( UserName.Length > 0)
            {
                return $"{UserName} use him device {UserDevice}";

            }
            else
            {
                return "Not Information on user";
            }
        }
    }
}

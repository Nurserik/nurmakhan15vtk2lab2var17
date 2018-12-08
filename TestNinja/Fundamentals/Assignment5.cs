using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment5
    {
        public string UserName { get; set; }

        public void RealName(string HisName)
        {
            if (string.IsNullOrWhiteSpace(HisName))
                throw new ArgumentNullException();

            UserName = HisName;
        }
    }
}

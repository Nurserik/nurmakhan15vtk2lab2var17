using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        public Function FindDIGITAL(int TenaFind)
        {
            if (TenaFind > 0)
            {
                if (TenaFind >0 && TenaFind <10)
                {
                    return new One();
                }
                if (TenaFind > 9 && TenaFind < 99)
                {
                    return new Ten();
                }

                if (TenaFind > 99 && TenaFind < 999)
                {
                    return new Hundred();
                }

                else
                {
                    return new Slyzerin();
                }
            }
            else
            {
                return new OutTest();
            }
        }
    }
    public class Function
    {

    }

    public class One : Function
    {

    }

    public class Ten : Function
    {

    }

    public class Hundred : Function
    {

    }

    public class Slyzerin : Function
    {

    }
    public class OutTest : Function
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
       public int[] Binary(string Word)
        {
            Random rnd = new Random();
            
            if (Word.Length > 0)
            {
                int[] BINARY = new int[Word.Length];
                for (int i = 0; i < Word.Length; i++)
                {
                    BINARY[i] = rnd.Next(0, 2);
                }
                return BINARY;
            }
            else
            {
                int[] BINARY = new int[2];
               
                    BINARY[1] = 0;
                BINARY[2] = 0;
                return BINARY;
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Factorial(int n)
        {
          
            if (n > 0)
            {
                int fn = 1;
                for (int i = 2; i <= n; i++)
                    fn *= i;
                return fn;
            }
            else

                return 0;
        }
        

        
    }
}

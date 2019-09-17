using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOfCreatingDll
{
    public class Calculation
    {
        public int Addition(int a,int b)
        {
            return a + b;
        }

        public int subraction (int a,int b)
        {
            return a - b;
        }

        public int multiply(int a,int b)
        {
            return a * b;
        }

        public int divide(int a,int b)
        {
            return a / b;
        }
    }
}

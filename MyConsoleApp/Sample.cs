using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Sample 
    {
        public void GetTotalForPrices()
        {
            int test = 1234;

            var digits = test.ToString().Select(x => int.Parse(x.ToString())); ;

            Console.WriteLine(digits);
        }
    }
}
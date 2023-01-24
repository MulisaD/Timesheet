using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you logging in ?, Please respond in Y for Yes and N for No");
            var YesONo = Convert.ToString(Console.ReadLine());
            if (YesONo == "Y")
            {
                Console.Write("Check in Date and Time is : ");
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Good bye");
            }
           
        }
    }
}
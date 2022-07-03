using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            DateTime dt = new DateTime();
            Type dtType = typeof(DateTime); 
            PropertyInfo[] dtProps = dtType.GetProperties();
            Console.WriteLine("All DateTime properties:");
            foreach(PropertyInfo prop in dtProps)
            {
                Console.WriteLine("- " + prop.Name);
            }
            Console.ReadKey();
        }
    }
}

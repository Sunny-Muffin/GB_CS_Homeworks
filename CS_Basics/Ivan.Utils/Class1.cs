using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ivan.Utils
{
     public class Tasks
    {
        public static void BeginTask(int num)
        {
            Console.WriteLine($"Task{num} ============================================================================================= \n");
        }

        public static void EndTask()
        {
            Console.WriteLine("Press any key to get next task");
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    public class GetNumbers
    {
        public static int GetIntFromKey(string numStr)
        {
            int numKey = 0;
            while (!int.TryParse(numStr, out numKey))
            {
                Console.WriteLine("\nPlease enter integers in a row");
                Console.WriteLine("If you want to quit press 0");
                numStr = Console.ReadKey().KeyChar.ToString();
            }
            return numKey;
        }

        public static double GetDouble()
        {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.WriteLine("Please enter a valid number: ");
            return num;
        }

        public static int GetInt()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
                Console.WriteLine("Please enter an imteger: ");
            return num;
        }

        public static int CountDigitsSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}

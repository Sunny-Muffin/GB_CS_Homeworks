using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanUtils
{
    public class Tasks
    {
        public static void MyName(int lessonNum)
        {
            PrintInMid($"Homework #{lessonNum}");
            PrintInMid($"made by Afanasev Ivan\n");
        }

        public static int Menu(int taskCount)
        {
            Console.Clear();
            PrintInMid("MENU");
            Console.WriteLine("To navigate through tasks use numbers 1...9\n");
            for (int i = 1; i <= taskCount; i++)
            {
                Console.WriteLine($"{i} - Task {i}");
            }
            return GetNumbers.GetIntFromKey((Console.ReadKey().KeyChar.ToString()));
        }

        public static void BeginTask(int num)
        {
            Console.Clear();
            Console.WriteLine($"\nTask{num} ============================================================================================= \n");
        }

        public static void EndTask()
        {
            Console.WriteLine("Press any key to get next task");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void PrintInMid(string text)
        {
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            Console.SetCursorPosition(centerX, Console.CursorTop);
            Console.WriteLine(text);
        }
    }

        public class GetNumbers
        {
            public static int GetIntFromKey(string numStr)
            {
                int numKey = 0;
                while (!int.TryParse(numStr, out numKey))
                {
                    Console.WriteLine("\nPlease enter valid integer");
                    //Console.WriteLine("If you want to quit press 0");
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

    public class GetArray
    {
        public static int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[] buf = new int[1000];

            StreamReader streamReader = new StreamReader(fileName);

            int counter = 0;
            while (!streamReader.EndOfStream)
            {
                buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }

            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);
            streamReader.Close();
            return arr;
        }
    }
}


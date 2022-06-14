using System;

using Ivan.Utils;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }
        #region Task1
        static void Task1()
        {
            Tasks.BeginTask(1);

            Console.WriteLine("Please enter 3 numbers in colomn: ");
            // тут бы массивы пригодились, но мы их еще не прошли
            double a = GetNumbers.GetDouble();
            double b = GetNumbers.GetDouble();
            double c = GetNumbers.GetDouble();

            double min = a <= b ? a : b;
            min = c <= min ? c : min;

            Console.WriteLine($"Min number is: {min}");

            Tasks.EndTask();
        }
        #endregion

        #region Task2
        static void Task2()
        {
            Tasks.BeginTask(2);

            Console.WriteLine("Please enter 1 number: ");
            double num = GetNumbers.GetDouble();
            double temp = num;
            int count = 0;
            while (temp >= 1 || temp <= -1)
            {
                temp = temp / 10;
                count++;
            }
            Console.WriteLine($"Amount of digits in number {num}: {count}");

            Tasks.EndTask();
        }
        #endregion

        #region Task3
        static void Task3()
        {
            Tasks.BeginTask(3);

            Console.WriteLine("Please enter integers in a row, do not separate them with spaces or other keys");
            Console.WriteLine("If you want to quit press 0");
            int num;
            int sum = 0;
            do
            {
                num = GetNumbers.GetIntFromKey((Console.ReadKey().KeyChar.ToString()));
                if (num > 0 && num % 2 == 1)
                    sum += num;
            }
            while (num != 0);
            Console.WriteLine($"\nSum of positive odd numbers: {sum}\n");

            Tasks.EndTask();
        }
        #endregion

        #region Task4
        static void Task4()
        {
            Tasks.BeginTask(4);

            string login = "root";
            string pass = "GeekBrains";
            int i = 0;
            int logResult;
            int passResult;

            do
            {
                Console.WriteLine($"You have {3 - i} attempts to enter login & password");
                Console.Write($"Login: ");
                logResult = String.Compare(login, Console.ReadLine());
                Console.Write($"Password: ");
                passResult = String.Compare(pass, Console.ReadLine());
                i++;
            }
            while ((logResult != 0 || passResult != 0) & i < 3);

            if (logResult != 0 || passResult != 0)
                Console.WriteLine($"You have no attempts left, please try later");
            else
                Console.WriteLine($"Sucsessfully logged in!");

            Tasks.EndTask();
        }
        #endregion

        #region Task5
        static void Task5()
        {
            Tasks.BeginTask(5);

            Console.WriteLine("Please enter your height (cm): ");
            double height = GetNumbers.GetDouble();

            Console.WriteLine("Please enter your weight (kg): ");
            double weight = GetNumbers.GetDouble();

            MassIndex(weight, height);

            Tasks.EndTask();
        }
        static void MassIndex(double m, double h)
        {
            double mi = m / (h * h / 10000);
            if (mi < 18.5)
            {
                double gainWeight = (18.5 - mi) * h * h / 10000;
                Console.WriteLine($"You need to gain {gainWeight:F} kg");
            }
            else if (mi > 25)
            {
                double loseWeight = (mi - 25) * h * h / 10000;
                Console.WriteLine($"You need to lose {loseWeight:F} kg");
            }
            else
                Console.WriteLine("You have normal mass index");
        }
        #endregion

        #region Task6
        static void Task6()
        {
            Tasks.BeginTask(6);

            DateTime start = DateTime.Now;

            int sum;
            int goodNums = 0;

            for (int i = 1; i <= 1000000000; i++)
            {
                sum = GetNumbers.CountDigitsSum(i);
                if (i % sum == 0)
                    goodNums++;
            }
            Console.WriteLine($"There are {goodNums} good numbers between 1 & 1 000 000 000");

            DateTime finish = DateTime.Now;
            Console.WriteLine($"Time count: {finish - start}");
            // 2min 23sec

            Tasks.EndTask();
        }
        #endregion

        #region Task7
        static void Task7()
        {
            Tasks.BeginTask(7);

            int a = GetNumbers.GetInt();
            int b = GetNumbers.GetInt();

            if(a<b)
            {
                PrintNums(a, b);
                Console.WriteLine($"Sum of numbers: {SumNums(a, b)}");
            }
            else
            {
                PrintNums(b, a);
                Console.WriteLine($"Sum of numbers: {SumNums(b, a)}");
            }

            Tasks.EndTask();
        }

        static void PrintNums (int x, int y)
        {
            if (x < y)
                PrintNums(x, (y-1));
            Console.Write($"{y} ");
        }

        static int SumNums (int x, int y)
        {
            int sum = 0;
            if (x < y)
                sum = SumNums(x, (y-1));
            return y + sum;
        }
        #endregion
    }
}

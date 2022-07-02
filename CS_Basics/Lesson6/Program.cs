using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanUtils;

namespace Lesson6
{
    public delegate double Fun(double x, double y);
    public delegate double Fun2(double x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks.MyName(6);
            MainMenu();
        }

        static void MainMenu()
        {
            switch (Tasks.Menu(2))
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                default:
                    Console.WriteLine("\nTask not found, please try again");
                    Console.ReadKey();
                    break;
            }
        }

        static void Task1()
        {
            Tasks.BeginTask(1);

            Console.WriteLine("Quadratic function:");
            Table(Quadratic, 3, -2, 2);
            Console.WriteLine("Qubic function:");
            Table(Qubic, 3, -2, 2);
            Console.WriteLine("Sin function:");
            Table(Sin, 3, -2, 2);

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        #region for Task 1
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Quadratic(double a, double x)
        {
            return a * (x * x);
        }
        public static double Qubic(double a, double x)
        {
            return a * (x * x * x);
        }
        public static double Sin(double a, double x)
        {
            return a * Math.Sin(x); // оставил радианы
        }
        #endregion

        static void Task2()
        {
            Tasks.BeginTask(2);

            Console.WriteLine("Press 1...3 to choose function");
            Console.WriteLine("1 - Quadratic\n2 - Qubic\n3 - Sin(x)");
            //int.TryParse((Console.ReadKey().KeyChar.ToString()), out int func);
            switch (GetNumbers.GetInt())
            {
                case 1:
                    Quad();
                    break;
                case 2:
                    Qube();
                    break;
                case 3:
                    SinX();
                    break;
                default:
                    Console.WriteLine("\nNo such function, please try again");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        #region for Task 2
        public static void Quad()
        {
            Console.WriteLine("Please enter coeff. a: ");
            double a = GetNumbers.GetDouble();
            SaveFunc("data.bin", Quadratic, a, -100, 100, 0.5);

            Console.WriteLine("Choose an interval to find min value (-100...100)");
            Console.Write("start: ");
            int start = GetNumbers.GetInt();
            Console.Write("finish: ");
            int finish = GetNumbers.GetInt();
            while (start < -100 || finish > 100 || start >= finish)
            {
                Console.WriteLine("Start and finish shoud be between -100...100\nStart shoud be less, than finish");
                Console.Write("start: ");
                start = GetNumbers.GetInt();
                Console.Write("finish: ");
                finish = GetNumbers.GetInt();
            }

            Console.Write($"Min value of quadratic funstion in interval {start}...{finish} is: ");
            Console.WriteLine(Load("data.bin", start, finish));
        }

        public static void Qube()
        {
            Console.WriteLine("Please enter coeff. a: ");
            double a = GetNumbers.GetDouble();
            SaveFunc("data.bin", Qubic, a, -100, 100, 0.5);

            Console.WriteLine("Choose an interval to find min value (-100...100)");
            Console.Write("start: ");
            int start = GetNumbers.GetInt();
            Console.Write("finish: ");
            int finish = GetNumbers.GetInt();
            while (start < -100 || finish > 100 || start >= finish)
            {
                Console.WriteLine("Start and finish shoud be between -100...100\nStart shoud be less, than finish");
                Console.Write("start: ");
                start = GetNumbers.GetInt();
                Console.Write("finish: ");
                finish = GetNumbers.GetInt();
            }

            Console.Write($"Min value of qubic funstion in interval {start}...{finish} is: ");
            Console.WriteLine(Load("data.bin", start, finish));
        }

        public static void SinX()
        {
            Console.WriteLine("Please enter coeff. a: ");
            double a = GetNumbers.GetDouble();
            SaveFunc("data.bin", Sin, a, -100, 100, 0.5);

            Console.WriteLine("Choose an interval to find min value (-100...100)");
            Console.Write("start: ");
            int start = GetNumbers.GetInt();
            Console.Write("finish: ");
            int finish = GetNumbers.GetInt();
            while (start < -100 || finish > 100 || start >= finish)
            {
                Console.WriteLine("Start and finish shoud be between -100...100\nStart shoud be less, than finish");
                Console.Write("start: ");
                start = GetNumbers.GetInt();
                Console.Write("finish: ");
                finish = GetNumbers.GetInt();
            }

            Console.Write($"Min value of sin(x) funstion in interval {start}...{finish} is: ");
            Console.WriteLine(Load("data.bin", start, finish));
        }

        public static void SaveFunc(string fileName, Fun F, double a, double b, double c, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = b;
            while (x <= c)
            {
                bw.Write(F(a, x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName, int start, int finish)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double[] d = new double[fs.Length / sizeof(double)];

            start += 100;
            finish += 100;
            
            for (int i = 0; i < fs.Length / sizeof(double); i++)
                d[i] = bw.ReadDouble();

            for (int i = start; i <= finish; i++)
                if (d[i] < min)
                    min = d[i];

            bw.Close();
            fs.Close();
            return min;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanUtils;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks.MyName(4);
            MainMenu();
        }

        #region Menu
        static void MainMenu()
        {
            switch (Tasks.Menu(5))
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                default:
                    Console.WriteLine("\nTask not found, please try again");
                    Console.ReadKey();
                    break;
            }
        }
        #endregion

        #region Task 1
        static void Task1()
        {
            Tasks.BeginTask(1);

            MyArray arr1 = new MyArray(20);
            int pairCount = MyArray.FindPairs(arr1.fullArr);
            Console.WriteLine($"In array: {arr1}, there are {pairCount} pairs");

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }
        #endregion

        #region Task 2
        static void Task2()
        {
            Tasks.BeginTask(2);

            MyArray arr1 = new MyArray(20);
            int pairCount = MyArray.FindPairs(arr1.fullArr);
            Console.WriteLine($"In array: {arr1}, there are {pairCount} pairs");

            int[] arr2 = MyArray.LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "Array.txt");

            Console.WriteLine("\nArray in file: ");
            for (int i = 0; i < arr2.Length; i++)
                Console.Write($"{arr2[i]}\t");
            Console.WriteLine();

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }
        #endregion

        #region Task 3
        static void Task3()
        {
            Tasks.BeginTask(3);

            MyArray arr3 = new MyArray(1, 10, 2);
            Console.Write("Array is:\t\t\t");
            arr3.PrintArr();

            Console.WriteLine($"Sum of array's elements:\t{arr3.Sum}");

            int[] invertedArr3 = arr3.Inverse();
            Console.Write("Inverted array is:\t\t");
            for (int i = 0; i < invertedArr3.Length; i++)
                Console.Write($"{invertedArr3[i]}\t");
            Console.WriteLine();

            arr3.Multi(2);
            Console.Write("Array, multiplyed by 2:\t\t");
            arr3.PrintArr();

            arr3[4] = 38;
            arr3[1] = 38;
            Console.Write("New array:\t\t\t");
            arr3.PrintArr();
            Console.Write("Max elements count:\t\t");
            Console.WriteLine(arr3.MaxCount);

            arr3.CountEements();

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }
        #endregion

        #region Task 4
        static void Task4()
        {
            Tasks.BeginTask(4);

            string[] arr4 = MyArray.LoadLoginPassFromFile(AppDomain.CurrentDomain.BaseDirectory + "LoginPass.txt");

            string login = "root";
            string pass = "GeekBrains";
            int i = 0;
            int logResult;
            int passResult;

            do
            {
                Console.WriteLine($"You have {3 - i} attempts to enter login & password");
                Console.WriteLine($"Login in file: {arr4[0]}");
                logResult = String.Compare(login, arr4[0]);
                Console.WriteLine($"Password in file: {arr4[1]}");
                passResult = String.Compare(pass, arr4[1]);
                i++;
            }
            while ((logResult != 0 || passResult != 0) & i < 3);

            if (logResult != 0 || passResult != 0)
                Console.WriteLine($"You have no attempts left, please try later");
            else
                Console.WriteLine($"Sucsessfully logged in!");


            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }
        #endregion

        #region Task 5
        static void Task5()
        {
            Tasks.BeginTask(5);

            Console.WriteLine("К сожалению, не успеваю сделать 5 задание =(");
            Console.WriteLine("А лучше сдать в срок, но не до конца завершенное, чем не сдать вообще");

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }
        #endregion
    }
}

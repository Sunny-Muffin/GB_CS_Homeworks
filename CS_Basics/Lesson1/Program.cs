using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasks 1 and 2
            Interview();
            // Task 3
            Distance();
            // Task 4
            ChangePlaces();
            // Task 5
            AboutMe();
        }

        // For tasks 1 and 2 ============================================================================================================
        #region
        static void Interview()
        {
            Console.WriteLine("Task 1 ===================================================================================================");

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            string ageStr = Console.ReadLine();
            int age = 0;
            while (!Int32.TryParse(ageStr, out age))
            {
                Console.WriteLine("Your age shoud be an integer. Please enter your age: ");
                ageStr = Console.ReadLine();
            }

            Console.WriteLine("Please enter your height (cm): ");
            string heightStr = Console.ReadLine();
            float height = 0;
            while (!float.TryParse(heightStr, out height))
            {
                Console.WriteLine("Your height shoud be a number. Please enter your height (cm): ");
                heightStr = Console.ReadLine();
            }

            Console.WriteLine("Please enter your weight (kg): ");
            string weightStr = Console.ReadLine();
            float weight = 0;
            while (!float.TryParse(weightStr, out weight))
            {
                Console.WriteLine("Your weight shoud be a number. Please enter your weight (kg): ");
                weightStr = Console.ReadLine();
            }

            // Glueing:
            Console.WriteLine("Name: " + name + ", surname: " + surname + ", age: " + age + ", height: " + height + ", weight: " + weight);
            // Formated:
            Console.WriteLine("Name: {0}, surname: {1}, age: {2}, height: {3:F}, weight: {4:F}", name, surname, age, height, weight);
            // With $ sign:
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}, height: {height:F}, weight: {weight:F}");
            Study.Print("Press ENTER to get task 2");
            Study.Pause();

            Console.WriteLine("Task 2 ===================================================================================================");
            Console.WriteLine("Your mass index is: {0:F}", MassIndex(weight, height));
            Study.Print("Press ENTER to get task 3");
            Study.Pause();
        }

        static float MassIndex(float m, float h)
        {
            return (m / (h * h / 10000));
        }
        #endregion

        // For task 3 ===================================================================================================================
        #region
        static void Distance()
        {
            Console.WriteLine("Task 3 ===================================================================================================");
            
            double x1, x2, y1, y2 = 0;
            Console.WriteLine("Please enter 4 coordinates (x1, y1, x2, and y2) in a colomn: ");

            x1 = CheckNumber();
            y1 = CheckNumber();
            x2 = CheckNumber();
            y2 = CheckNumber();

            Console.WriteLine("Distance between coordinates is: {0:F}", CalculateDist(x1,y1,x2,y2));
            Study.Print("Press ENTER to get task 4");
            Study.Pause();
        }

        static double CalculateDist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double CheckNumber()
        {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please enter a valid number: ");
            }
            return num;
        }
        #endregion

        // For task 4 ===================================================================================================================
        #region
        static void ChangePlaces()
        {
            Console.WriteLine("Task 4 ===================================================================================================");
            
            Console.WriteLine("Please enter number a: ");
            double a = CheckNumber();
            Console.WriteLine("Please enter number b: ");
            double b = CheckNumber();
            Console.WriteLine("Before swaping: a = " + a + ", b = " + b);

            // вот тут я хотел релизовать через указатели, а для C# это небезопасно
            // я погуглил и узнал как правильно подключить использование укзателей, но делать этого всё равно не буду

            // swapping with third variable
            double c = a;
            a = b;
            b = c;
            Console.WriteLine("After swaping: a = " + a + ", b = " + b);

            // swapping wthout third variable
            // it was actually really interesting, cause I thought it is impossible
            // honestly, I just googled it
            // God bless MATH

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Swaping back: a = " + a + ", b = " + b);

            Study.Print("Press ENTER to get task 5");
            Study.Pause();
            //Console.WriteLine("Press ENTER to get task 5");
            //Console.ReadLine();
        }
        #endregion

        // For task 5 ===================================================================================================================
        #region
        static void AboutMe()
        {
            Console.WriteLine("Task 5 ===================================================================================================");

            Person me = new Person();
            me.name = "Ivan";
            me.surname = "Afanasev";
            me.city = "Ufa";
            me.PrintPerson();

            Study.Print("Press ENTER to quit");
            Study.Pause();
        }
        #endregion
    }

    class Person
    {
        public string name;
        public string surname;
        public string city;
        public void PrintPerson()
        {
            string text = $"Hello! My name is {name} {surname}, I live in {city}";
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            Console.SetCursorPosition(centerX, Console.CursorTop);
            Console.WriteLine(text);
        }
    }

    // For task 6 ===================================================================================================================
    public class Study
    {
        // не понял зачем нам делать метод Print, если есть WriteLine?
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        // про метод Pause тоже ничего не понял, что он должен делать?
        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}

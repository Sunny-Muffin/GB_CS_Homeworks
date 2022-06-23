using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanUtils;
using System.Text.RegularExpressions;

namespace Lesson5
{
    struct Student
    {
        public string nameSurname;
        public double avg;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks.MyName(3);
            MainMenu();
        }

        static void MainMenu()
        {
            switch (Tasks.Menu(4))
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
                default:
                    Console.WriteLine("\nTask not found, please try again");
                    Console.ReadKey();
                    break;
            }
        }

        static void Task1()
        {
            Tasks.BeginTask(1);
            string login;
            string pattern = @"\b[A-z][A-z0-9]{1,9}\b";

            do
            {
                Console.WriteLine("Your login must be 2...10 characters (letters and numbers), first symble must not be a number\nPlease enter login: ");
                login = Console.ReadLine();
            } while (!Regex.IsMatch(login, pattern));

            Console.WriteLine($"Your login is: {login}");

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        static void Task2()
        {
            Tasks.BeginTask(2);
            //string text = "a, bb. ccc! dddd? eeeee; ffffff: ggggggg  hhhhhhhh- iiiiiiii* jjjjjjjj&";
            string text = "A wizard is never late, Frodo Baggins. Nor is he early; he arrives precisely when he means to!";

            Console.WriteLine("а)");
            Message.PrintWordsWithNLetters(text, 3);

            Console.WriteLine("б)");
            Console.WriteLine($"Full message: {text}");
            char ch = 's';
            text = Message.DeleteWordsWithLetters(text, ch);
            Console.WriteLine($"Message without words, ending with \"{ch}\": {text}");

            Console.WriteLine("в) г)");
            Message.FindLongestWord(text);

            Console.ReadKey();

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        static void Task3()
        {
            Tasks.BeginTask(3);

            string marshal1 = "Edward Daniels";
            string marshal2 = "Chuck Aule";
            string murderer = "Andrew Laeddis";

            Message.IsAnagram(marshal1, marshal2);
            Message.IsAnagram(marshal1, murderer);

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        static void Task4()
        {
            Tasks.BeginTask(4);

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "students.txt"))
                throw new FileNotFoundException();

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students.txt");
            int N = int.Parse(sr.ReadLine());
            Student[] arr = new Student[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                arr[i].nameSurname = s[0] + " " + s[1];
                double Score1 = double.Parse(s[2]);
                double Score2 = double.Parse(s[3]);
                double Score3 = double.Parse(s[4]);
                arr[i].avg = Math.Round((Score1 + Score2 + Score3) / 3, 2);
            }
            sr.Close();

            Array.Sort<Student>(arr, (x, y) => x.avg.CompareTo(y.avg)); // нашел на просторах интернета, сортирует массив структур

            // Проверяем, есть ли среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших
            int worstCount = 3;
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i + 1].avg == arr[i].avg)
                    worstCount++;
                else
                    break;
            }

            // Выводим худших учеников в консоль
            Console.WriteLine(worstCount);
            Console.WriteLine("Students with worst average score are:");
            for (int i = 0; i < worstCount; i++)
            {
                Console.WriteLine(arr[i].nameSurname + " " + arr[i].avg);
            }

            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }


        public static class Message
        {
            private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-", "*", "&" };

            //а)
            public static void PrintWordsWithNLetters(string message, int letters)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length <= letters)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }

            //б)
            public static string DeleteWordsWithLetters(string message, char c)
            {
                string pattern = @"\w+?(" + c + @")([\W\s]{1,})";
                // я скорпировал это регулярное выражение с просторов интернета и немного его переделал
                // \w+? - разделяет все слова на отдельные буквы
                // (" + c + @") - находит именно ту букву, которая нам нужна
                // ([\W\s]{1,}) - выделяет слово целиком, если сразу после искомого символа идет пробел или любой другой символ
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(message, "");
                return result;
                // это было АДОВОЕ задание, у меня стул прогорел, пока я пытался понять решение
                // в процессе проверки заметил, что этот метод удаляет только слова, после которых идет какий либо символ (точка, пробел и т.д.)
            }

            //в) г)
            public static void FindLongestWord(string message)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int max = 0;
                StringBuilder maxWords = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length >= max)
                        max = words[i].Length;
                }
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Length == max)
                    {
                        maxWords.Insert(maxWords.Length, words[j] + " ");
                    }
                }
                Console.WriteLine($"longest words in message are: {maxWords}");
            }

            public static void IsAnagram(string s1, string s2)
            {
                Regex rgx = new Regex(@"[\s\W]+"); // убираем пробелы и лишние символы, оставим только буквы
                string s1copy = rgx.Replace(s1, "").ToLower();
                string s2copy = rgx.Replace(s2, "").ToLower();

                StringBuilder sb1 = new StringBuilder(SortString(s1copy).ToLower());
                StringBuilder sb2 = new StringBuilder(SortString(s2copy).ToLower());

                if (sb1.Equals(sb2))
                    Console.WriteLine($"\"{s2}\" is an anogram of \"{s1}\"");
                else
                    Console.WriteLine($"\"{s2}\" is NOT an anogram of \"{s1}\"");
            }

            public static string SortString(string str)
            {
                char[] chars = str.ToArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }
    
    }
}

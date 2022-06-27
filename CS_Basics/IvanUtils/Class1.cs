using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Press any key to go to menu\n");
            Console.ReadKey();
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
                    Console.WriteLine("Please enter an integer: ");
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

    public class MyArray
    {

        #region Private Fields
        private int[] _array;
        #endregion

        #region Public Properties
        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int[] fullArr
        {
            get
            {
                return _array;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _array.Length; i++)
                    sum += _array[i];
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                Array.Sort(_array); // сортировать не обязательно, но так мы сразу будем знать, что максимаьные значения в конце
                int max = _array[_array.Length - 1];
                int maxCount = 0;
                for (int i = _array.Length - 1; i >= 0; i--)
                {
                    if (_array[i] == max)
                        maxCount++;
                    else
                        return maxCount;
                }
                return maxCount; // в этом необходимости нет, всё равно не отработает, но без него компилятор ругается
            }
        }

        public int Length
        {
            get
            {
                return _array.Length;
            }
        }
        #endregion

        #region Constructors
        public MyArray(int[] array)
        {
            _array = array;
        }

        public MyArray(int count)
        {
            _array = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                _array[i] = random.Next(-10000, 10001);
            }
        }

        public MyArray(string fileName)
        {
            _array = LoadArrayFromFile(fileName);
        }

        public MyArray(int begin, int size, int step)
        {
            _array = new int[size];
            _array[0] = begin;
            for (int i = 1; i < size; i++)
            {
                _array[i] = _array[i - 1] + step;
            }

        }
        #endregion

        #region Public Methods
        public void PrintArr()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]}\t");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string buf = "";
            for (int i = 0; i < _array.Length; i++)
            {
                buf += $"{_array[i]}\t";
            }
            return buf;
        }

        public static int FindPairs(int[] arr)
        {
            int pairs = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    pairs++;
                }
            }
            return pairs;
        }

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

        public static string[] LoadLoginPassFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            string[] buf = new string[1000];

            StreamReader streamReader = new StreamReader(fileName);

            int counter = 0;
            while (!streamReader.EndOfStream)
            {
                buf[counter] = streamReader.ReadLine();
                counter++;
            }

            string[] arr = new string[counter];
            Array.Copy(buf, arr, counter);
            streamReader.Close();
            return arr;
        }

        public int[] Inverse()
        {
            int[] temp = new int[_array.Length];
            Array.Copy(_array, temp, _array.Length);
            for (int i = 0; i < temp.Length; i++)
                temp[i] = -temp[i];
            return temp;
        }

        public void Multi(int mult)
        {
            for (int i = 0; i < _array.Length; i++)
                _array[i] *= mult;
        }
        #endregion

        public void CountEements()
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();
            for (int i = 0; i < _array.Length; i++)
            {
                int res;
                if (elements.TryGetValue(_array[i], out res))
                    elements[_array[i]] += 1;
                else
                    elements.Add(_array[i], 1);
            }
            
            foreach (var j in elements)
            {
                Console.Write($"/element: {j.Key}, amount: {j.Value}/ \t");
            }
            Console.WriteLine();
        }
    }
}


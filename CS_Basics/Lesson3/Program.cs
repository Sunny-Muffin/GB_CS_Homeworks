using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanUtils;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks.MyName(3);
            MainMenu();
        }

        #region Menu
        static void MainMenu()
        {
            switch (Tasks.Menu(3))
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

            Complex complex01;
            complex01.re = 2;
            complex01.im = 3;

            Complex complex02;
            complex02.re = -1;
            complex02.im = -2;

            Complex complex03 = Complex.Plus(complex01, complex02);
            Complex complex04 = Complex.Minus(complex01, complex02);
            Complex complex05 = Complex.Multiply(complex01, complex02);

            Console.WriteLine($"({complex01}) + ({complex02}) = ({complex03})");
            Console.WriteLine($"({complex01}) - ({complex02}) = ({complex04})");
            Console.WriteLine($"({complex01}) * ({complex02}) = ({complex05})");

            ComplexClass complex1 = new ComplexClass(5, -3);
            ComplexClass complex2 = new ComplexClass(-3, -2);

            ComplexClass complex3 = ComplexClass.Plus(complex1, complex2);
            ComplexClass complex4 = ComplexClass.Minus(complex1, complex2);
            ComplexClass complex5 = ComplexClass.Multiply(complex1, complex2);

            Console.WriteLine($"({complex1}) + ({complex2}) = ({complex3})");
            Console.WriteLine($"({complex1}) - ({complex2}) = ({complex4})");
            Console.WriteLine($"({complex1}) * ({complex2}) = ({complex5})");

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        #region structure Complex
        internal struct Complex
        {
            public double im;
            public double re;

            public static Complex Plus(Complex complex1, Complex complex2)
            {
                Complex res;
                res.re = complex1.re + complex2.re;
                res.im = complex1.im + complex2.im;
                return res;
            }
            public static Complex Minus(Complex complex1, Complex complex2)
            {
                Complex res;
                res.re = complex1.re - complex2.re;
                res.im = complex1.im - complex2.im;
                return res;
            }
            public static Complex Multiply(Complex complex1, Complex complex2)
            {
                Complex res;
                res.re = complex1.re * complex2.re;
                res.im = complex1.im * complex2.im;
                return res;
            }

            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }
        #endregion

        #region class Complex
        internal class ComplexClass
        {
            private double im; // field
            private double re;

            public double Im // property
            {
                get
                {
                    return im;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new Exception();
                    }
                    im = value;
                }
            }

            public ComplexClass(double newRe, double newIm) // constructor
            {
                if (newIm == 0)
                {
                    throw new Exception();
                }
                im = newIm;
                re = newRe;
            }

            public static ComplexClass Plus(ComplexClass complex1, ComplexClass complex2)
            {
                ComplexClass res = new ComplexClass(complex1.re + complex2.re, complex1.im + complex2.im);
                return res;
            }
            public static ComplexClass Minus(ComplexClass complex1, ComplexClass complex2)
            {
                ComplexClass res = new ComplexClass(complex1.re - complex2.re, complex1.im - complex2.im);
                return res;
            }
            public static ComplexClass Multiply(ComplexClass complex1, ComplexClass complex2)
            {
                ComplexClass res = new ComplexClass(complex1.re * complex2.re, complex1.im * complex2.im);
                return res;
            }

            public override string ToString() // method
            {
                return $"{re} + {im}i";
            }
        }

        #endregion

        #endregion

        #region Task 2
        static void Task2()
        {
            Tasks.BeginTask(2);

            Console.WriteLine("Please enter integers in a colomn");
            Console.WriteLine("If you want to quit press 0");
            int num;
            int sum = 0;
            do
            {
                num = GetNumbers.GetInt();
                if (num > 0 && num % 2 == 1)
                    sum += num;
            }
            while (num != 0);
            Console.WriteLine($"\nSum of positive odd numbers: {sum}\n");

            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
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

            Fraction fr1 = new Fraction(4, 8);
            Console.WriteLine(fr1);
            //Console.ReadKey();

            fr1.Numerator = 3;
            fr1.Denumerator = 9;
            Console.WriteLine(fr1);
            //Console.ReadKey();

            Fraction fr2 = new Fraction(4, 7);

            Fraction fr3 = Fraction.Plus(fr1, fr2);
            Console.WriteLine(fr3);
            //Console.ReadKey();
            Fraction fr4 = Fraction.Minus(fr1, fr2);
            Console.WriteLine(fr4);
            //Console.ReadKey();
            Fraction fr5 = Fraction.Multiply(fr1, fr2);
            Console.WriteLine(fr5);
            //Console.ReadKey();
            Fraction fr6 = Fraction.Divide(fr1, fr2);
            Console.WriteLine(fr6);
            //Console.ReadKey();


            Console.WriteLine("\nPress 0 to go to main menu\nPress any other key to quit");
            if (int.TryParse((Console.ReadKey().KeyChar.ToString()), out int ans))
            {
                if (ans == 0)
                    MainMenu();
            }
            else
                Console.ReadKey();
        }

        #region Class Fraction
        class Fraction
        {
            private int numerator;
            private int denumerator;

            public Fraction() { }

            public Fraction(int num, int denum)
            {
                if (denum == 0)
                    throw new ArgumentException("Denumerator cannot be 0");
                numerator = num;
                denumerator = denum;
            }

            public int Numerator
            {
                get
                {
                    return numerator;
                }
                set
                {
                    numerator = value;
                }
            }

            public int Denumerator
            {
                get
                {
                    return denumerator;
                }
                set
                {
                    if (value == 0)
                        throw new ArgumentException("Denumerator cannot be 0");
                    else
                        denumerator = value;
                }
            }

            public double Fract
            {
                get
                {
                    return ((double)numerator / (double)denumerator);
                }
            }

            public static Fraction Simplification(Fraction fract)
            {
                int temp = fract.numerator > fract.denumerator ? fract.numerator : fract.denumerator;
                for (int i = temp - 1; i > 1; i--)
                {
                    if (fract.numerator % i == 0 && fract.denumerator % i == 0)
                    {
                        fract.numerator /= i;
                        fract.denumerator /= i;
                    }
                }
                return fract;
            }

            public static Fraction Plus(Fraction fr1, Fraction fr2)
            {
                Fraction fr3 = new Fraction();
                fr3.numerator = fr1.numerator * fr2.denumerator + fr2.numerator * fr1.denumerator;
                fr3.denumerator = fr1.denumerator * fr2.denumerator;
                return Simplification(fr3);
            }
            public static Fraction Minus(Fraction fr1, Fraction fr2)
            {
                Fraction fr3 = new Fraction();
                fr3.numerator = fr1.numerator * fr2.denumerator - fr2.numerator * fr1.denumerator;
                fr3.denumerator = fr1.denumerator * fr2.denumerator;
                return Simplification(fr3);
            }
            public static Fraction Multiply(Fraction fr1, Fraction fr2)
            {
                Fraction fr3 = new Fraction();
                fr3.numerator = fr1.numerator * fr2.numerator;
                fr3.denumerator = fr1.denumerator * fr2.denumerator;
                return Simplification(fr3);
            }
            public static Fraction Divide(Fraction fr1, Fraction fr2)
            {
                Fraction fr3 = new Fraction();
                fr3.numerator = fr1.numerator * fr2.denumerator;
                fr3.denumerator = fr1.denumerator * fr2.numerator;
                return Simplification(fr3);
            }
            public override string ToString()
            {
                return ($"{numerator} / {denumerator} = {Fract:F}");
            }
        }
        #endregion

        #endregion
    }
}

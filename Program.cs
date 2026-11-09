using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace lab12
{
    // bo noticed article questions in definations.md file <==
    internal class Program
    {
        ///<summary>
        ///add 2 integers and return the result
        ///</summary>
        ///<param name="x">first integr</param>
        ///<param name="y">second integr</param>
        ///<returns>the sum </returns>
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            #region Declare and assign int & char variables
            int num = 20;
            char x = 'h';
            Console.WriteLine($"integer {num}, char {x}");
            #endregion

            #region Declare float, decimal and double variables
            float num2 = 10_000_000F;
            double num3 = 10.12345675646846967988798686986986999D;
            decimal num4 = 10.12345675646846967988798686986986999M;
            Console.WriteLine($"float {num2}, double {num3}, decimal {num4}");
            //// in double the number of digits limited to 14 digits and in decimal to 27 digits
            #endregion

            #region Using c formatting and culutre info formatting
            string currency = $"{num4:C}";
            //output is readable
            Console.WriteLine(currency);
            string curncy = string.Format(CultureInfo.GetCultureInfo("ar-EG"), "{0:c}", num4);
            Console.WriteLine(curncy);
            ////output contains symbols and unreadable
            #endregion

            #region arithmetic operation float and double
            float f1 = 0.1f;
            float f2 = 0.2f;
            Console.WriteLine(f1 + f2);
            double d1 = 0.1d;
            double d2 = 0.2d;
            Console.WriteLine(d1 + d2);
            /* float rounds the result off early and hides tiny floating points because it less percise
             double is more percise it reveales the whole number alot of zeros followed by number */
            #endregion

            #region Value type
            int v1, v2;
            v1 = 10;
            // trying to print never respond unassigned variable - compilar error
            Console.WriteLine(v1);
            v2 = v1;
            v1 = 15;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            //modifying int variable reflects directly to its value in stack
            #endregion

            #region reference type
            Point p1;
            Console.WriteLine(p1.x);
            /* trying to print without creating an object causes 2 problems:
              1.local variable must asigned to a value before printing-->considered as value type
              2.runtime error there is no object in momory for x to point to it-->reference type */
            Point p2 = new Point { x = 10, y = 20 };
            Console.WriteLine($"x is {p2.x} and y is {p2.y}");
            #endregion

            #region modifying the object
            Point p2 = new Point { x = 100, y = 200 };
            Point p3 = p2;
            p3.x = 150;
            Console.Write(p2.x);
            /* the change in p3 reflected on p2 because they poit to the same object
              but on data from value type changing in one variable doesn't affect another */
            #endregion

            #region Casting
            int MyInt = 25896321;
            long MyLong = MyInt;
            Console.WriteLine($"integer value is {MyInt}");
            Console.WriteLine($"with impilicit cast {MyLong} ");
            /* casting from small size to large size safe for compiler
              small value fit in int range */

            long small = 12345L;
            int big = (int)small;//explicit casting
            Console.WriteLine($"long value after explicit {big}");
            //very large value
            long veryLong = 1000_000_000_000_000L;
            int smallLong = (int)veryLong;
            int smallLong2;
            Console.WriteLine($"long number {veryLong} after cast will be {smallLong}");
            /* explicit output is a random not expected
              if we remove the cast throw compile-time error : missing a cast? */

            checked
            {
                smallLong2 = (int)veryLong;
                //Because the value exceeds int.MaxValue and there is no catch block to handle the error, the runtime throws a System.OverflowException,
                //causing application to crash immediately.
            }
            unchecked
            {
                Console.WriteLine(smallLong2);
            }
            if (veryLong > int.MaxValue)
            {
                Console.WriteLine("exception");
            }
            else
            {
                smallLong2 = (int)veryLong;
                Console.WriteLine($"successfull casting :{smallLong2}");
            }
            #endregion

            #region convert,parse,tryparse
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine($"the number is {number}");


            string str = "132ab";
            //1.int.parse
            try
            {
                int n1 = int.Parse(str);
                Console.WriteLine($"the number is {n1}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //2.convert.ToInt32
            try
            {
                int n2 = Convert.ToInt32(str);
                Console.WriteLine($"the number is {n2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //3.int.TryParse
            try
            {
                bool result1 = int.TryParse(str, out int n3);
                Console.WriteLine("int.tryParse: " + result1);
                Console.WriteLine("the value " + n3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            /* the empty string or null string will return 0 in convert.ToInt32 and int.TryParse
               but int.Parse will throw an exception
              the null string will throw an exception in convert.ToInt32 and int.Parse but int.TryParse will return false */
            #endregion

            #region interpolation
            Console.WriteLine("enter the day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Today's date: {day} , {month} , {year}");
            Console.WriteLine($"Today's date: {day} / {month} / {year}");
            Console.WriteLine($"Today's date: {day} - {month} - {year}");
            #endregion

            #region calling Add method
            int result = Add(10, 20);
            Console.WriteLine(result);
            #endregion
        }
    }
}

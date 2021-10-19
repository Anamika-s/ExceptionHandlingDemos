using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingDemo
{
    class DivideNo
    {
        static void Main()
        {
            int res = 0;
            int[] num1 = new int[10];
            try
            {
                int num, den;
                Console.WriteLine("Enter Num");
                num = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Den");
                den = Convert.ToByte(Console.ReadLine());
                res = num / den;
                num1[100] = 10;
                Console.WriteLine(res);
            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                Console.WriteLine("Res is " + res);
            }
        }
    }
}

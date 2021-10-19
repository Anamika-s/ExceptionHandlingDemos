using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingDemo
{
    class UserDefindedExcpetionDemo
    {
        static void Main()
        {
            string name = string.Empty;
            int age = 0;
            try
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                if (name.Length < 10)
                    throw new CustomException("Min 10 charcaters needed");
            Console.WriteLine("Enter Age");
                age = Convert.ToByte(Console.ReadLine());
                if(age  < 10 || age > 50)
                 throw new CustomException("Range is 10 - 50");  
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
        }
    }
}

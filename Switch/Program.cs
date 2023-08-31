using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Maths, Science, Computer_Science;
            decimal average_marks;

            Console.WriteLine("Please enter your marks in Maths");
            Maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your marks in Science");
            Science = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your marks in Computer Science");
            Computer_Science = Convert.ToInt32(Console.ReadLine());

            average_marks = (Maths + Science + Computer_Science) / 3;

            switch (average_marks)
            {
                case var s when(average_marks > 90):
                    Console.WriteLine("You got A!");
                    break;

                case var s when (average_marks < 90 && average_marks >= 80):
                    Console.WriteLine("You got B+!");
                    break;

                case var s when (average_marks < 90 && average_marks >= 80):
                    Console.WriteLine("You got B");
                    break;

                case var s when (average_marks < 80 && average_marks >= 70):
                    Console.WriteLine("You got C");
                    break;

                case var s when (average_marks < 70 && average_marks >= 60):
                    Console.WriteLine("You got D!");
                    break;

                default:
                    Console.WriteLine("You have failed...");
                    break;
            }
            Console.ReadKey();  
        } 
    }
}

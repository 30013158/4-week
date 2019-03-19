
/*Rajveer Kaur
Project: loop*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_week
{
    class Program
    {
        static void Main(string[] args)
        { /*part 1
            //task2 loops
            int start = 1;
            int finish = 12;
            Console.WriteLine("<<for loop>>");
            for (int i = start; i <= finish ; i++)
            {
                Console.WriteLine($"{i} x 7 = {i*7}");
            }
            Console.ReadLine();

            //while loop
            Console.WriteLine("<<while loop>>");
            int counter = start;
            while (counter <= finish)
            {
                Console.WriteLine($"{counter} x 7 = {counter * 7} ");
                counter++;
            }
            //do while loop
            Console.WriteLine("<<do while loop>>");
            counter = 1; 
            do
            {
                Console.WriteLine($"{counter} x 7 = {counter * 7} ");
                counter++;
            } while (counter <= finish);
            Console.ReadLine();

            //task 3
            Console.WriteLine("\nNumbers\t\tsquare\t\tcube");
            Console.WriteLine("<<for loop>>");

            for (int r = 0; r <= 10; r++)
            {
                Console.WriteLine($"{r}\t\t{r*r}\t\t{r*r*r}");
            }
            //while loop
            Console.WriteLine("<< while loop >>");
            int counter1 = 0;
                while(counter1<=10)
            {
                Console.WriteLine($"{counter1}\t\t{counter1 * counter1}\t\t{counter1 * counter1 * counter1}");
                counter1++;
            }

            //do while loop
            Console.WriteLine("<<do while loop>>");
            counter1 = 0;
            do
            {
                Console.WriteLine($"{counter1}\t\t{counter1 * counter1}\t\t{counter1 * counter1 * counter1}");
                counter1++;
            } while (counter1 <= 10);
            Console.ReadLine();
            */
            Console.WriteLine("odd numbers from 76 to 46 ");
            int start1 = 76;
            int finish1 = 46;
            int counter2 = start1;
            while(counter2>=finish1)
            {
              if(counter2 % 2 != 0)
                    Console.WriteLine(counter2);
                counter2--;
            }
            Console.ReadLine();
            //next task
            Console.WriteLine("enter any character here");
            string char1= Console.ReadLine();
            Console.WriteLine("how many times you want to display the number");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num1; i++) 
            { Console.WriteLine(char1); }
            Console.ReadLine();
        }
    }
}

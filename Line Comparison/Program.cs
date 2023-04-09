using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line comparison computation program");
            Console.ReadLine();
            //UC2
            int x0 = 5, y0 = 7, x1 = 8, y1 = 4;
            Console.WriteLine("Co-ordinates of first line are x0:{0}, y0:{1}, x1:{2}, y2:{3}",x0,y0,x1,y1);
            float lenght1 = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2)));
            Console.WriteLine("The legth of first line is: " + Math.Round(lenght1 * 10000.0) / 10000.0);
            //taking co-ordinates of second line from user to find length
            Console.WriteLine("Enter the co-ordinates of second line");
            Console.WriteLine("Enter the x1 co-ordinate");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 co-ordinate");
            float y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x2 co-ordinate");
            float x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y2 co-ordinate");
            float y3 = Convert.ToInt32(Console.ReadLine());
            float lenght2 = Convert.ToInt32(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            Console.WriteLine("The legth of second line is: " + Math.Round(lenght2 * 10000.0) / 10000.0);
            Console.ReadLine();
            if (lenght1 >= lenght2) 
            {
                Console.WriteLine("The leght of first line is greater then second line.");
            }
            else if(lenght1 <= lenght2)
            {
                Console.WriteLine("The length of first line is less than second line.");
            }
            else
            {
                Console.WriteLine("Two lines are equal");
            }
            Console.ReadLine();
        }
    }
}

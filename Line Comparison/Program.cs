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
            //UC1
            //taking co ordinates from user to find length
            Console.WriteLine("Enter the x1 co_ordibate");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 co_ordibate");
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x2 co_ordibate");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y2 co_ordibate");
            float y2 = Convert.ToInt32(Console.ReadLine());
            float lenght = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)));
            Console.WriteLine(Math.Round(lenght*10000.0)/10000.0);
            Console.ReadLine() ;    
        }
    }
}

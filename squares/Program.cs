using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squares
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Learn your Squares and Cubes!");

            Console.WriteLine("Press 'y' to Continue");
           string yes = Console.ReadLine();

            if (yes == "y")
            {

                Console.WriteLine("Please enter a valid Integer");
                string Integer = Console.ReadLine();
                // Console.WriteLine(i);
                int i;
                Boolean wasParseSuccessful = int.TryParse(Integer, out i);
                Console.WriteLine("  " + "Number" + "     " + "Squared" + "    " + "Cubed " + "  ");
                Console.WriteLine("  "+"----------" +"   " +"----------" +"   " +"---------" + "  ");
                Console.WriteLine("  "+"----------" +"   "+ "-----------" +"  " +"---------" + "   \n\n");



                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("  " + j + "       " + j * j + "       " + j * j * j + "  ");
                }
            }

            else
                Console.WriteLine("Thank You");

            Console.ReadKey();
            
        }
    }

}

    


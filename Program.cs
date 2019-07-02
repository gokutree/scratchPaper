using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchpaper2a
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Console.Write("Enter a number to be cubed: ");
            double solution = Convert.ToDouble(Console.ReadLine()); //ALL USER RESPONSES AUTOMATICALLY ENTERED
                                                                    //AS STRINGS AND MUST BE CONVERTED TO NUMBER
            
            Console.WriteLine(Question(solution)); 
            Console.ReadLine();
            */

                        
            double cube = Question(7); //ANOTHER PASS THRU METHOD OPTION (I LIKE THIS ONE BETTER)
            Console.WriteLine(cube); //OFFERS MORE FLEXIBILITY WITH USER INTERFACE
            Console.ReadLine();

            /*
            Console.WriteLine(Question(7)); //TAKES 7 AND PASSES THRU "QUESTION" METHOD AND RETURNS
            Console.ReadLine(); //ON WRITELINE; CALL METHOD IN WRITELINE
            */
        }

        static double Question(double num) //VARIABLES NAMED IN METHOD IS ARBITRARY; STATIC VOID MAIN VARIABLES
        {                                   //WILL STILL BE RUN THRU REGARDLESS OF NAME WHEN METHOD IS CALLED

            double result = num * num * num;
            return result;
        }
        
    }
}

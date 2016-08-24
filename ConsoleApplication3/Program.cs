using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome! What is your name?: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Would you like to play a game?:");
            string Awn = Console.ReadLine();
                if (Awn == "yes")
            {
                Console.WriteLine("Excellent! You are walking across a fieled and you encounter a fire- breathing dragon");
                Console.WriteLine("What would you like to do? (enter face beast or runaway)");
            }
                else if (Awn == "no")
                    {
                Console.WriteLine("You Make me sad, goodbye");
            }
                else
            {
                Console.WriteLine("please enter yes or no");

            }

            Console.WriteLine("You approach the dragon. You see that he has _ heads. ");
            Console.WriteLine("(enter 1,2 or 3)");

            string Awn2 = Console.ReadLine();
            int Awn2Num = int.Parse(Awn2);


            if (Awn2Num == 1)
            {
                Console.WriteLine("1 head dawg");
                Console.WriteLine("1 headed dragons are scary af bro");
                Console.WriteLine("what kind of weapon would you like to use?");
            }
                else if (Awn2Num == 2)
            {
                Console.WriteLine("2 Heads dawg");
                Console.WriteLine("2 headed dragons are easy to kill because each head only has half a brain");
                Console.WriteLine("what kind of weapon would you like to use?");
            }
            else if (Awn2Num == 3)
            {
                Console.WriteLine("3 heads dawg");
            }






            

        }

       
    }
}

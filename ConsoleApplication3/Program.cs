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
            Console.WriteLine("please enter yes or no");
            string Awn = Console.ReadLine();
                if (Awn == "yes")
            {
                Console.WriteLine("Excellent! You are walking across a fieled and you encounter a fire- breathing dragon");
                Console.WriteLine("What would you like to do? (enter face beast or runaway)");
                string fightOrFlight = Console.ReadLine();
                    if(fightOrFlight == "face the beast")
                {
                    Console.WriteLine("You approach the dragon. You see that he has _ heads. ");
                    Console.WriteLine("(enter 1,2 or 3)");

                    string Awn2 = Console.ReadLine();
                    int Awn2Num = int.Parse(Awn2);
                    string Awn3 = Console.ReadLine();


                    if (Awn2Num == 1)
                    {
                        Console.WriteLine("1 head dawg");
                        Console.WriteLine("1 headed dragons are scary af bro");
                        Console.WriteLine("what kind of weapon would you like to use?");
                        Console.WriteLine("Please select one: Sword, Slingshot or Sick dance moves ");


                        if (Awn3 == "Sword")
                        {
                            Console.WriteLine("You draw your sword and swing it hard at the beast!");
                            Console.WriteLine("The beast ducks it's head, but it didnt see you roll to the side and deliver a mighty blow");
                            Console.WriteLine("The beast falls dead. byoned the dead boy you see a pile of gold, you're rich!");
                        }
                        else if (Awn3 == "Slingshot")
                        {
                            Console.WriteLine("you produce your mighty slingshot and lunch a smooth round stone at the ");
                            Console.WriteLine("The stone bounces off of the mighty beast");
                            Console.WriteLine("You are daed...");
                        }
                        else if (Awn3 == "sick dance moves")
                        {
                            Console.WriteLine("you produce your mighty slingshot and lunch a smooth round stone at the ");
                            Console.WriteLine("The stone bounces off of the mighty beast");
                            Console.WriteLine("You are daed...");

                        }

                    }
                    else if (Awn2Num == 2)
                    {
                        Console.WriteLine("2 Heads dawg");
                        Console.WriteLine("2 headed dragons are easy to kill because each head only has half a brain");
                        Console.WriteLine("what kind of weapon would you like to use?");
                        Console.WriteLine("Please select one: Sword, Slingshot or Sick dance moves ");
                        if (Awn3 == "sword")
                        {
                            Console.WriteLine("You draw your sword and point it at the ugly monster!");
                            Console.WriteLine("The beast takes one look at you in your shiny armor and fants");
                            Console.WriteLine("after dispacting the beast on the ground you go for the gold!");
                        }
                        else if (Awn3 == "Slingshot")
                        {
                            Console.WriteLine("taking out your slingshot you aim at one of the monsters heads");
                            Console.WriteLine("losing the stone at the dragons left head it bounces off and hits the other");
                            Console.WriteLine("The beast is now dead all of his tresurs are now yours");
                        }
                        else if (Awn3 == "Sick dance moves")
                        {

                        }
                    }
                    else if (fightOrFlight == "runaway")
                        {
                            Console.WriteLine("You lose you dirty courad!");
                         }
                    
            }
                else if (Awn == "no")
           {
                Console.WriteLine("You Make me sad, goodbye");
                
            }
               

            
               

            }
           


            

            







        }

       
    }
}

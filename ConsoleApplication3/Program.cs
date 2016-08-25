using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class MovesMain
    {
        string Name;
        string Awn3;
        public void Move1()
        {







            Console.WriteLine("1 head dawg");
            Console.WriteLine("1 headed dragons are scary af bro");
            Console.WriteLine("what kind of weapon would you like to use?");
            Console.WriteLine("Please select one: Sword, Slingshot or Sick dance moves ");

            Awn3 = Console.ReadLine();
            do {

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
            } while (!(Awn3 == "sword" || Awn3 == "sick dance moves" || Awn3 == "Slingshot"));
        }

        public void Move2()
        {
            string Awn3;
            do
            {

                Console.WriteLine("2 Heads dawg");
                Console.WriteLine("2 headed dragons are easy to kill because each head only has half a brain");
                Console.WriteLine("what kind of weapon would you like to use?");
                Console.WriteLine("Please select one: Sword, Slingshot or Sick dance moves ");
                Awn3 = Console.ReadLine();
                if (Awn3 == "sword")
                {
                    Console.WriteLine("You draw your sword and point it at the ugly monster!");
                    Console.WriteLine("The beast takes one look at you in your shiny armor and fants");
                    Console.WriteLine("after dispacting the beast on the ground you go for the gold!");
                    Console.WriteLine("congradulations " + Name + " you won the game!");
                }
                else if (Awn3 == "Slingshot")
                {
                    Console.WriteLine("taking out your slingshot you aim at one of the monsters heads");
                    Console.WriteLine("losing the stone at the dragons left head it bounces off and hits the other");
                    Console.WriteLine("The beast is now dead all of his tresurs are now yours");
                    Console.WriteLine("congradulations " + Name + " you won the game!");
                }
                else if (Awn3 == "Sick dance moves")
                {
                    Console.WriteLine("You are taken a back as the clumsy beast starts to dance!");
                    Console.WriteLine("Seeing its awful dancing, you bust out your own moves");
                    Console.WriteLine("The monster is so clumsy it trips over its own heads falling ontop of you");
                    Console.WriteLine("The heavy beast cruses you and you die");
                }
            } while (!(Awn3 == "sword" || Awn3 == "sick dance moves" || Awn3 == "Slingshot"));

        }



        public void Move3()
        {
            string Awn3;
            Console.WriteLine("3 Heads dawg");
            Console.WriteLine("3 headed dragons have the sickest dance moves and challenges you to a dance off");


            do
            {
                Console.WriteLine("what kind of weapon would you like to use?");
                Console.WriteLine("Please select one: Sword, Slingshot or Sick dance moves ");
                Awn3 = Console.ReadLine();
                if (Awn3 == "sword")
                {
                    Console.WriteLine("You pull your sword out and swing at the mighty beats");
                    Console.WriteLine("Its dance moves are so smooth you can't seem to get a hit on him");
                    Console.WriteLine("after realizing you dontr intend to do dance with the dragon, he sets you a flame");
                    Console.WriteLine("you are now burnt to a crisp");
                }
                else if (Awn3 == "singshot")
                {
                    Console.WriteLine("you produce your mighty slingshot and lunch a smooth round stone at the ");
                    Console.WriteLine("The stone bounces off of the mighty beast");
                    Console.WriteLine("You are daed...");
                }
                else if (Awn3 == "sick dance moves")
                {
                    Console.WriteLine("The monster starts to dance, it's moves are so smooth you almost can't believe your eyes!");
                    Console.WriteLine("Sortly the spell is broken and you rermeber your training.");
                    Console.WriteLine("You start moving like no one has ever moved before.");
                    Console.WriteLine("The dragon can't handle it, your moves are to great.");
                    Console.WriteLine("Losing its will to live the dragon falls over dead");

                }
                else
                {


                    Console.WriteLine("Please select one");


                }
                
            } while (!(Awn3 == "sword" || Awn3 == "sick dance moves" || Awn3 == "Slingshot"));
        }
       
      
      class Program
        {
            static void Main(string[] args)
            {
                MovesMain Moves = new MovesMain();


                

                string FinalAwn;
                do
                {
                    string Name;
                    string Awn;



                    Console.WriteLine("Welcome! What is your name?: ");
                    Name = Console.ReadLine();
                    do
                    {



                        Console.WriteLine("Would you like to play a game?:");
                        Console.WriteLine("please enter yes or no");
                        Awn = Console.ReadLine();
                        string fightOrFlight;
                        string Awn2;
                        if (Awn == "yes")
                        {
                            Console.WriteLine("Excellent! you are walking across a field and you encounter a fire-breathing dragon!");
                            Console.WriteLine("What do you DO? Please enter face beast or runaway");

                            fightOrFlight = Console.ReadLine();
                            if (fightOrFlight == "face beast")
                            {
                                Console.WriteLine("You approach the dragon. You see that he has _ heads. ");
                                Console.WriteLine("(enter 1,2 or 3)");
                                Awn2 = Console.ReadLine();
                                int Awn2Num = int.Parse(Awn2);


                                if (Awn2Num == 1) // Move 1
                                {
                                    Moves.Move1();
                                }



                                else if (Awn2Num == 2) // Move 2
                                {
                                    Moves.Move2();
                                }

                                else if (Awn2Num == 3) // Move 3
                                {

                                    Moves.Move3();
                                }

                                

                            }
                            else if (fightOrFlight == "runaway")
                            {
                                Console.WriteLine("You lose you dirty courad!");
                                return;
                            }

                        }

                        else if (Awn == "no")
                        {
                            Console.WriteLine("You make me sad, goodbye");
                            return;
                        }
                        else 
                        {
                            Console.WriteLine("Please anwser yes or no");
                        }

                        Console.WriteLine("Game over " + Name + " you finished the game!");

                    }while (!(Awn == "no" || Awn == "yes" ));

                    Console.WriteLine("Would you like to play again?");
                    FinalAwn = Console.ReadLine();

                }
                while (FinalAwn == "yes");
                Console.WriteLine("Thanks for playing!");

            }
        }
    }
}
















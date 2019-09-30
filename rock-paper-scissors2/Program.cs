using System;

namespace rock_paper_scissors2
{

    class Program
    {
        static void Main(string[] args)
        {
            string state;
            state = "True";
            int cp;
            cp = 0;
            int hp;
            hp = 0;
            while (state == "True")
            {
                if (cp == 3)
                {
                    Console.WriteLine("Computer won with getting 3 points meanwhile you got " + hp.ToString() + " point(s).");
                    state = "False";
                }
                else if (hp == 3)
                {
                    Console.WriteLine("You won with getting 3 points meanwhile computer got " + cp.ToString() + " point(s).");
                    state = "False";
                }
                else
                {
                    Console.WriteLine("Let's play rock-paper-scissors. Please type your answer");
                    string ha;
                    ha = Console.ReadLine();
                    var random = new Random();
                    int randomnumber = random.Next(1, 4);
                    if (randomnumber == 1)
                    {
                        Console.WriteLine("Computer chose rock.");
                        if (ha == "rock")
                        {

                            Console.WriteLine("It's a tie! Noone gets a point.");
                        }
                        else if (ha == "paper")
                        {
                            Console.WriteLine("You won! You get a point.");
                            hp++;
                        }
                        else
                        {
                            Console.WriteLine("You lost! Computer gets a point");
                            cp++;
                        }
                    }
                    else if (randomnumber == 2)
                    {
                        Console.WriteLine("Computer chose paper.");
                        if (ha == "rock")
                        {
                            Console.WriteLine("You lost! Computer gets a point.");
                            cp++;
                        }
                        else if (ha == "paper")
                        {
                            Console.WriteLine("It's a tie! Noone gets a point.");
                        }
                        else
                        {
                            Console.WriteLine("You won! You get a point.");
                            hp++;
                        }
                    }
                    else if (randomnumber == 3)
                    {
                        Console.WriteLine("Computer chose scissors.");
                        if (ha == "rock")
                        {
                            Console.WriteLine("You won! You get a point.");
                            hp++;
                        }
                        else if (ha == "paper")
                        {
                            Console.WriteLine("You lost! Computer gets a point.");
                            cp++;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie Noone gets a point.");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

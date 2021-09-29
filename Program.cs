using System;

namespace cd_c_rpg_group
{
    class Program
    {
        static void Main(string[] args)
        {
            // SELECT PLAYERS
            System.Console.WriteLine("WIZARD NINJA SAMURAI FIGHT TO THE DEATH!!");
            // PLAYER 1 SET UP
            System.Console.WriteLine("Player 1: please enter your name.");
                string player1Name = Console.ReadLine();

            // PLAYER 1 CHOOSE CLASS
            System.Console.WriteLine($"{player1Name} please select your class: ");
            System.Console.WriteLine("1. Wizard\n2. Ninja\n3. Samurai");

            string response = Console.ReadLine();

            if (response == "1" || response.ToLower().StartsWith("one") || response.ToLower().Contains("wizard"))
            {
                System.Console.WriteLine("You chose Wizard!");
                Wizard player1 = new Wizard(player1Name);
            }
            if (response == "2" || response.ToLower().StartsWith("two") || response.ToLower().Contains("Ninja"))
            {
                System.Console.WriteLine("You chose Ninja!");
                Ninja player1 = new Ninja(player1Name);
            }
            if (response == "3" || response.ToLower().StartsWith("three") || response.ToLower().Contains("samurai"))
            {
                System.Console.WriteLine("You chose Samurai!");
                Samurai player1 = new Samurai(player1Name);
            } // END PLAYER 1 SET UP

            // PLAYER 2 SET UP
            System.Console.WriteLine("Player 2: please enter your name.");
                string player2Name = Console.ReadLine();

            // PLAYER 2 CHOOSE CLASS
            System.Console.WriteLine($"{player2Name} please select your class: ");
            System.Console.WriteLine("1. Wizard\n2. Ninja\n3. Samurai");

            string response2 = Console.ReadLine();

            if (response2 == "1" || response2.ToLower().StartsWith("one") || response2.ToLower().Contains("wizard"))
            {
                System.Console.WriteLine("You chose Wizard!");
                Wizard player2 = new Wizard(player2Name);
            }
            if (response2 == "2" || response2.ToLower().StartsWith("two") || response2.ToLower().Contains("Ninja"))
            {
                System.Console.WriteLine("You chose Ninja!");
                Ninja player2 = new Ninja(player2Name);
            }
            if (response2 == "3" || response2.ToLower().StartsWith("three") || response2.ToLower().Contains("samurai"))
            {
                System.Console.WriteLine("You chose Samurai!");
                Samurai player2 = new Samurai(player2Name);
            } // END PLAYER 2 SET UP

            // GAME LOOP
            int loops = 1;
            while (player1.Health > 0 || player2.Health > 0)
            {
                if (loops % 2 != 0)
                {
                    player = player1;
                    opponent = player2;
                }
                else{
                    player = player2;
                    opponent = player1;
                }
                {
                    // PLAYER TURN
                    System.Console.WriteLine($"{player.Name}, select an action");
                    System.Console.WriteLine("1. Attack\n2. Heal");
                    string response3 = Console.ReadLine();
                    // PLAYER ACTION
                    if (response3 == "1" || response3.ToLower().StartsWith("one") || response2.ToLower().Contains("attack"))
                    {
                        System.Console.WriteLine("You chose attack!");
                        player.Attack(opponent);
                    }
                    if (response3 == "2" || response3.ToLower().StartsWith("two") || response2.ToLower().Contains("heal"))
                    {
                        System.Console.WriteLine("You chose heal!");
                        player.Heal(player);
                    }

                    // GAME RESOLVE
                    if (player1.Health <= 0)
                    {
                        System.Console.WriteLine($"{player2.Name} is VICTORIOUS!");
                    }
                    if (player2.Health <= 0)
                    {
                        System.Console.WriteLine($"{player1.Name} is VICTORIOUS!");
                    }
                }



            } // END GAME LOOP

        } // END MAIN

    } // END PROGRAM CLASS
}

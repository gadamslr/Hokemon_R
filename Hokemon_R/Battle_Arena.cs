using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_R
{
    class Battle_Arena
    {
        public Battle_Arena() // CONSTRUCTOR method - notice same name as the CLASS
                                // Runs first when OBJECT INSTANTIATED
        {
            Console.WriteLine("*** Welcome to the BATTLE ARENA *******");
        }

        public void RequestAChallenger(Hokemon contender)
        {
            Console.WriteLine("{0}: say's 'I want a BATTLE... Who is ready to challenge me?'", contender.Name);
        }

        public void AcceptingTheBattle(Hokemon contender01, Hokemon contendor02)
        {
            Console.WriteLine("{0}: 'I accept the challenge to fight {1}' ", contendor02.Name, contender01.Name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{1}: 'Great {0}, lets start a BATTLE!!!' ", contendor02.Name, contender01.Name);

        }

        public void Battle(Hokemon Attacker, Hokemon Defender) // Passing in two PARAMETERS
                                                                // two Hokemon for the Battle
        {
            Hokemon tempHoke;
            int round = 0;

            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                int attackValue = Attacker.attackCalculator();
                int defenceValue = Defender.defenceCalculator();

                round += 1; // Alternate to statement round = round + 1

                Console.WriteLine("\n******** ROUND {0} ********\n", round);

                for (int i = 0; i < 2; i++)
                {

                    // Attacker attacks

                    Console.WriteLine("{0}: Attacks with value {1} ", Attacker.Name, attackValue);

                    // Defenders defence

                    Console.WriteLine("{0}: Defends with Value {1}", Defender.Name, defenceValue);

                    Console.WriteLine("{0}: health = {1}", Defender.Name, Defender.Health);

                    // Calculate the impact of the Attach on defenders health

                    Defender.Health = (Defender.Health + defenceValue) - attackValue;

                    Console.WriteLine("{0}: New health value = {1} // Calc: {1} + {2} - {3}", Defender.Name, Defender.Health, defenceValue, attackValue);

                    // IMPORTANT part of the Battle
                    Console.WriteLine("\n\n*** SWITCHING TURNS - Attacker now the Defender ***\n");

                    tempHoke = Attacker; // tempHoke is assigned the attacker object
                    Attacker = Defender;
                    Defender = tempHoke;
                }


            }

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine("{0} WINS", Attacker.Name);
            }
            else
            {
                Console.WriteLine("{0} WINS", Defender.Name);
            }
        }

    }
}

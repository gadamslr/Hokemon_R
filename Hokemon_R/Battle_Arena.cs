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


    }
}

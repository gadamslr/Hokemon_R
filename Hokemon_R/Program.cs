using System;

namespace Hokemon_R
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!\n\n");

            // INSTANTIATING our first object

            Hokemon HokeObject01 = new Hokemon();

            HokeObject01.get_details();

            System.Threading.Thread.Sleep(1000); // Sleep for 1 second

            // Create a second Hokemon

            Hokemon Hoke02 = new Hokemon();

            Hoke02.get_details();

        }
    }
}

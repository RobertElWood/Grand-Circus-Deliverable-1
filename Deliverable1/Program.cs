using System;

public class Program
{
    public static void Main()
    {
        bool trigger = false;
        while (!trigger)
        {

            Console.WriteLine("\nHow many people are we making PB&J sandwiches for?\n");
            int numPeople = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int slicesB = numPeople * 2;
            int tablespoonsPB = numPeople * 2;
            int teaspoonsJ = numPeople * 4;

            int totalLoaves = (int)Math.Ceiling((double)slicesB / 28);
            int jarsPB = (int)Math.Ceiling((double)tablespoonsPB / 32);
            int jarsJelly = (int)Math.Ceiling((double)teaspoonsJ / 48);

            Console.WriteLine("You need: \n");

                Console.WriteLine(slicesB + " slices of bread");
                Console.WriteLine(tablespoonsPB + " tablespoons of peanut butter");
                Console.WriteLine(teaspoonsJ + " teaspoons of jelly \n");

            Console.WriteLine("Which is... \n");

                Console.WriteLine(totalLoaves + " loaves of bread");
                Console.WriteLine(jarsPB + " jars of peanut butter");
                Console.WriteLine(jarsJelly + " jars of jelly \n");

            Console.WriteLine("Would you like to restart? Enter 'yes' or 'y' to continue, or enter any other key to exit.\n");
            
            string input = Console.ReadLine();
            
            if (input == "y" || input == "yes")
            {
                trigger = false;
            }
            else
            {
                Console.WriteLine("\nGoodbye!");
                trigger = true;
            }
        }
    }
}
//Hayden Cowart
//Section 4
//This is my IS 413 Mission 2 Assignment. It is a dice-rolling simulator! How exciting!

using System;
using Mission2;


internal class Program
{
    private static void Main()         //this line is just stating a method called Main
    {
        //greet the user and ask for number of rolls
        Console.WriteLine("Greetings! My name is DiceSpice! I am a program created by Hayden Cowart.\nTogether, you and I will roll some dice. How exciting!\nLet's begin!\n\n");
        Console.WriteLine("Welcome to the dice-rolling simulator!");
        Console.Write("How many dice rolls would you like to simulate?\n");
        //store the value received in the line above
        int iTotalRolls = int.Parse(Console.ReadLine());

        //now I need to call the DiceRoller program
        DiceRoller rollem = new DiceRoller();

        //create a new aiRollTotals array that stores the returned results from the method
        int[] aiRollTotals = rollem.RollDeDice(iTotalRolls);

        DisplayResults(aiRollTotals, iTotalRolls);

        Console.WriteLine("\n\nThank you for using the dice throwing simulator! Until next time, my friend!\nRemember who you are! Make good choices!");

    }

    private static void DisplayResults(int[] aiResults, int iTotalRolls)
    {
        //display nice words
        Console.WriteLine("\n\nThank you for giving me an opportunity to run! It get's a little lonely at times.");
        Console.WriteLine("Thankfully, Hayden taught me to listen to Elvis music when I'm lonely. It helps, but I'm always happy to serve a user!");
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS:");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {iTotalRolls}.");

        //for loop to iterate through results based on their apartment #
        for (int iCount = 2; iCount < aiResults.Length; iCount++)
        {
            //percentage for each apartment
            double iPercentage = ((aiResults[iCount] / (float)iTotalRolls)) * 100;

            //empty string to receive asterisk
            string sAstOutput = "";

            //for loop to add * for each percent
            for (int iApartmentPct = 0; iApartmentPct < iPercentage; iApartmentPct++)
            {
                //add a * for as long as the incrementing 0 is less than the true percentage
                sAstOutput += "*";
            }

            //Format the output to be 2: *** and so forth
            Console.WriteLine($"{iCount}: {sAstOutput} ");
        }
    }
}



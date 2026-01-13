using System.Runtime.InteropServices;

namespace Mission2HW;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Roll roll = new Roll();

        Console.WriteLine("Welcome to the dice throwing simulator!");

        int rolls = 0;

        Console.WriteLine("How many dice rolls would you like to simulate? ");
        rolls = int.Parse(Console.ReadLine());

        int[] rollResults = roll.RollingSimulation(rolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents " +
                          "1% of the total number of rolls.\nTotal number " +
                          "of rolls = " + rollResults.Length + "\n");

        int[] counts = new int[11];

        foreach (int i in rollResults)
        {
            counts[i - 2]++;
        }

        int rollNum = 2;
        foreach (int i in counts)
        {
            double percent = ((double)i / rollResults.Length) * 100;
            
            string bars = new string('*', (int)percent);
            
            Console.WriteLine(rollNum + ": " + bars);
            rollNum++;
        }

    }
}
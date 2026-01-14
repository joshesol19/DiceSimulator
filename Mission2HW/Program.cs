namespace Mission2HW;
public class Program
{
    public static void Main()
    {
        Roll roll = new Roll();

        Console.WriteLine("Welcome to the dice throwing simulator!\n");

        // create rolls starting as 0
        int rolls = 0;

        // ask user how many roles to do
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        rolls = int.Parse(Console.ReadLine());

        // simulate the a roll how ever many times the user wanted to roll, and store the 
        // combinations in the variable "rollResults"
        int[] rollResults = roll.RollingSimulation(rolls);

        // display results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents " +
                          "1% of the total number of rolls.\nTotal number " +
                          "of rolls = " + rollResults.Length + ".\n");

        // create empty array with as many slots as possible combinations (11 because cant combo to 1)
        int[] counts = new int[11];

        // increment each combination based on index
        foreach (int i in rollResults)
        {
            counts[i - 2]++;
        }

        // set default first display num to 2, will increment thus on
        int rollNum = 2;
        
        // print the counts
        foreach (int i in counts)
        {
            // calculate the percent of how frequent that index/combo occured 
            double percent = ((double)i / rollResults.Length) * 100;
            
            // create a string for the histogram that shows a * for each percent
            string bars = new string('*', (int)percent);
            
            // print the percent *'s
            Console.WriteLine(rollNum + ": " + bars);
            
            // increment
            rollNum++;
        }
        
        // adios, amigo
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}
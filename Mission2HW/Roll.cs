namespace Mission2HW;

public class Roll
{
    // Simulates a full roll
    public int[] RollingSimulation(int rolls)
    {
        // create final roll combination array that will be returned later (long as rolls requested) 
        int[] combinations = new int[rolls];
        
        // for each roll, roll twice
        for (int roll = 0; roll < combinations.Length; roll++)
        {
            // the two roles
            int rol1 = RollSimulator();
            int rol2 = RollSimulator();
            
            // create and return roll combination
            int combination = rol1 + rol2;
            combinations[roll] = combination;
        }
        
        return combinations;
    }

    // simulates one individual die roll
    public int RollSimulator()
    {
        // roll is a random result of min as 1 and max as 6
        Random rnd = new Random();
        int result = rnd.Next(1, 7);

        // return result
        return result;
    }
}
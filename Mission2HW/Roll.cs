namespace Mission2HW;

public class Roll
{
    public int[] RollingSimulation(int rolls)
    {
        int[] combinations = new int[rolls];
        
        for (int roll = 0; roll < combinations.Length; roll++)
        {
            int rol1 = RollSimulator();
            int rol2 = RollSimulator();
            
            int combination = rol1 + rol2;
            
            combinations[roll] = combination;
        }
        
        return combinations;
    }

    public int RollSimulator()
    {
        Random rnd = new Random();
        int result = rnd.Next(1, 7);

        return result;
    }
}
namespace AppStrategy;

public class Transport
{
    public void ChooseTransport(string mode)
    {
        if (mode.Equals("CAR"))
        {
            Console.WriteLine("User opted to go by CAR");
        }
        else if (mode.Equals("BUS"))
        {
            Console.WriteLine("User opted to go by BUS");
        }
        else if (mode.Equals("TAXI"))
        {
            Console.WriteLine("User opted to go by TAXI");
        }
        // else if (mode.Equals("UBER"))
        // {
        //     Console.WriteLine("User opted to go by UBER");
        // }
        // else if (mode.Equals("PLANE"))
        // {
        //     Console.WriteLine("User opted to go by PLANE");
        // }
        // else if (mode.Equals("TRAIN"))
        // {
        //     Console.WriteLine("User opted to go by TRAIN");
        // }
        
    }
}
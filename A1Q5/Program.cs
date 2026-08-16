namespace namespace_A1Q5;

class Program
{
    static string p2s(int i)
    {

        switch(i)
        {
            case 0:
                return "The score is love";
            case 1:
                return "The score is 15";
            case 2:
                return "The score is 30";
            case 3:
                return "The score is 40";
            default:
                return "";
        }
        
    }

    static string p3s(int i)
    {

        switch(i)
        {
            case 0:
                return "love";
            case 1:
                return "15";
            case 2:
                return "30";
            case 3:
                return "40";
            default:
                return "";
        }
        
    }

    static string concat(int a, int b)

    {

        if (a >= 3  && b >= 3)

        {
            if (a == b)

            {
                return "deuce";
            }

            if (a - b == 1)
                return "P1 advantage";
            else
                return "P2 advantage";
        }

        if (a == b)

        {
            return p2s(a) + " all.";
        }
        
        return p2s(a) + "-" + p3s(b);
        
    }

    static int check(int a, int b)

    {

        if (a >= 4 && a - b >= 2)

        {
            return 1;
        }

        else if (b >= 4 && a - b >= 2)

        {
            return 2;
        }
        return -1;

    }

    static void handle(ref int p1,ref int p2)

    {

        System.Console.WriteLine("Please enter which player wins the first point? 1 or 2:");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int choice))

        {
            // System.Console.WriteLine("Invalid char");
            return;
        }

        if (choice != 1 && choice != 2)

        {
            System.Console.WriteLine("Out of bound");
            return;
        }

        if (choice == 1)

        {
            p1++; // p1 = p1 + 1
        }

        else

        {
            p2++; // p2 = p2 + 1
        }

    }

    static void Main()

    {
        // Keep this line intact 
        Console.WriteLine("===========================");

        Console.WriteLine("Welcome to the tennis match.");

        int p1 = 0;
        int p2 = 0;
        System.Console.WriteLine(concat(p1, p2));
        while (check(p1, p2) == -1)

        {
            handle(ref p1, ref p2);
            System.Console.WriteLine(concat(p1, p2));
        }

        if (check(p1, p2) == 1)

        {
            System.Console.WriteLine("Player 1 wins the game");
            Console.WriteLine("===========================");
            return;
        }

        else if (check(p1, p2) == 2)

        {
            System.Console.WriteLine("Player 2 wins the game");
            Console.WriteLine("===========================");
            return;
        }


        // Keep this line intact 
        Console.WriteLine("===========================");
    }
}

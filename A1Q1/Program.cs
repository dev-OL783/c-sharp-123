namespace namespace_A1Q1;

class Program
{
    static void Main(string[] args)
    {
        // D = numDays
        // T = breadRolls
        // L = breadRolls / 13 left overs
        const string WELCOME_MSG = "Welcome to Baker's Dozen Bakery.";
        const string PROMPT = "Please enter the number of days that you have been baking:";
        const string ITEM_FORMAT = "Item {0}: {1}";
        const string EMPTY_LIST = "You have baked 0 rolls in total, which is equal to 0 baker's dozen and 0 rolls left over.";
        const string ERROR = "Error - Invalid number of days entered.";

        // Keep the following line intact 
        Console.WriteLine("===========================");

        Console.WriteLine(WELCOME_MSG);

        // // Print the initial prompt 
        Console.WriteLine(PROMPT);
        string userInput = Console.ReadLine();
        int numDays = int.Parse(userInput);


        // If number of items is greater than 0
        if (numDays > 0) {

                // Create the collection
                string[] items = new string[numDays];

                // Ask for bread rolls baked each day
                int T = 0;

                // Ask for bread rolls baked each day
                for (int i = 0; i < numDays; i++) {
                    Console.WriteLine("Please enter the number of rolls baked for day " + (i + 1) + ":");
                    userInput = Console.ReadLine();

                    items[i] = userInput;
                    T += int.Parse(userInput);
                    }

                    int B = T / 13;
                    int L = T % 13;

                    // Console.WriteLine("===========================");

                    // Console.WriteLine("T: " + T);
                    // Console.WriteLine("B: " + B);
                    // Console.WriteLine("L: " + L);
                    Console.WriteLine($"You have baked {T} rolls in total, which is equal to {B} baker's dozen and {L} rolls left over.");
                }

            
        // Else if the number of items is 0, present a suitable message
        else if (numDays == 0) {
            Console.WriteLine(EMPTY_LIST);
        // Else present error message
        } else { 
            Console.WriteLine(ERROR);
        }
        
        

        // Keep the following line intact
        Console.WriteLine("===========================");

    }
}

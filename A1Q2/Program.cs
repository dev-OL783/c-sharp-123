namespace A1Q2;

class Program
{
    static void Main(string[] args)
    {

        // Keep this line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        Console.WriteLine("Smoke and dust health action level calculator.");
        // Console.WriteLine("-----------------------------------------------");
        // Console.WriteLine("***********************************************");
        // Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Please enter the PM_2.5 concentration:");

        string value_PM = Console.ReadLine();
        double PM_Concentrate = Convert.ToDouble(value_PM);

        if (PM_Concentrate < 12.50 && PM_Concentrate >= 0) {
            Console.WriteLine("The PM_2.5 concentration is " + PM_Concentrate + ". The health action level is 1, which is good. The recommendation is that air pollution is at its usual background levels.");
        } else if (PM_Concentrate < 25.00 && PM_Concentrate >= 12.50) {
            Console.WriteLine("The PM_2.5 concentration is " + PM_Concentrate + ". The health action level is 2, which is fair. The recommendation is that sensitive groups can detect a change in air quality.");
        } else if (PM_Concentrate < 50.00 && PM_Concentrate >= 25.00) {
            Console.WriteLine("The PM_2.5 concentration is " + PM_Concentrate + ". The health action level is 3, which is poor. The recommendation is that the air is likely to be dusty or smoky.");
        } else if (PM_Concentrate < 150.00 && PM_Concentrate >= 50.00) {
            Console.WriteLine("The PM_2.5 concentration is " + PM_Concentrate + ". The health action level is 4, which is very poor. The recommendation is that the air is very dusty or smoky.");
        } else if (PM_Concentrate >= 150.00) {
            Console.WriteLine("The PM_2.5 concentration is " + PM_Concentrate + ". The health action level is 5, which is extremely poor. The recommendation is that the air is extremely dusty or smoky.");
        } else if (PM_Concentrate < 0) {
            Console.WriteLine("Error - The entered PM_2.5 concentration is invalid. It must be above 0.");
        } else {
            Console.WriteLine("Error - the input you have entered is invalid,");
        }

        // Keep this line intact 
        Console.WriteLine("===========================");
    }
}
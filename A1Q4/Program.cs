namespace A1Q4;

class Program
{

    // testing Coordinates (c). if the string input is within [1, 5]. Then return an response stating so.
    static void inputChoice(out int c)
    
    {
        string input = Console.ReadLine();
        if (!int.TryParse(input, out c))
        {
            System.Console.WriteLine("Wrong typed.");
        }
        else if (c < 0 || c > 5) // less than 0 or more than 5
        {
            System.Console.WriteLine("Out of bounds.");
        }
    }

    static void printMatrics(char[,] a)

    {
        for(int i = 4; i >= 0; --i)

        {
            for (int j = 0; j < 5; ++ j)

            {
                System.Console.WriteLine(a[i, j]);
            }

            System.Console.WriteLine();
        
        }
    
    }

    static bool checkMatrix(char[,] a, int x, int y, char c)
    {
        bool horizon = true;
        bool vertical = true;
        
        for (int i = 0; i < 5; ++i)
        {
            if (c!= a[i, y])
            {
                horizon = false;
                break;
            }
        }

        for (int i = 0; i < 5; ++i)
        {
            if (c!= a[x, i])
            {
                vertical = false;
                break;
            }
        }

        if (x == y || x + y == 4)
        {
            bool mainDiag = true;
            bool antiDiag = true;
            for (int i = 0; i < 5; ++i)
            {
                if (c!= a[i, i])
                {
                mainDiag = false;
                break;
                }
            }
            for (int i = 0; i < 5; ++i)
            {
                if (c!= a[i, 4 - i])
                {
                    antiDiag = false;
                    break;
                }
            }

            return horizon || vertical || mainDiag || antiDiag;
        }

        return horizon || vertical;
    }

    public static void Main()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Welcome to Connect Five.");
        Console.WriteLine("Player 1 is Red (R).");
        Console.WriteLine("Player 2 is Yellow (Y).");

        char[,] a =
        {
            {'0', '0', '0', '0', '0'},
            {'0', '0', '0', '0', '0'},
            {'0', '0', '0', '0', '0'},
            {'0', '0', '0', '0', '0'},
            {'0', '0', '0', '0', '0'},
        };

        int choice;
        char put = 'R';
        int cnt = 0;
        do
        {
            System.Console.WriteLine("Enter a column (1-5): ");
            inputChoice(out choice);
            if (choice == 0)
            
            {
                System.Console.WriteLine("Exit");
                Console.WriteLine("===========================");
                break;
            }
            
            else if (choice >= 1 && choice <= 5)

            {
                choice = choice - 1;
                int r = -1;
                for (int i = 0; i < 5; ++i)

                {

                    if (a[i, choice] == '0')

                    {
                        r = i;
                        a[r, choice] = put;
                        break;
                    }

                }
                
                if (r == -1)

                {
                    System.Console.WriteLine("Columns not found");
                    break;
                }

                printMatrics(a);
                if (checkMatrix(a, r, choice, put))

                {
                    System.Console.WriteLine($"{put} win");
                    Console.WriteLine("===========================");
                    break;
                }
                
            }

            put = (put == 'R') ? 'Y' : 'R';
            cnt += 1;
            
        } while (cnt < 25);

        if (cnt == 25)

        {
            System.Console.WriteLine("Tie");
            Console.WriteLine("===========================");
        }

    }


} 
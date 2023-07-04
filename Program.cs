namespace Assignment_1;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter an integer value between 1 and 100:");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please specify a series: even or odd");
            string series = Console.ReadLine();

            Console.WriteLine($"You have selected the {series} series. The numbers between 0 and {userInput} are:");

            switch (series.ToLower())
            {
                case "even":
                    PrintEvenSeries(userInput);
                    break;
                case "odd":
                    PrintOddSeries(userInput);
                    break;
                default:
                    Console.WriteLine("Invalid series selection. Please choose 'even' or 'odd'.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input. Please enter an integer within the range.");
        }
    }

    static void PrintEvenSeries(int n)
    {
        for (int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void PrintOddSeries(int n)
    {
        for (int i = 1; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}

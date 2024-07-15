namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers(int max)
        {
            var negative = max * -1;
            while (max >= negative)
            {
                Console.WriteLine(negative);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbersBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckIfEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        //Write a method to check whether a given number is even or odd
        public static bool CheckIfEven(int num)
        {
            return num % 2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        public static bool CheckIfPositive(int num)
        {
            return num >= 0;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote(int age)
        {
            if (int.TryParse(age.ToString(), out int parsedAge))
            {
                return parsedAge >= 18;
            }
            else
            {
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInRange(int num)
        {
            return num >= -10 && num <= 10;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers(1000);
            PrintNumbersBy3();
            bool isEqual = CheckIfEqual(5, 5);
            bool isOdd = CheckIfEven(7);
            bool isPositive = CheckIfPositive(-10);
            bool canVote = CanVote(18);
            bool isInRange = IsInRange(5);
            MultiplicationTable(5);
        }

        
    }
}

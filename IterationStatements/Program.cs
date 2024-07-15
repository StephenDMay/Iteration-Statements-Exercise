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
                Console.WriteLine(max);
                max--;
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
        public static void CheckIfEqual(int num1, int num2)
        {
            Console.WriteLine(num1 == num2);
        }

        //Write a method to check whether a given number is even or odd
        public static void CheckIfEven(int num)
        {
            Console.WriteLine(num % 2 == 0);
        }
        //Write a method to check whether a given number is positive or negative
        public static void CheckIfPositive(int num)
        {
            Console.WriteLine(num >= 0);
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote(int age)
        {
            var canVote = false;
            if (int.TryParse(age.ToString(), out int parsedAge))
            {
                canVote = parsedAge >= 18;
            }
            Console.WriteLine(canVote);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsInRange(int num)
        {
            Console.WriteLine(num >= -10 && num <= 10);
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
            CheckIfEqual(5, 5);
            CheckIfEven(7);
            CheckIfPositive(-10);
            CanVote(18);
            IsInRange(5);
            MultiplicationTable(5);
            Console.ReadLine();
        }

        
    }
}

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

       
        

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time USE FOR LOOP

        public static void ByThree()
        {
            for(int i = 3; i <= 999; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number to see if it is even or odd");
            int answer = int.Parse(Console.ReadLine());

            if(answer % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg()
        {
            Console.WriteLine("Enter a number to see if it is positive or negative");
            int answer = int.Parse(Console.ReadLine());

            if (answer < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is positive");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void VoterAge()
        {
            Console.WriteLine("Enter your age to see if you can vote");
            int UserAge = int.Parse(Console.ReadLine());

            int VoteAge = 18;

            if(UserAge > VoteAge)
            {
                Console.WriteLine("You can vote");
            }
            else 
            {
                Console.Write("You are too young to vote");
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void Range()
        {
            Console.WriteLine("Enter a number. It can be positive or negative");
            int answer = int.Parse(Console.ReadLine());

            if(answer >= -10 && answer <=10)
            {
                Console.WriteLine($"{answer} is between -10 & 10");
            }
            else
            {
                Console.WriteLine($"{answer} is not between -10 & 10");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable()
        {
            Console.WriteLine("Enter a number to see its multiplication table from 1-12");
            int UserInput = int.Parse( Console.ReadLine());

            for(int i = 0; i <= 12; i++)
            {
                int answer = UserInput * i;
                Console.WriteLine(answer);
            }
        }



        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintThousand();
            //ByThree();
            //IsEqual(4, 4);
            //EvenOrOdd();
            //PosOrNeg();
            //VoterAge();
            //Range();
            //MultTable();
        }
    }
}

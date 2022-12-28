namespace NumbersGame
{
    internal class Program
    {
        static bool CheckGuess(int number, int userValue)
        {
            if (number > userValue)
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
            }
            else if (number < userValue)
            {
                Console.WriteLine("Tyvärr du gissade för högt!");
            }
            else if (number == userValue)
            {
                Console.WriteLine("Woho! Du gjorde det!");
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            Console.WriteLine("Tryck '1' to  play the easy level");
            Console.WriteLine("Tryck '2' to  play the easy level");
            Console.WriteLine("Tryck '3' to  play the easy level");
            int newInput = Convert.ToInt32(Console.ReadLine());
            switch (newInput)
            {
                case 1:
                    Console.WriteLine("Enter a number to guess between 1 to 20:");
                    int number = random.Next(1, 20);

                    bool isGuessedRight = false;


                    for (int i = 0; i < 5; i++)
                    {

                        var userinput = Console.ReadLine();
                        int userValue = Convert.ToInt32(userinput);

                        isGuessedRight = CheckGuess(number, userValue);

                        if (isGuessedRight == true)
                        {
                            break;
                        }


                    //}//break;

                    //int number = random.Next(1, 20);

                    //bool isGuessedRight = false;


                    //for (int i = 0; i < 5; i++)
                    //{

                    //    var userinput = Console.ReadLine();
                    //    int userValue= Convert.ToInt32(userinput);

                    //    isGuessedRight = CheckGuess(number, userValue);

                    //    if (isGuessedRight == true)
                    //    {
                    //        break;
                    //    }


                    //if (number>userValue)
                    //{
                    //    Console.WriteLine("Tyvärr du gissade för lågt!");
                    //}
                    //else if (number<userValue)
                    //{
                    //    Console.WriteLine("Tyvärr du gissade för högt!");
                    //}
                    //else if (number==userValue)
                    //{
                    //    isGuessedRight = true;
                    //    Console.WriteLine("Woho! Du gjorde det!");

                    //}

                    if (i == 4 && isGuessedRight == false)
                    {
                        Console.WriteLine("Sorry, you failed to guess the number in five tries!");
                    }
                    
            }
                    break;
                
            }

        }
    }
}
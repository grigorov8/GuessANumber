namespace GuessANumber
{
    internal class Program
    {
        static void Main()
        {
            
            Random randomNumber = new Random();

            int computerNumber = randomNumber.Next(1, 100);

            while(true)
            {
                Console.Write("Guess a number (1-100): ");


                string playerInput = Console.ReadLine();

                bool IsValyd = int.TryParse(playerInput, out int playerNumber);

                if (IsValyd)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    

                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Its too High");
                    }

                    else
                    {
                        Console.WriteLine("Its too Low");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }


            }





        }
    }
}
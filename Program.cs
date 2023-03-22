namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "COMPUTER";
            string displayWord = "________";
            string guess;
            int wrongGuesses = 0;
            int totalGuesses = 0;
            bool done = false;


            Console.WriteLine(displayWord);
            Console.WriteLine();

            while (!done)
            {
                Console.Write("Pick a letter:  ");
                guess = Console.ReadLine().ToUpper();


                if (guess.Length == 1)
                {
                    if (word.Contains(guess))
                    {
                        displayWord = displayWord.Remove(word.IndexOf(guess), 1);
                        displayWord = displayWord.Insert(word.IndexOf(guess), guess);
                    }
                    else
                    {
                        wrongGuesses++;
                    }

                    totalGuesses++;

                    switch (wrongGuesses) 
                    {
                        case 1: DrawHanger(); break;
                        case 2: DrawHead(); break;
                        case 3: DrawArmL(); break;
                        case 4: DrawArmR(); break;
                        case 5: DrawLegL(); break;
                        case 6: DrawLegR(); break;
                        case 7: DrawDead(); break;
                    }

                    Console.WriteLine(displayWord);
                }
                else
                {
                    Console.WriteLine("You can only guess one letter at a time! ");
                }

                if (displayWord == word)
                {
                    Console.WriteLine("You guessed the word correctly! ");
                    done = true;
                }

                if (wrongGuesses == 7)
                {
                    Console.WriteLine("You died! ");
                    done = true;
                }
            }

            Console.WriteLine($"Your wrong guesses: {wrongGuesses} ");
            Console.WriteLine($"Your total guesses: {totalGuesses} ");
        }






        static void DrawHanger()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawHead()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawBody()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawArmL()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawArmR()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawLegL()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========");
        }
        static void DrawLegR()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
        }
        static void DrawDead()
        {
            Console.WriteLine("  +---+\r\n      |\r\n      | \r\n \\O/  |\r\n  |   |\r\n / \\  |\r\n=========s");
        }
    }
}
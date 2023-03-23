namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string word = "C O M P U T E R";
            string displayWord = "_ _ _ _ _ _ _ _";
            string guess;
            int wrongGuesses = 0;
            int totalGuesses = 0;
            bool done = false;
            
            Console.WriteLine();
            Console.WriteLine("  HANGMAN LITE");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How to Play: ");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine(" You are to continuously guess letters until you discover the entire word. ");
            Thread.Sleep(2000);
            Console.WriteLine(" After each guess, you will be told whether it is correct or incorrect. ");
            Thread.Sleep(2000);
            Console.WriteLine(" If the letter you guessed is not in the word, a limb is drawn on the man. ");
            Thread.Sleep(2000);
            Console.WriteLine(" After enough wrong guesses, the man will die and you LOSE. ");
            Thread.Sleep(2000);

            Console.WriteLine();
            Console.Write("Press ENTER to begin ");
            Console.ReadLine();
            Console.WriteLine();

            DrawHanger();
            Console.WriteLine();
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
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("That letter IS in the word! ");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        displayWord = displayWord.Remove(word.IndexOf(guess), 1);
                        displayWord = displayWord.Insert(word.IndexOf(guess), guess);
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("That letter is NOT in the word! ");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        wrongGuesses++;
                    }

                    totalGuesses++;

                    switch (wrongGuesses) 
                    {
                        case 1: DrawHead(); break;
                        case 2: DrawArmL(); break;
                        case 3: DrawArmR(); break;
                        case 4: DrawLegL(); break;
                        case 5: DrawLegR(); break;
                    }

                    Console.WriteLine(displayWord);
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("You can only guess one letter at a time! ");
                    Console.WriteLine();
                    Thread.Sleep(500);
                }

                if (displayWord == word)
                {
                    DrawWin();
                    Console.WriteLine("You guessed the word correctly and saved the man! ");
                    Console.WriteLine();
                    Thread.Sleep(1500);
                    done = true;
                }

                if (wrongGuesses == 5)
                {
                    Console.WriteLine("You died! ");
                    Console.WriteLine($"The word was {word}! ");
                    Console.WriteLine();
                    Thread.Sleep(1500);
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
        static void DrawWin()
        {
            Console.WriteLine("  +---+\r\n      |\r\n      | \r\n \\O/  |\r\n  |   |\r\n / \\  |\r\n=========");
        }
    }
}
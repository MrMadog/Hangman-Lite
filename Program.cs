namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string word = "";
            string displayWord = "_ _ _ _ _ _ _ _";
            string guess;
            int wrongGuesses = 0;
            int totalGuesses = 0;
            int difficulty = 0;
            bool done = false;
            List<string> words = new List<string>();

            Console.WriteLine();
            Console.WriteLine("  HANGMAN LITE");
            Wait10();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How to Play: ");
            Wait5();
            Console.WriteLine();
            Console.WriteLine(" You are to continuously guess letters until you discover the entire word. ");
            Wait20();
            Console.WriteLine(" After each guess, you will be told whether it is correct or incorrect. ");
            Wait20();
            Console.WriteLine(" If the letter you guessed is not in the word, a limb is drawn on the man. ");
            Wait20();
            Console.WriteLine(" After enough wrong guesses, the man will die and you LOSE. ");
            Wait20();
            
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
                Console.WriteLine("What difficulty would you like? ");
                Console.WriteLine("1 - Easy ");
                Console.WriteLine("2 - Medium ");
                Console.WriteLine("3 - Hard ");
                Console.Write("Difficulty:  ");
                difficulty = Convert.ToInt32(Console.ReadLine());

                var easyWords = File.ReadAllLines("Easy Words.txt");
                var mediumWords = File.ReadAllLines("Medium Words.txt");
                var hardWords = File.ReadAllLines("Hard Words.txt");

                switch (difficulty)
                {
                    case 1: Console.WriteLine("Difficulty set to: Easy ");
                        foreach (var s in easyWords)
                            words.Add(s); break;
                    case 2: Console.WriteLine("Difficulty set to: Medium ");
                        foreach (var s in mediumWords)
                            words.Add(s); break;
                    case 3: Console.WriteLine("Difficulty set to: Hard ");
                        foreach (var s in hardWords) 
                            words.Add(s); break;
                }
                Console.WriteLine(words[0] + words[1]);


                Console.Write("Pick a letter:  ");
                guess = Console.ReadLine().ToUpper();


                if (guess.Length == 1)
                {
                    if (word.Contains(guess))
                    {
                        Wait5();
                        Console.WriteLine();
                        Console.WriteLine("That letter IS in the word! ");
                        Console.WriteLine();
                        Wait5();
                        displayWord = displayWord.Remove(word.IndexOf(guess), 1);
                        displayWord = displayWord.Insert(word.IndexOf(guess), guess);
                    }
                    else
                    {
                        Wait5();
                        Console.WriteLine();
                        Console.WriteLine("That letter is NOT in the word! ");
                        Console.WriteLine();
                        Wait5();
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
                    Wait10();
                }
                else
                {
                    Wait5();
                    Console.WriteLine();
                    Console.WriteLine("You can only guess one letter at a time! ");
                    Console.WriteLine();
                    Wait5();
                }

                if (displayWord == word)
                {
                    DrawWin();
                    Console.WriteLine("You guessed the word correctly and saved the man! ");
                    Console.WriteLine();
                    Wait20();
                    done = true;
                }

                if (wrongGuesses == 5)
                {
                    Console.WriteLine("You died! ");
                    Console.WriteLine($"The word was {word}! ");
                    Console.WriteLine();
                    Wait20();
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
        static void Wait5()
        {
            Thread.Sleep(500);
        }
        static void Wait10()
        {
            Thread.Sleep(1000);
        }
        static void Wait20()
        {
            Thread.Sleep(2000);
        }
    }
}
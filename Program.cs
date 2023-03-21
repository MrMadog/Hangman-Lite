namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "C O M P U T E R";
            string displayWord = "_ _ _ _ _ _ _ _";
            int wrongGuesses = 0;
            bool done = false;
            DrawHanger();
            Console.WriteLine(word);
            Console.WriteLine(displayWord);
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
namespace LocalMathGame;

class Menu
{
    public void MenuSystem(int numOfGames)
    {
        Engine engine = new Engine();
        bool isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("(a) Addition");
            Console.WriteLine("(s) Subtraction");
            Console.WriteLine("(m) Multiplication");
            Console.WriteLine("(d) Division");
            Console.WriteLine("(v) View games!");
            Console.WriteLine("(r) Random Game!");
            Console.WriteLine("(q) Quit!");

            string input = Console.ReadLine();

            switch (input.Trim().ToLower())
            {

                case "a":
                    engine.Addition(numOfGames);
                    break;
                case "s":
                    engine.Subtraction(numOfGames);
                    break;
                case "m":
                    engine.Multiplication(numOfGames);
                    break;
                case "d":
                    engine.Division(numOfGames);
                    break;
                case "v":
                    break;
                case "r":
                    break;
                case "q":
                    Console.WriteLine("Goodbye! Thank you for playing!");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Please type a correct value");
                    break;
            } while (isGameOn);
        }
    }
}
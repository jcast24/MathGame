namespace LocalMathGame;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Math game!");
        // Console.WriteLine("How many games would you like to play?: ");

        // var input = int.Parse(Console.ReadLine());
        var menu = new Menu();
        menu.MenuSystem();

    }
}
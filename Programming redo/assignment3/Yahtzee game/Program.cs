namespace Yahtzee_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.Start();
        }
        void Start()
        {
            YahtzeeGame yahtzeeGame= new YahtzeeGame();
            yahtzeeGame.Init();
            PlayYahtzee(yahtzeeGame);
            
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int numberOfAttempts = 0;
            do
            {
                game.Throw();
                game.DisplayValues();
                numberOfAttempts++;

            } while (!game.Yahtzee());
            Console.WriteLine($"{numberOfAttempts} number of attempts needed for yahtzee");
        }

    }
}
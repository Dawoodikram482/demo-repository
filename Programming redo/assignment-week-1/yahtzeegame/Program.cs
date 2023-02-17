namespace yahtzeegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program newProgram = new Program();
            newProgram.Start();
        }
        void Start()
        {
            GameYahtzee yahtzee= new GameYahtzee();
            yahtzee.Init();
            PlayYahtzee(yahtzee);
        }
        void PlayYahtzee(GameYahtzee game)
        {
             int nrOfAttempts = 0;
            do
            {
                game.Throw();
                game.DisplayValue();
                nrOfAttempts++;
            } while (!game.Yahtzee());
            Console.WriteLine($"Number of attempts needed (for Yahtzee): {nrOfAttempts}");

        }
    }
}
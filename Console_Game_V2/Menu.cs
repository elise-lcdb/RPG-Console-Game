using System;
namespace Console_Game_V2
{
    public class Menu
    {
        public Menu()
        {
            PrintMenu();
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    About();
                    break;
                case 2:
                    Quit();
                    break;
                default:
                    Console.WriteLine("Please enter a valid character:");
                    break;

            }

        }
        public void PrintMenu()
        {
            Console.WriteLine(".___  ___.  _______ .__   __.  __    __  \n|   \\/   | |   ____||  \\ |  | |  |  |  | \n|  \\  /  | |  |__   |   \\|  | |  |  |  | \n|  |\\/|  | |   __|  |  . `  | |  |  |  | \n|  |  |  | |  |____ |  |\\   | |  `--'  | \n|__|  |__| |_______||__| \\__|  \\______/  \n                                         ");
            Console.WriteLine("0 - Start Game");
            Console.WriteLine("1 - About Game");
            Console.WriteLine("2 - Quit Game");
        }
        //public void AskChoice(int min, int max)
        //{

        //}
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Hello. This is Start Game");
            Game game = new Game();
        }
        public void About()
        {
            Console.WriteLine("Hello, this is what the game is about");
            Console.WriteLine("Made by Elise");
        }
        public void Quit()
        {
            Console.WriteLine("Hello. This is quit");
        }
    }
}

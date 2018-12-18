using System;
namespace Console_Game_V2
{
    public class Player
    {
        //TODO define the characters
        //TODO maybe have 1 character, and not a choice between several players
        public enum PlayerJob { PlayerOpt1, PlayerOpt2, PlayerOpt3 };
        public string Name;
        public PlayerJob Job;
        protected int LifePoints;
        protected int Force;
        //protected int Endurance;

        public Player()
        {
            Console.WriteLine("What is your name?");
            string PlayerName = Console.ReadLine();
            Name = PlayerName;
            Console.Clear();
            Console.WriteLine("Welcome " + Name + "!");
            Console.WriteLine("Choose your player: ");
            PrintPlayerChoice();
            int PlayerJ = Convert.ToInt32(Console.ReadLine());
            PlayerChoice(PlayerJ);
            DefinePlayer(Job);
            Console.Clear();
            PlayerIntroduction();
            //TODO attacks but later one thing at a time
        }
        public void DefinePlayer(PlayerJob j)
        {
            Job = j;

            if(j == PlayerJob.PlayerOpt1)
            {
                LifePoints = 100;

            }
            else if(j == PlayerJob.PlayerOpt2)
            {
                LifePoints = 100;
            }
            else if(j == PlayerJob.PlayerOpt3)
            {
                LifePoints = 100;
            }
            //TODO add things like force size lifepoints etc
            //TODO have the player have an inventory
            //TODO the player could also have a level and that could determine what monsters you fight 
        }
        public void PrintPlayerChoice()
        {
         
            Console.WriteLine("0 - " + PlayerJob.PlayerOpt1);
            Console.WriteLine("1 - " + PlayerJob.PlayerOpt2);
            Console.WriteLine("2 - " + PlayerJob.PlayerOpt3);
           
        }
        public void PlayerChoice(int c)
        {
            switch (c)
            {
                case 0:
                    Job = PlayerJob.PlayerOpt1;
                    break;
                case 1:
                    Job = PlayerJob.PlayerOpt2;
                    break;
                case 2:
                    Job = PlayerJob.PlayerOpt3;
                    break;


            }
        }
        public void PlayerIntroduction()
        {
            Console.WriteLine("Congrats, " + Name + "!");
            Console.WriteLine("You have chosen the player " + Job + "!");
            Console.WriteLine("This player has " + LifePoints + " life points, and all of the other things here.");
            Console.WriteLine("You also have an inventory, where you are allowed to hold 10 items");
            Console.WriteLine("To start off we have given you a cellphone (if that is the route I am going in)");
            Console.WriteLine("Lets get started on your adventure!");
        }
        public void Attack()
        {
            //TODO loose health and define when an attack is over
            //TODO define different attacks with different strengths maybe?
            //TODO If there are different attacks they should maybe be worth different XP, slowly but surely the XP refills
        }
    }
}

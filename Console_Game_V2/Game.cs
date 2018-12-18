using System;
namespace Console_Game_V2
{
    public class Game
    {
        public Game()
        {
            Introduction();
            Player player = new Player();
            Console.Clear();
            //TODO define the map and create it
            Map map = new Map(); 
        }
        public void Introduction()
        {
            //TODO Introcution Text
            Console.WriteLine("Game introduction thing goes here");

        }
        //public void Map()
        //{
        //    //TODO pull everything from the class Map and handle that stuff
        //}


    }
}

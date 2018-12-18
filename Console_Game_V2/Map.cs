using System;
namespace Console_Game_V2
{
    public class Map
    {
        public string[,] TheMap = new string[5, 7];
        public int PositionX; //Column
        public int PositionY; //Row
        public string CurrentPos;
        public string Empty;
        public string DirectionChoice;


        public Map()
        {
           
            //Empty = "Nothing";
            CurrentPos = "Current Position"; //I don't think I need youuuuuuuu
            StartPosition();
            Console.WriteLine("Choose a direction to go in?");
            PrintDirectionChoices();
            //TODO maybe add a while loop. while posX is not equal to 6 ask for directions?
        }
        public void StartPosition()
        {
            PositionX = 0;
            PositionY = 2;
            TheMap[PositionX, PositionY] = CurrentPos;

        }
        public void PrintDirectionChoices()
        {
            if(PositionX == 0 && PositionY == 0)
            {
                Console.WriteLine("1 - Go Right");
                Console.WriteLine("2 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "RIGHT";
                        break;
                    case 2:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
            else if(PositionX == 0 && PositionY == 4)
            {
                Console.WriteLine("1 - Go Up");
                Console.WriteLine("2 - Go Right");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "RIGHT";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
            else if(PositionX == 0 && PositionY != 0 && PositionY != 4)
            {
                Console.Write("1 - Go Up");
                Console.WriteLine("2 - Go Right");
                Console.WriteLine("3 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "RIGHT";
                        break;
                    case 3:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
                //I might not need all of this. if that is my ending point
            //else if(PositionX == 6 && PositionY == 0)
            //{
            //    Console.WriteLine("1 - Go left");
            //    Console.WriteLine("2 - Go Down");
            //    int direction = Convert.ToInt32(Console.ReadLine());
            //}
            //else if(PositionX == 6 && PositionY == 4)
            //{
            //    Console.WriteLine("1 - Go Up");
            //    Console.WriteLine("2 - Go Left");
            //    int direction = Convert.ToInt32(Console.ReadLine());
            //}
            //else if(PositionX == 6 && PositionY != 0 && PositionY != 4)
            //{
            //    Console.WriteLine("1 - Go up");
            //    Console.WriteLine("2 - Go left");
            //    Console.WriteLine("3 - Go down");
            //    int direction = Convert.ToInt32(Console.ReadLine());
            //}
            else
            {
                Console.WriteLine("1 - Go Up");
                Console.WriteLine("2 - Go Left");
                Console.WriteLine("3 - Go Right");
                Console.WriteLine("4 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "LEFT";
                        break;
                    case 3:
                        DirectionChoice = "RIGHT";
                        break;
                    case 4:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }

        }
        public void UpdatePosition()
        {
            switch (DirectionChoice)
            {
                case "UP":
                    PositionY = PositionY + 1;
                    break;
                case "DOWN":
                    PositionY = PositionY - 1;
                    break;
                case "RIGHT":
                    PositionX = PositionX + 1;
                    break;
                case "LEFT":
                    PositionX = PositionX - 1;
                    break;
            }
        }
        public void Dodge()
        {
            //ConsoleKeyInfo k = new ConsoleKeyInfo();
            //Console.WriteLine("Press any key in the next 5 seconds.");
            //for (int cnt = 5; cnt > 0; cnt--)
            //{
            //    if (Console.KeyAvailable == true)
            //    {
            //        k = Console.ReadKey();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(cnt.ToString());
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //}
            //Console.WriteLine("The key pressed was " + k.Key);
        }
        public void EmptySpot()
        {
            Console.WriteLine("So far so good");
        }
        public void EnemyLvl1()
        {
            //List the enemy spots. Then do an if dodge == "true" then do nothing well ask for new directions 
            //If dodge is equal to false then call the enemy to attack. Actually I think those could be done in the seprate 
            //if dodge == false
            //If unable to dodge the player has been spotted 
            //TODO what happens when the player lands on a case that has an enemy
            //TODO create an attack method in player and allow the player to choose between different attack options
            //TODO create an attack method in enemy that randomly chooses attacks
        }
        public void EnemyLvl2()
        {
            //If inventory item added like sunglasses and hoodie combined, then not seen else. attack

        }
        public void EnemyLvl3()
        {
            //If dodged behind a car, then not seen else. attack

        }
        public void EnemyBoss()
        {
            //Their ain't no hiding from your ex
        }
        public void InventoryItem()
        {

        }
    }
}

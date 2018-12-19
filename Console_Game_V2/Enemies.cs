using System;
namespace Console_Game_V2
{
    public class Enemies
    {
        public enum EnemyJob { GiletVert, HsClassmate, AuntLynda, YourEx };
        public string Name;
        public EnemyJob Job;
        protected int LifePoints;
        protected int Force;
        protected int Endurance;
        //This will be exactly like the player except there are no choices done
        //The enemy could also have an inventory to make the attacks more brutal or defend against you
        public Enemies()
        {
        }
        public void DefineEnemy(EnemyJob j)
        {
            Job = j;

            if (j == EnemyJob.GiletVert)
            {
                LifePoints = 10;

            }
            else if (j == EnemyJob.HsClassmate)
            {
                LifePoints = 15;
            }
            else if (j == EnemyJob.AuntLynda)
            {
                LifePoints = 25;
            }
            else if(j == EnemyJob.YourEx)
            {
                LifePoints = 35;
            }
            //TODO add things like force size lifepoints etc
            //TODO have the player have an inventory
            //TODO the player could also have a level and that could determine what monsters you fight 
        }
     
    }
}

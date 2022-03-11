using System;

namespace homework_dana
{
    class Program
    {
        static void Main(string[] args)
        {
            string charctername = "hero";
            int playerHealth = 100;
            int update = 10;
            int Damage()
            {
                
                int enemyDamage = 20;
                return playerHealth - enemyDamage;
            }
            Console.WriteLine(Damage());

            Console.WriteLine("health is {0}" ,playerHealth+update);


               
           

               
            
             int boost()
            {
                int boost = 10;
              return playerHealth + boost;
            }

            Console.WriteLine(boost());





                string[] charcternames = {"80" , "110","120" };
            Console.WriteLine(charcternames[1]);
            Console.WriteLine(Damage()>boost());
            




        }



        }
    }


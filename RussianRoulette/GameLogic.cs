using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    public class GameLogic
    {
        public int loadbullet, spinbullet, shoot, shootaway, scrore = 100, counter =0, bulletposition;
        public bool win, loss;
        Random obj_rnd = new Random();
        public void Load() // Load funtion will load the Bullet
        {
            loadbullet = 1;
        }

        public void Spin() // Spin Function will spin Chamber
        {
            spinbullet = obj_rnd.Next(1, 7);
        }

        public bool Shoot() // Shoot function will shoot the bullet
        {
            bulletposition = logic(loadbullet ,spinbullet);
            if(bulletposition==0)
            {
                return true;
            }
            else
            {
                spinbullet = bulletposition;
                return false;
            }
        }

        public int logic(int load, int spin)
        {
            if (load == spin)
            {
                return 0;
            }
            else if (spin == 6)
            {
                return 1;
            }
            else
            {
               return spin = spin+1;
            }
            
        }
    }
}

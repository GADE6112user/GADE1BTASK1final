using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Goblin : Enemy
    {
        private int hp = 10;
        private int damage = 1;
        private int x;
        private int y;
        public delegate void Del(string message);
        public delegate int goblinHP(int hp);
        public delegate int goblinDamage(int damage);
        Del handler = Goblin;
        public Goblin (int X, int Y) //2.5 ?
        {
            //hp = Hp;
            //damage = Damage;
            x = X;
            y = Y;

        }
        public override ReturnMove()
        {
            // This method does not use the optional movement parameter. Instead, it randoms a direction for the goblin to move in, and checks that movement against the goblin’s vision array.If something is in the way(a Hero or a Wall for now), the random position should be rerolled.When a valid position is chosen, it is returned from the method.
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    
    public abstract class Enemy : Character
    {
        //protected Member variable?? 2.4
        Random Random = new Random();   
        private int enemyDamage = 0;
        private int enemyHp = 0;
        private int enemyMaxHp = 0;
        private int x = 0;
        private int y = 0;
        private char charr;
        public delegate int xPos(int x); // ??
        public delegate int yPos(int y);

        public Enemy(int X, int Y, char Char,int EnemyDamage, int EnemyHp, int EnemyMaxHp)
        {
            enemyDamage = EnemyDamage;
            enemyHp = EnemyHp;
            enemyMaxHp = EnemyMaxHp;
            charr = Char;
            x = X;
            y = Y;

        }
        public abstract override ToString()
        {
            return "EnemyClassName (1) at [x,y] (1) (X DMG) (1)"; //EnemyClassName at [X, Y] (Amount DMG) 
        }
    }
    
}

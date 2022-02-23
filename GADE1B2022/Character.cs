using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public abstract class Character
    {
        protected int x;
        protected int y;
        public char symbol;
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected Tile[] CharacterVison = new Tile[4];
        public readonly Character ctype;
       // public Enum MovementEnum;
        public Character(int X, int Y, char Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;

        }
        
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        protected int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public enum Movement
        {
            No_Movement,
            Up,
            Down,
            Left,
            Right
        }
        public Movement movement
        {
            get { return movement; }
            set { movement = value; }
        }
        // public Character(int Hp, int MaxHp, int Damage,  )
        public virtual void Attack(Character target)
        {
            target.hp = target.hp - this.damage;

        }
        public bool IsDead()
        {
            if (hp > 0)
                return true;
            else
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            //Checks if a target is in range of a character(barehanded range is always 1, but this will be extended with weapon types later). It determines distance via the DistanceTo() method and returns true or false.
            // if ()

            return DistanceTo(target);
        }
        private bool DistanceTo(Character target)
        {
            //used by CheckRange(): Determines the absolute distance(number of spaces needed to move – e.g.diagonal is one up + one across = 2) between a character and its target.
            if ((Math.Abs(this.x - target.x) <= 1) ||
                   (Math.Abs(this.x - target.y) <= 1))
                return true;
            else
                return false ;
       }
        public void Move(Movement move)
        {
            if (move == Movement.Up)
                y++;
            if (move == Movement.Down)
                y--;
            if (move == Movement.Left)
                x--;
            if (move == Movement.Right)
                x++;
            //Edits a unit’s X and Y values to move it up / down / left / right based on the identifier from the enum.
        }
        // 2.3 ??
        public abstract Movement ReturnMove(Movement move = 0);

    public abstract string toString();

}
    
}



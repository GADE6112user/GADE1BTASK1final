using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Hero : Character // 2.6
    {
        private int x = 0;
        private int y = 0;
        private int hp;
        private int maxHp = 0;
        private char symbol = 'H';

        public Hero(int X, int Y, char Symbol) : base(X, Y, Symbol)
        {
            this.x = X;
            this.y = Y;
            this.symbol = Symbol;
        }

        public override Movement ReturnMove(Movement move)
        {
            return Character.Movement.No_Movement;
            // This method receives a movement indicator based on a directional button press(either on the Windows Form or via the keyboard). It then checks that potential movement (up/ down / left / right) against the vision array and returns that same number  if it is valid.If it is not valid, it returns a MovementEnum.None, which signals to the calling method that a movement should not be made.
        }

        public override string toString()
        {
            // Player Stats:
            //  HP: HP / Max HP
            //   Damage: 2 
            //     X, Y]
            return "Player Stats: " + "\n" + "HP: " + hp / maxHp + "\n" + "Damage: 2" + "\n" + x + ", " + y;

        }
    }
}
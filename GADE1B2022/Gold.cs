using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public class Gold : Item
    {
        private int x;
        private int y;
        private int goldDropCount;
        private Random rnd = new Random();
        //public TileType goldTT;
        public int GetRandomNumber()
        {
            return rnd.Next(1,6);
        }
        
        public int getGoldDropCount
        {
            get { return goldDropCount; }// 
        }
        public Gold(int X, int Y)
        {
            x = X;
            y = Y;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class PO
    {

        public int x;
        public int y;
        public char sum;

        public PO (int _x, int _y, char _sum )
        {
            x = _x;
            y = _y;
            sum = _sum;
        }

        public PO(PO p)
        {
            x = p.x;
            y = p.y;
            sum = p.sum;
        }

        public void Move(int offset, DN1 direction)
        { 
            if(direction==DN1.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == DN1.LEFT)
            {
                x = x - offset;
            }
            else if (direction == DN1.UP)
            {
                y = y - offset;

            }
            else if (direction == DN1.DOWN)
            {
                y = y - offset;
            }

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }

        //public override string ToString()
        //{
        //    return x+','+y+'y'+sum;

        //}

    }
}

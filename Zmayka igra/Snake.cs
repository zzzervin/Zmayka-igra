using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class Snake: Fe
    {
        public Snake(PO tail, int lenght ,DN1 direction )
        {
            pList = new List<PO>();
            for (int i = 0; i < lenght ; i++)
            {
                PO p = new PO(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}

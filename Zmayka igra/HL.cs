using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class HL :Fe
    {

        //List<PO> pList;

        public HL(int xleft, int xreight, int y, char sum)
        {
            pList = new List<PO>();
            for (int x = xleft; x <= xreight; x++)
            {
                PO p = new PO(x, y, sum);
                pList.Add(p);
            }

            //PO p1 = new PO(4, 4, '*');
            //PO p2 = new PO(5, 4, '*');
            //PO p3 = new PO(6, 4, '*');
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
        }

        //public void Drow()
        //{
        //    foreach(PO p in pList)
        //    {
        //        p.Draw();
        //    }
        //}

    }
}

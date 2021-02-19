using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class VL : Fe
    {
        //List<PO> pList;
        public VL(int yup, int ydown, int x, char sum)
        {
            pList = new List<PO>();
            for (int y = yup; y <= ydown; y++)
            {
                PO p = new PO(x, y, sum);
                pList.Add(p);
            }

        }

        //public void Drow()
        //{
        //    foreach (PO p in pList)
        //    {
        //        p.Draw();
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class Fe
    {
        protected List<PO> pList;

        public void Drow()
        {
            foreach (PO p in pList)
            {
                p.Draw();
            }
        }
    }
}

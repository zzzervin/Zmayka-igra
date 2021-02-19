using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmayka_igra
{
    class Program
    {
        static void Main(string[] args)
        {
            PO p = new PO(1,3,'@');
            Snake snake = new Snake( p, 4, DN1.RIGHT);
          

            PO p2 = new PO(4,5,'#');
            p2.Draw();

            HL rughtline = new HL(0,78,0,'+');
            HL leftline = new HL(0,78,24, '+');
            VL upline = new VL(0,24 ,0 , '+');
            VL downline = new VL(0, 24, 78, '+');
            rughtline.Drow();
            leftline.Drow();
            upline.Drow();
            downline.Drow();



            //List<int> numList = new List<int>();
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);

            //int x  = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            //foreach (int i in numList)
            //{
            //    Console.WriteLine(i);
            //}

            //numList.RemoveAt(0);

            //List<PO> pList = new List<PO>();
            //pList.Add(p1);
            //pList.Add(p2);

            Console.ReadLine();
        }
        
     


    }
}

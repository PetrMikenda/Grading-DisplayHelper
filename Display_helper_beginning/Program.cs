using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_helper_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(20,5/*, 15, 6*/);
            Display d2 = new Display(60, 0);
            //Display d2 = new Display(20, 20);
            //d2.AddItem("ahoj");
            d1.AddItem("ahoj");
            d1.AddItem("joha");
            d2.AddItem("jdjsaaaaaaaaaaaaaaa");
            d2.AddItem("ahojahoj");
            d1.AddItem("aaaaa");
            d1.AddItem("a");
            d2.frame();
            d1.frame();
            d1.AddItem("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.ReadKey();
        }
    }
}

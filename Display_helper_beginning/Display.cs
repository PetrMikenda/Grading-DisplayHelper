using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_helper_beginning
{
    public class Display
    {
        private int d;
        private int x;
        private string item_;
        string[] pole_ = new string[50];
        int[] width_ = new int[50];
        private int lenght_;
        private int line_ ;
        //private int width_;
        //private int height_;
        private int yMg_; /*margin na ose y*/
        private int xMg_; /*margin na ose x*/
        const int PADDING = 1;


        public Display(/*string item, int line, */int xMg, int yMg/*, int width, int height*/)
        {
            //item_ = item;
            //line_ = line - 1;
            xMg_ = xMg;
            yMg_ = yMg;
            //width_ = width;
            //height_ = height;
        }

        public void frame()
        {
            Console.SetCursorPosition(xMg_, yMg_);
            Console.Write("+");
            for (int i = 0; i < lenght_ + (2 * PADDING); i++)
            {
                Console.Write("-");
            }
            Console.Write("+" + "\n");
            for (int i = 0; i <= (2 * PADDING) + line_; i++)
            {
                Console.SetCursorPosition(xMg_, yMg_  + i + 1);
                Console.Write("|");
                //for (int j = 0; j < lenght_ + 2*PADDING; j++)
                //{
                //if (j == PADDING + 1)
                //{
                //    /*   Console.Write(PADDING * " ");*/
                //    Console.Write(String.Concat(Enumerable.Repeat(" ", PADDING)));
                //    Console.Write(item_);
                //    Console.Write(String.Concat(Enumerable.Repeat(" ", PADDING)));
                //}
                //else
                //    Console.Write(" ");
                //}
                Console.SetCursorPosition(xMg_ + lenght_ + 2 * PADDING + 1, yMg_ + i + 1);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(xMg_, yMg_ + 2*PADDING + line_ + 1);
            Console.Write("+");
            for (int i = 0; i < lenght_ + 2*PADDING; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine(pole_[2]);

            for (int i = 0; i <= x; i++)
            {
                Console.SetCursorPosition(1 + xMg_ + PADDING, 1 + yMg_ + PADDING + i);
                Console.WriteLine(pole_[i]);
            }
        }
        //public void print()
        //{
        //    //Console.SetCursorPosition(1 + xMg_ + PADDING, 1 + yMg_ + PADDING);
        //    //Console.WriteLine(item_);
        //    for (int i = 0; i <= x ; i++)
        //    {
        //        Console.SetCursorPosition(1 + xMg_ + PADDING, 1 + yMg_ + PADDING + i);
        //        Console.WriteLine(pole_[i]);
        //    }
        //}

        public void AddItem(string item_)
        {
            pole_[x] = item_;
            width_[x] = item_.Length;
            Console.SetCursorPosition(1 + xMg_ + PADDING, 1 + yMg_ + PADDING);
            lenght_ = width_.Max();
            line_++;
            x++;
            //Console.WriteLine(item_);


        }

        //public void back(int count)
        //{
        //    Console.SetCursorPosition(1 + xMg_ + PADDING + , 1 + yMg_ + PADDING + count);
        //}
    }
}

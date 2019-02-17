using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            //отрисовка рамочки
            

            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VerticallLine Leftline = new VerticallLine(0, 24, 0, '+');
            VerticallLine Rightline = new VerticallLine(0, 24, 78, '+');


            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rightline.Draw();

            Console.ReadLine();
        }
    }
}
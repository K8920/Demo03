using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            tv.Power = true;
            tv.Channel = 10;
            tv.TextTV = false;
            tv.Volume = 100;
            Console.WriteLine("------------------------------");
            tv.DataPrint();
            tv.Signal();
            tv.LessVol();
            Console.WriteLine("------------------------------");
            tv.DataPrint();
            tv.Signal();
            tv.MoreVol();
            tv.MoreVol();
            tv.TextTV = true;
            tv.Channel = 101;
            Console.WriteLine("------------------------------");
            tv.DataPrint();
            tv.Signal();
            Console.WriteLine("------------------------------");
        }
    }
}

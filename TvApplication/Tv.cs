using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Tv
    {
        public bool Power { get; set; }
        public int Channel { get; set; }
        public bool TextTV { get; set; }
        public int Volume { get; set; }

        public void Signal()
        {
            if(Channel < 1 || Channel > 100)
            {
                Console.WriteLine("No Signal");
            }
            else if (Channel < 100 || Channel > 1)
            {
                Console.WriteLine("Signal Found");
            }
        }
        public void DataPrint()
        {
            Console.WriteLine("power is " +Power);
            Console.WriteLine("channel is " + Channel);
            Console.WriteLine("text-tv is " + TextTV);
            Console.WriteLine("volume is " + Volume);
            
        }
        public void MoreVol()
        {
            Volume += 2;
        }
        public void LessVol()
        {
            Volume -= 2;
        }
    }
}

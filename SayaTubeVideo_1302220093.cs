using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL06_1302220093
{
    public class SayaTubeVideo_1302220093
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo_1302220093(string title)
        {
            Random acak = new Random();
            id = acak.Next(9999, 100001);

            //  Precondition
            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}

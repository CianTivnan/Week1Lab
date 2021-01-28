using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Album
    {
        //attributes
        public string AlbumName { get; set; }

        public DateTime Released { get; set; }

        public int Sales { get; set; }

        //ctor
        public Album() { }

        public Album(string a)
        {
            AlbumName = a;

            var rand = new Random();

            Released = RandomYear();

            Sales = rand.Next(1000, 250000);
        }

        public override string ToString()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan sinceRelease = (DateTime.Today - Released);
            int years = (zeroTime + sinceRelease).Year - 1;

            return AlbumName + ", " + Sales + " sales, \n" + "Years since release: " + years;
        }


        private Random gen = new Random();
        private DateTime RandomYear()
        {
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}

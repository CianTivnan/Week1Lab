using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    abstract class Band : IComparable<Band>
    {
        //attributes
        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        public List<Album> Albums { get; set; }

        //ctors
        public Band() { }

        public Band(string a, int b, string c)
        {
            BandName = a;
            YearFormed = b;
            Members = c;
            Albums = new List<Album>();
        }

        

        public int CompareTo(Band band)
        {
            return BandName.CompareTo(band.BandName);
        }
    }

    class RockBand : Band
    {
        //ctor
        public RockBand(string a, int b, string c) : base(a, b, c) { }

        public override string ToString()
        {
            return BandName + " - Rock";
        }
    }

    class PopBand : Band
    {
        //ctor
        public PopBand(string a, int b, string c) : base(a, b, c) { }

        public override string ToString()
        {
            return BandName + " - Pop";
        }
    }

    class IndieBand : Band
    {
        //ctor
        public IndieBand(string a, int b, string c) : base(a, b, c) { }

        public override string ToString()
        {
            return BandName + " - Indie";
        }
    }

}

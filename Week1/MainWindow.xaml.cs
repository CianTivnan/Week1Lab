using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Band> DisplayList = new List<Band>();
        static List<Band> BandList = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();

            LoadBands();

            DisplayBands();
        }

        private void LoadBands()
        {
            RockBand b1 = new RockBand("Woods of Ypres", 2002, "David Gold, Joel Violette, Rae Amitay, Brendan Hayter");
            BandList.Add(b1);
            DisplayList.Add(b1);
            RockBand b2 = new RockBand("Behemoth", 1991, "Adam Darski, Zbigniew Prominski, Tomasz Wroblewski");
            BandList.Add(b2);
            DisplayList.Add(b2);
            PopBand b3 = new PopBand("Scooter", 1993, "Hans Peter Geerdes, Michael Simon, Sebastian Schilde");
            BandList.Add(b3);
            DisplayList.Add(b3);
            PopBand b4 = new PopBand("Cascada", 2004, "Natalie Horlier, Manuel Reuter, Yann Peifer");
            BandList.Add(b4);
            DisplayList.Add(b4);
            IndieBand b5 = new IndieBand("Dread Sovereign", 2013, "Alan Nemtheanga Averill, Eoin Bones, Johnny King");
            BandList.Add(b5);
            DisplayList.Add(b5);
            IndieBand b6 = new IndieBand("Cruachan", 1992, "Keith Fay, Joe Farrell, Audrey Trainor, Dave Quinn, Tom Woodlock");
            BandList.Add(b6);
            DisplayList.Add(b6);
        }

        private void DisplayBands()
        {
            DisplayList.Sort();
            lbx_Bands.ItemsSource = DisplayList;
        }
    }
}

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
            LoadBands();
            InitializeComponent();

            

            LoadAlbums();

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

        private void LoadAlbums()
        {
            Album a1 = new Album("Woods 5: Grey Skies and Electric Light");
            BandList[0].Albums.Add(a1);
            Album a2 = new Album("Woods IV: The Green Album");
            BandList[0].Albums.Add(a2);
            Album a3 = new Album("The Satanist");
            BandList[1].Albums.Add(a3);
            Album a4 = new Album("The Apostasy");
            BandList[1].Albums.Add(a4);
            Album a5 = new Album("...and the Beat Goes On!");
            BandList[2].Albums.Add(a5);
            Album a6 = new Album("Our Happy Hardcore");
            BandList[2].Albums.Add(a6);
            Album a7 = new Album("Everytime We Touch");
            BandList[3].Albums.Add(a7);
            Album a8 = new Album("Evacuate The Dancefloor");
            BandList[3].Albums.Add(a8);
            Album a9 = new Album("Pray to the Devil in Man");
            BandList[4].Albums.Add(a9);
            Album a10 = new Album("All Hell's Martyrs");
            BandList[4].Albums.Add(a10);
            Album a11 = new Album("Tuatha na Gael");
            BandList[5].Albums.Add(a11);
            Album a12 = new Album("The Morrigan's Call");
            BandList[5].Albums.Add(a12);
        }

        private void DisplayBands()
        {
            lbx_Bands.ItemsSource = null;
            DisplayList.Sort();
            lbx_Bands.ItemsSource = DisplayList;
        }

        private void lbx_Bands_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            lbx_Albums.ItemsSource = null;

            Band SelectedBand = lbx_Bands.SelectedItem as Band;

            if(SelectedBand == null)
            {
                return;
            }

            tblk_Formed.Text = SelectedBand.YearFormed.ToString();

            tblk_Members.Text = SelectedBand.Members;

            lbx_Albums.ItemsSource = SelectedBand.Albums;
        }

        private void cmbx_Genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxItem = cmbx_Genre.SelectedItem as ComboBoxItem;
            string SelectedGenre = comboBoxItem.Content.ToString();

            if (lbx_Bands != null)
            {
                lbx_Bands.ItemsSource = null;
            }
            if (lbx_Albums.ItemsSource != null)
            {
                lbx_Albums.ItemsSource = null;
            }
            if (tblk_Formed.Text != null)
            {
                tblk_Formed.Text = null; ;
            }
            if (tblk_Members.Text != null)
            {
                tblk_Members.Text = null; ;
            }

            DisplayList.Clear();


            switch(SelectedGenre)
            {
                case "All":
                    for (int i = 0; i < BandList.Count; i++)
                    {
                        DisplayList.Add(BandList[i]);
                    }
                    break;

                case "Rock":
                    foreach (Band band in BandList)
                    {
                        if(band is RockBand)
                        {
                            DisplayList.Add(band);
                        }
                    }
                    break;

                case "Pop":
                    foreach (Band band in BandList)
                    {
                        if (band is PopBand)
                        {
                            DisplayList.Add(band);
                        }
                    }
                    break;

                case "Indie":
                    foreach (Band band in BandList)
                    {
                        if (band is IndieBand)
                        {
                            DisplayList.Add(band);
                        }
                    }
                    break;
            }

            DisplayBands();
        }
    }
}

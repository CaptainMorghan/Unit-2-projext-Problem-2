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

namespace Unit_2_problem_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFishCombo_Click(object sender, RoutedEventArgs e)
        {//declair variables
            int Trout;
            int.TryParse(txtTrout.Text, out Trout);
            int Pike;
            int.TryParse(txtPike.Text, out Pike);
            int Pickerel;
            int.TryParse(txtPickerel.Text, out Pickerel);
            int Limit;
            int.TryParse(txtLimit.Text, out Limit);
            int Total;
            int TroutValue;
            int PikeValue;
            int PickerelValue;
            TroutValue = Trout * 5;
            PikeValue = Pike * 2;
            PickerelValue = Pickerel * 7;
            //Multiply number of fish given from input by the fishes value

            



            if (TroutValue + PikeValue + PickerelValue <= Limit)
            {
                lblTrout.Content = Trout.ToString() + " Trout";
                lblPike.Content = Pike.ToString() + " Pike";
                lblPikerel.Content = Pickerel.ToString() + " Pickerel";

            }
            else
            {
                lblOutput.Content = "too many fish";
                    }

        

           
           

        }
    }
}

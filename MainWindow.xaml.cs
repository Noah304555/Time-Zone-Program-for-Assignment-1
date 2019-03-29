/* Noah Irving
 *  3/28/2019
 *  A program that finds time zones
 */ 





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

namespace Progam_2_for_assignment_1
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

        private void BtnTime_Click(object sender, RoutedEventArgs e)
        {
            /* Declairing variables for the different Areas*/
            string TextEntered = txtInput.Text;
            int Ottawa = 0;
            int.TryParse(txtInput.Text, out Ottawa);

            int Victoria = Ottawa - 300;
            int Edmonton =  Ottawa - 200;
            int Winnipeg =  Ottawa - 100;
            int Toronto = Ottawa;
            int Halifax = Ottawa + 100;
            int StJohns = Ottawa + 130;

            /* If statements to convert the time zones and for entered times*/
            if (Victoria % 100 > 59) Victoria = Victoria - 60 + 100;
            if (Victoria <= 0)
            {
                Victoria += 2400;
            }
            if (Edmonton % 100 > 59) Edmonton = Edmonton - 60 + 100;
            if (Edmonton <= 0) 
            {
                Edmonton += 2400;
            }
            if (Winnipeg % 100 > 59) Winnipeg = Winnipeg - 60 + 100;
            if (Winnipeg <= 0)
            {
                Winnipeg += 2400;
            }
            if (Toronto % 100 > 59) Toronto = Toronto - 60 + 100;
            if (Toronto <= 0)
            {
                Toronto += 2400;
            }
            if (Halifax % 100 > 59) Halifax = Halifax - 60 + 100;
            if (Halifax >= 2400)
            {
                Halifax -= 2400;
            }
            if (StJohns % 100 > 59) StJohns = StJohns - 60 + 100;
            if (StJohns >= 2400)
            {
                StJohns -= 2400;
            }

            /* Entered text will show up in the label*/
            lblOutput.Content += Ottawa + " In Ottawa" + "\r" + "\n";
            lblOutput.Content += Victoria + " In Victoria" + "\r" + "\n";
            lblOutput.Content += Edmonton + " In Edmonton" + "\r" + "\n";
            lblOutput.Content += Winnipeg + " In Winnipeg" + "\r" + "\n";
            lblOutput.Content += Toronto + " In Toronto" + "\r" + "\n";
            lblOutput.Content += Halifax + " In Halifax" + "\r" + "\n";
            lblOutput.Content += StJohns + " In St. John's" + "\r" + "\n";
          


        }
    }
}

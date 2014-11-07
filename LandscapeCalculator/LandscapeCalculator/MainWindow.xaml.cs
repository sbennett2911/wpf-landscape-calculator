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

namespace LandscapeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblDate.Content = DateTime.Now.ToShortDateString();

            //Pool Tab
            txtPoolVolume.Background = Brushes.LightGray;
        }

        /*Pool calculator button handlers.*/
        private void btnPoolCalc_Click(object sender, RoutedEventArgs e)
        {
            double length = 0.0;
            double width = 0.0;
            double depth = 0.0;
            double volume = 0.0;
            string errMsg = "Invalid input!!  Please enter a positive number.";
            string clrErrMsg = "";
            bool inputValid = true;

            //validate input for length text box. If text fails to convert to double display error message.
            try
            {
                length = Convert.ToDouble(txtPoolLength.Text);
            }
            catch
            {
                txtPoolLength.Text = "0";
                inputValid = false;
            }

            //validate input for width text box.  If text fails to convert to double display error message.
            try
            {
                width = Convert.ToDouble(txtPoolWidth.Text);
            }
            catch
            {
                txtPoolWidth.Text = "0";
                inputValid = false;
            }

            //validate input for depth text box.  If text fails to convert to double display error message.
            try
            {
                depth = Convert.ToDouble(txtPoolDepth.Text);
            }
            catch
            {
                txtPoolDepth.Text = "0";
                inputValid = false;
            }

            //Test if input is valid to set lblPoolErrorMsg appropriately.
            if (!inputValid)
            {
                lblPoolErrorMsg.Content = errMsg;
                lblPoolErrorMsg.Foreground = Brushes.Red;
            }
            else
            {
                lblPoolErrorMsg.Content = clrErrMsg;
            }

            //calculate volume
            volume = length * width * depth;
            txtPoolVolume.Text = volume.ToString();

        }

        private void btnPoolClear_Click(object sender, RoutedEventArgs e)
        {
            txtPoolLength.Text = "0";
            txtPoolWidth.Text = "0";
            txtPoolDepth.Text = "0";
            txtPoolVolume.Text = "";
        }

    }
}

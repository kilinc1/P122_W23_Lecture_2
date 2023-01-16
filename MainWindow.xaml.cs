using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace P122_W23_Lecture_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Equivilant of our Main
        public MainWindow()
        {
            InitializeComponent(); // Don't Delete

   


        } // Ma
        // Add Button Event
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lblAddSubtract.Content = "+";

            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            double val1, val2 = 0;

            bool val1IsANumber = double.TryParse(value1, out val1);
            bool val2IsANumber = double.TryParse(value2, out val2);

            if(val1IsANumber && val2IsANumber)
            {
                double btnadd = val1 + val2;
                txtValueResult.Text = btnadd.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }



            
            
            //MessageBox.Show(btnadd.ToString());
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            lblAddSubtract.Content = "-";

            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            int valText = int.Parse(txtValue1.Text);

            double val1, val2 = 0;

            bool val1IsANumber = double.TryParse(value1, out val1);
            bool val2IsANumber = double.TryParse(value2, out val2);

            if (val1IsANumber && val2IsANumber)
            {
                double btnadd = val1 - val2;
                txtValueResult.Text = btnadd.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }


        // -------------------------------------------------------------------
        // Provided Code
        private void btnLecture_Result_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtValueResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnmultiply_Click(object sender, RoutedEventArgs e)
        {
            
            string vl1 = txtdata1.Text;
            string vl2 = txtdata2.Text;

            int v1=int.Parse(vl1);
            int v2 = int.Parse(vl2);
            int val3= v1 * v2;
            
            txtdata3.Text= val3.ToString();
            lbmultidivide.Content = "*";
        }

        private void btndivide_Click(object sender, RoutedEventArgs e)
        {
            string vl1 = txtdata1.Text;
            string vl2 = txtdata2.Text;

            int v1 = int.Parse(vl1);
            int v2 = int.Parse(vl2);
            float val3 = v1 / v2;

            txtdata3.Text = val3.ToString();
            lbmultidivide.Content = "/";
        }

        private void btnave_Click(object sender, RoutedEventArgs e)
        {

            string b1 = txtdata3.Text;
            string b2 = txtValueResult.Text;
            int a1=int.Parse(b1);
            int a2=int.Parse(b2);
            int totalval = a1+a2;
            float avetotal = totalval / 2;
            txtaor.Text = avetotal.ToString();
        }
    }
}

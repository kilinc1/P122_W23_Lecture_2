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

   


        } // MainWindow()

        // Click Event
        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            // Event based
            // Change the text of our text box when our app runs

            //txtFirstName.Text = "Hi Everyone"; // Set the text

            // Get the text
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            // Message Box
            MessageBox.Show(firstName + " " + lastName);

        } // btnDisplayInfo_Click


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

   
    }
}

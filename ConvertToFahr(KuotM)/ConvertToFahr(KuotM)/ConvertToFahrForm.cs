/*
 * Created by: Kuot Mariak
 * Created on: 14-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Temperature Converter
 * ConvertToFahr
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToFahr_KuotM_
{

    public partial class frmConvertToFahr : Form
    {
        public frmConvertToFahr()
        {
            InitializeComponent();
        }

        public void TempConvert(double Celsius)
        {
            // Declare the variable
            double Fahrenheit;
            // Convert celsius to fahrenheit
            Fahrenheit = 9 / (double) (5) * Celsius + 32;
            // Displays the message box
            MessageBox.Show(Celsius + "°C (Celsius) is equal to" + Fahrenheit + "°F(Fahrenheit)");

        }
        

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double userCelsius;

            // Convert the user's celsius from string to double and assigning them
            userCelsius = Convert.ToDouble(txtCelsius.Text);

            // Call the TempConvert function to convert user celsius to fahrenheit passing the userCelsius variable as an argument
            this.TempConvert(userCelsius);
            
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

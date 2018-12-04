/*
 * Created by: Kuot Mariak
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * Volume of a Cylinder
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

namespace VolumeCylinder_KuotM_
{
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        private double CalculateVolume(double radius, double height)
        {
            // This declares local variable
            double Volume;

            // This calculates the volume 
            Volume = Math.PI * Math.Pow(radius, 2) * height;

            // This displays the volume in a message box
            MessageBox.Show("The volume is: " + Volume + " cubic units");

            // This returns the volume as a double
            return Volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This declares local variables
            double userRadius, userHeight;

            // This converts the text box to a double and assigns it to given variables
            userRadius = Convert.ToDouble(txtRadius.Text);
            userHeight = Convert.ToDouble(txtHeight.Text);

            // This calls the CalculateVolume function
            this.CalculateVolume(userRadius, userHeight);

        }
    }
}

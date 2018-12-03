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
            double Volume;
            Volume = Math.PI * Math.Pow(radius, 2) * height;
            return Volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}

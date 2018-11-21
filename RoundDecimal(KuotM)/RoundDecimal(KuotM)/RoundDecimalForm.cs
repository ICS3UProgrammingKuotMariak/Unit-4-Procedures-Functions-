/*
 * Created by: Kuot Mariak
 * Created on: 19-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * Round Decimal
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

namespace RoundDecimal_KuotM_
{
    public partial class frmRoundDecimal : Form
    {
        public frmRoundDecimal()
        {
            InitializeComponent();
        }

        public void RoundDecimal(ref double roundedNum, int numDecimal)
        {
            // This moves the decimal place
            roundedNum = roundedNum * Math.Pow(10, numDecimal);

            // This adds 0.5
            roundedNum = roundedNum + 0.5;

            // This gets rid of the decimal
            roundedNum = Math.Truncate(roundedNum);

            // This moves the decimal place back
            roundedNum = roundedNum / Math.Pow(10, numDecimal);
        }


        private void btnRound_Click(object sender, EventArgs e)
        {
            // This declares local variables
            double userNum;
            int userDecimal;
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;

            // This assigns the min and max values 
            nudDecimal.Minimum = MIN_NUM;
            nudDecimal.Maximum = MAX_NUM;

            // This converts
            userNum = Convert.ToDouble(txtUserNum.Text);
            userDecimal = Convert.ToInt32(nudDecimal.Value);

            // This calls the procedure
            this.RoundDecimal(ref userNum, userDecimal);

            // This displays in a message box
            MessageBox.Show("Your number rounded is " + userNum);
            
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

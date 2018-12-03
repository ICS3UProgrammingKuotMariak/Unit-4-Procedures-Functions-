/*
 * Created by: Kuot Mariak
 * Created on: 21-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * Percentage
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

namespace Percentage_KuotM_
{
    public partial class frmPercentage : Form
    {
        public frmPercentage()
        {
            InitializeComponent();
        }

        // Function: ConvertToPercent
        // Input: String Grade
        // Output; int
        // This function converts a String grade to it's equilvalent int percentage
        private int ConvertToPercent(String Grade)
        {
            int percentage;

            // Complicated if else statement 
            switch (Grade)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;

                default:
                    percentage = 0;
                    break;
            }
            // This displays the grade and percentage in a message box
            MessageBox.Show("Level " + Grade + " is equal to " + percentage + "%");
            return percentage;
            
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            // This declares and assigns local variables
            String userGrade;
            userGrade = txtGrade.Text;
            
            // This checks what is entered in the txt box and calls the ConvertToPercent procedure accordingly
            if (userGrade == "")
            {
                MessageBox.Show("Enter a valid grade");
            }
            else if(userGrade.Contains("+"))
            {
                this.ConvertToPercent(userGrade);
            }
            else if (userGrade.Contains("-"))
            {
                this.ConvertToPercent(userGrade);
            }
            else if (userGrade.Any(char.IsDigit))
            {
                this.ConvertToPercent(userGrade);
            }
            else
            {
                MessageBox.Show("Enter a valid grade");
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

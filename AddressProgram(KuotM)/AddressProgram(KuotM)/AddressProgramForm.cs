/*
 * Created by: Kuot Mariak
 * Created on: 20-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * Address Program
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

namespace AddressProgram_KuotM_
{
    public partial class frmAddressProgram : Form
    {
        public frmAddressProgram()
        {
            InitializeComponent();
        }

        // Procedure: PrintAddress
        // Input: string address, string city, string postalCode, string Province
        // Output: void
        // This procedure displays a message box with 4 parameters: address, city, postalCode, province
        public void PrintAddress(String address, String city, String postalCode, String province)
        {
            MessageBox.Show("Your full address is: " + address + ", "+ city + " " + province + ", " + postalCode);
        }

        // Procedure: PrintAddress
        // Input: string address, string city, string postalCode, string Province
        // Output: void
        // This procedure displays a message box with 4 parameters: address, city, postalCode, aptNum, province
        public void PrintAddress(String address, String city, String postalCode, String aptNum, String province)
        {
            MessageBox.Show("Your full address is: "+ address + ", #" + aptNum+", " + city + " " + province + ", "+ postalCode);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // This declares local variables
            String userAddress, userCity, userPostalCode, userAptNum, userProvince;

            // Gets the address from the text boxes
            userAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            userPostalCode = this.txtPostalCode.Text;
            userAptNum = this.txtAptNum.Text;
            userProvince = this.txtProvince.Text;

            // This checks if the user has input the address correctly
            if (userAddress == "")
            {
                MessageBox.Show("Please enter your address!");
            }
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your city!");
            }
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your postal code!");
            }
            else if (userAptNum == "")
            {
                this.PrintAddress(userAddress, userCity, userPostalCode, userProvince);
            }
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your Province");
            }
            else
            {
                this.PrintAddress(userAddress, userCity, userPostalCode, userAptNum, userProvince);
            }
        }

        private void frmAddressProgram_Load(object sender, EventArgs e)
        {

        }
    }
}

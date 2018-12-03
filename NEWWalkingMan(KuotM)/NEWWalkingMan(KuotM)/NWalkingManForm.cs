/*
 * Created by: Kuot Mariak
 * Created on: 23-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - New Walking Man
 * New Walking Man
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
using System.Threading;

namespace NEWWalkingMan_KuotM_
{
    public partial class NWalkingManForm : Form
    {
        public NWalkingManForm()
        {
            InitializeComponent();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // Dynamically generates a new picture box and a new point at the given location (x,y)
            PictureBox tempPicMan = new PictureBox();
            Point pointpic = new System.Drawing.Point(x, y);

            // Set the location of the picture box
            tempPicMan.Location = pointpic;

            // Assigns the image to the picture box
            tempPicMan.Image = Properties.Resources.walk1;

            // Stretch the image to the picBox
            tempPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // Make the picture box width and height to be the same as the image
            tempPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // Add the event listener
            tempPicMan.Click += new System.EventHandler(PictureBox_Click);

            // Add the picture box to the form
            this.Controls.Add(tempPicMan);
        }

        private void GeneratePictureBoxes()
        {
            GeneratePictureBox(25, 57);
            GeneratePictureBox(477, 57);
            GeneratePictureBox(25, 362);
            GeneratePictureBox(477, 362);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Cast the sender object into a picture box
            PictureBox tempPicMan = (PictureBox)sender;

            // Write a message in the console to check which picture box was clicked
            Console.WriteLine("Picture box (" + tempPicMan.Location.X + ", " + tempPicMan.Location.Y + ") was clicked.");

            // Declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;


            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tempPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tempPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tempPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tempPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tempPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tempPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tempPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tempPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tempPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tempPicMan.Image = Properties.Resources.walk10;
                }

                // This increments the counter
                pictureFrameCounter++;

                // This refreshes the form
                this.Refresh();

                // This pauses the frames
                Thread.Sleep(100);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            // This shows the instructions
            lblClickOnPic.Show();

            // This calls the Generate picturboxes procedure
            this.GeneratePictureBoxes();
        }

    }
}

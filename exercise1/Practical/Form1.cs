using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320;
        const int DISPLAY_HEIGHT = 460;

        //NOTE: If the display looks wrong in your screen resolution, 
        //please check that the picture box is 400 x 730 pixels in size
        //and adjust the form to be slightly larger than that.
        //Stupid Visual Studio changes the form size based on your screen resolution - gah!

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws an image of a phone in the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = Properties.Resources.iPhone;

            
        }

        private Color GetRandomColor(int number)
        {
            if (number >= 1 && number <= 9)
            {
                return Color.Blue;
            }
            else if (number >= 10 && number <= 19)
            {
                return Color.Orange;
            }
            else if (number >= 20 && number <= 29)
            {
                return Color.Green;
            }
            else if (number >= 30 && number <= 39)
            {
                return Color.Red;
            }
            else
            {
                return Color.Purple;
            }
        }

        private void buttonDrawBalls_Click(object sender, EventArgs e)
        {

            try
            {
                //create graphics and objects
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush br = new SolidBrush(Color.Red);
                //Pen pen1 = new Pen(Color.Orange);

                //convert text from textbox to int
                int num_balls = Convert.ToInt32(textBox1.Text);
                int rows = DISPLAY_HEIGHT/(BALL_SIZE+GAP_SIZE);

                Random rand = new Random();

                if (((BALL_SIZE+GAP_SIZE)*num_balls) < DISPLAY_WIDTH)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < num_balls; j++)
                        {
                            int randomNumber = rand.Next(1, 41);
                            Color randomcolor = GetRandomColor(randomNumber);
                            br.Color = randomcolor;
                            int x = DISPLAY_LEFT + j * (BALL_SIZE + GAP_SIZE);
                            int y = DISPLAY_TOP + i * (BALL_SIZE + GAP_SIZE);
                            paper.FillEllipse(br, x, y, BALL_SIZE, BALL_SIZE);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Number of balls per row exceed the screen size");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
    }
}

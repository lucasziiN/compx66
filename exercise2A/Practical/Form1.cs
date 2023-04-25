using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //The number of squares in each row
        const int NUM_COLUMNS = 10;
        //The minimum number of rows to draw
        const int MIN_ROWS = 5;
        //The maximum number of rows to draw
        const int MAX_ROWS = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxBoard.Refresh();
                Graphics paper = pictureBoxBoard.CreateGraphics();
                SolidBrush brush_pink = new SolidBrush(Color.LightPink);
                SolidBrush brush_blue = new SolidBrush(Color.LightBlue);
                SolidBrush brush_green = new SolidBrush(Color.Green);
                Pen pen = new Pen(Color.Black, 3);

                float square_width = pictureBoxBoard.Width/NUM_COLUMNS;
                float square_height = pictureBoxBoard.Height/NUM_COLUMNS;
                float x = 0;
                float y = 0;

                int numRows = int.Parse(textBoxRows.Text);


                if (numRows >= MIN_ROWS && numRows <= MAX_ROWS)
                {
                    for (int i = 0; i < numRows; i++)
                    {
                        for (int j = 0; j < NUM_COLUMNS; j++)
                        {
                            if (j == 0 || j == 9)
                            {
                                paper.FillRectangle(brush_pink,x, y , square_width, square_height);
                                paper.DrawRectangle(pen, x, y, square_width, square_height);
                            }
                            else if (j == 4 || j == 5)
                            {
                                paper.FillRectangle(brush_blue,x,y,square_width, square_height);
                                paper.DrawRectangle(pen, x, y, square_width, square_height);
                            }
                            else
                            {
                                paper.FillRectangle(brush_green, x, y, square_width, square_height);
                                paper.DrawRectangle(pen, x, y, square_width, square_height);
                            }
                            x += square_width;
                        }
                        y += square_height;
                        x = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number of rows.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxBoard.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Threading;

namespace ICA6_hamzaSaid
{
    public partial class Form1 : Form
    {
        private List<Ball> ballList = new List<Ball>();
        private int radius = -50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _rbColor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            int addedCounter = 0;
            int discardCounter = 0;
            Ball temp;


            //try ~1000 times to add 25 balls
            while (addedCounter < 25 && discardCounter < 1000)
            {
                temp = new Ball(radius);

                if (ballList.IndexOf(temp) >= 0)
                {
                    discardCounter++;
                }
                else
                {
                    ballList.Add(temp);
                    addedCounter++;
                }
            }
            //draw the balls
            Ball.Load = true;
            for (int i = 0; i < ballList.Count; i++)
            {
                ballList[i].ShowBall();
            }
            Ball.Load = false;

            //show the user our effort
            _pbDiscarded.Value = discardCounter;
            Text = $"Added {addedCounter} unique balls, with {discardCounter} discarded balls";

        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            _blocks.Clear();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            lblSize.Text = "Size: " + tbSize.Value.ToString();
        }

        private void grbSortType_Enter(object sender, EventArgs e)
        {

        }
    }

}

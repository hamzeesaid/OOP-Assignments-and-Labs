//*****************************************************************************
//Assignment         : CMPE2300 ica3

//Author             : Hamza Said

//Instructor         : Shane 

//Submission Code    : 1202_2300_A03

//Created Jan 29 2021
//*****************************************************************************
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

namespace hamzasaid_ica3
{
    public partial class Form1 : Form
    {
        //list of balls currently in the drawer
        List<Ball> _balls = new List<Ball>();

        
        object key = new object();


        public Form1()
        {
            InitializeComponent();

            _tbrRadius.Scroll += _tbrRadius_Scroll;
            KeyDown += Form1_KeyDown;
        }


        /// <summary>
        /// Steal focus from the drawer and accept keyevents.
        /// start the thread that will render the balls in the drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

           
            KeyPreview = true;
            Text = "Size: " + _tbrRadius.Value.ToString();
            Thread irender = new Thread(new ThreadStart(RenderBalls));
            irender.IsBackground = true;
            irender.Start();

        }


        /// <summary>
        /// B key is pressed , 5 new balls are added to the list
        /// if the user presses the escape key, the list is cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lock (key)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        for (int i = 0; i < 5; ++i)
                            _balls.Add(new Ball());
                        break;
                    case Keys.Escape:
                        _balls.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// form title bar will show the value of the trackbar 
        /// Set the value of the radius of the ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _tbrRadius_Scroll(object sender, EventArgs e)
        {
            Ball.Radius = _tbrRadius.Value;
            Text = "Size: " + _tbrRadius.Value.ToString();
        }

        private void RenderBalls()
        {
            while (true)
            {

                //clear the drawer
                Ball.Loading = true;

                lock (key)
                {
                    //move balls to their new location
                    foreach (Ball b in _balls)
                    {
                        b.MoveBall();
                        b.ShowBall();
                    }
                }


                //render the drawer using the ball property
                Ball.Loading = false;

                //pause the thread briefly 
                Thread.Sleep(25);
            }
        }
    }
}

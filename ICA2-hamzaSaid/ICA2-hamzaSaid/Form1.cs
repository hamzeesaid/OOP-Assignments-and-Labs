﻿//////////////////////////////////////////////////
//Project:     ICA 02
//Progeam:     Form1.cs
//Author:      Hamza Said
//Date:        01/26/2021
//Submission Code : 1202_2300_A02

//This program will create moving balls inside the GDIDrawer. Each ball will
//be an instance of the "Ball" class, and properties will be used to determine 
//specifics about each ball including its velocity, color, and size

//////////////////////////////////////////////////
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

namespace ICA2_hamzaSaid
{
    public partial class Form1 : Form
    {

        //static instance of the GDIDrawer
        static CDrawer _canvas;

        //collection of balls that have been added to the drawer
        List<Ball> _balls = new List<Ball>();



        public Form1()
        {
            InitializeComponent();
            _canvas = new CDrawer(bContinuousUpdate: false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Location = new Point(0, 0);
            _canvas.Position = new Point(Location.X + Width, Location.Y);
        }


        /// <summary>
        /// Gets the last left and right clicks from the user, adds new balls to the collection, 
        /// clears the list if required, renders the drawer, and updates the title of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_canvas.GetLastMouseLeftClick(out Point point))
            {
                _balls.Add(new Ball(point));
            }

            //remove all elements from the list if right click
            if (_canvas.GetLastMouseRightClick(out point))
                _balls.Clear();

            //clear the drawer
            _canvas.Clear();

            //move all all the balls to their new location within the drawer
            foreach (Ball b in _balls)
            {
                b.MoveBall(_canvas);
                b.ShowBall(_canvas);

                //set the data for the last ball to be the text on the form
                Text = _balls[_balls.Count - 1].ToString();
            }

            _canvas.Render();
        }

        /// <summary>
        /// Changed the opacity of the balls based on the value of the Opacity trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _tbrOpacity_Scroll(object sender, EventArgs e)
        {
            if (_cbAll.Checked)
            {
                foreach (Ball b in _balls)
                    b.Opacity = _tbrOpacity.Value;
            }
            else if (_balls.Count > 0)
                _balls[_balls.Count - 1].Opacity = _tbrOpacity.Value;

            _lblOpacity.Text = "Opacity: " + _tbrOpacity.Value;
        }


        /// <summary>
        /// Change the X Velocity based on the value of the X trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void _tbrXVelocity_Scroll(object sender, EventArgs e)
        {
            if (_cbAll.Checked)
            {
                foreach (Ball b in _balls)
                    b.XVelocity = _tbrXVelocity.Value;
            }
            else if (_balls.Count > 0)
                _balls[_balls.Count - 1].XVelocity = _tbrXVelocity.Value;

            _lblXVelocity.Text = "X: " + _tbrXVelocity.Value;
        }



        /// <summary>
        /// Change the Y Velocity based on the value of the Y trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _tbrYVelocity_Scroll(object sender, EventArgs e)
        {
            if (_cbAll.Checked)
            {
                foreach (Ball b in _balls)
                    b.YVelocity = _tbrYVelocity.Value;
            }
            else if (_balls.Count > 0)
                _balls[_balls.Count - 1].YVelocity = _tbrYVelocity.Value;



            _lblYVelocity.Text = "Y: " + _tbrYVelocity.Value;
        }

    }
}

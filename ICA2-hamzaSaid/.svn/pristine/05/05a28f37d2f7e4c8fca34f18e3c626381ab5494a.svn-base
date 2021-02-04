
//////////////////////////////////////////////////
//Project:     ICA 02
//Progeam:     Ball.cs
//Author:      Hamza Said
//Date:        01/26/2021
//Submission Code : 1202_2300_A02

//This program will create moving balls inside the GDIDrawer. Each ball will
//be an instance of the "Ball" class, and properties will be used to determine 
//specifics about each ball including its velocity, color, and size

//////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA2_hamzaSaid
{
    class Ball
    {
        static Random rand = new Random();
        Point _bCenter = new Point();

        public Point Location
        {
            get
            {
                return _bCenter;
            }
        }

        //X and Y velocity of the ball
        int _iXVelocity;
        int _iYVelocity;

        //allow public access to set the X Velocity only
        public int XVelocity
        {
            set
            {
                _iXVelocity = value;
            }
        }

        //allow public access to set the Y velocity but restrict the range to -10 to +10
        public int YVelocity
        {
            set
            {
                if (value < 0)
                    _iYVelocity = Math.Max(value, -10);
                else
                    _iYVelocity = Math.Min(value, 10);
            }
        }

        //color of the ball
        Color _ballColor;

        //allows public access to set the opacity only
        public int Opacity { private get; set; }

        //ball radius available publicly as read only
        public readonly int _ballRadius;

        /// <summary>
        /// construct a ball and render it at the point provided, with some default settings

        /// </summary>
        /// <param name="bCenter"></param>
        public Ball(Point bCenter)
        {
            _ballColor = RandColor.GetColor();
            _ballRadius = 40;
            _iXVelocity = rand.Next((-10),(10));
            _iYVelocity = rand.Next((-10),10);
             Opacity = 128;
            _bCenter = bCenter;
            
        }

        /// <summary>
        /// moves a balls location based on its velocity properties,
        /// will bounce off walls if movement takes it out of the bounds of the drawer window
        /// </summary>
        /// <param name="canvas">the drawer window that will render the ball</param>
        public void MoveBall(CDrawer canvas)
        {

            //move point to new location
            _bCenter.X += _iXVelocity;
            _bCenter.Y += _iYVelocity;

            //check to see if the ball will go out of the window, if so negate the velocity
            if (_bCenter.X + _ballRadius  >=canvas.ScaledWidth || (_bCenter.X - _ballRadius)  <= 0)
                _iXVelocity = -_iXVelocity;
            if (_bCenter.Y + _ballRadius  >= canvas.ScaledHeight || (_bCenter.Y - _ballRadius)  <= 0)
                _iYVelocity = -_iYVelocity;

            

            //make sure that the initial location of the ball is in the 
            _bCenter.X = Math.Max(_bCenter.X, _ballRadius);
            _bCenter.Y = Math.Max(_bCenter.Y, _ballRadius);
            _bCenter.X = Math.Min(_bCenter.X, canvas.ScaledWidth - _ballRadius-1);
            _bCenter.Y = Math.Min(_bCenter.Y, canvas.ScaledHeight - _ballRadius-1);

        }

        /// <summary>
        /// draws a single ball in the drawer window using its own properties
        /// </summary>
        /// <param name="canvas">the drawer window that will render the ball</param>
        public void ShowBall(CDrawer canvas)
        {

            //generate the ball color from the random color and the opacity
            Color col = Color.FromArgb(Opacity, _ballColor.R, _ballColor.G, _ballColor.B);

            //add the ball to the drawer
            canvas.AddCenteredEllipse(_bCenter, _ballRadius * 2, _ballRadius * 2, col);

        }

        public override string ToString()
        {
            return "[" + _bCenter.ToString() + "] - Vel: " + _iXVelocity + "," + _iYVelocity + ", Opacity: " + Opacity;
        }
    }
}

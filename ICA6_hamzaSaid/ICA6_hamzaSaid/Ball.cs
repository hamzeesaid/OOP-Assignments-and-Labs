//*****************************************************************************
//Assignment         : CMPE2300 ica4

//Author             : Hamza Said

//Instructor         : Shane 

//Submission Code    : 1202_2300_A06

//*****************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace ICA6_hamzaSaid
{
    class Ball
    {

        static private CDrawer canvas;
        static private Random randNum;

        private float _radius;
        private float Radius
        {
            //Positive & !0
            set
            {
                if (value == 0)
                    _radius = 1;
                else
                    _radius = Math.Abs(value);
            }
        }

        private Color _colour;
        private PointF _center;

        //Static constuctor
        static Ball()
        {
            randNum = new Random();
            canvas = new CDrawer(800, 600, false);
            canvas.BBColour = Color.White;
        }
        //Instance constructor
        public Ball(int inRadius)
        {
            Radius = inRadius;
            _colour = RandColor.GetColor();
            _center = new PointF(randNum.Next((int)Math.Floor(_radius), canvas.ScaledWidth - (int)Math.Floor(_radius)),
                                 randNum.Next((int)Math.Floor(_radius), canvas.ScaledHeight - (int)Math.Floor(_radius)));

        }

        //Static methods
        static public bool Load
        {
            set
            {
                if (value)
                    canvas.Clear();
                else
                    canvas.Render();
            }
        }
        //Instance methods
        public void ShowBall()
        {
            canvas.AddCenteredEllipse((int)_center.X, (int)_center.Y, (int)(_radius * 2), (int)(_radius * 2), _colour);
        }

        private float GetDistance(Ball other)
        {
            return (float)Math.Abs(Math.Sqrt(Math.Pow((other._center.X - this._center.X), 2) + Math.Pow(other._center.Y - this._center.Y, 2))); 
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ball)) return false; 

            Ball input = obj as Ball; 
            float distance = this.GetDistance(input); 

            return distance <= this._radius + input._radius; 
        }

        public override int GetHashCode()
        {
            return 1; 
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Ball)) throw new ArgumentException("Not a valid ball, or null");

            Ball temp = (Ball)obj;
            //Check if our radius is higher than their radius
            return -1 * this._radius.CompareTo(temp._radius);
        }

        static public int CompareByDistance(Ball arg1, Ball arg2)
        {
            Ball origin = new Ball(1);
            origin._center.X = 0;
            origin._center.Y = 0;

            return -1 * arg1.GetDistance(origin).CompareTo(arg2.GetDistance(origin));
        }

        static public int CompareByColour(Ball arg1, Ball arg2)
        {
            return arg2._colour.ToArgb().CompareTo(arg1._colour.ToArgb());
        }

        static public bool tooBig(Ball arg1)
        {
            return arg1._radius > 20;
        }
    }



}

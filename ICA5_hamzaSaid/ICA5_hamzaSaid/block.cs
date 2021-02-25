using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA5_hamzaSaid
{
    class block 
    {
        private static CDrawer _canvas = new CDrawer();     //shared instance of the drawer window
        private static Random _rng = new Random();          //shared random number generator
        private int _iSize;                                 //size of this block
        private Color _cBlockColor;                         //color of this block
        private Rectangle _rBlock;                          //coordinates for this block

        public enum ESortType { eSize, eDistance, eColor };



        public int Size
        {
            set
            {
                _iSize = Math.Abs(value);
            }
        }

        public static bool Loading
        {
            set
            {
                if (value)
                    _canvas.Clear();
                else
                    _canvas.Render();

            }
        }


        public static Point CanvasPosition
        {
            set
            {
                _canvas.Position = value;
            }
        }
    }
}

//****************************************************************************
//CMPE2300 - ica07 Predi-Bars

//Hamza Said

//Submission Code: 1202_2300_A07  

//Feb 23 2021

//Modified:
//****************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA7_hamzaSaid
{
    public partial class Form1 : Form
    {
        //List of Bars
        List<Bar> _bars = new List<Bar>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draw Bars On Drawer Widow
        /// checking to make sure that the last bar does not go off the edge of the screen
        /// </summary>
        private void ShowBars()
        {
            Bar.Canvas.Clear();
 
            int iWidth = 0;
            int iHeight = 0;

          
            foreach (Bar b in _bars)
            {
                
                if (iWidth + b.Width > Bar.Canvas.ScaledWidth)
                {
                    iHeight += Bar.Height;
                    iWidth = 0;
                }


                b.ShowBar(new Point(iWidth, iHeight));

                iWidth += b.Width;
            }

            Bar.Canvas.Render();
        }

        /// <summary>
        /// clear the bars . repopulate new bars if sum
        /// of the width of all bar is taking less than 80% of the Drawer window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //clear the list
            _bars.Clear();

            //sum of the widths of the bars 
            int iSum = 0;

            
            while (iSum < 0.8 * (Bar.Canvas.ScaledHeight * Bar.Canvas.ScaledWidth) / Bar.Height)
            {
                Bar barTemp = new Bar();

                if (!(_bars.Contains(barTemp)))
                {
                    _bars.Add(barTemp);
                    iSum += barTemp.Width;
                }

            }

            UpdateTrackbar();

            //display the bars in the drawer
            ShowBars();
        }

        /// <summary>
        /// Sort the list of bars by color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            _bars.Sort();
            ShowBars();
        }

        /// <summary>
        /// check the trackbar valuer and remove all the bars according to the trackbar value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLongerThan_Click(object sender, EventArgs e)

        {
            Text = _bars.RemoveAll((x) =>
            {
                if (x == null) return true;
                return x.Width > tbrWidthMax.Value;
            }).ToString();
            UpdateTrackbar();
            ShowBars();
        }
        /// <summary>
        /// sort the bar list by width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWidth_Click(object sender, EventArgs e)
        {
            _bars.Sort(Bar.CompareWidth);
            ShowBars();
        }

        /// <summary>
        /// Sorting width in descending order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWidthDesc_Click(object sender, EventArgs e)
        {
            _bars.Sort((barTemp1, barTemp2) =>
            {
                
                //if both are null, return 0
                if (barTemp1 == null && barTemp2 == null)
                    return 0;

                //null is less than anything, return accordingly
                if (barTemp1 == null)
                    return -1;
                if (barTemp2 == null)
                    return 1;

                return barTemp2.Width.CompareTo(barTemp1.Width);
            });

            ShowBars();
        }

        /// <summary>
        /// First sorth the list by width
        /// then sort by color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWidthColor_Click(object sender, EventArgs e)
        {
            _bars.Sort(Bar.CompareWidthColor);
            ShowBars();
        }
        /// <summary>
        /// removes all bars from the list that have a color brightness value less than 0.6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBright_Click(object sender, EventArgs e)
        {
            int initialBars = _bars.Count;
            _bars.RemoveAll(Bar.Brightness);
            UpdateTrackbar();
            ShowBars();

            //indicate the number of bars removed
            Text = $"{initialBars - _bars.Count} Bars Removed";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int iHighlightWidth = e.X;

            //set every bar in the list to NOT highlighted
            _bars.ForEach((barTemp) => { barTemp.HighLight = false; });


            //
            _bars.FindAll((barTemp) =>
            {
                return Math.Abs(iHighlightWidth - barTemp.Width) < 10;
            }).ForEach((barTemp) => { barTemp.HighLight = true; });

            ShowBars();
        }

        /// <summary>
        /// Update the trackbar
        /// </summary>
        private void UpdateTrackbar()
        {

            tbrWidthMax.Maximum = _bars.Max((barTemp) => barTemp.Width);

            tbrWidthMax.Minimum = _bars.Min((barTemp) => barTemp.Width);

            tbrWidthMax.Value = (tbrWidthMax.Maximum + tbrWidthMax.Minimum) / 2;

            btnLongerThan.Text = $"Longer than {tbrWidthMax.Value.ToString()}";
        }

        private void tbrWidthMax_Scroll(object sender, EventArgs e)
        {
            btnLongerThan.Text = $"Longer than {tbrWidthMax.Value.ToString()}";
        }
    }
}

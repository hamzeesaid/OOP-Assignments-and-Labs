//***********************************************************************************************************************************
//Project: ICA 01 - Trek lamps
//Author: Hamza Said
//Date: 21/01/2021
//Submission Code : 1202_2300_A01
//***********************************************************************************************************************************
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

namespace ICA1_hamzaSaid
{
    public partial class Form1 : Form

    {
        //Holds a reference to each instance of TrekLamps
        List<TrekLamp> _lamps = new List<TrekLamp>();

        //drawer for rendering TrekLamps with required specifications
        CDrawer _canvas = new CDrawer(900, 500);  
        

        Timer _timer = new Timer();

        
        public Form1()
        {
            InitializeComponent();
            _canvas.Scale = 50;
            _timer.Tick += _timer_Tick;
            _timer.Enabled = true;
        }

        /// <summary>
        /// iterate through the list, incrementing the tick counter for ALL TrekLamp instances and 
        /// rendering appropriate TreckLamp instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Tick(object sender, EventArgs e)
        {
            _canvas.Clear();

            for (int i = 0; i < _lamps.Count; ++i)
            {
                
                _lamps[i].Tick();

                
                _lamps[i].RenderLamp(_canvas, i);
            }

            _canvas.Render();
        }


        /// <summary>
        /// F1 ,F2 , F3 keys will add random and orange color lamps 
        /// ESc key will remove the last lamp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F1)
            {
                _lamps.Add(new TrekLamp());
            }
            else if (e.KeyCode == Keys.F2)
            {
                _lamps.Add(new TrekLamp(180, Color.Orange));
            }
            else if (e.KeyCode == Keys.F3)
            {
                _lamps.Add(new TrekLamp((byte)new Random().Next(60, 221), RandColor.GetColor(), 4));
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (_lamps.Count <= 0)
                {
                    _canvas.AddText("No More Lamps Left", 50 , Color.YellowGreen);
                }

                else
                    _lamps.RemoveAt(_lamps.Count - 1);
               
                
            }
        }
    }
}

﻿//***********************************************************************************************************************************
//Project: ICA 01 - Trek lamps
//Author: Hamza Said
//Date: 21/01/2021
//Submission Code : 1202_2300_A01
//Description: class - TrekLamp, defines an object that will be rendered in the CDrawer as a square of a certain color
//***********************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA1_hamzaSaid
{
    class TrekLamp
    {

        private byte _byToggle;   //the threshold that the lamp will be toggled on at
        private Color _lampColor; //the color that the lamp will be drawn in
        private int _border;      //the thickness of the border of each lamp, defaults to 2
        private byte _byTick;     //a counter that will determine when to toggle the lamp on and off

        static Random rng = new Random(); 

        public TrekLamp(byte byToggle, Color LampColor, int border = 2)
        {
          
            //Set all initial values for class members
            _lampColor = LampColor;
            _byToggle = byToggle;
            _border = border;
            _byTick = (byte)rng.Next();
        }

        /// <summary>
        /// Default constructor, leverages the custom constructor
        /// toggle threshold of 64, rand color, 6 border size
        /// </summary>

        public TrekLamp() : this(64, RandColor.GetColor(), 6)
        {

        }

        public void Tick()
        {
            _byTick += 3; //
        }

        /// <summary>
        /// This method will render the lamp to the drawer window in the appropriate location
        /// </summary>
        /// <param name="drawer"></param>
        /// <param name="iLamp"></param>

        public void RenderLamp(CDrawer drawer, int iLamp)
        {
            int lampPositionX = iLamp % drawer.ScaledWidth;
            int lampPositionY = iLamp / drawer.ScaledWidth;

            if (_byTick > _byToggle) //draw a lamp if it is toggled on
            {
                drawer.AddRectangle(lampPositionX, lampPositionY, 1, 1, _lampColor, _border, Color.Black);
            }

        }
    }
}

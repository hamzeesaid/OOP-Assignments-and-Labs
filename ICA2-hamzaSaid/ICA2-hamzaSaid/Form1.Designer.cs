﻿namespace ICA2_hamzaSaid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._cbAll = new System.Windows.Forms.CheckBox();
            this._lblYVelocity = new System.Windows.Forms.Label();
            this._lblXVelocity = new System.Windows.Forms.Label();
            this._lblOpacity = new System.Windows.Forms.Label();
            this._tbrYVelocity = new System.Windows.Forms.TrackBar();
            this._tbrXVelocity = new System.Windows.Forms.TrackBar();
            this._tbrOpacity = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._tbrYVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbrXVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbrOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // _cbAll
            // 
            this._cbAll.AutoSize = true;
            this._cbAll.Location = new System.Drawing.Point(285, 191);
            this._cbAll.Name = "_cbAll";
            this._cbAll.Size = new System.Drawing.Size(37, 17);
            this._cbAll.TabIndex = 13;
            this._cbAll.Text = "All";
            this._cbAll.UseVisualStyleBackColor = true;
            // 
            // _lblYVelocity
            // 
            this._lblYVelocity.AutoSize = true;
            this._lblYVelocity.Location = new System.Drawing.Point(16, 140);
            this._lblYVelocity.Name = "_lblYVelocity";
            this._lblYVelocity.Size = new System.Drawing.Size(32, 13);
            this._lblYVelocity.TabIndex = 12;
            this._lblYVelocity.Text = "Y: 15";
            // 
            // _lblXVelocity
            // 
            this._lblXVelocity.AutoSize = true;
            this._lblXVelocity.Location = new System.Drawing.Point(16, 94);
            this._lblXVelocity.Name = "_lblXVelocity";
            this._lblXVelocity.Size = new System.Drawing.Size(35, 13);
            this._lblXVelocity.TabIndex = 11;
            this._lblXVelocity.Text = "X: -14";
            // 
            // _lblOpacity
            // 
            this._lblOpacity.AutoSize = true;
            this._lblOpacity.Location = new System.Drawing.Point(16, 43);
            this._lblOpacity.Name = "_lblOpacity";
            this._lblOpacity.Size = new System.Drawing.Size(70, 13);
            this._lblOpacity.TabIndex = 10;
            this._lblOpacity.Text = "Opacity:  169";
            // 
            // _tbrYVelocity
            // 
            this._tbrYVelocity.Location = new System.Drawing.Point(81, 140);
            this._tbrYVelocity.Maximum = 15;
            this._tbrYVelocity.Minimum = -15;
            this._tbrYVelocity.Name = "_tbrYVelocity";
            this._tbrYVelocity.Size = new System.Drawing.Size(453, 45);
            this._tbrYVelocity.TabIndex = 9;
            this._tbrYVelocity.Value = 15;
            this._tbrYVelocity.Scroll += new System.EventHandler(this._tbrYVelocity_Scroll);
            // 
            // _tbrXVelocity
            // 
            this._tbrXVelocity.Location = new System.Drawing.Point(81, 94);
            this._tbrXVelocity.Maximum = 15;
            this._tbrXVelocity.Minimum = -15;
            this._tbrXVelocity.Name = "_tbrXVelocity";
            this._tbrXVelocity.Size = new System.Drawing.Size(453, 45);
            this._tbrXVelocity.TabIndex = 8;
            this._tbrXVelocity.Value = -14;
            this._tbrXVelocity.Scroll += new System.EventHandler(this._tbrXVelocity_Scroll);
            // 
            // _tbrOpacity
            // 
            this._tbrOpacity.Location = new System.Drawing.Point(81, 43);
            this._tbrOpacity.Maximum = 255;
            this._tbrOpacity.Name = "_tbrOpacity";
            this._tbrOpacity.Size = new System.Drawing.Size(453, 45);
            this._tbrOpacity.TabIndex = 7;
            this._tbrOpacity.TickFrequency = 5;
            this._tbrOpacity.Value = 169;
            this._tbrOpacity.Scroll += new System.EventHandler(this._tbrOpacity_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 219);
            this.Controls.Add(this._cbAll);
            this.Controls.Add(this._lblYVelocity);
            this.Controls.Add(this._lblXVelocity);
            this.Controls.Add(this._lblOpacity);
            this.Controls.Add(this._tbrYVelocity);
            this.Controls.Add(this._tbrXVelocity);
            this.Controls.Add(this._tbrOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._tbrYVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbrXVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbrOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _cbAll;
        private System.Windows.Forms.Label _lblYVelocity;
        private System.Windows.Forms.Label _lblXVelocity;
        private System.Windows.Forms.Label _lblOpacity;
        private System.Windows.Forms.TrackBar _tbrYVelocity;
        private System.Windows.Forms.TrackBar _tbrXVelocity;
        private System.Windows.Forms.TrackBar _tbrOpacity;
        private System.Windows.Forms.Timer timer1;
    }
}


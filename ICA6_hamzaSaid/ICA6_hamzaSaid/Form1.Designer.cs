﻿namespace ICA6_hamzaSaid
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
            this._pbDiscarded = new System.Windows.Forms.ProgressBar();
            this.grbSortType = new System.Windows.Forms.GroupBox();
            this._rbColor = new System.Windows.Forms.RadioButton();
            this._rbDistance = new System.Windows.Forms.RadioButton();
            this._rbSize = new System.Windows.Forms.RadioButton();
            this._btnClear = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.grbSortType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // _pbDiscarded
            // 
            this._pbDiscarded.Location = new System.Drawing.Point(25, 215);
            this._pbDiscarded.Maximum = 1000;
            this._pbDiscarded.Name = "_pbDiscarded";
            this._pbDiscarded.Size = new System.Drawing.Size(322, 23);
            this._pbDiscarded.Step = 1;
            this._pbDiscarded.TabIndex = 11;
            // 
            // grbSortType
            // 
            this.grbSortType.Controls.Add(this._rbColor);
            this.grbSortType.Controls.Add(this._rbDistance);
            this.grbSortType.Controls.Add(this._rbSize);
            this.grbSortType.Location = new System.Drawing.Point(25, 151);
            this.grbSortType.Name = "grbSortType";
            this.grbSortType.Size = new System.Drawing.Size(322, 57);
            this.grbSortType.TabIndex = 10;
            this.grbSortType.TabStop = false;
            this.grbSortType.Text = "Sort Type";
            this.grbSortType.Enter += new System.EventHandler(this.grbSortType_Enter);
            // 
            // _rbColor
            // 
            this._rbColor.AutoSize = true;
            this._rbColor.Location = new System.Drawing.Point(266, 19);
            this._rbColor.Name = "_rbColor";
            this._rbColor.Size = new System.Drawing.Size(49, 17);
            this._rbColor.TabIndex = 2;
            this._rbColor.TabStop = true;
            this._rbColor.Text = "Color";
            this._rbColor.UseVisualStyleBackColor = true;
            this._rbColor.CheckedChanged += new System.EventHandler(this._rbColor_CheckedChanged);
            // 
            // _rbDistance
            // 
            this._rbDistance.AutoSize = true;
            this._rbDistance.Location = new System.Drawing.Point(125, 19);
            this._rbDistance.Name = "_rbDistance";
            this._rbDistance.Size = new System.Drawing.Size(67, 17);
            this._rbDistance.TabIndex = 1;
            this._rbDistance.TabStop = true;
            this._rbDistance.Text = "Distance";
            this._rbDistance.UseVisualStyleBackColor = true;
            // 
            // _rbSize
            // 
            this._rbSize.AutoSize = true;
            this._rbSize.Location = new System.Drawing.Point(6, 19);
            this._rbSize.Name = "_rbSize";
            this._rbSize.Size = new System.Drawing.Size(45, 17);
            this._rbSize.TabIndex = 0;
            this._rbSize.TabStop = true;
            this._rbSize.Text = "Size";
            this._rbSize.UseVisualStyleBackColor = true;
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(230, 111);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(117, 33);
            this._btnClear.TabIndex = 9;
            this._btnClear.Text = "Clear";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(25, 111);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(199, 33);
            this._btnAdd.TabIndex = 8;
            this._btnAdd.Text = "Add Exclusive";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(163, 75);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 13);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Size: 0";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(25, 27);
            this.tbSize.Maximum = 50;
            this.tbSize.Minimum = -50;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(322, 45);
            this.tbSize.TabIndex = 6;
            this.tbSize.TickFrequency = 10;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 264);
            this.Controls.Add(this._pbDiscarded);
            this.Controls.Add(this.grbSortType);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSortType.ResumeLayout(false);
            this.grbSortType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _pbDiscarded;
        private System.Windows.Forms.GroupBox grbSortType;
        private System.Windows.Forms.RadioButton _rbColor;
        private System.Windows.Forms.RadioButton _rbDistance;
        private System.Windows.Forms.RadioButton _rbSize;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TrackBar tbSize;
    }
}


namespace hamzasaid_ica3
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
            this._tbrRadius = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this._tbrRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // _tbrRadius
            // 
            this._tbrRadius.Location = new System.Drawing.Point(41, 59);
            this._tbrRadius.Maximum = 100;
            this._tbrRadius.Minimum = -100;
            this._tbrRadius.Name = "_tbrRadius";
            this._tbrRadius.Size = new System.Drawing.Size(326, 45);
            this._tbrRadius.TabIndex = 1;
            this._tbrRadius.TickFrequency = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 162);
            this.Controls.Add(this._tbrRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._tbrRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar _tbrRadius;
    }
}


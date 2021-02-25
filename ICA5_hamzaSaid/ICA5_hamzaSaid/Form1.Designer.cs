namespace ICA5_hamzaSaid
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
            this.pbrDiscarded = new System.Windows.Forms.ProgressBar();
            this.grbSortType = new System.Windows.Forms.GroupBox();
            this.rbnColor = new System.Windows.Forms.RadioButton();
            this.rbnDistance = new System.Windows.Forms.RadioButton();
            this.rbnSize = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbrSize = new System.Windows.Forms.TrackBar();
            this.grbSortType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbrDiscarded
            // 
            this.pbrDiscarded.Location = new System.Drawing.Point(48, 224);
            this.pbrDiscarded.Maximum = 1000;
            this.pbrDiscarded.Name = "pbrDiscarded";
            this.pbrDiscarded.Size = new System.Drawing.Size(322, 23);
            this.pbrDiscarded.Step = 1;
            this.pbrDiscarded.TabIndex = 11;
            // 
            // grbSortType
            // 
            this.grbSortType.Controls.Add(this.rbnColor);
            this.grbSortType.Controls.Add(this.rbnDistance);
            this.grbSortType.Controls.Add(this.rbnSize);
            this.grbSortType.Location = new System.Drawing.Point(48, 160);
            this.grbSortType.Name = "grbSortType";
            this.grbSortType.Size = new System.Drawing.Size(322, 57);
            this.grbSortType.TabIndex = 10;
            this.grbSortType.TabStop = false;
            this.grbSortType.Text = "Sort Type";
            // 
            // rbnColor
            // 
            this.rbnColor.AutoSize = true;
            this.rbnColor.Location = new System.Drawing.Point(266, 19);
            this.rbnColor.Name = "rbnColor";
            this.rbnColor.Size = new System.Drawing.Size(49, 17);
            this.rbnColor.TabIndex = 2;
            this.rbnColor.TabStop = true;
            this.rbnColor.Text = "Color";
            this.rbnColor.UseVisualStyleBackColor = true;
            // 
            // rbnDistance
            // 
            this.rbnDistance.AutoSize = true;
            this.rbnDistance.Location = new System.Drawing.Point(125, 19);
            this.rbnDistance.Name = "rbnDistance";
            this.rbnDistance.Size = new System.Drawing.Size(67, 17);
            this.rbnDistance.TabIndex = 1;
            this.rbnDistance.TabStop = true;
            this.rbnDistance.Text = "Distance";
            this.rbnDistance.UseVisualStyleBackColor = true;
            // 
            // rbnSize
            // 
            this.rbnSize.AutoSize = true;
            this.rbnSize.Location = new System.Drawing.Point(6, 19);
            this.rbnSize.Name = "rbnSize";
            this.rbnSize.Size = new System.Drawing.Size(45, 17);
            this.rbnSize.TabIndex = 0;
            this.rbnSize.TabStop = true;
            this.rbnSize.Text = "Size";
            this.rbnSize.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(253, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Exclusive";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(186, 84);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 13);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Size: 0";
            // 
            // tbrSize
            // 
            this.tbrSize.Location = new System.Drawing.Point(48, 36);
            this.tbrSize.Maximum = 100;
            this.tbrSize.Minimum = -100;
            this.tbrSize.Name = "tbrSize";
            this.tbrSize.Size = new System.Drawing.Size(322, 45);
            this.tbrSize.TabIndex = 6;
            this.tbrSize.TickFrequency = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 290);
            this.Controls.Add(this.pbrDiscarded);
            this.Controls.Add(this.grbSortType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbrSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbSortType.ResumeLayout(false);
            this.grbSortType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrDiscarded;
        private System.Windows.Forms.GroupBox grbSortType;
        private System.Windows.Forms.RadioButton rbnColor;
        private System.Windows.Forms.RadioButton rbnDistance;
        private System.Windows.Forms.RadioButton rbnSize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TrackBar tbrSize;
    }
}


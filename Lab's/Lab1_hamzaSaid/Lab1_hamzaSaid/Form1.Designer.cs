namespace Lab1_hamzaSaid
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.DefragFile = new System.Windows.Forms.Button();
            this.VerifyFile = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(214, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(213, 242);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
           
            // 
            // DefragFile
            // 
            this.DefragFile.Location = new System.Drawing.Point(39, 95);
            this.DefragFile.Name = "DefragFile";
            this.DefragFile.Size = new System.Drawing.Size(170, 23);
            this.DefragFile.TabIndex = 6;
            this.DefragFile.Text = "Defrag FileSystem";
            this.DefragFile.UseVisualStyleBackColor = true;
            this.DefragFile.Click += new System.EventHandler(this.DefragFile_Click);
            // 
            // VerifyFile
            // 
            this.VerifyFile.Location = new System.Drawing.Point(39, 66);
            this.VerifyFile.Name = "VerifyFile";
            this.VerifyFile.Size = new System.Drawing.Size(170, 23);
            this.VerifyFile.TabIndex = 5;
            this.VerifyFile.Text = "Verify FileSystem";
            this.VerifyFile.UseVisualStyleBackColor = true;
            this.VerifyFile.Click += new System.EventHandler(this.VerifyFile_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(39, 37);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(170, 23);
            this.LoadFile.TabIndex = 4;
            this.LoadFile.Text = "Load FileSystem";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 306);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DefragFile);
            this.Controls.Add(this.VerifyFile);
            this.Controls.Add(this.LoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button DefragFile;
        private System.Windows.Forms.Button VerifyFile;
        private System.Windows.Forms.Button LoadFile;
    }
}


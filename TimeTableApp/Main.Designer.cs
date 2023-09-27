namespace TimeTableApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnViewTimeTable1 = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(381, 123);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(174, 57);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnViewTimeTable1
            // 
            this.btnViewTimeTable1.Location = new System.Drawing.Point(381, 209);
            this.btnViewTimeTable1.Name = "btnViewTimeTable1";
            this.btnViewTimeTable1.Size = new System.Drawing.Size(174, 57);
            this.btnViewTimeTable1.TabIndex = 1;
            this.btnViewTimeTable1.Text = "View Time Table";
            this.btnViewTimeTable1.UseVisualStyleBackColor = true;
            this.btnViewTimeTable1.Click += new System.EventHandler(this.btnViewTimeTable1_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(381, 302);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(174, 57);
            this.btnExit1.TabIndex = 3;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 360);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnViewTimeTable1);
            this.Controls.Add(this.btnSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnViewTimeTable1;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
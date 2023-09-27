namespace TimeTableApp
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxLecturer = new System.Windows.Forms.TextBox();
            this.txtBoxRoomNum = new System.Windows.Forms.TextBox();
            this.btnMain2 = new System.Windows.Forms.Button();
            this.btnViewTimeTable2 = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.txtBoxlecturerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAssignedCrs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For A Class";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(78, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(66, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lecturer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(99, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time :";
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(239, 154);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.ReadOnly = true;
            this.txtBoxTime.Size = new System.Drawing.Size(100, 25);
            this.txtBoxTime.TabIndex = 6;
            // 
            // txtBoxLecturer
            // 
            this.txtBoxLecturer.Location = new System.Drawing.Point(239, 219);
            this.txtBoxLecturer.Name = "txtBoxLecturer";
            this.txtBoxLecturer.ReadOnly = true;
            this.txtBoxLecturer.Size = new System.Drawing.Size(100, 25);
            this.txtBoxLecturer.TabIndex = 7;
            // 
            // txtBoxRoomNum
            // 
            this.txtBoxRoomNum.Location = new System.Drawing.Point(239, 279);
            this.txtBoxRoomNum.Name = "txtBoxRoomNum";
            this.txtBoxRoomNum.ReadOnly = true;
            this.txtBoxRoomNum.Size = new System.Drawing.Size(100, 25);
            this.txtBoxRoomNum.TabIndex = 8;
            // 
            // btnMain2
            // 
            this.btnMain2.Location = new System.Drawing.Point(794, 197);
            this.btnMain2.Name = "btnMain2";
            this.btnMain2.Size = new System.Drawing.Size(111, 41);
            this.btnMain2.TabIndex = 9;
            this.btnMain2.Text = "Main";
            this.btnMain2.UseVisualStyleBackColor = true;
            this.btnMain2.Click += new System.EventHandler(this.btnMain2_Click);
            // 
            // btnViewTimeTable2
            // 
            this.btnViewTimeTable2.Location = new System.Drawing.Point(794, 263);
            this.btnViewTimeTable2.Name = "btnViewTimeTable2";
            this.btnViewTimeTable2.Size = new System.Drawing.Size(111, 41);
            this.btnViewTimeTable2.TabIndex = 10;
            this.btnViewTimeTable2.Text = "View Time Table";
            this.btnViewTimeTable2.UseVisualStyleBackColor = true;
            this.btnViewTimeTable2.Click += new System.EventHandler(this.btnViewTimeTable2_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(794, 329);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(111, 41);
            this.btnExit2.TabIndex = 11;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // txtBoxlecturerID
            // 
            this.txtBoxlecturerID.Location = new System.Drawing.Point(642, 107);
            this.txtBoxlecturerID.Name = "txtBoxlecturerID";
            this.txtBoxlecturerID.Size = new System.Drawing.Size(100, 25);
            this.txtBoxlecturerID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(512, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lecturer ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(461, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Assigned Course :";
            // 
            // txtBoxAssignedCrs
            // 
            this.txtBoxAssignedCrs.Location = new System.Drawing.Point(642, 154);
            this.txtBoxAssignedCrs.Name = "txtBoxAssignedCrs";
            this.txtBoxAssignedCrs.Size = new System.Drawing.Size(100, 96);
            this.txtBoxAssignedCrs.TabIndex = 15;
            this.txtBoxAssignedCrs.Text = "";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.txtBoxAssignedCrs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxlecturerID);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnViewTimeTable2);
            this.Controls.Add(this.btnMain2);
            this.Controls.Add(this.txtBoxRoomNum);
            this.Controls.Add(this.txtBoxLecturer);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxLecturer;
        private System.Windows.Forms.TextBox txtBoxRoomNum;
        private System.Windows.Forms.Button btnMain2;
        private System.Windows.Forms.Button btnViewTimeTable2;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.TextBox txtBoxlecturerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBoxAssignedCrs;
    }
}
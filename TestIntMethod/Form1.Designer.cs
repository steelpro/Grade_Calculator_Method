namespace TestIntMethod
{
    partial class Grade
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbxExam1 = new System.Windows.Forms.TextBox();
            this.tbxExam2 = new System.Windows.Forms.TextBox();
            this.tbxAver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.HotPink;
            this.btnCalc.Location = new System.Drawing.Point(12, 107);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(149, 49);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbxExam1
            // 
            this.tbxExam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExam1.Location = new System.Drawing.Point(61, 12);
            this.tbxExam1.Name = "tbxExam1";
            this.tbxExam1.Size = new System.Drawing.Size(100, 20);
            this.tbxExam1.TabIndex = 1;
            // 
            // tbxExam2
            // 
            this.tbxExam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExam2.Location = new System.Drawing.Point(61, 42);
            this.tbxExam2.Name = "tbxExam2";
            this.tbxExam2.Size = new System.Drawing.Size(100, 20);
            this.tbxExam2.TabIndex = 2;
            // 
            // tbxAver
            // 
            this.tbxAver.BackColor = System.Drawing.Color.White;
            this.tbxAver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAver.Enabled = false;
            this.tbxAver.Location = new System.Drawing.Point(61, 69);
            this.tbxAver.Name = "tbxAver";
            this.tbxAver.Size = new System.Drawing.Size(100, 20);
            this.tbxAver.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exam 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(12, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 222);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAver);
            this.Controls.Add(this.tbxExam2);
            this.Controls.Add(this.tbxExam1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Grade";
            this.Text = "Jimmy John\'s Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbxExam1;
        private System.Windows.Forms.TextBox tbxExam2;
        private System.Windows.Forms.TextBox tbxAver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}


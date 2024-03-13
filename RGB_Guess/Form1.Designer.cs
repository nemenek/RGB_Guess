
namespace RGB_Guess
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorPanel = new System.Windows.Forms.Panel();
            this.RedVal = new System.Windows.Forms.NumericUpDown();
            this.GreenVal = new System.Windows.Forms.NumericUpDown();
            this.BlueVal = new System.Windows.Forms.NumericUpDown();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.redSol = new System.Windows.Forms.Label();
            this.greenSol = new System.Windows.Forms.Label();
            this.blueSol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.earnedPoints = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueVal)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(154, 12);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(10);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Padding = new System.Windows.Forms.Padding(10);
            this.colorPanel.Size = new System.Drawing.Size(475, 322);
            this.colorPanel.TabIndex = 0;
            // 
            // RedVal
            // 
            this.RedVal.Location = new System.Drawing.Point(200, 347);
            this.RedVal.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.RedVal.Name = "RedVal";
            this.RedVal.Size = new System.Drawing.Size(120, 23);
            this.RedVal.TabIndex = 1;
            this.RedVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GreenVal
            // 
            this.GreenVal.Location = new System.Drawing.Point(398, 347);
            this.GreenVal.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.GreenVal.Name = "GreenVal";
            this.GreenVal.Size = new System.Drawing.Size(120, 23);
            this.GreenVal.TabIndex = 2;
            this.GreenVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlueVal
            // 
            this.BlueVal.Location = new System.Drawing.Point(589, 347);
            this.BlueVal.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.BlueVal.Name = "BlueVal";
            this.BlueVal.Size = new System.Drawing.Size(120, 23);
            this.BlueVal.TabIndex = 3;
            this.BlueVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.Location = new System.Drawing.Point(411, 393);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(120, 45);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(154, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(337, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(540, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue:";
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Round.Location = new System.Drawing.Point(642, 27);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(46, 30);
            this.Round.TabIndex = 8;
            this.Round.Text = "1/5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(642, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Score:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(717, 151);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(25, 30);
            this.Score.TabIndex = 10;
            this.Score.Text = "0";
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(550, 393);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(114, 45);
            this.Next.TabIndex = 11;
            this.Next.Text = "Next Round";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Solution:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Red:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Green:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blue:";
            // 
            // redSol
            // 
            this.redSol.AutoSize = true;
            this.redSol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redSol.Location = new System.Drawing.Point(74, 165);
            this.redSol.Name = "redSol";
            this.redSol.Size = new System.Drawing.Size(19, 21);
            this.redSol.TabIndex = 16;
            this.redSol.Text = "0";
            // 
            // greenSol
            // 
            this.greenSol.AutoSize = true;
            this.greenSol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greenSol.Location = new System.Drawing.Point(74, 195);
            this.greenSol.Name = "greenSol";
            this.greenSol.Size = new System.Drawing.Size(19, 21);
            this.greenSol.TabIndex = 17;
            this.greenSol.Text = "0";
            // 
            // blueSol
            // 
            this.blueSol.AutoSize = true;
            this.blueSol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blueSol.Location = new System.Drawing.Point(74, 223);
            this.blueSol.Name = "blueSol";
            this.blueSol.Size = new System.Drawing.Size(19, 21);
            this.blueSol.TabIndex = 18;
            this.blueSol.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Earned points:";
            // 
            // earnedPoints
            // 
            this.earnedPoints.AutoSize = true;
            this.earnedPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earnedPoints.Location = new System.Drawing.Point(13, 298);
            this.earnedPoints.Name = "earnedPoints";
            this.earnedPoints.Size = new System.Drawing.Size(52, 21);
            this.earnedPoints.TabIndex = 20;
            this.earnedPoints.Text = "0/300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(642, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 30);
            this.label10.TabIndex = 21;
            this.label10.Text = "High Score:";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScore.Location = new System.Drawing.Point(642, 266);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(25, 30);
            this.highScore.TabIndex = 22;
            this.highScore.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.earnedPoints);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.blueSol);
            this.Controls.Add(this.greenSol);
            this.Controls.Add(this.redSol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.BlueVal);
            this.Controls.Add(this.GreenVal);
            this.Controls.Add(this.RedVal);
            this.Controls.Add(this.colorPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.NumericUpDown RedVal;
        private System.Windows.Forms.NumericUpDown GreenVal;
        private System.Windows.Forms.NumericUpDown BlueVal;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Round;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label redSol;
        private System.Windows.Forms.Label greenSol;
        private System.Windows.Forms.Label blueSol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label earnedPoints;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label highScore;
    }
}



namespace RGB_Guess
{
    partial class RapidForm
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
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.roundCtr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.blueVal = new System.Windows.Forms.Label();
            this.greenVal = new System.Windows.Forms.Label();
            this.redVal = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorPanel.Location = new System.Drawing.Point(184, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(409, 317);
            this.ColorPanel.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.Location = new System.Drawing.Point(184, 375);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(129, 53);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(467, 375);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(126, 53);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next Round";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(621, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Round:";
            // 
            // roundCtr
            // 
            this.roundCtr.AutoSize = true;
            this.roundCtr.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundCtr.Location = new System.Drawing.Point(621, 58);
            this.roundCtr.Name = "roundCtr";
            this.roundCtr.Size = new System.Drawing.Size(22, 25);
            this.roundCtr.TabIndex = 7;
            this.roundCtr.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(621, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "High Score:";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScore.Location = new System.Drawing.Point(621, 214);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(25, 30);
            this.highScore.TabIndex = 9;
            this.highScore.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.DataSource = this.ColorPanel.Controls;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 124);
            this.listBox1.TabIndex = 10;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox1_DragEnter);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Solution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Red:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Green:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Blue:";
            // 
            // blueVal
            // 
            this.blueVal.AutoSize = true;
            this.blueVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blueVal.Location = new System.Drawing.Point(80, 313);
            this.blueVal.Name = "blueVal";
            this.blueVal.Size = new System.Drawing.Size(22, 25);
            this.blueVal.TabIndex = 15;
            this.blueVal.Text = "0";
            // 
            // greenVal
            // 
            this.greenVal.AutoSize = true;
            this.greenVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greenVal.Location = new System.Drawing.Point(80, 270);
            this.greenVal.Name = "greenVal";
            this.greenVal.Size = new System.Drawing.Size(22, 25);
            this.greenVal.TabIndex = 16;
            this.greenVal.Text = "0";
            // 
            // redVal
            // 
            this.redVal.AutoSize = true;
            this.redVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redVal.Location = new System.Drawing.Point(80, 228);
            this.redVal.Name = "redVal";
            this.redVal.Size = new System.Drawing.Size(22, 25);
            this.redVal.TabIndex = 17;
            this.redVal.Text = "0";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(13, 375);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(111, 37);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.Text = "Correct!";
            this.resultLabel.Visible = false;
            // 
            // RapidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.redVal);
            this.Controls.Add(this.greenVal);
            this.Controls.Add(this.blueVal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundCtr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.ColorPanel);
            this.Name = "RapidForm";
            this.Text = "Form3";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roundCtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label blueVal;
        private System.Windows.Forms.Label greenVal;
        private System.Windows.Forms.Label redVal;
        private System.Windows.Forms.Label resultLabel;
    }
}
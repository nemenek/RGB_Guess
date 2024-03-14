
namespace RGB_Guess
{
    partial class MainMenu
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
            this.ClassicBtn = new System.Windows.Forms.Button();
            this.RapidBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(254, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess The Color";
            // 
            // ClassicBtn
            // 
            this.ClassicBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassicBtn.Location = new System.Drawing.Point(143, 286);
            this.ClassicBtn.Name = "ClassicBtn";
            this.ClassicBtn.Size = new System.Drawing.Size(89, 43);
            this.ClassicBtn.TabIndex = 1;
            this.ClassicBtn.Text = "Classic";
            this.ClassicBtn.UseVisualStyleBackColor = true;
            this.ClassicBtn.Click += new System.EventHandler(this.ClassicBtn_Click);
            // 
            // RapidBtn
            // 
            this.RapidBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RapidBtn.Location = new System.Drawing.Point(514, 286);
            this.RapidBtn.Name = "RapidBtn";
            this.RapidBtn.Size = new System.Drawing.Size(91, 43);
            this.RapidBtn.TabIndex = 2;
            this.RapidBtn.Text = "Rapid";
            this.RapidBtn.UseVisualStyleBackColor = true;
            this.RapidBtn.Click += new System.EventHandler(this.RapidBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RapidBtn);
            this.Controls.Add(this.ClassicBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClassicBtn;
        private System.Windows.Forms.Button RapidBtn;
    }
}
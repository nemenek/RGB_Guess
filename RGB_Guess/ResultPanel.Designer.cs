
namespace RGB_Guess
{
    partial class ResultPanel
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
            this.asdasd = new System.Windows.Forms.Label();
            this.finalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asdasd
            // 
            this.asdasd.AutoSize = true;
            this.asdasd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asdasd.Location = new System.Drawing.Point(290, 58);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(174, 45);
            this.asdasd.TabIndex = 0;
            this.asdasd.Text = "Final Score";
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalScore.Location = new System.Drawing.Point(364, 185);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(100, 45);
            this.finalScore.TabIndex = 1;
            this.finalScore.Text = "/1500";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.asdasd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asdasd;
        private System.Windows.Forms.Label finalScore;
    }
}
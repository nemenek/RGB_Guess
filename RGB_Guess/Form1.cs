using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Guess
{
    public partial class MainForm : Form
    {

        private short Red;
        private short Green;
        private short Blue;
        private short round;
        private int HighScore;

        public MainForm()
        {
            InitializeComponent();

            this.round = 1;
            colorPanel.BackColor = GenerateRandomColor();
            Next.Enabled = false;

            this.HighScore = ReadHighScore();
            highScore.Text = this.HighScore.ToString();
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.Red = color.R;
            this.Green = color.G;
            this.Blue = color.B;
            return color;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SubmitBtn.Enabled = false;

            int score = Calculate_Score();
            
            Score.Text = (int.Parse(Score.Text) + score).ToString();

            redSol.Text = this.Red.ToString();
            greenSol.Text = this.Green.ToString();
            blueSol.Text = this.Blue.ToString();

            earnedPoints.Text = score.ToString() + "/100";

            if(this.round == 10)
            {
                Form2 form = new Form2(int.Parse(Score.Text));
                form.ShowDialog();
                if(int.Parse(Score.Text) > this.HighScore)
                {
                    this.HighScore = int.Parse(Score.Text);
                    highScore.Text = this.HighScore.ToString();
                    SetHighScore(this.HighScore);
                }
            }

            Next.Enabled = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Next.Enabled = false;

            if (this.round < 10)
            {
                this.round++;
            }
            else
            {
                round = 1;
                Score.Text = 0.ToString();
            }
            colorPanel.BackColor = GenerateRandomColor();
            Round.Text = this.round + "/10";

            BlueVal.Value = 0;
            GreenVal.Value = 0;
            RedVal.Value = 0;

            redSol.Text = 0.ToString();
            greenSol.Text = 0.ToString();
            blueSol.Text = 0.ToString();

            earnedPoints.Text = 0.ToString() + "/100";


            SubmitBtn.Enabled = true;
        }

        private int Calculate_Score()
        {
            int maxDiff_R = this.Red >= 128 ? this.Red : 256 - this.Red;
            int maxDiff_G = this.Green >= 128 ? this.Green : 256 - this.Green;
            int maxDiff_B = this.Blue >= 128 ? this.Blue : 256 - this.Blue;

            int maxDiff = maxDiff_B + maxDiff_G + maxDiff_R;

            int diff_R = Math.Abs(((short)RedVal.Value - this.Red));

            int diff_G = Math.Abs(((short)GreenVal.Value - this.Green));

            int diff_B = Math.Abs(((short)BlueVal.Value - this.Blue));

            int totalDiff = diff_B + diff_G + diff_R;

            double normalizedDiff = (double)totalDiff / maxDiff;

            return (int)(100 * (1 - normalizedDiff));
        }

        private int ReadHighScore()
        {
            int number = 0;
            using (StreamReader reader = new StreamReader("highscore.txt"))
            {
                string line = reader.ReadLine();
                if (int.TryParse(line, out number))
                {
                    // Number successfully parsed
                    return number;
                }
            }
            return number;
        }

        private void SetHighScore(int number)
        {
            using (StreamWriter writer = new StreamWriter("highscore.txt"))
            {
                writer.WriteLine(number);
            }
        }
    }
}

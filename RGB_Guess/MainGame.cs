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
            colorPanel.BackColor = ColorGenerator.GenerateColor();
            setColorValues();
            Next.Enabled = false;

            this.HighScore = ReadHighScore();
            highScore.Text = this.HighScore.ToString();
        }

        private void setColorValues()
        {
            this.Red = colorPanel.BackColor.R;
            this.Green = colorPanel.BackColor.G;
            this.Blue = colorPanel.BackColor.B;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SubmitBtn.Enabled = false;

            int score = Calculate_Score();
            
            Score.Text = (int.Parse(Score.Text) + score).ToString();

            redSol.Text = this.Red.ToString();
            greenSol.Text = this.Green.ToString();
            blueSol.Text = this.Blue.ToString();

            earnedPoints.Text = score.ToString() + "/300";

            if(this.round == 5)
            {
                ResultPanel form = new ResultPanel(int.Parse(Score.Text));
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

            if (this.round < 5)
            {
                this.round++;
            }
            else
            {
                round = 1;
                Score.Text = 0.ToString();
            }
            colorPanel.BackColor = ColorGenerator.GenerateColor();
            setColorValues();
            Round.Text = this.round + "/5";

            BlueVal.Value = 0;
            GreenVal.Value = 0;
            RedVal.Value = 0;

            redSol.Text = 0.ToString();
            greenSol.Text = 0.ToString();
            blueSol.Text = 0.ToString();

            earnedPoints.Text = 0.ToString() + "/300";


            SubmitBtn.Enabled = true;
        }

        private int Calculate_Score()
        {
            int score_R = Math.Max(0, 100 - Math.Abs(((short)RedVal.Value - this.Red)));

            int score_G = Math.Max(0, 100 - Math.Abs(((short)GreenVal.Value - this.Green)));

            int score_B = Math.Max(0, 100 - Math.Abs(((short)BlueVal.Value - this.Blue)));

            return (score_B + score_G + score_R);
        }

        private int ReadHighScore()
        {
            int number = 0;
            if (File.Exists("highscoreClassic.txt"))
            {
                using (StreamReader reader = new StreamReader("highscoreClassic.txt"))
                {
                    string line = reader.ReadLine();
                    if (int.TryParse(line, out number))
                    {
                        // Number successfully parsed
                        return number;
                    }
                }
            }
            else
            {
                File.Create("highscoreClassic.txt").Close();
            }
                
            return number;
        }

        private void SetHighScore(int number)
        {
            using (StreamWriter writer = new StreamWriter("highscoreClassic.txt"))
            {
                writer.WriteLine(number);
            }
        }
    }
}

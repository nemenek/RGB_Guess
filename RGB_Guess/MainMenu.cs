using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Guess
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ClassicBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainGame = new MainForm();
            mainGame.ShowDialog();

            this.Close();
        }

        private void RapidBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            RapidForm rpdForm = new RapidForm();
            rpdForm.ShowDialog();

            this.Close();
        }
    }
}

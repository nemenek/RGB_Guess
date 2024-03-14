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
    public partial class ResultPanel : Form
    {
        public ResultPanel(int score)
        {
            InitializeComponent();
            finalScore.Text = score.ToString() + "/1500";
        }
    }
}

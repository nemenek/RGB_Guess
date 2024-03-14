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
    public partial class RapidResult : Form
    {
        public RapidResult(int result)
        {
            InitializeComponent();
            score.Text = result.ToString();
        }
    }
}

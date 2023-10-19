using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentClickerGame
{
    public partial class GameCompleteUI : Form
    {
        public GameCompleteUI()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnCompleteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEndlessMode_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            if (grpBoxInfo.Visible == false) { grpBoxInfo.Visible = true; }
            else { grpBoxInfo.Visible = false; }
        }
    }
}

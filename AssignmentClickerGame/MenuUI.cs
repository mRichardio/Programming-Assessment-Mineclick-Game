using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentClickerGame
{
    public partial class MenuUI : Form
    {
        Shop shop = new();
        Player player = new();

        public MenuUI()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuLoadGame_Click(object sender, EventArgs e)
        {
            LoadSave loadSave = new();
            loadSave.ShowDialog();
        }

        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            if (grpBoxInfo.Visible == false) { grpBoxInfo.Visible = true; }
            else { grpBoxInfo.Visible = false; }
        }
    }
}

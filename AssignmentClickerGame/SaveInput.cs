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
    public partial class SaveInput : Form
    {
        // Attributes
        private string saveInput;

        public SaveInput()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtSaveInput.TextLength >= 3)
            {
                SetSaveInput(txtSaveInput.Text);
                Close();
            }
            else { MessageBox.Show("Save names must be 3 or more characters long.", "Error Saving Game", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetSaveInput(string savename) {  saveInput = savename; }

        public string GetSaveInput() {  return saveInput; }
    }
}

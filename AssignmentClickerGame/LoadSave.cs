using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentClickerGame
{
    public partial class LoadSave : Form
    {
        // Attributes

        private string selectedSave;

        // Member Functions

        public LoadSave()
        {
            InitializeComponent();
            ControlBox = false;

            // REFERENCE: https://social.msdn.microsoft.com/Forums/vstudio/en-US/aaa024d2-3d6e-4e2f-834c-818775de6464/list-files-from-a-folder-to-a-listbox?forum=csharpgeneral
            lstBxLoadSaves.Items.Clear();
            var folderName = Environment.CurrentDirectory;
            var results = Directory
                .GetFiles(folderName, "*.txt")
                .Select(file => Path.GetFileName(file)) // Lambda Expression (Modified Foreach Loop)
                .ToArray();
            lstBxLoadSaves.Items.AddRange(results);
        }
        
        private void btnLoadSave_Click(object sender, EventArgs e)
        {
            if (lstBxLoadSaves.SelectedIndex >= 0) // Checks if a user has selected an item
            {
                SetSelectedSave(lstBxLoadSaves.SelectedItem.ToString());
                Close();
            }
            else { MessageBox.Show("A save file wasn't selected. (To load a save you much choose one from the list first!)", "Error Loading Game", MessageBoxButtons.OK, MessageBoxIcon.Error); } // If no item is selected an error will appear
        }

        private void btnCancelLoad_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Functions

        public string GetSelectedSave()
        {
            return selectedSave;
        }

        public string SetSelectedSave(string newSelect)
        {
            return selectedSave = newSelect;
        }
    }
}

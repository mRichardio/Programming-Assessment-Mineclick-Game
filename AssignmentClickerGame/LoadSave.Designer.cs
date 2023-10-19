namespace AssignmentClickerGame
{
    partial class LoadSave
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
            this.grpBxLoad = new System.Windows.Forms.GroupBox();
            this.btnCancelLoad = new System.Windows.Forms.Button();
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.lstBxLoadSaves = new System.Windows.Forms.ListBox();
            this.grpBxLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxLoad
            // 
            this.grpBxLoad.Controls.Add(this.btnCancelLoad);
            this.grpBxLoad.Controls.Add(this.btnLoadSave);
            this.grpBxLoad.Controls.Add(this.lstBxLoadSaves);
            this.grpBxLoad.Location = new System.Drawing.Point(6, 4);
            this.grpBxLoad.Name = "grpBxLoad";
            this.grpBxLoad.Size = new System.Drawing.Size(230, 369);
            this.grpBxLoad.TabIndex = 10;
            this.grpBxLoad.TabStop = false;
            this.grpBxLoad.Text = "Load Saves";
            // 
            // btnCancelLoad
            // 
            this.btnCancelLoad.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelLoad.Location = new System.Drawing.Point(56, 325);
            this.btnCancelLoad.Name = "btnCancelLoad";
            this.btnCancelLoad.Size = new System.Drawing.Size(117, 38);
            this.btnCancelLoad.TabIndex = 11;
            this.btnCancelLoad.Text = "Cancel";
            this.btnCancelLoad.UseVisualStyleBackColor = false;
            this.btnCancelLoad.Click += new System.EventHandler(this.btnCancelLoad_Click);
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLoadSave.Location = new System.Drawing.Point(6, 272);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(216, 47);
            this.btnLoadSave.TabIndex = 10;
            this.btnLoadSave.Text = "Load Save";
            this.btnLoadSave.UseVisualStyleBackColor = false;
            this.btnLoadSave.Click += new System.EventHandler(this.btnLoadSave_Click);
            // 
            // lstBxLoadSaves
            // 
            this.lstBxLoadSaves.FormattingEnabled = true;
            this.lstBxLoadSaves.ItemHeight = 15;
            this.lstBxLoadSaves.Location = new System.Drawing.Point(6, 22);
            this.lstBxLoadSaves.Name = "lstBxLoadSaves";
            this.lstBxLoadSaves.Size = new System.Drawing.Size(216, 244);
            this.lstBxLoadSaves.TabIndex = 8;
            // 
            // LoadSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 375);
            this.Controls.Add(this.grpBxLoad);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LoadSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadSave";
            this.grpBxLoad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBxLoad;
        private Button btnCancelLoad;
        private Button btnLoadSave;
        private ListBox lstBxLoadSaves;
    }
}
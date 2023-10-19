namespace AssignmentClickerGame
{
    partial class MenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUI));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuInfo = new System.Windows.Forms.Button();
            this.grpBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNewGame.Location = new System.Drawing.Point(296, 293);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(205, 83);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Begin";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(234, 183);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.richTextBox1);
            this.grpBoxInfo.Location = new System.Drawing.Point(542, 67);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(246, 211);
            this.grpBoxInfo.TabIndex = 5;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Information";
            this.grpBoxInfo.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(351, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 173);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuInfo
            // 
            this.btnMenuInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuInfo.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.infoBtnIcon;
            this.btnMenuInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuInfo.Location = new System.Drawing.Point(738, 12);
            this.btnMenuInfo.Name = "btnMenuInfo";
            this.btnMenuInfo.Size = new System.Drawing.Size(50, 49);
            this.btnMenuInfo.TabIndex = 9;
            this.btnMenuInfo.UseVisualStyleBackColor = false;
            this.btnMenuInfo.Click += new System.EventHandler(this.btnMenuInfo_Click);
            // 
            // MenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.btnMenuInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mineclick | Menu";
            this.grpBoxInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnNewGame;
        private RichTextBox richTextBox1;
        private GroupBox grpBoxInfo;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Button btnMenuInfo;
    }
}
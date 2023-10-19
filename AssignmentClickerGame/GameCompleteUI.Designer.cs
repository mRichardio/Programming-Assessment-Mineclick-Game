namespace AssignmentClickerGame
{
    partial class GameCompleteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCompleteUI));
            this.btnCompleteExit = new System.Windows.Forms.Button();
            this.btnEndlessMode = new System.Windows.Forms.Button();
            this.lblGameComplete = new System.Windows.Forms.Label();
            this.lblCompleteWarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.rchTxtInfo = new System.Windows.Forms.RichTextBox();
            this.btnMenuInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompleteExit
            // 
            this.btnCompleteExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnCompleteExit.Location = new System.Drawing.Point(305, 320);
            this.btnCompleteExit.Name = "btnCompleteExit";
            this.btnCompleteExit.Size = new System.Drawing.Size(202, 47);
            this.btnCompleteExit.TabIndex = 0;
            this.btnCompleteExit.Text = "Exit";
            this.btnCompleteExit.UseVisualStyleBackColor = false;
            this.btnCompleteExit.Click += new System.EventHandler(this.btnCompleteExit_Click);
            // 
            // btnEndlessMode
            // 
            this.btnEndlessMode.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEndlessMode.Location = new System.Drawing.Point(278, 220);
            this.btnEndlessMode.Name = "btnEndlessMode";
            this.btnEndlessMode.Size = new System.Drawing.Size(251, 94);
            this.btnEndlessMode.TabIndex = 1;
            this.btnEndlessMode.Text = "Endless Mode";
            this.btnEndlessMode.UseVisualStyleBackColor = false;
            this.btnEndlessMode.Click += new System.EventHandler(this.btnEndlessMode_Click);
            // 
            // lblGameComplete
            // 
            this.lblGameComplete.AutoSize = true;
            this.lblGameComplete.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameComplete.Location = new System.Drawing.Point(220, 131);
            this.lblGameComplete.Name = "lblGameComplete";
            this.lblGameComplete.Size = new System.Drawing.Size(349, 86);
            this.lblGameComplete.TabIndex = 2;
            this.lblGameComplete.Text = "Complete!";
            // 
            // lblCompleteWarning
            // 
            this.lblCompleteWarning.AutoSize = true;
            this.lblCompleteWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompleteWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCompleteWarning.Location = new System.Drawing.Point(218, 397);
            this.lblCompleteWarning.Name = "lblCompleteWarning";
            this.lblCompleteWarning.Size = new System.Drawing.Size(385, 30);
            this.lblCompleteWarning.TabIndex = 3;
            this.lblCompleteWarning.Text = "Warning: Pressing the exit button will exit the game without saving.\r\n           " +
    "               (Select Endless mode to keep playing!)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(191, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 173);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.rchTxtInfo);
            this.grpBoxInfo.Location = new System.Drawing.Point(542, 67);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(246, 211);
            this.grpBoxInfo.TabIndex = 23;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Information";
            this.grpBoxInfo.Visible = false;
            // 
            // rchTxtInfo
            // 
            this.rchTxtInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.rchTxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchTxtInfo.Location = new System.Drawing.Point(6, 22);
            this.rchTxtInfo.Name = "rchTxtInfo";
            this.rchTxtInfo.ReadOnly = true;
            this.rchTxtInfo.Size = new System.Drawing.Size(234, 183);
            this.rchTxtInfo.TabIndex = 2;
            this.rchTxtInfo.Text = resources.GetString("rchTxtInfo.Text");
            // 
            // btnMenuInfo
            // 
            this.btnMenuInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuInfo.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.infoBtnIcon;
            this.btnMenuInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuInfo.Location = new System.Drawing.Point(738, 12);
            this.btnMenuInfo.Name = "btnMenuInfo";
            this.btnMenuInfo.Size = new System.Drawing.Size(50, 49);
            this.btnMenuInfo.TabIndex = 24;
            this.btnMenuInfo.UseVisualStyleBackColor = false;
            this.btnMenuInfo.Click += new System.EventHandler(this.btnMenuInfo_Click);
            // 
            // GameCompleteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.btnMenuInfo);
            this.Controls.Add(this.lblCompleteWarning);
            this.Controls.Add(this.lblGameComplete);
            this.Controls.Add(this.btnEndlessMode);
            this.Controls.Add(this.btnCompleteExit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameCompleteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Placeholder | Complete";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCompleteExit;
        private Button btnEndlessMode;
        private Label lblGameComplete;
        private Label lblCompleteWarning;
        private PictureBox pictureBox1;
        private GroupBox grpBoxInfo;
        private RichTextBox rchTxtInfo;
        private Button btnMenuInfo;
    }
}
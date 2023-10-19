namespace AssignmentClickerGame
{
    partial class SaveInput
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSaveInput = new System.Windows.Forms.TextBox();
            this.lblInputSave = new System.Windows.Forms.Label();
            this.lblSaveInputInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(178, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(10, 142);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(162, 41);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSaveInput
            // 
            this.txtSaveInput.Location = new System.Drawing.Point(10, 113);
            this.txtSaveInput.Name = "txtSaveInput";
            this.txtSaveInput.Size = new System.Drawing.Size(254, 23);
            this.txtSaveInput.TabIndex = 2;
            // 
            // lblInputSave
            // 
            this.lblInputSave.AutoSize = true;
            this.lblInputSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputSave.Location = new System.Drawing.Point(61, 9);
            this.lblInputSave.Name = "lblInputSave";
            this.lblInputSave.Size = new System.Drawing.Size(141, 21);
            this.lblInputSave.TabIndex = 3;
            this.lblInputSave.Text = "Input Save Name";
            // 
            // lblSaveInputInfo
            // 
            this.lblSaveInputInfo.AutoSize = true;
            this.lblSaveInputInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveInputInfo.Location = new System.Drawing.Point(21, 30);
            this.lblSaveInputInfo.Name = "lblSaveInputInfo";
            this.lblSaveInputInfo.Size = new System.Drawing.Size(221, 30);
            this.lblSaveInputInfo.TabIndex = 4;
            this.lblSaveInputInfo.Text = "(Warning, if the save name already exists\r\n then the file will be overwritten!)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save name must be 3 or more characters long.";
            // 
            // SaveInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaveInputInfo);
            this.Controls.Add(this.lblInputSave);
            this.Controls.Add(this.txtSaveInput);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "SaveInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "saveInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private TextBox txtSaveInput;
        private Label lblInputSave;
        private Label lblSaveInputInfo;
        private Label label1;
    }
}
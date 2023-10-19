namespace AssignmentClickerGame
{
    partial class Mineclick
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mineclick));
            this.btnMiner = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.grpBxItemShop = new System.Windows.Forms.GroupBox();
            this.lblShopFactory = new System.Windows.Forms.Label();
            this.lblShopQuarry = new System.Windows.Forms.Label();
            this.lblShopDrill = new System.Windows.Forms.Label();
            this.btnBuyFactory = new System.Windows.Forms.Button();
            this.btnBuyQuarry = new System.Windows.Forms.Button();
            this.lblShopWorker = new System.Windows.Forms.Label();
            this.btnBuyWorker = new System.Windows.Forms.Button();
            this.btnBuyDrill = new System.Windows.Forms.Button();
            this.lblShopError = new System.Windows.Forms.Label();
            this.lblShopPickaxe = new System.Windows.Forms.Label();
            this.btnBuyPickaxe = new System.Windows.Forms.Button();
            this.btnShopMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBxUpgradeShop = new System.Windows.Forms.GroupBox();
            this.btnFactoryMultiplier = new System.Windows.Forms.Button();
            this.btnWorkerMultiplier = new System.Windows.Forms.Button();
            this.lblQuarryMultiplier = new System.Windows.Forms.Label();
            this.lblDrillMultiplier = new System.Windows.Forms.Label();
            this.btnDrillMultiplier = new System.Windows.Forms.Button();
            this.lblFactoryMultiplier = new System.Windows.Forms.Label();
            this.lblWorkerMultiplier = new System.Windows.Forms.Label();
            this.btnQuarryMultiplier = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProgramTickSpeed = new System.Windows.Forms.Timer(this.components);
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnConsoleRun = new System.Windows.Forms.Button();
            this.btnCollectIncome = new System.Windows.Forms.Button();
            this.lblAutoIncome = new System.Windows.Forms.Label();
            this.grpBxAutoIncome = new System.Windows.Forms.GroupBox();
            this.grpBxOwnedItems = new System.Windows.Forms.GroupBox();
            this.lblBoughtPickaxe = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBoughtQuarry = new System.Windows.Forms.Label();
            this.lblBoughtFactory = new System.Windows.Forms.Label();
            this.lblBoughtDrill = new System.Windows.Forms.Label();
            this.lblBoughtWorker = new System.Windows.Forms.Label();
            this.pbQuarry = new System.Windows.Forms.PictureBox();
            this.pbFactory = new System.Windows.Forms.PictureBox();
            this.pbDrill = new System.Windows.Forms.PictureBox();
            this.pbWorker = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBoughtQuarryUpg = new System.Windows.Forms.Label();
            this.lblBoughtFactoryUpg = new System.Windows.Forms.Label();
            this.lblBoughtDrillUpg = new System.Windows.Forms.Label();
            this.lblBoughtWorkerUpg = new System.Windows.Forms.Label();
            this.pbQuarryUpg = new System.Windows.Forms.PictureBox();
            this.pbFactoryUpg = new System.Windows.Forms.PictureBox();
            this.pbDrillUpg = new System.Windows.Forms.PictureBox();
            this.pbWorkerUpg = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBxItemShop.SuspendLayout();
            this.grpBxUpgradeShop.SuspendLayout();
            this.grpBxAutoIncome.SuspendLayout();
            this.grpBxOwnedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorker)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarryUpg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactoryUpg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrillUpg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkerUpg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMiner
            // 
            this.btnMiner.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMiner.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.pick;
            this.btnMiner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMiner.Location = new System.Drawing.Point(303, 360);
            this.btnMiner.Name = "btnMiner";
            this.btnMiner.Size = new System.Drawing.Size(209, 83);
            this.btnMiner.TabIndex = 0;
            this.btnMiner.UseVisualStyleBackColor = false;
            this.btnMiner.Click += new System.EventHandler(this.btnMiner_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(342, 332);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(133, 25);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "[User Balance]";
            // 
            // grpBxItemShop
            // 
            this.grpBxItemShop.Controls.Add(this.lblShopFactory);
            this.grpBxItemShop.Controls.Add(this.lblShopQuarry);
            this.grpBxItemShop.Controls.Add(this.lblShopDrill);
            this.grpBxItemShop.Controls.Add(this.btnBuyFactory);
            this.grpBxItemShop.Controls.Add(this.btnBuyQuarry);
            this.grpBxItemShop.Controls.Add(this.lblShopWorker);
            this.grpBxItemShop.Controls.Add(this.btnBuyWorker);
            this.grpBxItemShop.Controls.Add(this.btnBuyDrill);
            this.grpBxItemShop.Location = new System.Drawing.Point(542, 55);
            this.grpBxItemShop.Name = "grpBxItemShop";
            this.grpBxItemShop.Size = new System.Drawing.Size(246, 215);
            this.grpBxItemShop.TabIndex = 2;
            this.grpBxItemShop.TabStop = false;
            this.grpBxItemShop.Text = "Shop";
            this.grpBxItemShop.Visible = false;
            // 
            // lblShopFactory
            // 
            this.lblShopFactory.AutoSize = true;
            this.lblShopFactory.BackColor = System.Drawing.Color.Transparent;
            this.lblShopFactory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopFactory.Location = new System.Drawing.Point(22, 185);
            this.lblShopFactory.Name = "lblShopFactory";
            this.lblShopFactory.Size = new System.Drawing.Size(98, 19);
            this.lblShopFactory.TabIndex = 10;
            this.lblShopFactory.Text = "[Factory Cost]";
            // 
            // lblShopQuarry
            // 
            this.lblShopQuarry.AutoSize = true;
            this.lblShopQuarry.BackColor = System.Drawing.Color.Transparent;
            this.lblShopQuarry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopQuarry.Location = new System.Drawing.Point(135, 185);
            this.lblShopQuarry.Name = "lblShopQuarry";
            this.lblShopQuarry.Size = new System.Drawing.Size(95, 19);
            this.lblShopQuarry.TabIndex = 9;
            this.lblShopQuarry.Text = "[Quarry Cost]";
            // 
            // lblShopDrill
            // 
            this.lblShopDrill.AutoSize = true;
            this.lblShopDrill.BackColor = System.Drawing.Color.Transparent;
            this.lblShopDrill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopDrill.Location = new System.Drawing.Point(142, 90);
            this.lblShopDrill.Name = "lblShopDrill";
            this.lblShopDrill.Size = new System.Drawing.Size(78, 19);
            this.lblShopDrill.TabIndex = 8;
            this.lblShopDrill.Text = "[Drill Cost]";
            // 
            // btnBuyFactory
            // 
            this.btnBuyFactory.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Factory;
            this.btnBuyFactory.Location = new System.Drawing.Point(36, 117);
            this.btnBuyFactory.Name = "btnBuyFactory";
            this.btnBuyFactory.Size = new System.Drawing.Size(65, 65);
            this.btnBuyFactory.TabIndex = 7;
            this.btnBuyFactory.UseVisualStyleBackColor = true;
            this.btnBuyFactory.Click += new System.EventHandler(this.btnBuyFactory_Click);
            // 
            // btnBuyQuarry
            // 
            this.btnBuyQuarry.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Quarry;
            this.btnBuyQuarry.Location = new System.Drawing.Point(150, 117);
            this.btnBuyQuarry.Name = "btnBuyQuarry";
            this.btnBuyQuarry.Size = new System.Drawing.Size(65, 65);
            this.btnBuyQuarry.TabIndex = 6;
            this.btnBuyQuarry.UseVisualStyleBackColor = true;
            this.btnBuyQuarry.Click += new System.EventHandler(this.btnBuyQuarry_Click);
            // 
            // lblShopWorker
            // 
            this.lblShopWorker.AutoSize = true;
            this.lblShopWorker.BackColor = System.Drawing.Color.Transparent;
            this.lblShopWorker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopWorker.Location = new System.Drawing.Point(22, 90);
            this.lblShopWorker.Name = "lblShopWorker";
            this.lblShopWorker.Size = new System.Drawing.Size(97, 19);
            this.lblShopWorker.TabIndex = 4;
            this.lblShopWorker.Text = "[Worker Cost]";
            // 
            // btnBuyWorker
            // 
            this.btnBuyWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuyWorker.BackgroundImage")));
            this.btnBuyWorker.Location = new System.Drawing.Point(36, 22);
            this.btnBuyWorker.Name = "btnBuyWorker";
            this.btnBuyWorker.Size = new System.Drawing.Size(65, 65);
            this.btnBuyWorker.TabIndex = 2;
            this.btnBuyWorker.UseVisualStyleBackColor = true;
            this.btnBuyWorker.Click += new System.EventHandler(this.btnBuyWorker_Click);
            // 
            // btnBuyDrill
            // 
            this.btnBuyDrill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuyDrill.BackgroundImage")));
            this.btnBuyDrill.Location = new System.Drawing.Point(150, 22);
            this.btnBuyDrill.Name = "btnBuyDrill";
            this.btnBuyDrill.Size = new System.Drawing.Size(65, 65);
            this.btnBuyDrill.TabIndex = 5;
            this.btnBuyDrill.UseVisualStyleBackColor = true;
            this.btnBuyDrill.Click += new System.EventHandler(this.btnBuyDrill_Click);
            // 
            // lblShopError
            // 
            this.lblShopError.AutoSize = true;
            this.lblShopError.ForeColor = System.Drawing.Color.Red;
            this.lblShopError.Location = new System.Drawing.Point(350, 317);
            this.lblShopError.Name = "lblShopError";
            this.lblShopError.Size = new System.Drawing.Size(106, 15);
            this.lblShopError.TabIndex = 1;
            this.lblShopError.Text = "Insufficient Funds!";
            this.lblShopError.Visible = false;
            // 
            // lblShopPickaxe
            // 
            this.lblShopPickaxe.AutoSize = true;
            this.lblShopPickaxe.BackColor = System.Drawing.Color.Transparent;
            this.lblShopPickaxe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopPickaxe.Location = new System.Drawing.Point(217, 348);
            this.lblShopPickaxe.Name = "lblShopPickaxe";
            this.lblShopPickaxe.Size = new System.Drawing.Size(39, 19);
            this.lblShopPickaxe.TabIndex = 3;
            this.lblShopPickaxe.Text = "$100";
            // 
            // btnBuyPickaxe
            // 
            this.btnBuyPickaxe.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.pickaxe;
            this.btnBuyPickaxe.Location = new System.Drawing.Point(209, 370);
            this.btnBuyPickaxe.Name = "btnBuyPickaxe";
            this.btnBuyPickaxe.Size = new System.Drawing.Size(65, 65);
            this.btnBuyPickaxe.TabIndex = 0;
            this.btnBuyPickaxe.UseVisualStyleBackColor = true;
            this.btnBuyPickaxe.Click += new System.EventHandler(this.btnBuyBetterPickaxe_Click);
            // 
            // btnShopMenu
            // 
            this.btnShopMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnShopMenu.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.local_atm_FILL0_wght400_GRAD0_opsz48;
            this.btnShopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShopMenu.FlatAppearance.BorderSize = 0;
            this.btnShopMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopMenu.Location = new System.Drawing.Point(734, 12);
            this.btnShopMenu.Name = "btnShopMenu";
            this.btnShopMenu.Size = new System.Drawing.Size(48, 48);
            this.btnShopMenu.TabIndex = 3;
            this.btnShopMenu.UseVisualStyleBackColor = false;
            this.btnShopMenu.Click += new System.EventHandler(this.btnShopMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBxUpgradeShop
            // 
            this.grpBxUpgradeShop.Controls.Add(this.btnFactoryMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.btnWorkerMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.lblQuarryMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.lblDrillMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.btnDrillMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.lblFactoryMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.lblWorkerMultiplier);
            this.grpBxUpgradeShop.Controls.Add(this.btnQuarryMultiplier);
            this.grpBxUpgradeShop.Location = new System.Drawing.Point(290, 55);
            this.grpBxUpgradeShop.Name = "grpBxUpgradeShop";
            this.grpBxUpgradeShop.Size = new System.Drawing.Size(246, 215);
            this.grpBxUpgradeShop.TabIndex = 7;
            this.grpBxUpgradeShop.TabStop = false;
            this.grpBxUpgradeShop.Text = "Upgrades";
            this.grpBxUpgradeShop.Visible = false;
            // 
            // btnFactoryMultiplier
            // 
            this.btnFactoryMultiplier.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.FactoryUpgrade;
            this.btnFactoryMultiplier.Location = new System.Drawing.Point(30, 117);
            this.btnFactoryMultiplier.Name = "btnFactoryMultiplier";
            this.btnFactoryMultiplier.Size = new System.Drawing.Size(65, 65);
            this.btnFactoryMultiplier.TabIndex = 4;
            this.btnFactoryMultiplier.UseVisualStyleBackColor = true;
            this.btnFactoryMultiplier.Click += new System.EventHandler(this.btnUpgProdDrill_Click);
            // 
            // btnWorkerMultiplier
            // 
            this.btnWorkerMultiplier.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.WorkerUpgrade;
            this.btnWorkerMultiplier.Location = new System.Drawing.Point(30, 22);
            this.btnWorkerMultiplier.Name = "btnWorkerMultiplier";
            this.btnWorkerMultiplier.Size = new System.Drawing.Size(65, 65);
            this.btnWorkerMultiplier.TabIndex = 2;
            this.btnWorkerMultiplier.UseVisualStyleBackColor = true;
            this.btnWorkerMultiplier.Click += new System.EventHandler(this.btnUpgProdWorker_Click);
            // 
            // lblQuarryMultiplier
            // 
            this.lblQuarryMultiplier.AutoSize = true;
            this.lblQuarryMultiplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuarryMultiplier.Location = new System.Drawing.Point(129, 185);
            this.lblQuarryMultiplier.Name = "lblQuarryMultiplier";
            this.lblQuarryMultiplier.Size = new System.Drawing.Size(117, 19);
            this.lblQuarryMultiplier.TabIndex = 9;
            this.lblQuarryMultiplier.Text = "[Quarry Up Cost]";
            // 
            // lblDrillMultiplier
            // 
            this.lblDrillMultiplier.AutoSize = true;
            this.lblDrillMultiplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDrillMultiplier.Location = new System.Drawing.Point(140, 90);
            this.lblDrillMultiplier.Name = "lblDrillMultiplier";
            this.lblDrillMultiplier.Size = new System.Drawing.Size(100, 19);
            this.lblDrillMultiplier.TabIndex = 8;
            this.lblDrillMultiplier.Text = "[Drill Up Cost]";
            // 
            // btnDrillMultiplier
            // 
            this.btnDrillMultiplier.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.DrillUpgrade;
            this.btnDrillMultiplier.Location = new System.Drawing.Point(152, 22);
            this.btnDrillMultiplier.Name = "btnDrillMultiplier";
            this.btnDrillMultiplier.Size = new System.Drawing.Size(65, 65);
            this.btnDrillMultiplier.TabIndex = 3;
            this.btnDrillMultiplier.UseVisualStyleBackColor = true;
            this.btnDrillMultiplier.Click += new System.EventHandler(this.btnUpgProdFactory_Click);
            // 
            // lblFactoryMultiplier
            // 
            this.lblFactoryMultiplier.AutoSize = true;
            this.lblFactoryMultiplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFactoryMultiplier.Location = new System.Drawing.Point(3, 185);
            this.lblFactoryMultiplier.Name = "lblFactoryMultiplier";
            this.lblFactoryMultiplier.Size = new System.Drawing.Size(120, 19);
            this.lblFactoryMultiplier.TabIndex = 7;
            this.lblFactoryMultiplier.Text = "[Factory Up Cost]";
            // 
            // lblWorkerMultiplier
            // 
            this.lblWorkerMultiplier.AutoSize = true;
            this.lblWorkerMultiplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkerMultiplier.Location = new System.Drawing.Point(6, 90);
            this.lblWorkerMultiplier.Name = "lblWorkerMultiplier";
            this.lblWorkerMultiplier.Size = new System.Drawing.Size(119, 19);
            this.lblWorkerMultiplier.TabIndex = 6;
            this.lblWorkerMultiplier.Text = "[Worker Up Cost]";
            // 
            // btnQuarryMultiplier
            // 
            this.btnQuarryMultiplier.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.QuarryUpgrade;
            this.btnQuarryMultiplier.Location = new System.Drawing.Point(152, 117);
            this.btnQuarryMultiplier.Name = "btnQuarryMultiplier";
            this.btnQuarryMultiplier.Size = new System.Drawing.Size(65, 65);
            this.btnQuarryMultiplier.TabIndex = 5;
            this.btnQuarryMultiplier.UseVisualStyleBackColor = true;
            this.btnQuarryMultiplier.Click += new System.EventHandler(this.btnUpgProdQuarry_Click);
            // 
            // ProgramTickSpeed
            // 
            this.ProgramTickSpeed.Interval = 1;
            this.ProgramTickSpeed.Tick += new System.EventHandler(this.ProgramTickSpeed_Tick);
            // 
            // tmrError
            // 
            this.tmrError.Interval = 1000;
            // 
            // txtConsole
            // 
            this.txtConsole.AcceptsReturn = true;
            this.txtConsole.Location = new System.Drawing.Point(132, 12);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(305, 23);
            this.txtConsole.TabIndex = 8;
            // 
            // btnConsoleRun
            // 
            this.btnConsoleRun.Location = new System.Drawing.Point(443, 13);
            this.btnConsoleRun.Name = "btnConsoleRun";
            this.btnConsoleRun.Size = new System.Drawing.Size(40, 23);
            this.btnConsoleRun.TabIndex = 9;
            this.btnConsoleRun.Text = "Run";
            this.btnConsoleRun.UseVisualStyleBackColor = true;
            this.btnConsoleRun.Click += new System.EventHandler(this.btnConsoleRun_Click);
            // 
            // btnCollectIncome
            // 
            this.btnCollectIncome.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCollectIncome.Location = new System.Drawing.Point(10, 43);
            this.btnCollectIncome.Name = "btnCollectIncome";
            this.btnCollectIncome.Size = new System.Drawing.Size(158, 63);
            this.btnCollectIncome.TabIndex = 10;
            this.btnCollectIncome.Text = "Collect Income";
            this.btnCollectIncome.UseVisualStyleBackColor = false;
            this.btnCollectIncome.Click += new System.EventHandler(this.btnCollectIncome_Click);
            // 
            // lblAutoIncome
            // 
            this.lblAutoIncome.AutoSize = true;
            this.lblAutoIncome.Location = new System.Drawing.Point(47, 26);
            this.lblAutoIncome.Name = "lblAutoIncome";
            this.lblAutoIncome.Size = new System.Drawing.Size(85, 15);
            this.lblAutoIncome.TabIndex = 11;
            this.lblAutoIncome.Text = "[Auto Income]";
            // 
            // grpBxAutoIncome
            // 
            this.grpBxAutoIncome.Controls.Add(this.btnCollectIncome);
            this.grpBxAutoIncome.Controls.Add(this.lblAutoIncome);
            this.grpBxAutoIncome.Location = new System.Drawing.Point(564, 332);
            this.grpBxAutoIncome.Name = "grpBxAutoIncome";
            this.grpBxAutoIncome.Size = new System.Drawing.Size(179, 110);
            this.grpBxAutoIncome.TabIndex = 12;
            this.grpBxAutoIncome.TabStop = false;
            this.grpBxAutoIncome.Text = "Collect Automated Income";
            // 
            // grpBxOwnedItems
            // 
            this.grpBxOwnedItems.Controls.Add(this.lblBoughtPickaxe);
            this.grpBxOwnedItems.Controls.Add(this.pictureBox2);
            this.grpBxOwnedItems.Controls.Add(this.lblBoughtQuarry);
            this.grpBxOwnedItems.Controls.Add(this.lblBoughtFactory);
            this.grpBxOwnedItems.Controls.Add(this.lblBoughtDrill);
            this.grpBxOwnedItems.Controls.Add(this.lblBoughtWorker);
            this.grpBxOwnedItems.Controls.Add(this.pbQuarry);
            this.grpBxOwnedItems.Controls.Add(this.pbFactory);
            this.grpBxOwnedItems.Controls.Add(this.pbDrill);
            this.grpBxOwnedItems.Controls.Add(this.pbWorker);
            this.grpBxOwnedItems.Location = new System.Drawing.Point(12, 2);
            this.grpBxOwnedItems.Name = "grpBxOwnedItems";
            this.grpBxOwnedItems.Size = new System.Drawing.Size(114, 218);
            this.grpBxOwnedItems.TabIndex = 13;
            this.grpBxOwnedItems.TabStop = false;
            this.grpBxOwnedItems.Text = "Owned Items";
            // 
            // lblBoughtPickaxe
            // 
            this.lblBoughtPickaxe.AutoSize = true;
            this.lblBoughtPickaxe.Location = new System.Drawing.Point(64, 29);
            this.lblBoughtPickaxe.Name = "lblBoughtPickaxe";
            this.lblBoughtPickaxe.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtPickaxe.TabIndex = 24;
            this.lblBoughtPickaxe.Text = "0x";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.pickItem;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(6, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // lblBoughtQuarry
            // 
            this.lblBoughtQuarry.AutoSize = true;
            this.lblBoughtQuarry.Location = new System.Drawing.Point(62, 183);
            this.lblBoughtQuarry.Name = "lblBoughtQuarry";
            this.lblBoughtQuarry.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtQuarry.TabIndex = 22;
            this.lblBoughtQuarry.Text = "0x";
            // 
            // lblBoughtFactory
            // 
            this.lblBoughtFactory.AutoSize = true;
            this.lblBoughtFactory.Location = new System.Drawing.Point(63, 144);
            this.lblBoughtFactory.Name = "lblBoughtFactory";
            this.lblBoughtFactory.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtFactory.TabIndex = 21;
            this.lblBoughtFactory.Text = "0x";
            // 
            // lblBoughtDrill
            // 
            this.lblBoughtDrill.AutoSize = true;
            this.lblBoughtDrill.Location = new System.Drawing.Point(63, 106);
            this.lblBoughtDrill.Name = "lblBoughtDrill";
            this.lblBoughtDrill.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtDrill.TabIndex = 20;
            this.lblBoughtDrill.Text = "0x";
            // 
            // lblBoughtWorker
            // 
            this.lblBoughtWorker.AutoSize = true;
            this.lblBoughtWorker.Location = new System.Drawing.Point(63, 67);
            this.lblBoughtWorker.Name = "lblBoughtWorker";
            this.lblBoughtWorker.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtWorker.TabIndex = 19;
            this.lblBoughtWorker.Text = "0x";
            // 
            // pbQuarry
            // 
            this.pbQuarry.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Quarry1;
            this.pbQuarry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbQuarry.Location = new System.Drawing.Point(6, 174);
            this.pbQuarry.Name = "pbQuarry";
            this.pbQuarry.Size = new System.Drawing.Size(32, 32);
            this.pbQuarry.TabIndex = 17;
            this.pbQuarry.TabStop = false;
            // 
            // pbFactory
            // 
            this.pbFactory.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Factory1;
            this.pbFactory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFactory.Location = new System.Drawing.Point(6, 136);
            this.pbFactory.Name = "pbFactory";
            this.pbFactory.Size = new System.Drawing.Size(32, 32);
            this.pbFactory.TabIndex = 16;
            this.pbFactory.TabStop = false;
            // 
            // pbDrill
            // 
            this.pbDrill.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Drill;
            this.pbDrill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDrill.Location = new System.Drawing.Point(6, 98);
            this.pbDrill.Name = "pbDrill";
            this.pbDrill.Size = new System.Drawing.Size(32, 32);
            this.pbDrill.TabIndex = 15;
            this.pbDrill.TabStop = false;
            // 
            // pbWorker
            // 
            this.pbWorker.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.Worker;
            this.pbWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbWorker.Location = new System.Drawing.Point(6, 60);
            this.pbWorker.Name = "pbWorker";
            this.pbWorker.Size = new System.Drawing.Size(32, 32);
            this.pbWorker.TabIndex = 14;
            this.pbWorker.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBoughtQuarryUpg);
            this.groupBox1.Controls.Add(this.lblBoughtFactoryUpg);
            this.groupBox1.Controls.Add(this.lblBoughtDrillUpg);
            this.groupBox1.Controls.Add(this.lblBoughtWorkerUpg);
            this.groupBox1.Controls.Add(this.pbQuarryUpg);
            this.groupBox1.Controls.Add(this.pbFactoryUpg);
            this.groupBox1.Controls.Add(this.pbDrillUpg);
            this.groupBox1.Controls.Add(this.pbWorkerUpg);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 179);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Multipliers";
            // 
            // lblBoughtQuarryUpg
            // 
            this.lblBoughtQuarryUpg.AutoSize = true;
            this.lblBoughtQuarryUpg.Location = new System.Drawing.Point(64, 145);
            this.lblBoughtQuarryUpg.Name = "lblBoughtQuarryUpg";
            this.lblBoughtQuarryUpg.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtQuarryUpg.TabIndex = 23;
            this.lblBoughtQuarryUpg.Text = "0x";
            // 
            // lblBoughtFactoryUpg
            // 
            this.lblBoughtFactoryUpg.AutoSize = true;
            this.lblBoughtFactoryUpg.Location = new System.Drawing.Point(64, 107);
            this.lblBoughtFactoryUpg.Name = "lblBoughtFactoryUpg";
            this.lblBoughtFactoryUpg.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtFactoryUpg.TabIndex = 21;
            this.lblBoughtFactoryUpg.Text = "0x";
            // 
            // lblBoughtDrillUpg
            // 
            this.lblBoughtDrillUpg.AutoSize = true;
            this.lblBoughtDrillUpg.Location = new System.Drawing.Point(63, 68);
            this.lblBoughtDrillUpg.Name = "lblBoughtDrillUpg";
            this.lblBoughtDrillUpg.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtDrillUpg.TabIndex = 22;
            this.lblBoughtDrillUpg.Text = "0x";
            // 
            // lblBoughtWorkerUpg
            // 
            this.lblBoughtWorkerUpg.AutoSize = true;
            this.lblBoughtWorkerUpg.Location = new System.Drawing.Point(63, 30);
            this.lblBoughtWorkerUpg.Name = "lblBoughtWorkerUpg";
            this.lblBoughtWorkerUpg.Size = new System.Drawing.Size(20, 15);
            this.lblBoughtWorkerUpg.TabIndex = 21;
            this.lblBoughtWorkerUpg.Text = "0x";
            // 
            // pbQuarryUpg
            // 
            this.pbQuarryUpg.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.QuarryUpgrade1;
            this.pbQuarryUpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbQuarryUpg.Location = new System.Drawing.Point(6, 136);
            this.pbQuarryUpg.Name = "pbQuarryUpg";
            this.pbQuarryUpg.Size = new System.Drawing.Size(32, 32);
            this.pbQuarryUpg.TabIndex = 17;
            this.pbQuarryUpg.TabStop = false;
            // 
            // pbFactoryUpg
            // 
            this.pbFactoryUpg.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.FactoryUpgrade1;
            this.pbFactoryUpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFactoryUpg.Location = new System.Drawing.Point(6, 98);
            this.pbFactoryUpg.Name = "pbFactoryUpg";
            this.pbFactoryUpg.Size = new System.Drawing.Size(32, 32);
            this.pbFactoryUpg.TabIndex = 16;
            this.pbFactoryUpg.TabStop = false;
            // 
            // pbDrillUpg
            // 
            this.pbDrillUpg.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.DrillUpgrade1;
            this.pbDrillUpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDrillUpg.Location = new System.Drawing.Point(6, 60);
            this.pbDrillUpg.Name = "pbDrillUpg";
            this.pbDrillUpg.Size = new System.Drawing.Size(32, 32);
            this.pbDrillUpg.TabIndex = 15;
            this.pbDrillUpg.TabStop = false;
            // 
            // pbWorkerUpg
            // 
            this.pbWorkerUpg.BackgroundImage = global::AssignmentClickerGame.Properties.Resources.WorkerUpgrade1;
            this.pbWorkerUpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbWorkerUpg.Location = new System.Drawing.Point(6, 22);
            this.pbWorkerUpg.Name = "pbWorkerUpg";
            this.pbWorkerUpg.Size = new System.Drawing.Size(32, 32);
            this.pbWorkerUpg.TabIndex = 14;
            this.pbWorkerUpg.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(93, 406);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 40);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(209, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 173);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxOwnedItems);
            this.Controls.Add(this.grpBxAutoIncome);
            this.Controls.Add(this.btnConsoleRun);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.grpBxUpgradeShop);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblShopPickaxe);
            this.Controls.Add(this.btnShopMenu);
            this.Controls.Add(this.grpBxItemShop);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnBuyPickaxe);
            this.Controls.Add(this.btnMiner);
            this.Controls.Add(this.lblShopError);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placeholder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenConsole_Key);
            this.grpBxItemShop.ResumeLayout(false);
            this.grpBxItemShop.PerformLayout();
            this.grpBxUpgradeShop.ResumeLayout(false);
            this.grpBxUpgradeShop.PerformLayout();
            this.grpBxAutoIncome.ResumeLayout(false);
            this.grpBxAutoIncome.PerformLayout();
            this.grpBxOwnedItems.ResumeLayout(false);
            this.grpBxOwnedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorker)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarryUpg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactoryUpg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrillUpg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkerUpg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMiner;
        private Label lblBalance;
        private GroupBox grpBxItemShop;
        private Button btnBuyPickaxe;
        private Label lblShopError;
        private Button btnBuyWorker;
        private Button btnShopMenu;
        private Label lblShopPickaxe;
        private Label lblShopWorker;
        private Button btnSave;
        private GroupBox grpBxUpgradeShop;
        private Button btnQuarryMultiplier;
        private Button btnFactoryMultiplier;
        private Button btnDrillMultiplier;
        private Button btnWorkerMultiplier;
        private ToolTip ToolTip;
        private Label lblQuarryMultiplier;
        private Label lblDrillMultiplier;
        private Label lblFactoryMultiplier;
        private Label lblWorkerMultiplier;
        private System.Windows.Forms.Timer ProgramTickSpeed;
        private Label lblShopFactory;
        private Label lblShopQuarry;
        private Label lblShopDrill;
        private Button btnBuyFactory;
        private Button btnBuyQuarry;
        private Button btnBuyDrill;
        private System.Windows.Forms.Timer tmrError;
        private TextBox txtConsole;
        private Button btnConsoleRun;
        private Button btnCollectIncome;
        private Label lblAutoIncome;
        private GroupBox grpBxAutoIncome;
        private GroupBox grpBxOwnedItems;
        private Label lblBoughtQuarry;
        private Label lblBoughtFactory;
        private Label lblBoughtDrill;
        private Label lblBoughtWorker;
        private PictureBox pbQuarry;
        private PictureBox pbFactory;
        private PictureBox pbDrill;
        private PictureBox pbWorker;
        private GroupBox groupBox1;
        private Label lblBoughtQuarryUpg;
        private Label lblBoughtFactoryUpg;
        private Label lblBoughtDrillUpg;
        private Label lblBoughtWorkerUpg;
        private PictureBox pbQuarryUpg;
        private PictureBox pbFactoryUpg;
        private PictureBox pbDrillUpg;
        private PictureBox pbWorkerUpg;
        private Button btnLoad;
        private PictureBox pictureBox1;
        private Label lblBoughtPickaxe;
        private PictureBox pictureBox2;
    }
}
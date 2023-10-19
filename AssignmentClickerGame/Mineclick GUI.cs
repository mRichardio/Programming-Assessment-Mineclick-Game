using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace AssignmentClickerGame
{
    public partial class Mineclick : Form
    {
        // Attributes

        Shop shop = new();
        Player player = new();
        Saves save = new();

        public int ErrorMsgTimer = 0;

        // Constructors

        public Mineclick()
        {
            InitializeComponent();
            ToolTips();
            ProgramTickSpeed.Enabled = true;
            txtConsole.Visible = false;
            btnConsoleRun.Visible = false;
            grpBxAutoIncome.Visible = false;  
            grpBxUpgradeShop.Visible = false;
            MenuUI menu = new();
            menu.ShowDialog();

            //Debug.Assert(player.GetBalance() == 0);
            //Debug.Assert(shop.GetPickaxeLevel() == 1);                // These debugs were used during the tesing of my program. 
            //Debug.Assert(ProgramTickSpeed.Enabled == true);          // Some probably wont be valid in its finished state
            //Debug.Assert(btnMiner.Visible && btnMiner.Enabled == true);
        }

        // Events

        private void ProgramTickSpeed_Tick(object sender, EventArgs e) // Tick Speed of the program for updates etc.
        {
            player.PlusAutomatedIncome(shop.GetWorkerAmount()*shop.GetWorkerMultiplier(),
                                       shop.GetDrillAmount()*shop.GetDrillMultiplier(),
                                       shop.GetFactoryAmount()*shop.GetFactoryMultiplier(),
                                       shop.GetQuarryAmount()*shop.GetQuarryMultiplier());
            UpdateBalance();
            UpdateDisplay();
            RemoveShopError();
            WinConditions();
            ShowGameCompleteForm();
        }

        private void btnShopMenu_Click(object sender, EventArgs e) // Opens shop menu
        {
            if (grpBxItemShop.Visible == true)
            {
                grpBxItemShop.Visible = false;
                grpBxUpgradeShop.Visible = false;
            }
            else
            {
                grpBxItemShop.Visible = true;
                if (shop.GetWorkerAmount() >= 1 || shop.GetDrillAmount() >= 1 || shop.GetFactoryAmount() >= 1 || shop.GetQuarryAmount() >= 1)
                {
                    grpBxUpgradeShop.Visible = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) // Writes data to a txt file
        {
            SaveInput saveInput = new();
            saveInput.ShowDialog();
            save.Save(player, shop, saveInput.GetSaveInput());
        }

        private void btnLoad_Click(object sender, EventArgs e) // Loads data from txt file
        {
            LoadSave loadSave = new();
            loadSave.ShowDialog();
            save.LoadSave(player, shop, loadSave.GetSelectedSave());
        }

        private void btnMiner_Click(object sender, EventArgs e) // Clicker
        {
            player.PlusBalance(shop.GetPickaxeLevel());
            UpdateBalance();
        }

        private void btnBuyBetterPickaxe_Click(object sender, EventArgs e) // Buy Pickaxe
        {
            if (player.GetBalance() >= shop.GetPickaxeCost())
            {
                shop.SetPickaxeLevel(shop.GetPickaxeLevel() * 2);
                player.MinusBalance(shop.GetPickaxeCost());
                shop.SetPickaxeCost(shop.GetPickaxeCost() * 2.55f);
            }
            else { DisplayShopError(); }
        }

        private void btnBuyWorker_Click(object sender, EventArgs e) // Buy Worker
        {
            if (player.GetBalance() >= shop.GetWorkerCost())
            {
                shop.SetWorkerAmount(shop.GetDrillAmount() + 1);
                player.MinusBalance(shop.GetWorkerCost());
                shop.SetWorkerCost(shop.GetWorkerCost() * 1.3f);
            }
            else { DisplayShopError(); }
        }

        private void btnBuyDrill_Click(object sender, EventArgs e) // Buy Drill
        {
            if (player.GetBalance() >= shop.GetDrillCost())
            {
                shop.SetDrillAmount(shop.GetDrillAmount() + 1);
                player.MinusBalance(shop.GetPickaxeCost());
                shop.SetDrillCost(shop.GetDrillCost() * 1.3f);
            }
            else { DisplayShopError(); }
        }

        private void btnBuyFactory_Click(object sender, EventArgs e) // Buy Factory
        {
            if (player.GetBalance() >= shop.GetFactoryCost())
            {
                shop.SetFactoryAmount(shop.GetFactoryAmount() + 1);
                player.MinusBalance(shop.GetFactoryCost());
                shop.SetFactoryCost(shop.GetFactoryCost() * 1.3f);
            }
            else { DisplayShopError(); }
        }

        private void btnBuyQuarry_Click(object sender, EventArgs e) // Buy Quarry
        {
            if (player.GetBalance() >= shop.GetDrillCost())
            {
                shop.SetQuarryAmount(shop.GetQuarryAmount() + 1);
                player.MinusBalance(shop.GetQuarryCost());
                shop.SetQuarryCost(shop.GetQuarryCost() * 1.3f);
            }
            else { DisplayShopError(); }
        }

        private void btnUpgProdWorker_Click(object sender, EventArgs e) // Upgrade Production Worker
        {
            if (player.GetBalance() >= shop.GetWorkerMultiplierCost())
            {
                shop.SetWorkerMultiplier(shop.GetWorkerMultiplier() + 0.15f);
                player.MinusBalance(shop.GetWorkerMultiplierCost());
                shop.SetWorkerMultiplierCost(shop.GetWorkerMultiplierCost() * 2.55f);
            }
            else { DisplayShopError(); }
        }

        private void btnUpgProdDrill_Click(object sender, EventArgs e) // Upgrade Production Drill
        {
            if (player.GetBalance() >= shop.GetDrillMultiplierCost())
            {
                shop.SetDrillMultiplier(shop.GetDrillMultiplier() + 0.15f);
                player.MinusBalance(shop.GetDrillMultiplierCost());
                shop.SetDrillMultiplierCost(shop.GetDrillMultiplierCost() * 2.55f);
            }
            else { DisplayShopError(); }
        }

        private void btnUpgProdFactory_Click(object sender, EventArgs e) // Upgrade Production Factory
        {
            if (player.GetBalance() >= shop.GetFactoryMultiplierCost())
            {
                shop.SetFactoryMultiplier(shop.GetFactoryMultiplier() + 0.15f);
                player.MinusBalance(shop.GetFactoryMultiplierCost());
                shop.SetFactoryMultiplierCost(shop.GetFactoryMultiplierCost() * 2.55f);
            }
            else { DisplayShopError(); }
        }

        private void btnUpgProdQuarry_Click(object sender, EventArgs e) // Upgrade Production Quarry
        {
            if (player.GetBalance() >= shop.GetQuarryMultiplierCost())
            {
                shop.SetQuarryMultiplier(shop.GetQuarryMultiplier() + 0.15f);
                player.MinusBalance(shop.GetQuarryMultiplierCost());
                shop.SetQuarryMultiplierCost(shop.GetQuarryMultiplierCost() * 2.55f);
            }
            else { DisplayShopError(); }
        }

        public void OpenConsole_Key(object sender, KeyEventArgs e) // Press PgDn to open up the console // Cheats below vvvvv
        {
            if (e.KeyCode == Keys.PageDown)
            {
                if (txtConsole.Visible == false) { txtConsole.Visible = true; }
                else { txtConsole.Visible = false; }

                if (btnConsoleRun.Visible == false) { btnConsoleRun.Visible = true; }
                else { btnConsoleRun.Visible = false; }
            }    
        }

        public void btnConsoleRun_Click(object sender, EventArgs e)
        {
            if (txtConsole.Text == "givemoney".Trim().ToLower()) // Cheats in 100k
            {
                player.PlusBalance(100000);
                txtConsole.Clear();
                UpdateBalance();
            }
            else if (txtConsole.Text == "letmefinish".Trim().ToLower()) // Cheats in £1mill. Allows you to skip to the end of the game.
            {
                player.PlusBalance(1000000);
                txtConsole.Clear();
                UpdateBalance();
            }
            else { txtConsole.Clear(); }
        }
        private void btnCollectIncome_Click(object sender, EventArgs e)
        {
            player.PlusBalance(player.GetAutomatedIncome());
            player.SetAutomatedIncome(0);
        }

        // Functions

        void ToolTips()
        {
            // REFERNCE: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time?view=netframeworkdesktop-4.8
            ToolTip.SetToolTip(btnBuyWorker, "Buy a worker to automate your income.");
            ToolTip.SetToolTip(btnBuyDrill, "Buy a drill to automate your income.");
            ToolTip.SetToolTip(btnBuyFactory, "Buy a factory to automate your income.");
            ToolTip.SetToolTip(btnBuyQuarry, "Buy a quarry to automate your income.");

            ToolTip.SetToolTip(btnBuyPickaxe, "Make your pickaxe more powerful!");
            ToolTip.SetToolTip(btnWorkerMultiplier, "Increases the productivity of your workers.");
            ToolTip.SetToolTip(btnDrillMultiplier, "Increases the productivity of your drills.");
            ToolTip.SetToolTip(btnFactoryMultiplier, "Increases the productivity of your factories.");
            ToolTip.SetToolTip(btnQuarryMultiplier, "Increases the productivity of your quarries.");

            ToolTip.SetToolTip(btnSave, "Save your progress (If you already have an existing save, enter the name of that save to overwrite it.)");
            ToolTip.SetToolTip(btnLoad, "Load a saved game (Select a save to load from the list.)");
        }

        void UpdateBalance()
        {
            if (player.GetBalance() < 0) // This fixes a strange bug that sets the balance in the negatives
            {
                player.SetBalance(0);
            }

            lblBalance.Text = String.Format("{0:C}", player.GetBalance());
        }

        void DisplayShopError()
        {
            lblShopError.Text = "Insufficient Funds!";
            lblShopError.ForeColor = Color.Red;
            lblShopError.Visible = true;
            tmrError.Enabled = true;
        }

        void RemoveShopError()
        {
            if (lblShopError.Visible == true)
            {
                ErrorMsgTimer++;
                if (ErrorMsgTimer >= 120)
                {
                    lblShopError.Visible = false;
                    ErrorMsgTimer = 0;
                    tmrError.Enabled = false;
                }
            }
        }
        
        void UpdateDisplay() // Updates UI elements
        {
            // Set labels
            lblShopPickaxe.Text = String.Format("{0:C}", shop.GetPickaxeCost());
            lblShopWorker.Text = String.Format("{0:C}", shop.GetWorkerCost());
            lblShopDrill.Text = String.Format("{0:C}", shop.GetDrillCost());
            lblShopFactory.Text = String.Format("{0:C}", shop.GetFactoryCost());
            lblShopQuarry.Text = String.Format("{0:C}", shop.GetQuarryCost());

            lblBoughtPickaxe.Text = $"{shop.GetPickaxeLevel()}x";
            lblBoughtWorker.Text = $"{shop.GetWorkerAmount()}x";
            lblBoughtDrill.Text = $"{shop.GetDrillAmount()}x";
            lblBoughtFactory.Text = $"{shop.GetFactoryAmount()}x";
            lblBoughtQuarry.Text = $"{shop.GetQuarryAmount()}x";

            lblBoughtWorkerUpg.Text = String.Format("{0:0.00}x", shop.GetWorkerMultiplier());
            lblBoughtDrillUpg.Text = String.Format("{0:0.00}x", shop.GetDrillMultiplier());
            lblBoughtFactoryUpg.Text = String.Format("{0:0.00}x", shop.GetFactoryMultiplier());
            lblBoughtQuarryUpg.Text = String.Format("{0:0.00}x", shop.GetQuarryMultiplier());

            lblWorkerMultiplier.Text = String.Format("{0:C}", shop.GetWorkerMultiplierCost());
            lblFactoryMultiplier.Text = String.Format("{0:C}", shop.GetDrillMultiplierCost());
            lblDrillMultiplier.Text = String.Format("{0:C}", shop.GetFactoryMultiplierCost());
            lblQuarryMultiplier.Text = String.Format("{0:C}", shop.GetQuarryMultiplierCost());

            lblAutoIncome.Text = String.Format("{0:C}", player.GetAutomatedIncome());

            // Displays item income collection
            if (shop.GetWorkerAmount() >= 1 || shop.GetDrillAmount() >= 1 || shop.GetFactoryAmount() >= 1 || shop.GetQuarryAmount() >= 1)
            {
                grpBxAutoIncome.Visible = true;
                if (grpBxItemShop.Visible == true) { grpBxUpgradeShop.Visible = true; } // This fixes a bug that would prevent the upgrade shop from appearing unless the shop was closed and re-opened.   
            }

            // Changes upgrades between grayscale and normal images
            if (shop.GetWorkerAmount() <= 0) { btnWorkerMultiplier.BackgroundImage = Properties.Resources.workerUpGray; }
            else { btnWorkerMultiplier.BackgroundImage = Properties.Resources.WorkerUpgrade; }

            if (shop.GetDrillAmount() <= 0) { btnDrillMultiplier.BackgroundImage = Properties.Resources.drillUpGray; }
            else { btnDrillMultiplier.BackgroundImage = Properties.Resources.DrillUpgrade; }

            if (shop.GetFactoryAmount() <= 0) { btnFactoryMultiplier.BackgroundImage = Properties.Resources.factoryUpGray; }
            else { btnFactoryMultiplier.BackgroundImage = Properties.Resources.FactoryUpgrade; }

            if (shop.GetQuarryAmount() <= 0) { btnQuarryMultiplier.BackgroundImage = Properties.Resources.quarryUpGray; }
            else { btnQuarryMultiplier.BackgroundImage = Properties.Resources.QuarryUpgrade; }

            // Disable/Enable upgrades based on owned item
            if (shop.GetWorkerAmount() >= 1) { btnWorkerMultiplier.Enabled = true; } else btnWorkerMultiplier.Enabled = false;
            if (shop.GetDrillAmount() >= 1) { btnDrillMultiplier.Enabled = true; } else btnDrillMultiplier.Enabled = false;
            if (shop.GetWorkerAmount() >= 1) { btnFactoryMultiplier.Enabled = true; } else btnFactoryMultiplier.Enabled = false;
            if (shop.GetWorkerAmount() >= 1) { btnQuarryMultiplier.Enabled = true; } else btnQuarryMultiplier.Enabled = false;
        }

        public bool WinConditions() // Function for setting when the game ends
        {
            if (player.GetBalance() >= 1000000)
            {
                return true;
            }
            else return false;
        }

        public void ShowGameCompleteForm() // Shows the game complete screen
        {
            if (WinConditions() == true)
            {
                ProgramTickSpeed.Enabled = false;    
                GameCompleteUI GCUI = new();
                GCUI.ShowDialog();
            }
        }
    }
}
    

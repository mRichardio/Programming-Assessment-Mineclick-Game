using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClickerGame
{
    internal class Saves
    {
        // Functions
        public void Save(Player player, Shop shop, string saveName)
        {
                List<string> lines = new();

                lines.Add(player.GetBalance().ToString());
                lines.Add(player.GetAutomatedIncome().ToString());

                lines.Add(shop.GetPickaxeLevel().ToString());
                lines.Add(shop.GetWorkerAmount().ToString());
                lines.Add(shop.GetDrillAmount().ToString());
                lines.Add(shop.GetFactoryAmount().ToString());
                lines.Add(shop.GetQuarryAmount().ToString());

                lines.Add(shop.GetPickaxeCost().ToString());
                lines.Add(shop.GetWorkerCost().ToString());
                lines.Add(shop.GetDrillCost().ToString());
                lines.Add(shop.GetFactoryCost().ToString());
                lines.Add(shop.GetQuarryCost().ToString());

                lines.Add(shop.GetWorkerMultiplier().ToString());
                lines.Add(shop.GetDrillMultiplier().ToString());
                lines.Add(shop.GetFactoryMultiplier().ToString());
                lines.Add(shop.GetQuarryMultiplier().ToString());

                lines.Add(shop.GetWorkerMultiplierCost().ToString());
                lines.Add(shop.GetDrillMultiplierCost().ToString());
                lines.Add(shop.GetFactoryMultiplierCost().ToString());
                lines.Add(shop.GetQuarryMultiplierCost().ToString());

                File.WriteAllLines($"{saveName}.txt", lines); 
        }

        public void LoadSave(Player player, Shop shop, string selectedSave)
        {
            if (File.Exists(selectedSave))
            {
                List<string> lines = File.ReadAllLines(selectedSave).ToList();

                player.SetBalance(Convert.ToSingle(lines[0]));
                player.SetAutomatedIncome(Convert.ToSingle(lines[1]));

                shop.SetPickaxeLevel(Convert.ToSingle(lines[2]));
                shop.SetWorkerAmount(Convert.ToSingle(lines[3]));
                shop.SetDrillAmount(Convert.ToSingle(lines[4]));
                shop.SetFactoryAmount(Convert.ToSingle(lines[5]));
                shop.SetQuarryAmount(Convert.ToSingle(lines[6]));

                shop.SetPickaxeCost(Convert.ToSingle(lines[7]));
                shop.SetWorkerCost(Convert.ToSingle(lines[8]));
                shop.SetDrillCost(Convert.ToSingle(lines[9]));
                shop.SetFactoryCost(Convert.ToSingle(lines[10]));
                shop.SetQuarryCost(Convert.ToSingle(lines[11]));

                shop.SetWorkerMultiplier(Convert.ToSingle(lines[12]));
                shop.SetDrillMultiplier(Convert.ToSingle(lines[13]));
                shop.SetFactoryMultiplier(Convert.ToSingle(lines[14]));
                shop.SetQuarryMultiplier(Convert.ToSingle(lines[15]));

                shop.SetWorkerMultiplierCost(Convert.ToSingle(lines[16]));
                shop.SetDrillMultiplierCost(Convert.ToSingle(lines[17]));
                shop.SetFactoryMultiplierCost(Convert.ToSingle(lines[18]));
                shop.SetQuarryMultiplierCost(Convert.ToSingle(lines[19]));
            }
        }
    }
}

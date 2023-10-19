using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;

namespace AssignmentClickerGame
{
    class Shop
    {
        // Attributes

        // Pickaxe
        private float pickaxeLevel = 1;
        private float pickaxeCost = 75;


        // Worker
        private float workerAmount = 0;
        private float workerCost = 650;

        // Drill
        private float drillAmount = 0; 
        private float drillCost = 3500;

        // Factory
        private float factoryAmount = 0;
        private float factoryCost = 7500;

        // Quarry
        private float quarryAmount = 0;
        private float quarryCost = 15000;

        // Worker
        private float workerMultiplier = 1;
        private float workerMultiplierCost = 450;

        // Drill
        private float drillMultiplier = 1.3f;
        private float drillMultiplierCost = 1500;

        // Factory
        private float factoryMultiplier = 1.5f;
        private float factoryMultiplierCost = 4500;

        // Quarry
        private float quarryMultiplier = 2;
        private float quarryMultiplierCost = 10000;


        // Functions

        // Setters

        // Pickaxe
        public float SetPickaxeLevel(float newPickaxeLevel) { return pickaxeLevel = newPickaxeLevel; }
        public float SetPickaxeCost(float newPickaxeCost) { return pickaxeCost = newPickaxeCost; }

        // Worker
        public float SetWorkerAmount(float newWorkerAmount) { return workerAmount = newWorkerAmount; }
        public float SetWorkerCost(float newWorkerCost) { return workerCost = newWorkerCost; }
        public float SetWorkerMultiplier(float newValue) { return workerMultiplier = newValue; }
        public float SetWorkerMultiplierCost(float newValue) { return workerMultiplierCost = newValue; }

        // Drill
        public float SetDrillAmount(float newDrillAmount) { return drillAmount = newDrillAmount; }
        public float SetDrillCost(float newDrillCost) { return drillCost = newDrillCost; }
        public float SetDrillMultiplier(float newValue) { return drillMultiplier = newValue; }
        public float SetDrillMultiplierCost(float newValue) { return drillMultiplierCost = newValue; }

        // Factory
        public float SetFactoryAmount(float newFactoryAmount) { return factoryAmount = newFactoryAmount; }
        public float SetFactoryCost(float newFactoryCost) { return factoryCost = newFactoryCost; }
        public float SetFactoryMultiplier(float newValue) { return factoryMultiplier = newValue; }
        public float SetFactoryMultiplierCost(float newValue) { return factoryMultiplierCost = newValue; }

        // Quarry
        public float SetQuarryAmount(float newQuarryAmount) { return quarryAmount = newQuarryAmount; }
        public float SetQuarryCost(float newQuarryCost) { return quarryCost = newQuarryCost; }
        public float SetQuarryMultiplier(float newValue) { return quarryMultiplier = newValue; }
        public float SetQuarryMultiplierCost(float newValue) { return quarryMultiplierCost = newValue; }

        // Getters

        // Pickaxe
        public float GetPickaxeLevel() { return pickaxeLevel; }
        public float GetPickaxeCost() { return pickaxeCost; }

        // Worker
        public float GetWorkerAmount() { return workerAmount; }
        public float GetWorkerCost() { return workerCost; }
        public float GetWorkerMultiplier() { return workerMultiplier; }
        public float GetWorkerMultiplierCost() { return workerMultiplierCost; }

        // Drill
        public float GetDrillAmount() { return drillAmount; }
        public float GetDrillCost() { return drillCost; }
        public float GetDrillMultiplier() { return drillMultiplier; }
        public float GetDrillMultiplierCost() { return drillMultiplierCost; }

        // Factory
        public float GetFactoryAmount() { return factoryAmount; }
        public float GetFactoryCost() { return factoryCost; }
        public float GetFactoryMultiplier() { return factoryMultiplier; }
        public float GetFactoryMultiplierCost() { return factoryMultiplierCost; }

        // Quarry
        public float GetQuarryAmount() { return quarryAmount; }
        public float GetQuarryCost() { return quarryCost; }
        public float GetQuarryMultiplier() { return quarryMultiplier; }
        public float GetQuarryMultiplierCost() { return quarryMultiplierCost; }


        public float IncreaseWorkerAmount(float multiplier) { return workerAmount += multiplier; }
    }
}

using System.Numerics;
using System.Security.Policy;

namespace AssignmentClickerGame
{
    public class Player
    {
        // Data

        private float balance = 0;
        private float automatedIncome = 0;

        // Functions

        //    =====| SETTERS |=====     

        public float SetBalance(float newBalance) { return balance = newBalance; }
        public float SetAutomatedIncome(float newAutomatedIncome) { return automatedIncome = newAutomatedIncome; }   

        //    =====| GETTERS |=====

        public float GetBalance() { return balance; }
        public float GetAutomatedIncome() { return automatedIncome; }   

        //     =====| OPERATORS |=====

        public void PlusBalance(float value) { balance += value; }
        public float PlusAutomatedIncome(float item1, float item2, float item3, float item4) { return automatedIncome += item1 + item2 + item3 + item4; }
        public float MinusBalance(float mb) { return balance -= mb; }
     }
}

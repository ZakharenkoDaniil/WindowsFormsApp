using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp
{
    class Artifact
    {
        private string name;
        private int hpPercentage;
        private int attackPercentage;
        private int defensePercentage;
        private double cost;
        public Artifact()
        {
            this.name = "";
            this.hpPercentage = 0;
            this.attackPercentage = 0;
            this.defensePercentage = 0;
            this.cost = 0;
        }
        public double getHpImpact(double heroHpValue)
        {
            return heroHpValue * this.hpPercentage / 100.0;
        }
        public double getAttackImpact(double heroAttackValue)
        {
            return heroAttackValue * this.attackPercentage / 100.0;
        }
        public double getDefenseImpact(double heroDefenseValue)
        {
            return heroDefenseValue * this.defensePercentage / 100.0;
        }
        public double getCostWithDiscount(double discountValue)
        {
            return this.cost * (100.0 - discountValue) / 100.0;
        }
        
        //Get methods
        public string getName()
        {
            return name;
        }
        public int getHpPercentage()
        {
            return this.hpPercentage;
        }
        public int getAttackPercentage()
        {
            return this.attackPercentage;
        }
        public int getDefensePercentage()
        {
            return this.defensePercentage;
        }
        public double getCost()
        {
            return this.cost;
        }
        
        //Set methods
        public void setName(string name)
        {
            this.name = name;
        }
        public void setHpPercentage(int hpPercentage)
        {
            this.hpPercentage = hpPercentage;
        }
        public void setAttackPercentage(int attackPercentage)
        {
            this.attackPercentage = attackPercentage;
        }
        public void setDefensePercentage(int defensePercentage)
        {
            this.defensePercentage = defensePercentage;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }
    }
}

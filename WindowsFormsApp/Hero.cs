using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp
{
    class Hero
    {
        private double hp;
        private double attack;
        private double defense;
        private double cost;

        public Hero()
        {
            hp = 0.0;
            attack = 0.0;
            defense = 0.0;
            cost = 0.0;
        }

        //Get methods
        public double getHp()
        {
            return this.hp;
        }
        public double getAttack()
        {
            return this.attack;
        }
        public double getDefense()
        {
            return this.defense;
        }
        public double getCost()
        {
            return this.cost;
        }
        
        //Set methods
        public void setHp(double hp)
        {
            this.hp = hp;
        }
        public void setAttack(double attack)
        {
            this.attack = attack;
        }
        public void setDefense(double defense)
        {
            this.defense = defense;
        }
        public void setCost(double cost)
        {
            this.cost = cost;
        }

    }
}

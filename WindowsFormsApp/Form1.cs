using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Hero hero;
        private Artifact artifact_1;
        private Artifact artifact_2;
        public Form1()
        {
            this.hero = new Hero();
            this.artifact_1 = new Artifact();
            this.artifact_2 = new Artifact();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hp1plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.hpValue1.Text);
            value++;
            this.hpValue1.Text = value.ToString();
        }

        private void hp1minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.hpValue1.Text);
            value--;
            this.hpValue1.Text = value.ToString();
        }

        private void hp1save_Click(object sender, EventArgs e)
        {
            this.artifact_1.setHpPercentage(int.Parse(this.hpValue1.Text));
            this.hpValue1.Enabled = false;
            this.hp1plus.Enabled = false;
            this.hp1minus.Enabled = false;
            this.hp1save.Enabled = false;
        }

        private void hp2plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.hpValue2.Text);
            value++;
            this.hpValue2.Text = value.ToString();
        }

        private void hp2minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.hpValue2.Text);
            value--;
            this.hpValue2.Text = value.ToString();
        }

        private void hp2save_Click(object sender, EventArgs e)
        {
            this.artifact_2.setHpPercentage(int.Parse(this.hpValue2.Text));
            this.hpValue2.Enabled = false;
            this.hp2plus.Enabled = false;
            this.hp2minus.Enabled = false;
            this.hp2save.Enabled = false;
        }

        private void attack1plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.attackValue1.Text);
            value++;
            this.attackValue1.Text = value.ToString();
        }

        private void attack1minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.attackValue1.Text);
            value--;
            this.attackValue1.Text = value.ToString();
        }

        private void attack1save_Click(object sender, EventArgs e)
        {
            this.artifact_1.setAttackPercentage(int.Parse(this.attackValue1.Text));
            this.attackValue1.Enabled = false;
            this.attack1plus.Enabled = false;
            this.attack1minus.Enabled = false;
            this.attack1save.Enabled = false;
        }
        
        private void attack2plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.attackValue2.Text);
            value++;
            this.attackValue2.Text = value.ToString();
        }

        private void attack2minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.attackValue2.Text);
            value--;
            this.attackValue2.Text = value.ToString();
        }

        private void attack2save_Click(object sender, EventArgs e)
        {
            this.artifact_2.setAttackPercentage(int.Parse(this.attackValue2.Text));
            this.attackValue2.Enabled = false;
            this.attack2plus.Enabled = false;
            this.attack2minus.Enabled = false;
            this.attack2save.Enabled = false;
        }

        private void defense1plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.defenseValue1.Text);
            value++;
            this.defenseValue1.Text = value.ToString();
        }

        private void defense1minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.defenseValue1.Text);
            value--;
            this.defenseValue1.Text = value.ToString();
        }

        private void defense1save_Click(object sender, EventArgs e)
        {
            this.artifact_1.setDefensePercentage(int.Parse(this.defenseValue1.Text));
            this.defenseValue1.Enabled = false;
            this.defense1plus.Enabled = false;
            this.defense1minus.Enabled = false;
            this.defense1save.Enabled = false;
        }

        private void defense2plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.defenseValue2.Text);
            value++;
            this.defenseValue2.Text = value.ToString();
        }

        private void defense2minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.defenseValue2.Text);
            value--;
            this.defenseValue2.Text = value.ToString();
        }

        private void defense2save_Click(object sender, EventArgs e)
        {
            this.artifact_2.setDefensePercentage(int.Parse(this.defenseValue2.Text));
            this.defenseValue2.Enabled = false;
            this.defense2plus.Enabled = false;
            this.defense2minus.Enabled = false;
            this.defense2save.Enabled = false;
        }

        private void cost1plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.costValue1.Text);
            value++;
            this.costValue1.Text = value.ToString();
        }

        private void cost1minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.costValue1.Text);
            value--;
            this.costValue1.Text = value.ToString();
        }

        private void cost1save_Click(object sender, EventArgs e)
        {
            this.artifact_1.setCost(int.Parse(this.costValue1.Text));
            this.costValue1.Enabled = false;
            this.cost1plus.Enabled = false;
            this.cost1minus.Enabled = false;
            this.cost1save.Enabled = false;
        }

        private void cost2plus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.costValue2.Text);
            value++;
            this.costValue2.Text = value.ToString();
        }

        private void cost2minus_Click(object sender, EventArgs e)
        {
            int value = int.Parse(this.costValue2.Text);
            value--;
            this.costValue2.Text = value.ToString();
        }

        private void cost2save_Click(object sender, EventArgs e)
        {
            this.artifact_2.setCost(int.Parse(this.costValue2.Text));
            this.costValue2.Enabled = false;
            this.cost2plus.Enabled = false;
            this.cost2minus.Enabled = false;
            this.cost2save.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.hero.setHp(double.Parse(this.hpValue.Text));
            this.hero.setAttack(double.Parse(this.attackValue.Text));
            this.hero.setDefense(double.Parse(this.defenseValue.Text));
            this.hero.setCost(double.Parse(this.costValue.Text));
            this.hpValue.Enabled = false;
            this.attackValue.Enabled = false;
            this.defenseValue.Enabled = false;
            this.costValue.Enabled = false;
            this.save.Enabled = false;
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            this.buy1.Enabled = false;
            this.buy2.Enabled = false;
            this.hero.setHp(this.hero.getHp()+this.artifact_1.getHpImpact(this.hero.getHp()));
            this.hero.setAttack(this.hero.getAttack() + this.artifact_1.getAttackImpact(this.hero.getAttack()));
            this.hero.setDefense(this.hero.getDefense() + this.artifact_1.getDefenseImpact(this.hero.getDefense()));
            this.hero.setCost(this.hero.getCost()-this.artifact_1.getCostWithDiscount(0.0));
            //Output info of a hero
            this.hpValue.Text = this.hero.getHp().ToString();
            this.attackValue.Text = this.hero.getAttack().ToString();
            this.defenseValue.Text = this.hero.getDefense().ToString();
            this.costValue.Text = this.hero.getCost().ToString();
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            this.buy1.Enabled = false;
            this.buy2.Enabled = false;
            this.hero.setHp(this.hero.getHp() + this.artifact_2.getHpImpact(this.hero.getHp()));
            this.hero.setAttack(this.hero.getAttack() + this.artifact_2.getAttackImpact(this.hero.getAttack()));
            this.hero.setDefense(this.hero.getDefense() + this.artifact_2.getDefenseImpact(this.hero.getDefense()));
            this.hero.setCost(this.hero.getCost() - this.artifact_2.getCostWithDiscount(0.0));
            //Output info of a hero
            this.hpValue.Text = this.hero.getHp().ToString();
            this.attackValue.Text = this.hero.getAttack().ToString();
            this.defenseValue.Text = this.hero.getDefense().ToString();
            this.costValue.Text = this.hero.getCost().ToString();
        }

        private void name1save_Click(object sender, EventArgs e)
        {
            this.artifact_1.setName(this.artefact1Name.Text);
            this.name1save.Enabled = false;
        }

        private void name2save_Click(object sender, EventArgs e)
        {
            this.artifact_2.setName(this.artefact2Name.Text);
            this.name2save.Enabled = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.hpValue.Text = "0";
            this.hpValue.Enabled = true;
            this.attackValue.Text = "0";
            this.attackValue.Enabled = true;
            this.defenseValue.Text = "0";
            this.defenseValue.Enabled = true;
            this.costValue.Text = "0";
            this.costValue.Enabled = true;

            this.artefact1Name.Text = "";
            this.artefact1Name.Enabled = true;
            this.hpValue1.Text = "0";
            this.hpValue1.Enabled = true;
            this.attackValue1.Text = "0";
            this.attackValue1.Enabled = true;
            this.defenseValue1.Text = "0";
            this.defenseValue1.Enabled = true;
            this.costValue1.Text = "0";
            this.costValue1.Enabled = true;

            this.artefact2Name.Text = "";
            this.artefact2Name.Enabled = true;
            this.hpValue2.Text = "0";
            this.hpValue2.Enabled = true;
            this.attackValue2.Text = "0";
            this.attackValue2.Enabled = true;
            this.defenseValue2.Text = "0";
            this.defenseValue2.Enabled = true;
            this.costValue2.Text = "0";
            this.costValue2.Enabled = true;

            this.save.Enabled = true;

            this.name1save.Enabled = true;
            this.hp1plus.Enabled = true;
            this.hp1minus.Enabled = true;
            this.hp1save.Enabled = true;
            this.attack1plus.Enabled = true;
            this.attack1minus.Enabled = true;
            this.attack1save.Enabled = true;
            this.defense1plus.Enabled = true;
            this.defense1minus.Enabled = true;
            this.defense1save.Enabled = true;
            this.cost1plus.Enabled = true;
            this.cost1minus.Enabled = true;
            this.cost1save.Enabled = true;
            this.buy1.Enabled = true;

            this.name2save.Enabled = true;
            this.hp2plus.Enabled = true;
            this.hp2minus.Enabled = true;
            this.hp2save.Enabled = true;
            this.attack2plus.Enabled = true;
            this.attack2minus.Enabled = true;
            this.attack2save.Enabled = true;
            this.defense2plus.Enabled = true;
            this.defense2minus.Enabled = true;
            this.defense2save.Enabled = true;
            this.cost2plus.Enabled = true;
            this.cost2minus.Enabled = true;
            this.cost2save.Enabled = true;
            this.buy2.Enabled = true;
        }
    }
}

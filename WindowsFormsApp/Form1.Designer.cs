using System;

namespace WindowsFormsApp
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.artifact1 = new System.Windows.Forms.Label();
            this.artifact2 = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpLabel1 = new System.Windows.Forms.Label();
            this.hpLabel2 = new System.Windows.Forms.Label();
            this.hpValue = new System.Windows.Forms.TextBox();
            this.hpValue1 = new System.Windows.Forms.TextBox();
            this.hpValue2 = new System.Windows.Forms.TextBox();
            this.attackLabel = new System.Windows.Forms.Label();
            this.attackLabel1 = new System.Windows.Forms.Label();
            this.attackLabel2 = new System.Windows.Forms.Label();
            this.attackValue = new System.Windows.Forms.TextBox();
            this.attackValue1 = new System.Windows.Forms.TextBox();
            this.attackValue2 = new System.Windows.Forms.TextBox();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.defenseLabel1 = new System.Windows.Forms.Label();
            this.defenseLabel2 = new System.Windows.Forms.Label();
            this.defenseValue = new System.Windows.Forms.TextBox();
            this.defenseValue1 = new System.Windows.Forms.TextBox();
            this.defenseValue2 = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.costLabel2 = new System.Windows.Forms.Label();
            this.costValue = new System.Windows.Forms.TextBox();
            this.costValue1 = new System.Windows.Forms.TextBox();
            this.costValue2 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.buy1 = new System.Windows.Forms.Button();
            this.buy2 = new System.Windows.Forms.Button();
            this.hp1plus = new System.Windows.Forms.Button();
            this.hp1minus = new System.Windows.Forms.Button();
            this.hp1save = new System.Windows.Forms.Button();
            this.attack1save = new System.Windows.Forms.Button();
            this.attack1plus = new System.Windows.Forms.Button();
            this.attack1minus = new System.Windows.Forms.Button();
            this.defense1save = new System.Windows.Forms.Button();
            this.defense1plus = new System.Windows.Forms.Button();
            this.defense1minus = new System.Windows.Forms.Button();
            this.cost1save = new System.Windows.Forms.Button();
            this.cost1plus = new System.Windows.Forms.Button();
            this.cost1minus = new System.Windows.Forms.Button();
            this.hp2save = new System.Windows.Forms.Button();
            this.hp2plus = new System.Windows.Forms.Button();
            this.hp2minus = new System.Windows.Forms.Button();
            this.attack2save = new System.Windows.Forms.Button();
            this.attack2plus = new System.Windows.Forms.Button();
            this.attack2minus = new System.Windows.Forms.Button();
            this.defense2save = new System.Windows.Forms.Button();
            this.defense2plus = new System.Windows.Forms.Button();
            this.defense2minus = new System.Windows.Forms.Button();
            this.cost2save = new System.Windows.Forms.Button();
            this.cost2plus = new System.Windows.Forms.Button();
            this.cost2minus = new System.Windows.Forms.Button();
            this.artefact1Name = new System.Windows.Forms.TextBox();
            this.artefact2Name = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.name1save = new System.Windows.Forms.Button();
            this.name2save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(492, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Hero";
            // 
            // artifact1
            // 
            this.artifact1.AutoSize = true;
            this.artifact1.Location = new System.Drawing.Point(669, 30);
            this.artifact1.Name = "artifact1";
            this.artifact1.Size = new System.Drawing.Size(39, 15);
            this.artifact1.TabIndex = 14;
            this.artifact1.Text = "Name";
            // 
            // artifact2
            // 
            this.artifact2.AutoSize = true;
            this.artifact2.Location = new System.Drawing.Point(1062, 30);
            this.artifact2.Name = "artifact2";
            this.artifact2.Size = new System.Drawing.Size(39, 15);
            this.artifact2.TabIndex = 23;
            this.artifact2.Text = "Name";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(410, 64);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(23, 15);
            this.hpLabel.TabIndex = 5;
            this.hpLabel.Text = "HP";
            // 
            // hpLabel1
            // 
            this.hpLabel1.AutoSize = true;
            this.hpLabel1.Location = new System.Drawing.Point(685, 64);
            this.hpLabel1.Name = "hpLabel1";
            this.hpLabel1.Size = new System.Drawing.Size(23, 15);
            this.hpLabel1.TabIndex = 15;
            this.hpLabel1.Text = "HP";
            // 
            // hpLabel2
            // 
            this.hpLabel2.AutoSize = true;
            this.hpLabel2.Location = new System.Drawing.Point(1078, 69);
            this.hpLabel2.Name = "hpLabel2";
            this.hpLabel2.Size = new System.Drawing.Size(23, 15);
            this.hpLabel2.TabIndex = 24;
            this.hpLabel2.Text = "HP";
            // 
            // hpValue
            // 
            this.hpValue.Location = new System.Drawing.Point(465, 61);
            this.hpValue.Name = "hpValue";
            this.hpValue.Size = new System.Drawing.Size(100, 23);
            this.hpValue.TabIndex = 0;
            this.hpValue.Text = "0";
            // 
            // hpValue1
            // 
            this.hpValue1.Location = new System.Drawing.Point(724, 61);
            this.hpValue1.Name = "hpValue1";
            this.hpValue1.Size = new System.Drawing.Size(100, 23);
            this.hpValue1.TabIndex = 30;
            this.hpValue1.Text = "0";
            // 
            // hpValue2
            // 
            this.hpValue2.Location = new System.Drawing.Point(1118, 61);
            this.hpValue2.Name = "hpValue2";
            this.hpValue2.Size = new System.Drawing.Size(100, 23);
            this.hpValue2.TabIndex = 34;
            this.hpValue2.Text = "0";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(392, 108);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(41, 15);
            this.attackLabel.TabIndex = 6;
            this.attackLabel.Text = "Attack";
            // 
            // attackLabel1
            // 
            this.attackLabel1.AutoSize = true;
            this.attackLabel1.Location = new System.Drawing.Point(667, 108);
            this.attackLabel1.Name = "attackLabel1";
            this.attackLabel1.Size = new System.Drawing.Size(41, 15);
            this.attackLabel1.TabIndex = 16;
            this.attackLabel1.Text = "Attack";
            // 
            // attackLabel2
            // 
            this.attackLabel2.AutoSize = true;
            this.attackLabel2.Location = new System.Drawing.Point(1060, 108);
            this.attackLabel2.Name = "attackLabel2";
            this.attackLabel2.Size = new System.Drawing.Size(41, 15);
            this.attackLabel2.TabIndex = 25;
            this.attackLabel2.Text = "Attack";
            // 
            // attackValue
            // 
            this.attackValue.Location = new System.Drawing.Point(465, 105);
            this.attackValue.Name = "attackValue";
            this.attackValue.Size = new System.Drawing.Size(100, 23);
            this.attackValue.TabIndex = 2;
            this.attackValue.Text = "0";
            // 
            // attackValue1
            // 
            this.attackValue1.Location = new System.Drawing.Point(724, 105);
            this.attackValue1.Name = "attackValue1";
            this.attackValue1.Size = new System.Drawing.Size(100, 23);
            this.attackValue1.TabIndex = 31;
            this.attackValue1.Text = "0";
            // 
            // attackValue2
            // 
            this.attackValue2.Location = new System.Drawing.Point(1118, 105);
            this.attackValue2.Name = "attackValue2";
            this.attackValue2.Size = new System.Drawing.Size(100, 23);
            this.attackValue2.TabIndex = 35;
            this.attackValue2.Text = "0";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(383, 155);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(49, 15);
            this.defenseLabel.TabIndex = 7;
            this.defenseLabel.Text = "Defense";
            // 
            // defenseLabel1
            // 
            this.defenseLabel1.AutoSize = true;
            this.defenseLabel1.Location = new System.Drawing.Point(659, 155);
            this.defenseLabel1.Name = "defenseLabel1";
            this.defenseLabel1.Size = new System.Drawing.Size(49, 15);
            this.defenseLabel1.TabIndex = 17;
            this.defenseLabel1.Text = "Defense";
            // 
            // defenseLabel2
            // 
            this.defenseLabel2.AutoSize = true;
            this.defenseLabel2.Location = new System.Drawing.Point(1052, 155);
            this.defenseLabel2.Name = "defenseLabel2";
            this.defenseLabel2.Size = new System.Drawing.Size(49, 15);
            this.defenseLabel2.TabIndex = 26;
            this.defenseLabel2.Text = "Defense";
            // 
            // defenseValue
            // 
            this.defenseValue.Location = new System.Drawing.Point(465, 152);
            this.defenseValue.Name = "defenseValue";
            this.defenseValue.Size = new System.Drawing.Size(100, 23);
            this.defenseValue.TabIndex = 3;
            this.defenseValue.Text = "0";
            // 
            // defenseValue1
            // 
            this.defenseValue1.Location = new System.Drawing.Point(724, 152);
            this.defenseValue1.Name = "defenseValue1";
            this.defenseValue1.Size = new System.Drawing.Size(100, 23);
            this.defenseValue1.TabIndex = 32;
            this.defenseValue1.Text = "0";
            // 
            // defenseValue2
            // 
            this.defenseValue2.Location = new System.Drawing.Point(1118, 152);
            this.defenseValue2.Name = "defenseValue2";
            this.defenseValue2.Size = new System.Drawing.Size(100, 23);
            this.defenseValue2.TabIndex = 36;
            this.defenseValue2.Text = "0";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(402, 207);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 15);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost";
            // 
            // costLabel1
            // 
            this.costLabel1.AutoSize = true;
            this.costLabel1.Location = new System.Drawing.Point(670, 207);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(31, 15);
            this.costLabel1.TabIndex = 61;
            this.costLabel1.Text = "Cost";
            // 
            // costLabel2
            // 
            this.costLabel2.AutoSize = true;
            this.costLabel2.Location = new System.Drawing.Point(1070, 207);
            this.costLabel2.Name = "costLabel2";
            this.costLabel2.Size = new System.Drawing.Size(31, 15);
            this.costLabel2.TabIndex = 27;
            this.costLabel2.Text = "Cost";
            // 
            // costValue
            // 
            this.costValue.Location = new System.Drawing.Point(465, 204);
            this.costValue.Name = "costValue";
            this.costValue.Size = new System.Drawing.Size(100, 23);
            this.costValue.TabIndex = 4;
            this.costValue.Text = "0";
            // 
            // costValue1
            // 
            this.costValue1.Location = new System.Drawing.Point(724, 204);
            this.costValue1.Name = "costValue1";
            this.costValue1.Size = new System.Drawing.Size(100, 23);
            this.costValue1.TabIndex = 33;
            this.costValue1.Text = "0";
            // 
            // costValue2
            // 
            this.costValue2.Location = new System.Drawing.Point(1118, 204);
            this.costValue2.Name = "costValue2";
            this.costValue2.Size = new System.Drawing.Size(100, 23);
            this.costValue2.TabIndex = 37;
            this.costValue2.Text = "0";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(478, 255);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // buy1
            // 
            this.buy1.Location = new System.Drawing.Point(749, 255);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(75, 23);
            this.buy1.TabIndex = 28;
            this.buy1.Text = "buy";
            this.buy1.UseVisualStyleBackColor = true;
            this.buy1.Click += new System.EventHandler(this.buy1_Click);
            // 
            // buy2
            // 
            this.buy2.Location = new System.Drawing.Point(1131, 255);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(75, 23);
            this.buy2.TabIndex = 29;
            this.buy2.Text = "buy";
            this.buy2.UseVisualStyleBackColor = true;
            this.buy2.Click += new System.EventHandler(this.buy2_Click);
            // 
            // hp1plus
            // 
            this.hp1plus.Location = new System.Drawing.Point(839, 61);
            this.hp1plus.Name = "hp1plus";
            this.hp1plus.Size = new System.Drawing.Size(26, 23);
            this.hp1plus.TabIndex = 38;
            this.hp1plus.Text = "+";
            this.hp1plus.UseVisualStyleBackColor = true;
            this.hp1plus.Click += new System.EventHandler(this.hp1plus_Click);
            // 
            // hp1minus
            // 
            this.hp1minus.Location = new System.Drawing.Point(871, 60);
            this.hp1minus.Name = "hp1minus";
            this.hp1minus.Size = new System.Drawing.Size(26, 23);
            this.hp1minus.TabIndex = 39;
            this.hp1minus.Text = "-";
            this.hp1minus.UseVisualStyleBackColor = true;
            this.hp1minus.Click += new System.EventHandler(this.hp1minus_Click);
            // 
            // hp1save
            // 
            this.hp1save.Location = new System.Drawing.Point(903, 61);
            this.hp1save.Name = "hp1save";
            this.hp1save.Size = new System.Drawing.Size(75, 23);
            this.hp1save.TabIndex = 40;
            this.hp1save.Text = "save";
            this.hp1save.UseVisualStyleBackColor = true;
            this.hp1save.Click += new System.EventHandler(this.hp1save_Click);
            // 
            // attack1save
            // 
            this.attack1save.Location = new System.Drawing.Point(903, 104);
            this.attack1save.Name = "attack1save";
            this.attack1save.Size = new System.Drawing.Size(75, 23);
            this.attack1save.TabIndex = 41;
            this.attack1save.Text = "save";
            this.attack1save.UseVisualStyleBackColor = true;
            this.attack1save.Click += new System.EventHandler(this.attack1save_Click);
            // 
            // attack1plus
            // 
            this.attack1plus.Location = new System.Drawing.Point(839, 104);
            this.attack1plus.Name = "attack1plus";
            this.attack1plus.Size = new System.Drawing.Size(26, 23);
            this.attack1plus.TabIndex = 43;
            this.attack1plus.Text = "+";
            this.attack1plus.UseVisualStyleBackColor = true;
            this.attack1plus.Click += new System.EventHandler(this.attack1plus_Click);
            // 
            // attack1minus
            // 
            this.attack1minus.Location = new System.Drawing.Point(873, 104);
            this.attack1minus.Name = "attack1minus";
            this.attack1minus.Size = new System.Drawing.Size(24, 23);
            this.attack1minus.TabIndex = 44;
            this.attack1minus.Text = "-";
            this.attack1minus.UseVisualStyleBackColor = true;
            this.attack1minus.Click += new System.EventHandler(this.attack1minus_Click);
            // 
            // defense1save
            // 
            this.defense1save.Location = new System.Drawing.Point(903, 151);
            this.defense1save.Name = "defense1save";
            this.defense1save.Size = new System.Drawing.Size(75, 23);
            this.defense1save.TabIndex = 42;
            this.defense1save.Text = "save";
            this.defense1save.UseVisualStyleBackColor = true;
            this.defense1save.Click += new System.EventHandler(this.defense1save_Click);
            // 
            // defense1plus
            // 
            this.defense1plus.Location = new System.Drawing.Point(839, 151);
            this.defense1plus.Name = "defense1plus";
            this.defense1plus.Size = new System.Drawing.Size(24, 23);
            this.defense1plus.TabIndex = 45;
            this.defense1plus.Text = "+";
            this.defense1plus.UseVisualStyleBackColor = true;
            this.defense1plus.Click += new System.EventHandler(this.defense1plus_Click);
            // 
            // defense1minus
            // 
            this.defense1minus.Location = new System.Drawing.Point(869, 151);
            this.defense1minus.Name = "defense1minus";
            this.defense1minus.Size = new System.Drawing.Size(27, 23);
            this.defense1minus.TabIndex = 46;
            this.defense1minus.Text = "-";
            this.defense1minus.UseVisualStyleBackColor = true;
            this.defense1minus.Click += new System.EventHandler(this.defense1minus_Click);
            // 
            // cost1save
            // 
            this.cost1save.Location = new System.Drawing.Point(903, 203);
            this.cost1save.Name = "cost1save";
            this.cost1save.Size = new System.Drawing.Size(75, 23);
            this.cost1save.TabIndex = 42;
            this.cost1save.Text = "save";
            this.cost1save.UseVisualStyleBackColor = true;
            this.cost1save.Click += new System.EventHandler(this.cost1save_Click);
            // 
            // cost1plus
            // 
            this.cost1plus.Location = new System.Drawing.Point(839, 204);
            this.cost1plus.Name = "cost1plus";
            this.cost1plus.Size = new System.Drawing.Size(26, 23);
            this.cost1plus.TabIndex = 47;
            this.cost1plus.Text = "+";
            this.cost1plus.UseVisualStyleBackColor = true;
            this.cost1plus.Click += new System.EventHandler(this.cost1plus_Click);
            // 
            // cost1minus
            // 
            this.cost1minus.Location = new System.Drawing.Point(870, 204);
            this.cost1minus.Name = "cost1minus";
            this.cost1minus.Size = new System.Drawing.Size(26, 23);
            this.cost1minus.TabIndex = 48;
            this.cost1minus.Text = "-";
            this.cost1minus.UseVisualStyleBackColor = true;
            this.cost1minus.Click += new System.EventHandler(this.cost1minus_Click);
            // 
            // hp2save
            // 
            this.hp2save.Location = new System.Drawing.Point(1289, 60);
            this.hp2save.Name = "hp2save";
            this.hp2save.Size = new System.Drawing.Size(75, 23);
            this.hp2save.TabIndex = 57;
            this.hp2save.Text = "save";
            this.hp2save.UseVisualStyleBackColor = true;
            this.hp2save.Click += new System.EventHandler(this.hp2save_Click);
            // 
            // hp2plus
            // 
            this.hp2plus.Location = new System.Drawing.Point(1224, 61);
            this.hp2plus.Name = "hp2plus";
            this.hp2plus.Size = new System.Drawing.Size(27, 23);
            this.hp2plus.TabIndex = 49;
            this.hp2plus.Text = "+";
            this.hp2plus.UseVisualStyleBackColor = true;
            this.hp2plus.Click += new System.EventHandler(this.hp2plus_Click);
            // 
            // hp2minus
            // 
            this.hp2minus.Location = new System.Drawing.Point(1257, 61);
            this.hp2minus.Name = "hp2minus";
            this.hp2minus.Size = new System.Drawing.Size(26, 23);
            this.hp2minus.TabIndex = 50;
            this.hp2minus.Text = "-";
            this.hp2minus.UseVisualStyleBackColor = true;
            this.hp2minus.Click += new System.EventHandler(this.hp2minus_Click);
            // 
            // attack2save
            // 
            this.attack2save.Location = new System.Drawing.Point(1289, 104);
            this.attack2save.Name = "attack2save";
            this.attack2save.Size = new System.Drawing.Size(75, 23);
            this.attack2save.TabIndex = 58;
            this.attack2save.Text = "save";
            this.attack2save.UseVisualStyleBackColor = true;
            this.attack2save.Click += new System.EventHandler(this.attack2save_Click);
            // 
            // attack2plus
            // 
            this.attack2plus.Location = new System.Drawing.Point(1224, 104);
            this.attack2plus.Name = "attack2plus";
            this.attack2plus.Size = new System.Drawing.Size(27, 23);
            this.attack2plus.TabIndex = 51;
            this.attack2plus.Text = "+";
            this.attack2plus.UseVisualStyleBackColor = true;
            this.attack2plus.Click += new System.EventHandler(this.attack2plus_Click);
            // 
            // attack2minus
            // 
            this.attack2minus.Location = new System.Drawing.Point(1257, 105);
            this.attack2minus.Name = "attack2minus";
            this.attack2minus.Size = new System.Drawing.Size(26, 23);
            this.attack2minus.TabIndex = 52;
            this.attack2minus.Text = "-";
            this.attack2minus.UseVisualStyleBackColor = true;
            this.attack2minus.Click += new System.EventHandler(this.attack2minus_Click);
            // 
            // defense2save
            // 
            this.defense2save.Location = new System.Drawing.Point(1289, 152);
            this.defense2save.Name = "defense2save";
            this.defense2save.Size = new System.Drawing.Size(75, 23);
            this.defense2save.TabIndex = 59;
            this.defense2save.Text = "save";
            this.defense2save.UseVisualStyleBackColor = true;
            this.defense2save.Click += new System.EventHandler(this.defense2save_Click);
            // 
            // defense2plus
            // 
            this.defense2plus.Location = new System.Drawing.Point(1224, 151);
            this.defense2plus.Name = "defense2plus";
            this.defense2plus.Size = new System.Drawing.Size(27, 23);
            this.defense2plus.TabIndex = 53;
            this.defense2plus.Text = "+";
            this.defense2plus.UseVisualStyleBackColor = true;
            this.defense2plus.Click += new System.EventHandler(this.defense2plus_Click);
            // 
            // defense2minus
            // 
            this.defense2minus.Location = new System.Drawing.Point(1257, 152);
            this.defense2minus.Name = "defense2minus";
            this.defense2minus.Size = new System.Drawing.Size(26, 23);
            this.defense2minus.TabIndex = 54;
            this.defense2minus.Text = "-";
            this.defense2minus.UseVisualStyleBackColor = true;
            this.defense2minus.Click += new System.EventHandler(this.defense2minus_Click);
            // 
            // cost2save
            // 
            this.cost2save.Location = new System.Drawing.Point(1289, 203);
            this.cost2save.Name = "cost2save";
            this.cost2save.Size = new System.Drawing.Size(75, 23);
            this.cost2save.TabIndex = 60;
            this.cost2save.Text = "save";
            this.cost2save.UseVisualStyleBackColor = true;
            this.cost2save.Click += new System.EventHandler(this.cost2save_Click);
            // 
            // cost2plus
            // 
            this.cost2plus.Location = new System.Drawing.Point(1224, 204);
            this.cost2plus.Name = "cost2plus";
            this.cost2plus.Size = new System.Drawing.Size(27, 23);
            this.cost2plus.TabIndex = 55;
            this.cost2plus.Text = "+";
            this.cost2plus.UseVisualStyleBackColor = true;
            this.cost2plus.Click += new System.EventHandler(this.cost2plus_Click);
            // 
            // cost2minus
            // 
            this.cost2minus.Location = new System.Drawing.Point(1257, 204);
            this.cost2minus.Name = "cost2minus";
            this.cost2minus.Size = new System.Drawing.Size(26, 23);
            this.cost2minus.TabIndex = 56;
            this.cost2minus.Text = "-";
            this.cost2minus.UseVisualStyleBackColor = true;
            this.cost2minus.Click += new System.EventHandler(this.cost2minus_Click);
            // 
            // artefact1Name
            // 
            this.artefact1Name.Location = new System.Drawing.Point(724, 27);
            this.artefact1Name.Name = "artefact1Name";
            this.artefact1Name.Size = new System.Drawing.Size(100, 23);
            this.artefact1Name.TabIndex = 62;
            // 
            // artefact2Name
            // 
            this.artefact2Name.Location = new System.Drawing.Point(1118, 27);
            this.artefact2Name.Name = "artefact2Name";
            this.artefact2Name.Size = new System.Drawing.Size(100, 23);
            this.artefact2Name.TabIndex = 63;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(749, 390);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 64;
            this.clear.Text = "clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // name1save
            // 
            this.name1save.Location = new System.Drawing.Point(839, 27);
            this.name1save.Name = "name1save";
            this.name1save.Size = new System.Drawing.Size(75, 23);
            this.name1save.TabIndex = 65;
            this.name1save.Text = "save";
            this.name1save.UseVisualStyleBackColor = true;
            this.name1save.Click += new System.EventHandler(this.name1save_Click);
            // 
            // name2save
            // 
            this.name2save.Location = new System.Drawing.Point(1224, 26);
            this.name2save.Name = "name2save";
            this.name2save.Size = new System.Drawing.Size(75, 23);
            this.name2save.TabIndex = 66;
            this.name2save.Text = "save";
            this.name2save.UseVisualStyleBackColor = true;
            this.name2save.Click += new System.EventHandler(this.name2save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 849);
            this.Controls.Add(this.name2save);
            this.Controls.Add(this.name1save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.artefact2Name);
            this.Controls.Add(this.artefact1Name);
            this.Controls.Add(this.costLabel1);
            this.Controls.Add(this.cost2save);
            this.Controls.Add(this.defense2save);
            this.Controls.Add(this.attack2save);
            this.Controls.Add(this.hp2save);
            this.Controls.Add(this.cost2minus);
            this.Controls.Add(this.cost2plus);
            this.Controls.Add(this.defense2minus);
            this.Controls.Add(this.defense2plus);
            this.Controls.Add(this.attack2minus);
            this.Controls.Add(this.attack2plus);
            this.Controls.Add(this.hp2minus);
            this.Controls.Add(this.hp2plus);
            this.Controls.Add(this.cost1minus);
            this.Controls.Add(this.cost1plus);
            this.Controls.Add(this.defense1minus);
            this.Controls.Add(this.defense1plus);
            this.Controls.Add(this.attack1minus);
            this.Controls.Add(this.attack1plus);
            this.Controls.Add(this.cost1save);
            this.Controls.Add(this.defense1save);
            this.Controls.Add(this.attack1save);
            this.Controls.Add(this.hp1save);
            this.Controls.Add(this.hp1minus);
            this.Controls.Add(this.hp1plus);
            this.Controls.Add(this.costValue2);
            this.Controls.Add(this.defenseValue2);
            this.Controls.Add(this.attackValue2);
            this.Controls.Add(this.hpValue2);
            this.Controls.Add(this.costValue1);
            this.Controls.Add(this.defenseValue1);
            this.Controls.Add(this.attackValue1);
            this.Controls.Add(this.hpValue1);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.costLabel2);
            this.Controls.Add(this.defenseLabel2);
            this.Controls.Add(this.attackLabel2);
            this.Controls.Add(this.hpLabel2);
            this.Controls.Add(this.artifact2);
            this.Controls.Add(this.defenseLabel1);
            this.Controls.Add(this.attackLabel1);
            this.Controls.Add(this.hpLabel1);
            this.Controls.Add(this.artifact1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.attackValue);
            this.Controls.Add(this.costValue);
            this.Controls.Add(this.defenseValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.hpValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Hero
        private System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.TextBox hpValue;

        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.TextBox attackValue;

        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.TextBox defenseValue;

        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costValue;

        private System.Windows.Forms.Button save;

        // artifact1
        private System.Windows.Forms.Label artifact1;

        private System.Windows.Forms.Label hpLabel1;
        private System.Windows.Forms.TextBox hpValue1;
        
        private System.Windows.Forms.Label attackLabel1;
        private System.Windows.Forms.TextBox attackValue1;

        private System.Windows.Forms.Label defenseLabel1;
        private System.Windows.Forms.TextBox defenseValue1;

        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.TextBox costValue1;

        private System.Windows.Forms.Button buy1;

        // artifact2
        private System.Windows.Forms.Label artifact2;

        private System.Windows.Forms.Label hpLabel2;
        private System.Windows.Forms.TextBox hpValue2;

        private System.Windows.Forms.Label attackLabel2;
        private System.Windows.Forms.TextBox attackValue2;

        private System.Windows.Forms.Label defenseLabel2;
        private System.Windows.Forms.TextBox defenseValue2;

        private System.Windows.Forms.Label costLabel2;
        private System.Windows.Forms.TextBox costValue2;

        private System.Windows.Forms.Button buy2;

        private System.Windows.Forms.Button hp1plus;
        private System.Windows.Forms.Button hp1minus;
        private System.Windows.Forms.Button hp1save;
        private System.Windows.Forms.Button attack1save;
        private System.Windows.Forms.Button defense1save;
        private System.Windows.Forms.Button cost1save;
        private System.Windows.Forms.Button attack1plus;
        private System.Windows.Forms.Button attack1minus;
        private System.Windows.Forms.Button defense1plus;
        private System.Windows.Forms.Button defense1minus;
        private System.Windows.Forms.Button cost1plus;
        private System.Windows.Forms.Button cost1minus;
        private System.Windows.Forms.Button hp2plus;
        private System.Windows.Forms.Button hp2minus;
        private System.Windows.Forms.Button attack2plus;
        private System.Windows.Forms.Button attack2minus;
        private System.Windows.Forms.Button defense2plus;
        private System.Windows.Forms.Button defense2minus;
        private System.Windows.Forms.Button cost2plus;
        private System.Windows.Forms.Button cost2minus;
        private System.Windows.Forms.Button hp2save;
        private System.Windows.Forms.Button attack2save;
        private System.Windows.Forms.Button defense2save;
        private System.Windows.Forms.Button cost2save;
        private System.Windows.Forms.TextBox artefact1Name;
        private System.Windows.Forms.TextBox artefact2Name;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button name1save;
        private System.Windows.Forms.Button name2save;
    }
}


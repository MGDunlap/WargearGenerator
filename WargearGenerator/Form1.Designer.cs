namespace WargearGenerator
{
    partial class Form1
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.typeItem = new System.Windows.Forms.RadioButton();
            this.typeMelee = new System.Windows.Forms.RadioButton();
            this.typeRanged = new System.Windows.Forms.RadioButton();
            this.typeWeapon = new System.Windows.Forms.RadioButton();
            this.typeRandom = new System.Windows.Forms.RadioButton();
            this.groupBoxRarity = new System.Windows.Forms.GroupBox();
            this.rarityLegend = new System.Windows.Forms.RadioButton();
            this.rarityRare = new System.Windows.Forms.RadioButton();
            this.rarityUncommon = new System.Windows.Forms.RadioButton();
            this.rarityCommon = new System.Windows.Forms.RadioButton();
            this.rarityRandom = new System.Windows.Forms.RadioButton();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRarity = new System.Windows.Forms.Label();
            this.labelAttacks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelSkill = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelWeapName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFaction = new System.Windows.Forms.GroupBox();
            this.radioButtonOrks = new System.Windows.Forms.RadioButton();
            this.radioButtonSM = new System.Windows.Forms.RadioButton();
            this.groupBoxType.SuspendLayout();
            this.groupBoxRarity.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxType.Controls.Add(this.typeItem);
            this.groupBoxType.Controls.Add(this.typeMelee);
            this.groupBoxType.Controls.Add(this.typeRanged);
            this.groupBoxType.Controls.Add(this.typeWeapon);
            this.groupBoxType.Controls.Add(this.typeRandom);
            this.groupBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxType.Location = new System.Drawing.Point(61, 59);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(150, 212);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // typeItem
            // 
            this.typeItem.AutoSize = true;
            this.typeItem.Location = new System.Drawing.Point(7, 166);
            this.typeItem.Name = "typeItem";
            this.typeItem.Size = new System.Drawing.Size(59, 24);
            this.typeItem.TabIndex = 4;
            this.typeItem.Text = "Item";
            this.typeItem.UseVisualStyleBackColor = true;
            // 
            // typeMelee
            // 
            this.typeMelee.AutoSize = true;
            this.typeMelee.Location = new System.Drawing.Point(7, 135);
            this.typeMelee.Name = "typeMelee";
            this.typeMelee.Size = new System.Drawing.Size(70, 24);
            this.typeMelee.TabIndex = 3;
            this.typeMelee.Text = "Melee";
            this.typeMelee.UseVisualStyleBackColor = true;
            // 
            // typeRanged
            // 
            this.typeRanged.AutoSize = true;
            this.typeRanged.Location = new System.Drawing.Point(6, 104);
            this.typeRanged.Name = "typeRanged";
            this.typeRanged.Size = new System.Drawing.Size(84, 24);
            this.typeRanged.TabIndex = 2;
            this.typeRanged.Text = "Ranged";
            this.typeRanged.UseVisualStyleBackColor = true;
            // 
            // typeWeapon
            // 
            this.typeWeapon.AutoSize = true;
            this.typeWeapon.Location = new System.Drawing.Point(6, 74);
            this.typeWeapon.Name = "typeWeapon";
            this.typeWeapon.Size = new System.Drawing.Size(87, 24);
            this.typeWeapon.TabIndex = 1;
            this.typeWeapon.Text = "Weapon";
            this.typeWeapon.UseVisualStyleBackColor = true;
            // 
            // typeRandom
            // 
            this.typeRandom.AutoSize = true;
            this.typeRandom.Checked = true;
            this.typeRandom.Location = new System.Drawing.Point(6, 44);
            this.typeRandom.Name = "typeRandom";
            this.typeRandom.Size = new System.Drawing.Size(88, 24);
            this.typeRandom.TabIndex = 0;
            this.typeRandom.TabStop = true;
            this.typeRandom.Text = "Random";
            this.typeRandom.UseVisualStyleBackColor = true;
            // 
            // groupBoxRarity
            // 
            this.groupBoxRarity.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRarity.Controls.Add(this.rarityLegend);
            this.groupBoxRarity.Controls.Add(this.rarityRare);
            this.groupBoxRarity.Controls.Add(this.rarityUncommon);
            this.groupBoxRarity.Controls.Add(this.rarityCommon);
            this.groupBoxRarity.Controls.Add(this.rarityRandom);
            this.groupBoxRarity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRarity.Location = new System.Drawing.Point(257, 59);
            this.groupBoxRarity.Name = "groupBoxRarity";
            this.groupBoxRarity.Size = new System.Drawing.Size(150, 212);
            this.groupBoxRarity.TabIndex = 1;
            this.groupBoxRarity.TabStop = false;
            this.groupBoxRarity.Text = "Rarity";
            // 
            // rarityLegend
            // 
            this.rarityLegend.AutoSize = true;
            this.rarityLegend.Location = new System.Drawing.Point(7, 168);
            this.rarityLegend.Name = "rarityLegend";
            this.rarityLegend.Size = new System.Drawing.Size(102, 24);
            this.rarityLegend.TabIndex = 4;
            this.rarityLegend.Text = "Legendary";
            this.rarityLegend.UseVisualStyleBackColor = true;
            // 
            // rarityRare
            // 
            this.rarityRare.AutoSize = true;
            this.rarityRare.Location = new System.Drawing.Point(7, 137);
            this.rarityRare.Name = "rarityRare";
            this.rarityRare.Size = new System.Drawing.Size(62, 24);
            this.rarityRare.TabIndex = 3;
            this.rarityRare.Text = "Rare";
            this.rarityRare.UseVisualStyleBackColor = true;
            // 
            // rarityUncommon
            // 
            this.rarityUncommon.AutoSize = true;
            this.rarityUncommon.Location = new System.Drawing.Point(7, 106);
            this.rarityUncommon.Name = "rarityUncommon";
            this.rarityUncommon.Size = new System.Drawing.Size(109, 24);
            this.rarityUncommon.TabIndex = 2;
            this.rarityUncommon.Text = "Uncommon";
            this.rarityUncommon.UseVisualStyleBackColor = true;
            // 
            // rarityCommon
            // 
            this.rarityCommon.AutoSize = true;
            this.rarityCommon.Location = new System.Drawing.Point(7, 75);
            this.rarityCommon.Name = "rarityCommon";
            this.rarityCommon.Size = new System.Drawing.Size(91, 24);
            this.rarityCommon.TabIndex = 1;
            this.rarityCommon.Text = "Common";
            this.rarityCommon.UseVisualStyleBackColor = true;
            // 
            // rarityRandom
            // 
            this.rarityRandom.AutoSize = true;
            this.rarityRandom.Checked = true;
            this.rarityRandom.Location = new System.Drawing.Point(7, 44);
            this.rarityRandom.Name = "rarityRandom";
            this.rarityRandom.Size = new System.Drawing.Size(88, 24);
            this.rarityRandom.TabIndex = 0;
            this.rarityRandom.TabStop = true;
            this.rarityRandom.Text = "Random";
            this.rarityRandom.UseVisualStyleBackColor = true;
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGen.Location = new System.Drawing.Point(68, 307);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(103, 31);
            this.buttonGen.TabIndex = 2;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(187, 307);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 31);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelRarity);
            this.panel1.Controls.Add(this.labelAttacks);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelKeywords);
            this.panel1.Controls.Add(this.labelDamage);
            this.panel1.Controls.Add(this.labelAP);
            this.panel1.Controls.Add(this.labelStrength);
            this.panel1.Controls.Add(this.labelSkill);
            this.panel1.Controls.Add(this.labelRange);
            this.panel1.Controls.Add(this.labelWeapName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 154);
            this.panel1.TabIndex = 4;
            // 
            // labelRarity
            // 
            this.labelRarity.AutoSize = true;
            this.labelRarity.Location = new System.Drawing.Point(85, 9);
            this.labelRarity.Name = "labelRarity";
            this.labelRarity.Size = new System.Drawing.Size(0, 13);
            this.labelRarity.TabIndex = 15;
            // 
            // labelAttacks
            // 
            this.labelAttacks.AutoSize = true;
            this.labelAttacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttacks.Location = new System.Drawing.Point(478, 39);
            this.labelAttacks.Name = "labelAttacks";
            this.labelAttacks.Size = new System.Drawing.Size(28, 17);
            this.labelAttacks.TabIndex = 14;
            this.labelAttacks.Text = "[A]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "A";
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.ForeColor = System.Drawing.Color.Teal;
            this.labelKeywords.Location = new System.Drawing.Point(8, 61);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(58, 13);
            this.labelKeywords.TabIndex = 12;
            this.labelKeywords.Text = "[keywords]";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamage.Location = new System.Drawing.Point(764, 39);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(27, 17);
            this.labelDamage.TabIndex = 11;
            this.labelDamage.Text = "[d]";
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAP.Location = new System.Drawing.Point(695, 39);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(36, 17);
            this.labelAP.TabIndex = 10;
            this.labelAP.Text = "[ap]";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(630, 39);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(26, 17);
            this.labelStrength.TabIndex = 9;
            this.labelStrength.Text = "[s]";
            // 
            // labelSkill
            // 
            this.labelSkill.AutoSize = true;
            this.labelSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkill.Location = new System.Drawing.Point(547, 39);
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(46, 17);
            this.labelSkill.TabIndex = 8;
            this.labelSkill.Text = "[skill]";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRange.Location = new System.Drawing.Point(393, 39);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(60, 17);
            this.labelRange.TabIndex = 7;
            this.labelRange.Text = "[range]";
            // 
            // labelWeapName
            // 
            this.labelWeapName.AutoSize = true;
            this.labelWeapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeapName.Location = new System.Drawing.Point(8, 39);
            this.labelWeapName.Name = "labelWeapName";
            this.labelWeapName.Size = new System.Drawing.Size(57, 17);
            this.labelWeapName.TabIndex = 6;
            this.labelWeapName.Text = "[name]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(764, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "AP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BS/WS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon";
            // 
            // groupBoxFaction
            // 
            this.groupBoxFaction.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFaction.Controls.Add(this.radioButtonOrks);
            this.groupBoxFaction.Controls.Add(this.radioButtonSM);
            this.groupBoxFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxFaction.Location = new System.Drawing.Point(452, 57);
            this.groupBoxFaction.Name = "groupBoxFaction";
            this.groupBoxFaction.Size = new System.Drawing.Size(150, 212);
            this.groupBoxFaction.TabIndex = 5;
            this.groupBoxFaction.TabStop = false;
            this.groupBoxFaction.Text = "Faction";
            // 
            // radioButtonOrks
            // 
            this.radioButtonOrks.AutoSize = true;
            this.radioButtonOrks.Location = new System.Drawing.Point(7, 77);
            this.radioButtonOrks.Name = "radioButtonOrks";
            this.radioButtonOrks.Size = new System.Drawing.Size(60, 24);
            this.radioButtonOrks.TabIndex = 1;
            this.radioButtonOrks.TabStop = true;
            this.radioButtonOrks.Text = "Orks";
            this.radioButtonOrks.UseVisualStyleBackColor = true;
            // 
            // radioButtonSM
            // 
            this.radioButtonSM.AutoSize = true;
            this.radioButtonSM.Checked = true;
            this.radioButtonSM.Location = new System.Drawing.Point(7, 46);
            this.radioButtonSM.Name = "radioButtonSM";
            this.radioButtonSM.Size = new System.Drawing.Size(133, 24);
            this.radioButtonSM.TabIndex = 0;
            this.radioButtonSM.TabStop = true;
            this.radioButtonSM.Text = "Space Marines";
            this.radioButtonSM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 566);
            this.Controls.Add(this.groupBoxFaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.groupBoxRarity);
            this.Controls.Add(this.groupBoxType);
            this.Name = "Form1";
            this.Text = "Wargear Generator";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxRarity.ResumeLayout(false);
            this.groupBoxRarity.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFaction.ResumeLayout(false);
            this.groupBoxFaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton typeRandom;
        private System.Windows.Forms.GroupBox groupBoxRarity;
        private System.Windows.Forms.RadioButton typeWeapon;
        private System.Windows.Forms.RadioButton typeItem;
        private System.Windows.Forms.RadioButton typeMelee;
        private System.Windows.Forms.RadioButton typeRanged;
        private System.Windows.Forms.RadioButton rarityCommon;
        private System.Windows.Forms.RadioButton rarityRandom;
        private System.Windows.Forms.RadioButton rarityUncommon;
        private System.Windows.Forms.RadioButton rarityLegend;
        private System.Windows.Forms.RadioButton rarityRare;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelWeapName;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelAttacks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRarity;
        private System.Windows.Forms.GroupBox groupBoxFaction;
        private System.Windows.Forms.RadioButton radioButtonOrks;
        private System.Windows.Forms.RadioButton radioButtonSM;
    }
}


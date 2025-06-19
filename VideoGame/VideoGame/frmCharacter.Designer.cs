namespace VideoGame
{
    partial class frmCharacter
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
            btnCreateWiz = new Button();
            lbCharacters = new ListBox();
            lblName = new Label();
            txtName = new TextBox();
            lblHealth = new Label();
            lblAttack = new Label();
            lblDefense = new Label();
            nudAttack = new NumericUpDown();
            nudHealth = new NumericUpDown();
            nudDefense = new NumericUpDown();
            nudMana = new NumericUpDown();
            lblWeapon = new Label();
            lblMana = new Label();
            nudArmor = new NumericUpDown();
            nudMagic = new NumericUpDown();
            lblArmor = new Label();
            lblMagic = new Label();
            txtWeapon = new TextBox();
            btnCreateWar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudArmor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMagic).BeginInit();
            SuspendLayout();
            // 
            // btnCreateWiz
            // 
            btnCreateWiz.Location = new Point(109, 499);
            btnCreateWiz.Name = "btnCreateWiz";
            btnCreateWiz.Size = new Size(224, 34);
            btnCreateWiz.TabIndex = 0;
            btnCreateWiz.Text = "Create Wizard";
            btnCreateWiz.UseVisualStyleBackColor = true;
            btnCreateWiz.Click += btnCreateWiz_Click;
            // 
            // lbCharacters
            // 
            lbCharacters.FormattingEnabled = true;
            lbCharacters.ItemHeight = 25;
            lbCharacters.Location = new Point(36, 44);
            lbCharacters.Name = "lbCharacters";
            lbCharacters.Size = new Size(704, 129);
            lbCharacters.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(75, 217);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 214);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(441, 219);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(67, 25);
            lblHealth.TabIndex = 4;
            lblHealth.Text = "Health:";
            // 
            // lblAttack
            // 
            lblAttack.AutoSize = true;
            lblAttack.Location = new Point(75, 281);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(66, 25);
            lblAttack.TabIndex = 6;
            lblAttack.Text = "Attack:";
            // 
            // lblDefense
            // 
            lblDefense.AutoSize = true;
            lblDefense.Location = new Point(431, 289);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(80, 25);
            lblDefense.TabIndex = 8;
            lblDefense.Text = "Defense:";
            // 
            // nudAttack
            // 
            nudAttack.Location = new Point(153, 279);
            nudAttack.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAttack.Name = "nudAttack";
            nudAttack.Size = new Size(180, 31);
            nudAttack.TabIndex = 10;
            nudAttack.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHealth
            // 
            nudHealth.Location = new Point(514, 219);
            nudHealth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHealth.Name = "nudHealth";
            nudHealth.Size = new Size(180, 31);
            nudHealth.TabIndex = 11;
            nudHealth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDefense
            // 
            nudDefense.Location = new Point(514, 287);
            nudDefense.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDefense.Name = "nudDefense";
            nudDefense.Size = new Size(180, 31);
            nudDefense.TabIndex = 12;
            nudDefense.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudMana
            // 
            nudMana.Location = new Point(153, 355);
            nudMana.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMana.Name = "nudMana";
            nudMana.Size = new Size(180, 31);
            nudMana.TabIndex = 15;
            nudMana.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblWeapon
            // 
            lblWeapon.AutoSize = true;
            lblWeapon.Location = new Point(431, 357);
            lblWeapon.Name = "lblWeapon";
            lblWeapon.Size = new Size(82, 25);
            lblWeapon.TabIndex = 14;
            lblWeapon.Text = "Weapon:";
            // 
            // lblMana
            // 
            lblMana.AutoSize = true;
            lblMana.Location = new Point(75, 357);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(60, 25);
            lblMana.TabIndex = 13;
            lblMana.Text = "Mana:";
            // 
            // nudArmor
            // 
            nudArmor.Location = new Point(514, 425);
            nudArmor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudArmor.Name = "nudArmor";
            nudArmor.Size = new Size(180, 31);
            nudArmor.TabIndex = 20;
            nudArmor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudMagic
            // 
            nudMagic.Location = new Point(153, 425);
            nudMagic.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMagic.Name = "nudMagic";
            nudMagic.Size = new Size(180, 31);
            nudMagic.TabIndex = 19;
            nudMagic.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblArmor
            // 
            lblArmor.AutoSize = true;
            lblArmor.Location = new Point(441, 427);
            lblArmor.Name = "lblArmor";
            lblArmor.Size = new Size(67, 25);
            lblArmor.TabIndex = 18;
            lblArmor.Text = "Armor:";
            // 
            // lblMagic
            // 
            lblMagic.AutoSize = true;
            lblMagic.Location = new Point(75, 427);
            lblMagic.Name = "lblMagic";
            lblMagic.Size = new Size(64, 25);
            lblMagic.TabIndex = 17;
            lblMagic.Text = "Magic:";
            // 
            // txtWeapon
            // 
            txtWeapon.Location = new Point(514, 355);
            txtWeapon.Name = "txtWeapon";
            txtWeapon.Size = new Size(180, 31);
            txtWeapon.TabIndex = 21;
            // 
            // btnCreateWar
            // 
            btnCreateWar.Location = new Point(460, 490);
            btnCreateWar.Name = "btnCreateWar";
            btnCreateWar.Size = new Size(224, 34);
            btnCreateWar.TabIndex = 22;
            btnCreateWar.Text = "Create Warrior";
            btnCreateWar.UseVisualStyleBackColor = true;
            btnCreateWar.Click += btnCreateWar_Click;
            // 
            // frmCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(btnCreateWar);
            Controls.Add(txtWeapon);
            Controls.Add(nudArmor);
            Controls.Add(nudMagic);
            Controls.Add(lblArmor);
            Controls.Add(lblMagic);
            Controls.Add(nudMana);
            Controls.Add(lblWeapon);
            Controls.Add(lblMana);
            Controls.Add(nudDefense);
            Controls.Add(nudHealth);
            Controls.Add(nudAttack);
            Controls.Add(lblDefense);
            Controls.Add(lblAttack);
            Controls.Add(lblHealth);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lbCharacters);
            Controls.Add(btnCreateWiz);
            Name = "frmCharacter";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMana).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudArmor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMagic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateWiz;
        private ListBox lbCharacters;
        private Label lblName;
        private TextBox txtName;
        private Label lblHealth;
        private Label lblAttack;
        private Label lblDefense;
        private NumericUpDown nudAttack;
        private NumericUpDown nudHealth;
        private NumericUpDown nudDefense;
        private NumericUpDown nudMana;
        private Label lblWeapon;
        private Label lblMana;
        private NumericUpDown nudArmor;
        private NumericUpDown nudMagic;
        private Label lblArmor;
        private Label lblMagic;
        private TextBox txtWeapon;
        private Button btnCreateWar;
    }
}

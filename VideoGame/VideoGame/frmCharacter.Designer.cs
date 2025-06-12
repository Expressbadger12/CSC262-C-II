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
            btnCreate = new Button();
            lbCharacters = new ListBox();
            lblName = new Label();
            txtName = new TextBox();
            lblHealth = new Label();
            lblAttack = new Label();
            lblDefense = new Label();
            nudAttack = new NumericUpDown();
            nudHealth = new NumericUpDown();
            nudDefense = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDefense).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(345, 379);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Object";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
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
            lblAttack.Location = new Point(75, 313);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(66, 25);
            lblAttack.TabIndex = 6;
            lblAttack.Text = "Attack:";
            // 
            // lblDefense
            // 
            lblDefense.AutoSize = true;
            lblDefense.Location = new Point(431, 321);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(80, 25);
            lblDefense.TabIndex = 8;
            lblDefense.Text = "Defense:";
            // 
            // nudAttack
            // 
            nudAttack.Location = new Point(153, 311);
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
            nudDefense.Location = new Point(514, 319);
            nudDefense.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDefense.Name = "nudDefense";
            nudDefense.Size = new Size(180, 31);
            nudDefense.TabIndex = 12;
            nudDefense.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudDefense);
            Controls.Add(nudHealth);
            Controls.Add(nudAttack);
            Controls.Add(lblDefense);
            Controls.Add(lblAttack);
            Controls.Add(lblHealth);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lbCharacters);
            Controls.Add(btnCreate);
            Name = "frmCharacter";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDefense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private ListBox lbCharacters;
        private Label lblName;
        private TextBox txtName;
        private Label lblHealth;
        private Label lblAttack;
        private Label lblDefense;
        private NumericUpDown nudAttack;
        private NumericUpDown nudHealth;
        private NumericUpDown nudDefense;
    }
}

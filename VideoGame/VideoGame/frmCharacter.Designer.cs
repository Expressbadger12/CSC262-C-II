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
            txtHealth = new TextBox();
            lblAttack = new Label();
            txtAttack = new TextBox();
            lblDefense = new Label();
            txtDefense = new TextBox();
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
            // txtHealth
            // 
            txtHealth.Location = new Point(527, 219);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(150, 31);
            txtHealth.TabIndex = 5;
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
            // txtAttack
            // 
            txtAttack.Location = new Point(153, 319);
            txtAttack.Name = "txtAttack";
            txtAttack.Size = new Size(150, 31);
            txtAttack.TabIndex = 7;
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
            // txtDefense
            // 
            txtDefense.Location = new Point(527, 319);
            txtDefense.Name = "txtDefense";
            txtDefense.Size = new Size(150, 31);
            txtDefense.TabIndex = 9;
            // 
            // frmCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDefense);
            Controls.Add(lblDefense);
            Controls.Add(txtAttack);
            Controls.Add(lblAttack);
            Controls.Add(txtHealth);
            Controls.Add(lblHealth);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lbCharacters);
            Controls.Add(btnCreate);
            Name = "frmCharacter";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private ListBox lbCharacters;
        private Label lblName;
        private TextBox txtName;
        private Label lblHealth;
        private TextBox txtHealth;
        private Label lblAttack;
        private TextBox txtAttack;
        private Label lblDefense;
        private TextBox txtDefense;
    }
}

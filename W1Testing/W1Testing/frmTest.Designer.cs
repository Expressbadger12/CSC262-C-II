namespace W1Testing
{
    partial class frmTest
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
            lblHandle = new Label();
            txtHandle = new TextBox();
            lblLevel = new Label();
            txtLevel = new TextBox();
            btnTest = new Button();
            SuspendLayout();
            // 
            // lblHandle
            // 
            lblHandle.AutoSize = true;
            lblHandle.Location = new Point(153, 43);
            lblHandle.Margin = new Padding(2, 0, 2, 0);
            lblHandle.Name = "lblHandle";
            lblHandle.Size = new Size(83, 15);
            lblHandle.TabIndex = 0;
            lblHandle.Text = "Gamer Handle";
            // 
            // txtHandle
            // 
            txtHandle.Location = new Point(253, 41);
            txtHandle.Margin = new Padding(2, 2, 2, 2);
            txtHandle.Name = "txtHandle";
            txtHandle.Size = new Size(106, 23);
            txtHandle.TabIndex = 1;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(174, 76);
            lblLevel.Margin = new Padding(2, 0, 2, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(34, 15);
            lblLevel.TabIndex = 2;
            lblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(253, 76);
            txtLevel.Margin = new Padding(2, 2, 2, 2);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(106, 23);
            txtLevel.TabIndex = 3;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(262, 113);
            btnTest.Margin = new Padding(2, 2, 2, 2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(78, 20);
            btnTest.TabIndex = 4;
            btnTest.Text = " Test Values";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnTest);
            Controls.Add(txtLevel);
            Controls.Add(lblLevel);
            Controls.Add(txtHandle);
            Controls.Add(lblHandle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmTest";
            Text = "Form1";
            Load += frmTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHandle;
        private TextBox txtHandle;
        private Label lblLevel;
        private TextBox txtLevel;
        private Button btnTest;
    }
}

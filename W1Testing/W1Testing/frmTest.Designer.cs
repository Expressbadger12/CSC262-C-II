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
            lblHandle.Location = new Point(218, 71);
            lblHandle.Name = "lblHandle";
            lblHandle.Size = new Size(125, 25);
            lblHandle.TabIndex = 0;
            lblHandle.Text = "Gamer Handle";
            // 
            // txtHandle
            // 
            txtHandle.Location = new Point(361, 68);
            txtHandle.Name = "txtHandle";
            txtHandle.Size = new Size(150, 31);
            txtHandle.TabIndex = 1;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(249, 127);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(51, 25);
            lblLevel.TabIndex = 2;
            lblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(361, 127);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(150, 31);
            txtLevel.TabIndex = 3;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(374, 189);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(112, 34);
            btnTest.TabIndex = 4;
            btnTest.Text = " Test Values";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += this.btnTest_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTest);
            Controls.Add(txtLevel);
            Controls.Add(lblLevel);
            Controls.Add(txtHandle);
            Controls.Add(lblHandle);
            Name = "frmTest";
            Text = "Form1";
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

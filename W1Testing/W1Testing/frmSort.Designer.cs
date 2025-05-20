namespace W1Testing
{
    partial class frmSort
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
            lblBubbleSort = new Label();
            lblSelectionSort = new Label();
            btnSort = new Button();
            SuspendLayout();
            // 
            // lblBubbleSort
            // 
            lblBubbleSort.AutoSize = true;
            lblBubbleSort.Location = new Point(325, 150);
            lblBubbleSort.Name = "lblBubbleSort";
            lblBubbleSort.Size = new Size(174, 25);
            lblBubbleSort.TabIndex = 0;
            lblBubbleSort.Text = "Run Sort to see time";
            // 
            // lblSelectionSort
            // 
            lblSelectionSort.AutoSize = true;
            lblSelectionSort.Location = new Point(325, 187);
            lblSelectionSort.Name = "lblSelectionSort";
            lblSelectionSort.Size = new Size(174, 25);
            lblSelectionSort.TabIndex = 1;
            lblSelectionSort.Text = "Run Sort to see time";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(285, 261);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(232, 34);
            btnSort.TabIndex = 2;
            btnSort.Text = "Run Sorting";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += this.btnSort_Click;
            // 
            // frmSort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(lblSelectionSort);
            Controls.Add(lblBubbleSort);
            Name = "frmSort";
            Text = "Sorting Fun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBubbleSort;
        private Label lblSelectionSort;
        private Button btnSort;
    }
}
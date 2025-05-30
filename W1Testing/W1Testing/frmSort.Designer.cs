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
            lblWhatsize = new Label();
            txtSize = new TextBox();
            lblDebug = new Label();
            SuspendLayout();
            // 
            // lblBubbleSort
            // 
            lblBubbleSort.AutoSize = true;
            lblBubbleSort.Location = new Point(228, 65);
            lblBubbleSort.Margin = new Padding(2, 0, 2, 0);
            lblBubbleSort.Name = "lblBubbleSort";
            lblBubbleSort.Size = new Size(113, 15);
            lblBubbleSort.TabIndex = 0;
            lblBubbleSort.Text = "Run Sort to see time";
            // 
            // lblSelectionSort
            // 
            lblSelectionSort.AutoSize = true;
            lblSelectionSort.Location = new Point(228, 91);
            lblSelectionSort.Margin = new Padding(2, 0, 2, 0);
            lblSelectionSort.Name = "lblSelectionSort";
            lblSelectionSort.Size = new Size(113, 15);
            lblSelectionSort.TabIndex = 1;
            lblSelectionSort.Text = "Run Sort to see time";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(200, 157);
            btnSort.Margin = new Padding(2);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(162, 20);
            btnSort.TabIndex = 2;
            btnSort.Text = "Run Sorting";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblWhatsize
            // 
            lblWhatsize.AutoSize = true;
            lblWhatsize.Location = new Point(314, 31);
            lblWhatsize.Name = "lblWhatsize";
            lblWhatsize.Size = new Size(205, 15);
            lblWhatsize.TabIndex = 3;
            lblWhatsize.Text = "Enter the size of the array to be sorted";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(202, 28);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 4;
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.Location = new Point(119, 123);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(0, 15);
            lblDebug.TabIndex = 5;
            // 
            // frmSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblDebug);
            Controls.Add(txtSize);
            Controls.Add(lblWhatsize);
            Controls.Add(btnSort);
            Controls.Add(lblSelectionSort);
            Controls.Add(lblBubbleSort);
            Margin = new Padding(2);
            Name = "frmSort";
            Text = "Sorting Fun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBubbleSort;
        private Label lblSelectionSort;
        private Button btnSort;
        private Label lblWhatsize;
        private TextBox txtSize;
        private Label lblDebug;
    }
}
namespace W1Testing
{
    partial class frmMemoryUser
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
            btnUseMemory = new Button();
            lblTimeTaken = new Label();
            lsbData = new ListBox();
            SuspendLayout();
            // 
            // btnUseMemory
            // 
            btnUseMemory.Location = new Point(282, 290);
            btnUseMemory.Name = "btnUseMemory";
            btnUseMemory.Size = new Size(221, 34);
            btnUseMemory.TabIndex = 0;
            btnUseMemory.Text = "Use lots of memory";
            btnUseMemory.UseVisualStyleBackColor = true;
            btnUseMemory.Click += btnUseMemory_Click;
            // 
            // lblTimeTaken
            // 
            lblTimeTaken.AutoSize = true;
            lblTimeTaken.Location = new Point(347, 88);
            lblTimeTaken.Name = "lblTimeTaken";
            lblTimeTaken.Size = new Size(99, 25);
            lblTimeTaken.TabIndex = 1;
            lblTimeTaken.Text = "Time Taken";
            // 
            // lsbData
            // 
            lsbData.FormattingEnabled = true;
            lsbData.ItemHeight = 25;
            lsbData.Location = new Point(23, 12);
            lsbData.Name = "lsbData";
            lsbData.Size = new Size(216, 304);
            lsbData.TabIndex = 2;
            // 
            // frmMemoryUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbData);
            Controls.Add(lblTimeTaken);
            Controls.Add(btnUseMemory);
            Name = "frmMemoryUser";
            Text = "frmMemoryUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUseMemory;
        private Label lblTimeTaken;
        private ListBox lsbData;
    }
}
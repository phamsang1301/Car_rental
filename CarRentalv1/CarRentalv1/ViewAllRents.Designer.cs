namespace CarRentalv1
{
    partial class ViewAllRents
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
            this.RentListBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RentListBox
            // 
            this.RentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentListBox.Location = new System.Drawing.Point(12, 35);
            this.RentListBox.Multiline = true;
            this.RentListBox.Name = "RentListBox";
            this.RentListBox.ReadOnly = true;
            this.RentListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RentListBox.Size = new System.Drawing.Size(548, 400);
            this.RentListBox.TabIndex = 0;
            this.RentListBox.Text = "abc";
            this.RentListBox.WordWrap = false;
            this.RentListBox.TextChanged += new System.EventHandler(this.RentListBox_TextChanged);
            // 
            // ViewAllRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.RentListBox);
            this.Name = "ViewAllRents";
            this.Text = "ViewAllRents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentListBox;
    }
}
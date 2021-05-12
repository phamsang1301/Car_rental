namespace CarRentalv1
{
    partial class DeleteRent
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
            this.RentIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RentIDTextBox
            // 
            this.RentIDTextBox.Location = new System.Drawing.Point(220, 129);
            this.RentIDTextBox.Name = "RentIDTextBox";
            this.RentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentIDTextBox.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Rent ID";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(406, 102);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 66);
            this.DeleteButton.TabIndex = 45;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RentIDTextBox);
            this.Controls.Add(this.label9);
            this.Name = "DeleteRent";
            this.Text = "DeleteRent";
            this.Load += new System.EventHandler(this.DeleteRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteButton;
    }
}
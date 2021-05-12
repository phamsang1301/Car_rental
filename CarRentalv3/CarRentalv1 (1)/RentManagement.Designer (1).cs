namespace CarRentalv1
{
    partial class RentManagement
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
            this.DeleteRentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewAllRentButton = new System.Windows.Forms.Button();
            this.UpdateRentButton = new System.Windows.Forms.Button();
            this.AddRentButton = new System.Windows.Forms.Button();
            this.IntroText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteRentButton
            // 
            this.DeleteRentButton.Location = new System.Drawing.Point(215, 3);
            this.DeleteRentButton.Name = "DeleteRentButton";
            this.DeleteRentButton.Size = new System.Drawing.Size(206, 96);
            this.DeleteRentButton.TabIndex = 1;
            this.DeleteRentButton.Text = "Delete a rent";
            this.DeleteRentButton.UseVisualStyleBackColor = true;
            this.DeleteRentButton.Click += new System.EventHandler(this.DeleteRentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ViewAllRentButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateRentButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteRentButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddRentButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 205);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ViewAllRentButton
            // 
            this.ViewAllRentButton.Location = new System.Drawing.Point(215, 105);
            this.ViewAllRentButton.Name = "ViewAllRentButton";
            this.ViewAllRentButton.Size = new System.Drawing.Size(206, 97);
            this.ViewAllRentButton.TabIndex = 3;
            this.ViewAllRentButton.Text = "View list of all rents";
            this.ViewAllRentButton.UseVisualStyleBackColor = true;
            this.ViewAllRentButton.Click += new System.EventHandler(this.ViewAllRentButton_Click);
            // 
            // UpdateRentButton
            // 
            this.UpdateRentButton.Location = new System.Drawing.Point(3, 105);
            this.UpdateRentButton.Name = "UpdateRentButton";
            this.UpdateRentButton.Size = new System.Drawing.Size(206, 97);
            this.UpdateRentButton.TabIndex = 2;
            this.UpdateRentButton.Text = "Update a rent";
            this.UpdateRentButton.UseVisualStyleBackColor = true;
            this.UpdateRentButton.Click += new System.EventHandler(this.UpdateRentButton_Click);
            // 
            // AddRentButton
            // 
            this.AddRentButton.Location = new System.Drawing.Point(3, 3);
            this.AddRentButton.Name = "AddRentButton";
            this.AddRentButton.Size = new System.Drawing.Size(206, 96);
            this.AddRentButton.TabIndex = 0;
            this.AddRentButton.Text = "Add a rent";
            this.AddRentButton.UseVisualStyleBackColor = true;
            this.AddRentButton.Click += new System.EventHandler(this.AddRentButton_Click);
            // 
            // IntroText
            // 
            this.IntroText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroText.Location = new System.Drawing.Point(15, 41);
            this.IntroText.Name = "IntroText";
            this.IntroText.Size = new System.Drawing.Size(418, 68);
            this.IntroText.TabIndex = 3;
            this.IntroText.Text = "Rent Management";
            this.IntroText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IntroText.Click += new System.EventHandler(this.IntroText_Click);
            // 
            // RentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.IntroText);
            this.Name = "RentManagement";
            this.Text = "RentManagement";
            this.Load += new System.EventHandler(this.RentManagement_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteRentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewAllRentButton;
        private System.Windows.Forms.Button UpdateRentButton;
        private System.Windows.Forms.Button AddRentButton;
        private System.Windows.Forms.Label IntroText;
    }
}
namespace CarRentalv1
{
    partial class BookAndRentForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.RentCarButton = new System.Windows.Forms.Button();
            this.RentTruckButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // RentCarButton
            // 
            this.RentCarButton.Location = new System.Drawing.Point(30, 188);
            this.RentCarButton.Name = "RentCarButton";
            this.RentCarButton.Size = new System.Drawing.Size(206, 96);
            this.RentCarButton.TabIndex = 8;
            this.RentCarButton.Text = "Rent a Car";
            this.RentCarButton.UseVisualStyleBackColor = true;
            this.RentCarButton.Click += new System.EventHandler(this.RentCarButton_Click);
            // 
            // RentTruckButton
            // 
            this.RentTruckButton.Location = new System.Drawing.Point(258, 188);
            this.RentTruckButton.Name = "RentTruckButton";
            this.RentTruckButton.Size = new System.Drawing.Size(206, 96);
            this.RentTruckButton.TabIndex = 9;
            this.RentTruckButton.Text = "Rent a Truck";
            this.RentTruckButton.UseVisualStyleBackColor = true;
            this.RentTruckButton.Click += new System.EventHandler(this.RentTruckButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 96);
            this.button2.TabIndex = 10;
            this.button2.Text = "View list of available vehicle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BookAndRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RentTruckButton);
            this.Controls.Add(this.RentCarButton);
            this.Name = "BookAndRentForm";
            this.Text = "BookAndRentForm";
            this.Load += new System.EventHandler(this.RentManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button RentCarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RentTruckButton;
    }
}
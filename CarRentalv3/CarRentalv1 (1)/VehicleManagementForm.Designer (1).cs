namespace CarRentalv1
{
    partial class VehicleManagementForm
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
            this.IntroText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JsonExporterButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.FleetManagementButton = new System.Windows.Forms.Button();
            this.RentManagementButton = new System.Windows.Forms.Button();
            this.MaintenanceJobOperandButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntroText
            // 
            this.IntroText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroText.Location = new System.Drawing.Point(12, 9);
            this.IntroText.Name = "IntroText";
            this.IntroText.Size = new System.Drawing.Size(533, 68);
            this.IntroText.TabIndex = 0;
            this.IntroText.Text = "Vehicle Rental Management";
            this.IntroText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IntroText.Click += new System.EventHandler(this.IntroText_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.JsonExporterButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServiceButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FleetManagementButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RentManagementButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 205);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // JsonExporterButton
            // 
            this.JsonExporterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JsonExporterButton.Location = new System.Drawing.Point(268, 105);
            this.JsonExporterButton.Name = "JsonExporterButton";
            this.JsonExporterButton.Size = new System.Drawing.Size(259, 97);
            this.JsonExporterButton.TabIndex = 3;
            this.JsonExporterButton.Text = "Json exporter";
            this.JsonExporterButton.UseVisualStyleBackColor = true;
            this.JsonExporterButton.Click += new System.EventHandler(this.JsonExporterButton_Click);
            // 
            // ServiceButton
            // 
            this.ServiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceButton.Location = new System.Drawing.Point(3, 105);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(259, 97);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Service";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // FleetManagementButton
            // 
            this.FleetManagementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FleetManagementButton.Location = new System.Drawing.Point(268, 3);
            this.FleetManagementButton.Name = "FleetManagementButton";
            this.FleetManagementButton.Size = new System.Drawing.Size(259, 96);
            this.FleetManagementButton.TabIndex = 1;
            this.FleetManagementButton.Text = "Fleet Management";
            this.FleetManagementButton.UseVisualStyleBackColor = true;
            this.FleetManagementButton.Click += new System.EventHandler(this.FleetManagementButton_Click);
            // 
            // RentManagementButton
            // 
            this.RentManagementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentManagementButton.Location = new System.Drawing.Point(3, 3);
            this.RentManagementButton.Name = "RentManagementButton";
            this.RentManagementButton.Size = new System.Drawing.Size(259, 96);
            this.RentManagementButton.TabIndex = 0;
            this.RentManagementButton.Text = "Rent Management";
            this.RentManagementButton.UseVisualStyleBackColor = true;
            this.RentManagementButton.Click += new System.EventHandler(this.RentManagment_Click);
            // 
            // MaintenanceJobOperandButton
            // 
            this.MaintenanceJobOperandButton.Location = new System.Drawing.Point(156, 309);
            this.MaintenanceJobOperandButton.Name = "MaintenanceJobOperandButton";
            this.MaintenanceJobOperandButton.Size = new System.Drawing.Size(259, 68);
            this.MaintenanceJobOperandButton.TabIndex = 2;
            this.MaintenanceJobOperandButton.Text = "Maintenance Job Operand";
            this.MaintenanceJobOperandButton.UseVisualStyleBackColor = true;
            this.MaintenanceJobOperandButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // VehicleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.MaintenanceJobOperandButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.IntroText);
            this.Name = "VehicleManagementForm";
            this.Text = "VehicleManagementForm";
            this.Load += new System.EventHandler(this.VehicleManagementForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntroText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button JsonExporterButton;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.Button FleetManagementButton;
        private System.Windows.Forms.Button RentManagementButton;
        private System.Windows.Forms.Button MaintenanceJobOperandButton;
    }
}
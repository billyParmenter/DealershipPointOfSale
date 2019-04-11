namespace RD_A4
{
    partial class VehicleWindow
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
            this.vehicleList = new System.Windows.Forms.ListBox();
            this.customerSearch = new System.Windows.Forms.Button();
            this.vin = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vehicleList
            // 
            this.vehicleList.FormattingEnabled = true;
            this.vehicleList.Location = new System.Drawing.Point(221, 9);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(425, 199);
            this.vehicleList.TabIndex = 13;
            this.vehicleList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VehicleList_MouseDoubleClick);
            // 
            // customerSearch
            // 
            this.customerSearch.Location = new System.Drawing.Point(76, 185);
            this.customerSearch.Name = "customerSearch";
            this.customerSearch.Size = new System.Drawing.Size(75, 23);
            this.customerSearch.TabIndex = 12;
            this.customerSearch.Text = "Search";
            this.customerSearch.UseVisualStyleBackColor = true;
            this.customerSearch.Click += new System.EventHandler(this.VehicleSearch_Click);
            // 
            // vin
            // 
            this.vin.Location = new System.Drawing.Point(92, 37);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(100, 20);
            this.vin.TabIndex = 11;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(93, 93);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "VIN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search for a vehicle by VIN or description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "OR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Make:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Model:";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(92, 119);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(100, 20);
            this.make.TabIndex = 17;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(92, 145);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 18;
            // 
            // VehicleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 221);
            this.Controls.Add(this.model);
            this.Controls.Add(this.make);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.customerSearch);
            this.Controls.Add(this.vin);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleWindow";
            this.Text = "VehicleWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vehicleList;
        private System.Windows.Forms.Button customerSearch;
        private System.Windows.Forms.TextBox vin;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.TextBox model;
    }
}
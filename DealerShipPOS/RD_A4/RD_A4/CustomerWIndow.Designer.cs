namespace RD_A4
{
    partial class CustomerWIndow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.customerSearch = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for a customer by last name or phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(120, 89);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 3;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(120, 53);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(100, 20);
            this.lNameTB.TabIndex = 4;
            // 
            // customerSearch
            // 
            this.customerSearch.Location = new System.Drawing.Point(78, 137);
            this.customerSearch.Name = "customerSearch";
            this.customerSearch.Size = new System.Drawing.Size(75, 23);
            this.customerSearch.TabIndex = 5;
            this.customerSearch.Text = "Search";
            this.customerSearch.UseVisualStyleBackColor = true;
            this.customerSearch.Click += new System.EventHandler(this.CustomerSearch_Click);
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(262, 13);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(325, 147);
            this.customerList.TabIndex = 6;
            this.customerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CustomerList_MouseDoubleClick);
            // 
            // CustomerWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 173);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.customerSearch);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerWIndow";
            this.Text = "CustomerWIndow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.Button customerSearch;
        private System.Windows.Forms.ListBox customerList;
    }
}
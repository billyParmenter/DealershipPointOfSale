namespace RD_A4
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.orderBT = new System.Windows.Forms.Button();
            this.orderLookupBT = new System.Windows.Forms.Button();
            this.inventoryBT = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backBT = new System.Windows.Forms.Button();
            this.customerBox = new System.Windows.Forms.GroupBox();
            this.customerInfoBT = new System.Windows.Forms.Button();
            this.customerInfo = new System.Windows.Forms.Label();
            this.vehicleBox = new System.Windows.Forms.GroupBox();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.orderSelectBT = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListBox();
            this.vehicleInfoBT = new System.Windows.Forms.Button();
            this.vehicleInfo = new System.Windows.Forms.Label();
            this.inventoryList = new System.Windows.Forms.ListBox();
            this.tradeInBox = new System.Windows.Forms.GroupBox();
            this.orderUpdateBox = new System.Windows.Forms.GroupBox();
            this.orderUpdate = new System.Windows.Forms.Panel();
            this.updateBT = new System.Windows.Forms.Button();
            this.paidRB = new System.Windows.Forms.RadioButton();
            this.holdRB = new System.Windows.Forms.RadioButton();
            this.refundRB = new System.Windows.Forms.RadioButton();
            this.cancelRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.holdBTN = new System.Windows.Forms.RadioButton();
            this.paidBTN = new System.Windows.Forms.RadioButton();
            this.error = new System.Windows.Forms.Label();
            this.tradeInPannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kmsTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colourTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vinTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.makeTB = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.noTradeIn = new System.Windows.Forms.RadioButton();
            this.yesTradeIn = new System.Windows.Forms.RadioButton();
            this.orderLable = new System.Windows.Forms.Label();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.customerBox.SuspendLayout();
            this.vehicleBox.SuspendLayout();
            this.orderBox.SuspendLayout();
            this.tradeInBox.SuspendLayout();
            this.orderUpdateBox.SuspendLayout();
            this.orderUpdate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tradeInPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBT
            // 
            this.orderBT.Location = new System.Drawing.Point(6, 11);
            this.orderBT.Name = "orderBT";
            this.orderBT.Size = new System.Drawing.Size(100, 50);
            this.orderBT.TabIndex = 0;
            this.orderBT.Text = "New Order";
            this.orderBT.UseVisualStyleBackColor = true;
            this.orderBT.Click += new System.EventHandler(this.OrderBT_Click);
            // 
            // orderLookupBT
            // 
            this.orderLookupBT.Location = new System.Drawing.Point(6, 67);
            this.orderLookupBT.Name = "orderLookupBT";
            this.orderLookupBT.Size = new System.Drawing.Size(100, 50);
            this.orderLookupBT.TabIndex = 1;
            this.orderLookupBT.Text = "Lookup Order";
            this.orderLookupBT.UseVisualStyleBackColor = true;
            this.orderLookupBT.Click += new System.EventHandler(this.OrderLookupBT_Click);
            // 
            // inventoryBT
            // 
            this.inventoryBT.Location = new System.Drawing.Point(6, 123);
            this.inventoryBT.Name = "inventoryBT";
            this.inventoryBT.Size = new System.Drawing.Size(100, 50);
            this.inventoryBT.TabIndex = 2;
            this.inventoryBT.Text = "Check Inventory";
            this.inventoryBT.UseVisualStyleBackColor = true;
            this.inventoryBT.Click += new System.EventHandler(this.InventoryBT_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(323, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(286, 218);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(522, 20);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backBT);
            this.groupBox1.Controls.Add(this.orderBT);
            this.groupBox1.Controls.Add(this.orderLookupBT);
            this.groupBox1.Controls.Add(this.inventoryBT);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // backBT
            // 
            this.backBT.Enabled = false;
            this.backBT.Location = new System.Drawing.Point(7, 180);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(98, 48);
            this.backBT.TabIndex = 3;
            this.backBT.Text = "Back";
            this.backBT.UseVisualStyleBackColor = true;
            this.backBT.Click += new System.EventHandler(this.BackBT_Click);
            // 
            // customerBox
            // 
            this.customerBox.Controls.Add(this.customerInfoBT);
            this.customerBox.Controls.Add(this.customerInfo);
            this.customerBox.Location = new System.Drawing.Point(129, 13);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(172, 234);
            this.customerBox.TabIndex = 9;
            this.customerBox.TabStop = false;
            this.customerBox.Text = "Customer Info:";
            this.customerBox.Visible = false;
            // 
            // customerInfoBT
            // 
            this.customerInfoBT.Location = new System.Drawing.Point(10, 202);
            this.customerInfoBT.Name = "customerInfoBT";
            this.customerInfoBT.Size = new System.Drawing.Size(85, 23);
            this.customerInfoBT.TabIndex = 1;
            this.customerInfoBT.Text = "Find Customer";
            this.customerInfoBT.UseVisualStyleBackColor = true;
            this.customerInfoBT.Click += new System.EventHandler(this.CustomerInfoBT_Click);
            // 
            // customerInfo
            // 
            this.customerInfo.AutoSize = true;
            this.customerInfo.Location = new System.Drawing.Point(7, 20);
            this.customerInfo.MaximumSize = new System.Drawing.Size(235, 205);
            this.customerInfo.MinimumSize = new System.Drawing.Size(160, 205);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(160, 205);
            this.customerInfo.TabIndex = 0;
            // 
            // vehicleBox
            // 
            this.vehicleBox.Controls.Add(this.orderBox);
            this.vehicleBox.Controls.Add(this.vehicleInfoBT);
            this.vehicleBox.Controls.Add(this.vehicleInfo);
            this.vehicleBox.Location = new System.Drawing.Point(307, 13);
            this.vehicleBox.Name = "vehicleBox";
            this.vehicleBox.Size = new System.Drawing.Size(250, 234);
            this.vehicleBox.TabIndex = 10;
            this.vehicleBox.TabStop = false;
            this.vehicleBox.Text = "Vehicle Info:";
            this.vehicleBox.Visible = false;
            // 
            // orderBox
            // 
            this.orderBox.Controls.Add(this.orderSelectBT);
            this.orderBox.Controls.Add(this.orderList);
            this.orderBox.Location = new System.Drawing.Point(0, 0);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(250, 234);
            this.orderBox.TabIndex = 11;
            this.orderBox.TabStop = false;
            this.orderBox.Text = "Orders Found:";
            this.orderBox.Visible = false;
            // 
            // orderSelectBT
            // 
            this.orderSelectBT.Location = new System.Drawing.Point(7, 202);
            this.orderSelectBT.Name = "orderSelectBT";
            this.orderSelectBT.Size = new System.Drawing.Size(75, 23);
            this.orderSelectBT.TabIndex = 1;
            this.orderSelectBT.Text = "Select";
            this.orderSelectBT.UseVisualStyleBackColor = true;
            this.orderSelectBT.Click += new System.EventHandler(this.OrderSelectBT_Click);
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Items.AddRange(new object[] {
            ""});
            this.orderList.Location = new System.Drawing.Point(7, 20);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(236, 173);
            this.orderList.TabIndex = 0;
            // 
            // vehicleInfoBT
            // 
            this.vehicleInfoBT.Location = new System.Drawing.Point(12, 202);
            this.vehicleInfoBT.Name = "vehicleInfoBT";
            this.vehicleInfoBT.Size = new System.Drawing.Size(75, 23);
            this.vehicleInfoBT.TabIndex = 2;
            this.vehicleInfoBT.Text = "Find Vehicle";
            this.vehicleInfoBT.UseVisualStyleBackColor = true;
            this.vehicleInfoBT.Click += new System.EventHandler(this.VehicleInfoBT_Click);
            // 
            // vehicleInfo
            // 
            this.vehicleInfo.AutoSize = true;
            this.vehicleInfo.Location = new System.Drawing.Point(9, 20);
            this.vehicleInfo.MaximumSize = new System.Drawing.Size(235, 205);
            this.vehicleInfo.MinimumSize = new System.Drawing.Size(235, 205);
            this.vehicleInfo.Name = "vehicleInfo";
            this.vehicleInfo.Size = new System.Drawing.Size(235, 205);
            this.vehicleInfo.TabIndex = 1;
            // 
            // inventoryList
            // 
            this.inventoryList.FormattingEnabled = true;
            this.inventoryList.Location = new System.Drawing.Point(129, 13);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(643, 225);
            this.inventoryList.TabIndex = 1;
            this.inventoryList.Visible = false;
            // 
            // tradeInBox
            // 
            this.tradeInBox.Controls.Add(this.orderUpdateBox);
            this.tradeInBox.Controls.Add(this.panel1);
            this.tradeInBox.Controls.Add(this.error);
            this.tradeInBox.Controls.Add(this.tradeInPannel);
            this.tradeInBox.Controls.Add(this.submit);
            this.tradeInBox.Controls.Add(this.noTradeIn);
            this.tradeInBox.Controls.Add(this.yesTradeIn);
            this.tradeInBox.Location = new System.Drawing.Point(563, 13);
            this.tradeInBox.Name = "tradeInBox";
            this.tradeInBox.Size = new System.Drawing.Size(223, 234);
            this.tradeInBox.TabIndex = 11;
            this.tradeInBox.TabStop = false;
            this.tradeInBox.Text = "Tradde in:";
            this.tradeInBox.Visible = false;
            // 
            // orderUpdateBox
            // 
            this.orderUpdateBox.Controls.Add(this.orderLable);
            this.orderUpdateBox.Controls.Add(this.orderUpdate);
            this.orderUpdateBox.Controls.Add(this.orderInfoLabel);
            this.orderUpdateBox.Location = new System.Drawing.Point(0, 0);
            this.orderUpdateBox.Name = "orderUpdateBox";
            this.orderUpdateBox.Size = new System.Drawing.Size(223, 234);
            this.orderUpdateBox.TabIndex = 2;
            this.orderUpdateBox.TabStop = false;
            this.orderUpdateBox.Text = "Order Info:";
            this.orderUpdateBox.Visible = false;
            // 
            // orderUpdate
            // 
            this.orderUpdate.Controls.Add(this.updateBT);
            this.orderUpdate.Controls.Add(this.paidRB);
            this.orderUpdate.Controls.Add(this.holdRB);
            this.orderUpdate.Controls.Add(this.refundRB);
            this.orderUpdate.Controls.Add(this.cancelRB);
            this.orderUpdate.Location = new System.Drawing.Point(12, 141);
            this.orderUpdate.Name = "orderUpdate";
            this.orderUpdate.Size = new System.Drawing.Size(205, 78);
            this.orderUpdate.TabIndex = 5;
            this.orderUpdate.Visible = false;
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(123, 48);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(75, 23);
            this.updateBT.TabIndex = 4;
            this.updateBT.Text = "Update";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // paidRB
            // 
            this.paidRB.AutoSize = true;
            this.paidRB.Location = new System.Drawing.Point(3, 3);
            this.paidRB.Name = "paidRB";
            this.paidRB.Size = new System.Drawing.Size(50, 17);
            this.paidRB.TabIndex = 0;
            this.paidRB.TabStop = true;
            this.paidRB.Text = "PAID";
            this.paidRB.UseVisualStyleBackColor = true;
            // 
            // holdRB
            // 
            this.holdRB.AutoSize = true;
            this.holdRB.Location = new System.Drawing.Point(3, 20);
            this.holdRB.Name = "holdRB";
            this.holdRB.Size = new System.Drawing.Size(55, 17);
            this.holdRB.TabIndex = 1;
            this.holdRB.TabStop = true;
            this.holdRB.Text = "HOLD";
            this.holdRB.UseVisualStyleBackColor = true;
            // 
            // refundRB
            // 
            this.refundRB.AutoSize = true;
            this.refundRB.Location = new System.Drawing.Point(3, 54);
            this.refundRB.Name = "refundRB";
            this.refundRB.Size = new System.Drawing.Size(70, 17);
            this.refundRB.TabIndex = 3;
            this.refundRB.TabStop = true;
            this.refundRB.Text = "REFUND";
            this.refundRB.UseVisualStyleBackColor = true;
            // 
            // cancelRB
            // 
            this.cancelRB.AutoSize = true;
            this.cancelRB.Location = new System.Drawing.Point(3, 37);
            this.cancelRB.Name = "cancelRB";
            this.cancelRB.Size = new System.Drawing.Size(67, 17);
            this.cancelRB.TabIndex = 2;
            this.cancelRB.TabStop = true;
            this.cancelRB.Text = "CANCEL";
            this.cancelRB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.holdBTN);
            this.panel1.Controls.Add(this.paidBTN);
            this.panel1.Location = new System.Drawing.Point(132, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 47);
            this.panel1.TabIndex = 20;
            // 
            // holdBTN
            // 
            this.holdBTN.AutoSize = true;
            this.holdBTN.Location = new System.Drawing.Point(3, 27);
            this.holdBTN.Name = "holdBTN";
            this.holdBTN.Size = new System.Drawing.Size(55, 17);
            this.holdBTN.TabIndex = 19;
            this.holdBTN.TabStop = true;
            this.holdBTN.Text = "HOLD";
            this.holdBTN.UseVisualStyleBackColor = true;
            // 
            // paidBTN
            // 
            this.paidBTN.AutoSize = true;
            this.paidBTN.Location = new System.Drawing.Point(3, 3);
            this.paidBTN.Name = "paidBTN";
            this.paidBTN.Size = new System.Drawing.Size(50, 17);
            this.paidBTN.TabIndex = 18;
            this.paidBTN.TabStop = true;
            this.paidBTN.Text = "PAID";
            this.paidBTN.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(134, 199);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 17;
            // 
            // tradeInPannel
            // 
            this.tradeInPannel.Controls.Add(this.label1);
            this.tradeInPannel.Controls.Add(this.priceTB);
            this.tradeInPannel.Controls.Add(this.label2);
            this.tradeInPannel.Controls.Add(this.kmsTB);
            this.tradeInPannel.Controls.Add(this.label3);
            this.tradeInPannel.Controls.Add(this.colourTB);
            this.tradeInPannel.Controls.Add(this.label4);
            this.tradeInPannel.Controls.Add(this.modelTB);
            this.tradeInPannel.Controls.Add(this.label5);
            this.tradeInPannel.Controls.Add(this.yearTB);
            this.tradeInPannel.Controls.Add(this.label6);
            this.tradeInPannel.Controls.Add(this.vinTB);
            this.tradeInPannel.Controls.Add(this.label7);
            this.tradeInPannel.Controls.Add(this.makeTB);
            this.tradeInPannel.Location = new System.Drawing.Point(6, 37);
            this.tradeInPannel.Name = "tradeInPannel";
            this.tradeInPannel.Size = new System.Drawing.Size(122, 182);
            this.tradeInPannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VIN:";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(41, 159);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(75, 20);
            this.priceTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            // 
            // kmsTB
            // 
            this.kmsTB.Location = new System.Drawing.Point(41, 133);
            this.kmsTB.Name = "kmsTB";
            this.kmsTB.Size = new System.Drawing.Size(75, 20);
            this.kmsTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make:";
            // 
            // colourTB
            // 
            this.colourTB.Location = new System.Drawing.Point(41, 107);
            this.colourTB.Name = "colourTB";
            this.colourTB.Size = new System.Drawing.Size(75, 20);
            this.colourTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model:";
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(41, 81);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(75, 20);
            this.modelTB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Colour:";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(41, 29);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(75, 20);
            this.yearTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kms:";
            // 
            // vinTB
            // 
            this.vinTB.Location = new System.Drawing.Point(41, 3);
            this.vinTB.Name = "vinTB";
            this.vinTB.Size = new System.Drawing.Size(75, 20);
            this.vinTB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price:";
            // 
            // makeTB
            // 
            this.makeTB.Location = new System.Drawing.Point(41, 55);
            this.makeTB.Name = "makeTB";
            this.makeTB.Size = new System.Drawing.Size(75, 20);
            this.makeTB.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(128, 95);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(91, 95);
            this.submit.TabIndex = 16;
            this.submit.Text = "ORDER";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // noTradeIn
            // 
            this.noTradeIn.AutoSize = true;
            this.noTradeIn.Location = new System.Drawing.Point(58, 14);
            this.noTradeIn.Name = "noTradeIn";
            this.noTradeIn.Size = new System.Drawing.Size(41, 17);
            this.noTradeIn.TabIndex = 1;
            this.noTradeIn.TabStop = true;
            this.noTradeIn.Text = "NO";
            this.noTradeIn.UseVisualStyleBackColor = true;
            this.noTradeIn.CheckedChanged += new System.EventHandler(this.NoTradeIn_CheckedChanged);
            // 
            // yesTradeIn
            // 
            this.yesTradeIn.AutoSize = true;
            this.yesTradeIn.Location = new System.Drawing.Point(6, 14);
            this.yesTradeIn.Name = "yesTradeIn";
            this.yesTradeIn.Size = new System.Drawing.Size(46, 17);
            this.yesTradeIn.TabIndex = 0;
            this.yesTradeIn.TabStop = true;
            this.yesTradeIn.Text = "YES";
            this.yesTradeIn.UseVisualStyleBackColor = true;
            this.yesTradeIn.CheckedChanged += new System.EventHandler(this.YesTradeIn_CheckedChanged);
            // 
            // orderLable
            // 
            this.orderLable.AutoSize = true;
            this.orderLable.Location = new System.Drawing.Point(10, 18);
            this.orderLable.MaximumSize = new System.Drawing.Size(200, 100);
            this.orderLable.MinimumSize = new System.Drawing.Size(205, 115);
            this.orderLable.Name = "orderLable";
            this.orderLable.Size = new System.Drawing.Size(205, 115);
            this.orderLable.TabIndex = 6;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Location = new System.Drawing.Point(12, 20);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.orderInfoLabel.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 255);
            this.Controls.Add(this.vehicleBox);
            this.Controls.Add(this.tradeInBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.inventoryList);
            this.Name = "MainScreen";
            this.Text = "BPWally";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.customerBox.ResumeLayout(false);
            this.customerBox.PerformLayout();
            this.vehicleBox.ResumeLayout(false);
            this.vehicleBox.PerformLayout();
            this.orderBox.ResumeLayout(false);
            this.tradeInBox.ResumeLayout(false);
            this.tradeInBox.PerformLayout();
            this.orderUpdateBox.ResumeLayout(false);
            this.orderUpdateBox.PerformLayout();
            this.orderUpdate.ResumeLayout(false);
            this.orderUpdate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tradeInPannel.ResumeLayout(false);
            this.tradeInPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderBT;
        private System.Windows.Forms.Button orderLookupBT;
        private System.Windows.Forms.Button inventoryBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.GroupBox customerBox;
        private System.Windows.Forms.Label customerInfo;
        private System.Windows.Forms.GroupBox vehicleBox;
        private System.Windows.Forms.Label vehicleInfo;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.ListBox inventoryList;
        private System.Windows.Forms.Button customerInfoBT;
        private System.Windows.Forms.Button vehicleInfoBT;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.GroupBox tradeInBox;
        private System.Windows.Forms.RadioButton noTradeIn;
        private System.Windows.Forms.RadioButton yesTradeIn;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox kmsTB;
        private System.Windows.Forms.TextBox colourTB;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox vinTB;
        private System.Windows.Forms.TextBox makeTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel tradeInPannel;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton holdBTN;
        private System.Windows.Forms.RadioButton paidBTN;
        private System.Windows.Forms.Button orderSelectBT;
        private System.Windows.Forms.GroupBox orderUpdateBox;
        private System.Windows.Forms.Panel orderUpdate;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.RadioButton paidRB;
        private System.Windows.Forms.RadioButton holdRB;
        private System.Windows.Forms.RadioButton refundRB;
        private System.Windows.Forms.RadioButton cancelRB;
        private System.Windows.Forms.Label orderLable;
        private System.Windows.Forms.Label orderInfoLabel;
    }
}


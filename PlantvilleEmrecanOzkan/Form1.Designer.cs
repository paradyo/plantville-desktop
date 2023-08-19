namespace PlantvilleEmrecanOzkan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.gardenListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gardenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seedsEmporiumList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellEverythingButton = new System.Windows.Forms.Button();
            this.harvestAllButton = new System.Windows.Forms.Button();
            this.conversationCloud = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conversationLabel = new System.Windows.Forms.Label();
            this.landPlotLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addStrawberryToEmporiumButton = new System.Windows.Forms.Button();
            this.addPearToEmporiumButton = new System.Windows.Forms.Button();
            this.addSpinachToEmporiumButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.mediumLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.conversationCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "strawberries.png");
            this.imageList1.Images.SetKeyName(1, "pears.jpg");
            this.imageList1.Images.SetKeyName(2, "spinach.jpg");
            // 
            // inventoryListView
            // 
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.countColumnHeader});
            this.inventoryListView.HideSelection = false;
            this.inventoryListView.LargeImageList = this.imageList1;
            this.inventoryListView.Location = new System.Drawing.Point(582, 43);
            this.inventoryListView.MultiSelect = false;
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.ShowItemToolTips = true;
            this.inventoryListView.Size = new System.Drawing.Size(214, 193);
            this.inventoryListView.SmallImageList = this.imageList1;
            this.inventoryListView.TabIndex = 2;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            this.inventoryListView.DoubleClick += new System.EventHandler(this.inventoryListView_DoubleClick);
            this.inventoryListView.MouseHover += new System.EventHandler(this.inventoryListView_MouseHover);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 86;
            // 
            // countColumnHeader
            // 
            this.countColumnHeader.Text = "Market Price";
            this.countColumnHeader.Width = 78;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(577, 12);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 25);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "Inventory";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(742, 15);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(54, 20);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "$1234";
            // 
            // gardenListView
            // 
            this.gardenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6});
            this.gardenListView.HideSelection = false;
            this.gardenListView.LargeImageList = this.imageList1;
            this.gardenListView.Location = new System.Drawing.Point(12, 274);
            this.gardenListView.MultiSelect = false;
            this.gardenListView.Name = "gardenListView";
            this.gardenListView.ShowItemToolTips = true;
            this.gardenListView.Size = new System.Drawing.Size(282, 193);
            this.gardenListView.SmallImageList = this.imageList1;
            this.gardenListView.TabIndex = 7;
            this.gardenListView.UseCompatibleStateImageBehavior = false;
            this.gardenListView.View = System.Windows.Forms.View.Details;
            this.gardenListView.DoubleClick += new System.EventHandler(this.gardenListView_DoubleClick);
            this.gardenListView.MouseHover += new System.EventHandler(this.gardenListView_MouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Harvest Time";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Spoil Time";
            this.columnHeader6.Width = 68;
            // 
            // gardenLabel
            // 
            this.gardenLabel.AutoSize = true;
            this.gardenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardenLabel.Location = new System.Drawing.Point(7, 239);
            this.gardenLabel.Name = "gardenLabel";
            this.gardenLabel.Size = new System.Drawing.Size(83, 25);
            this.gardenLabel.TabIndex = 8;
            this.gardenLabel.Text = "Garden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seeds Emporium";
            // 
            // seedsEmporiumList
            // 
            this.seedsEmporiumList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.seedsEmporiumList.HideSelection = false;
            this.seedsEmporiumList.LargeImageList = this.imageList1;
            this.seedsEmporiumList.Location = new System.Drawing.Point(335, 274);
            this.seedsEmporiumList.MultiSelect = false;
            this.seedsEmporiumList.Name = "seedsEmporiumList";
            this.seedsEmporiumList.ShowItemToolTips = true;
            this.seedsEmporiumList.Size = new System.Drawing.Size(198, 193);
            this.seedsEmporiumList.SmallImageList = this.imageList1;
            this.seedsEmporiumList.TabIndex = 9;
            this.seedsEmporiumList.UseCompatibleStateImageBehavior = false;
            this.seedsEmporiumList.View = System.Windows.Forms.View.Details;
            this.seedsEmporiumList.DoubleClick += new System.EventHandler(this.seedsEmporiumList_DoubleClick);
            this.seedsEmporiumList.MouseHover += new System.EventHandler(this.seedsEmporiumList_MouseHover);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price ($)";
            // 
            // sellEverythingButton
            // 
            this.sellEverythingButton.Location = new System.Drawing.Point(582, 241);
            this.sellEverythingButton.Name = "sellEverythingButton";
            this.sellEverythingButton.Size = new System.Drawing.Size(214, 23);
            this.sellEverythingButton.TabIndex = 13;
            this.sellEverythingButton.Text = "Sell Everything On Market";
            this.sellEverythingButton.UseVisualStyleBackColor = true;
            this.sellEverythingButton.Click += new System.EventHandler(this.sellEverythingButton_Click);
            // 
            // harvestAllButton
            // 
            this.harvestAllButton.Location = new System.Drawing.Point(101, 240);
            this.harvestAllButton.Name = "harvestAllButton";
            this.harvestAllButton.Size = new System.Drawing.Size(81, 23);
            this.harvestAllButton.TabIndex = 14;
            this.harvestAllButton.Text = "Harvest All";
            this.harvestAllButton.UseVisualStyleBackColor = true;
            this.harvestAllButton.Click += new System.EventHandler(this.harvestAllButton_Click);
            // 
            // conversationCloud
            // 
            this.conversationCloud.Image = global::PlantvilleEmrecanOzkan.Properties.Resources.conversation_cloud1;
            this.conversationCloud.Location = new System.Drawing.Point(169, 27);
            this.conversationCloud.Name = "conversationCloud";
            this.conversationCloud.Size = new System.Drawing.Size(373, 125);
            this.conversationCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conversationCloud.TabIndex = 17;
            this.conversationCloud.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlantvilleEmrecanOzkan.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(698, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlantvilleEmrecanOzkan.Properties.Resources.player;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(701, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // conversationLabel
            // 
            this.conversationLabel.AutoSize = true;
            this.conversationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversationLabel.Location = new System.Drawing.Point(221, 67);
            this.conversationLabel.Name = "conversationLabel";
            this.conversationLabel.Size = new System.Drawing.Size(244, 22);
            this.conversationLabel.TabIndex = 18;
            this.conversationLabel.Text = "Hey there! Welcome back!";
            this.conversationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // landPlotLabel
            // 
            this.landPlotLabel.AutoSize = true;
            this.landPlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landPlotLabel.Location = new System.Drawing.Point(226, 253);
            this.landPlotLabel.Name = "landPlotLabel";
            this.landPlotLabel.Size = new System.Drawing.Size(27, 20);
            this.landPlotLabel.TabIndex = 19;
            this.landPlotLabel.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Available Land Plot";
            // 
            // addStrawberryToEmporiumButton
            // 
            this.addStrawberryToEmporiumButton.Location = new System.Drawing.Point(582, 302);
            this.addStrawberryToEmporiumButton.Name = "addStrawberryToEmporiumButton";
            this.addStrawberryToEmporiumButton.Size = new System.Drawing.Size(214, 23);
            this.addStrawberryToEmporiumButton.TabIndex = 21;
            this.addStrawberryToEmporiumButton.Text = "Add Strawberry To Emporium";
            this.addStrawberryToEmporiumButton.UseVisualStyleBackColor = true;
            this.addStrawberryToEmporiumButton.Click += new System.EventHandler(this.addStrawberryToEmporiumButton_Click);
            // 
            // addPearToEmporiumButton
            // 
            this.addPearToEmporiumButton.Location = new System.Drawing.Point(582, 331);
            this.addPearToEmporiumButton.Name = "addPearToEmporiumButton";
            this.addPearToEmporiumButton.Size = new System.Drawing.Size(214, 23);
            this.addPearToEmporiumButton.TabIndex = 22;
            this.addPearToEmporiumButton.Text = "Add Pear To Emporium";
            this.addPearToEmporiumButton.UseVisualStyleBackColor = true;
            this.addPearToEmporiumButton.Click += new System.EventHandler(this.addPearToEmporiumButton_Click);
            // 
            // addSpinachToEmporiumButton
            // 
            this.addSpinachToEmporiumButton.Location = new System.Drawing.Point(582, 360);
            this.addSpinachToEmporiumButton.Name = "addSpinachToEmporiumButton";
            this.addSpinachToEmporiumButton.Size = new System.Drawing.Size(214, 23);
            this.addSpinachToEmporiumButton.TabIndex = 23;
            this.addSpinachToEmporiumButton.Text = "Add Spinach To Emporium";
            this.addSpinachToEmporiumButton.UseVisualStyleBackColor = true;
            this.addSpinachToEmporiumButton.Click += new System.EventHandler(this.addSpinachToEmporiumButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Emrecan Ozkan - Software Engineer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Emporium Helper";
            // 
            // myWebsiteLink
            // 
            this.myWebsiteLink.AutoSize = true;
            this.myWebsiteLink.Location = new System.Drawing.Point(701, 439);
            this.myWebsiteLink.Name = "myWebsiteLink";
            this.myWebsiteLink.Size = new System.Drawing.Size(96, 13);
            this.myWebsiteLink.TabIndex = 26;
            this.myWebsiteLink.TabStop = true;
            this.myWebsiteLink.Text = "Check my website!";
            this.myWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myWebsiteLink_LinkClicked);
            // 
            // mediumLink
            // 
            this.mediumLink.AutoSize = true;
            this.mediumLink.Location = new System.Drawing.Point(630, 455);
            this.mediumLink.Name = "mediumLink";
            this.mediumLink.Size = new System.Drawing.Size(166, 13);
            this.mediumLink.TabIndex = 27;
            this.mediumLink.TabStop = true;
            this.mediumLink.Text = "Check the object-oriented design!";
            this.mediumLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mediumLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.mediumLink);
            this.Controls.Add(this.myWebsiteLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addSpinachToEmporiumButton);
            this.Controls.Add(this.addPearToEmporiumButton);
            this.Controls.Add(this.addStrawberryToEmporiumButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.landPlotLabel);
            this.Controls.Add(this.conversationLabel);
            this.Controls.Add(this.conversationCloud);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.harvestAllButton);
            this.Controls.Add(this.sellEverythingButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seedsEmporiumList);
            this.Controls.Add(this.gardenLabel);
            this.Controls.Add(this.gardenListView);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.inventoryListView);
            this.Name = "Form1";
            this.Text = "Plantville - Your family\'s farm.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conversationCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView inventoryListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader countColumnHeader;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.ListView gardenListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label gardenLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView seedsEmporiumList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button sellEverythingButton;
        private System.Windows.Forms.Button harvestAllButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox conversationCloud;
        private System.Windows.Forms.Label conversationLabel;
        private System.Windows.Forms.Label landPlotLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStrawberryToEmporiumButton;
        private System.Windows.Forms.Button addPearToEmporiumButton;
        private System.Windows.Forms.Button addSpinachToEmporiumButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel myWebsiteLink;
        private System.Windows.Forms.LinkLabel mediumLink;
    }
}


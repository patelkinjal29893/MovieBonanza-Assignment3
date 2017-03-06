namespace MovieBonanza_Assignment3
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.LargeGraphicsPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderDVDCheckBox = new System.Windows.Forms.CheckBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalChargesTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.AdditionalChargesLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.StreamButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LargeGraphicsPictureBox)).BeginInit();
            this.YourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(541, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.StreamToolStripMenuItem,
            this.toolStripSeparator2,
            this.CancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // StreamToolStripMenuItem
            // 
            this.StreamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StreamToolStripMenuItem.Image")));
            this.StreamToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StreamToolStripMenuItem.Name = "StreamToolStripMenuItem";
            this.StreamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.StreamToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.StreamToolStripMenuItem.Text = "Strea&m";
            this.StreamToolStripMenuItem.Click += new System.EventHandler(this.StreamToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CancelToolStripMenuItem.Text = "Canc&el";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(392, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(50, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.LargeGraphicsPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(13, 37);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(198, 314);
            this.MovieSelectedGroupBox.TabIndex = 2;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // LargeGraphicsPictureBox
            // 
            this.LargeGraphicsPictureBox.Location = new System.Drawing.Point(10, 116);
            this.LargeGraphicsPictureBox.Name = "LargeGraphicsPictureBox";
            this.LargeGraphicsPictureBox.Size = new System.Drawing.Size(172, 181);
            this.LargeGraphicsPictureBox.TabIndex = 3;
            this.LargeGraphicsPictureBox.TabStop = false;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(10, 79);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(172, 22);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(10, 37);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(172, 22);
            this.TitleTextBox.TabIndex = 2;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(7, 63);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(64, 18);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(7, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 18);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.OrderDVDCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargesTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargesLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourOrderGroupBox.Location = new System.Drawing.Point(246, 37);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(283, 263);
            this.YourOrderGroupBox.TabIndex = 3;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // OrderDVDCheckBox
            // 
            this.OrderDVDCheckBox.AutoSize = true;
            this.OrderDVDCheckBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDVDCheckBox.Location = new System.Drawing.Point(14, 215);
            this.OrderDVDCheckBox.Name = "OrderDVDCheckBox";
            this.OrderDVDCheckBox.Size = new System.Drawing.Size(243, 21);
            this.OrderDVDCheckBox.TabIndex = 3;
            this.OrderDVDCheckBox.Text = "Order the DVD(adds $10 to Your Order)";
            this.OrderDVDCheckBox.UseVisualStyleBackColor = true;
            this.OrderDVDCheckBox.CheckedChanged += new System.EventHandler(this.OrderDVDCheckBox_CheckedChanged);
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxTextBox.Location = new System.Drawing.Point(155, 131);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.SalesTaxTextBox.TabIndex = 1;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalTextBox.Location = new System.Drawing.Point(155, 163);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.GrandTotalTextBox.TabIndex = 1;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(155, 97);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubTotalTextBox.TabIndex = 1;
            // 
            // AdditionalChargesTextBox
            // 
            this.AdditionalChargesTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalChargesTextBox.Location = new System.Drawing.Point(155, 63);
            this.AdditionalChargesTextBox.Name = "AdditionalChargesTextBox";
            this.AdditionalChargesTextBox.ReadOnly = true;
            this.AdditionalChargesTextBox.Size = new System.Drawing.Size(100, 22);
            this.AdditionalChargesTextBox.TabIndex = 1;
            this.AdditionalChargesTextBox.Visible = false;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(155, 30);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 22);
            this.CostTextBox.TabIndex = 1;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(61, 163);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(82, 18);
            this.GrandTotalLabel.TabIndex = 0;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(41, 136);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(102, 18);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax(13%)";
            // 
            // AdditionalChargesLabel
            // 
            this.AdditionalChargesLabel.AutoSize = true;
            this.AdditionalChargesLabel.Location = new System.Drawing.Point(13, 66);
            this.AdditionalChargesLabel.Name = "AdditionalChargesLabel";
            this.AdditionalChargesLabel.Size = new System.Drawing.Size(130, 18);
            this.AdditionalChargesLabel.TabIndex = 0;
            this.AdditionalChargesLabel.Text = "Additional Charges";
            this.AdditionalChargesLabel.Visible = false;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(75, 100);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(68, 18);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(106, 33);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(37, 18);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost";
            // 
            // StreamButton
            // 
            this.StreamButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamButton.Location = new System.Drawing.Point(460, 328);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(55, 23);
            this.StreamButton.TabIndex = 1;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(246, 328);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 364);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LargeGraphicsPictureBox)).EndInit();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.PictureBox LargeGraphicsPictureBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox OrderDVDCheckBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AdditionalChargesTextBox;
        private System.Windows.Forms.Label AdditionalChargesLabel;
    }
}
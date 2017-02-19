namespace MovieBonanza_Assignment3
{
    partial class SelectionForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallGraphicsPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallGraphicsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(34, 20);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(493, 24);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Choose the Movie you wish to STREAM from the list below";
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(47, 67);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(137, 24);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Cedar Rapids ",
            "Company\tMen",
            "Death Race 2",
            "Footloose ",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Season of\tthe Witch ",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other\tWoman",
            "The Rite Horror Sanctum",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.listBox1.Location = new System.Drawing.Point(51, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextbox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.SmallGraphicsPictureBox);
            this.YourSelectionGroupBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(201, 102);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(444, 170);
            this.YourSelectionGroupBox.TabIndex = 3;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // SmallGraphicsPictureBox
            // 
            this.SmallGraphicsPictureBox.Location = new System.Drawing.Point(16, 29);
            this.SmallGraphicsPictureBox.Name = "SmallGraphicsPictureBox";
            this.SmallGraphicsPictureBox.Size = new System.Drawing.Size(100, 114);
            this.SmallGraphicsPictureBox.TabIndex = 0;
            this.SmallGraphicsPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(151, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 21);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(154, 46);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(242, 26);
            this.TitleTextbox.TabIndex = 2;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(322, 80);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(43, 21);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(326, 104);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(70, 26);
            this.CostTextBox.TabIndex = 2;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(151, 80);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(75, 21);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(154, 104);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(152, 26);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(568, 303);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 30);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 345);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallGraphicsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox SmallGraphicsPictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}


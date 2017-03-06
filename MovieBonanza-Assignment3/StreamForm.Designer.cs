namespace MovieBonanza_Assignment3
{
    partial class StreamForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.MovieSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(156, 202);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(47, 27);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(11, 44);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(343, 24);
            this.ThankYouLabel.TabIndex = 1;
            this.ThankYouLabel.Text = "Thank you For Choosing Movie Bonanza!";
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.AutoSize = true;
            this.ChargeLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ChargeLabel.Location = new System.Drawing.Point(37, 98);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(317, 21);
            this.ChargeLabel.TabIndex = 2;
            this.ChargeLabel.Text = "Your Credit Card will be Charged [ X Dollar]";
            // 
            // MovieSelectedLabel
            // 
            this.MovieSelectedLabel.AutoSize = true;
            this.MovieSelectedLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSelectedLabel.Location = new System.Drawing.Point(62, 151);
            this.MovieSelectedLabel.Name = "MovieSelectedLabel";
            this.MovieSelectedLabel.Size = new System.Drawing.Size(247, 18);
            this.MovieSelectedLabel.TabIndex = 2;
            this.MovieSelectedLabel.Text = "[Your Movie] will be Streaming Shortly";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 242);
            this.ControlBox = false;
            this.Controls.Add(this.MovieSelectedLabel);
            this.Controls.Add(this.ChargeLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OkButton);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie is about to Start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label ChargeLabel;
        private System.Windows.Forms.Label MovieSelectedLabel;
    }
}
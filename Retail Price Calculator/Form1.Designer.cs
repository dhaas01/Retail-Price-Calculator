namespace Retail_Price_Calculator
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
            this.wholesaleTextBox = new System.Windows.Forms.TextBox();
            this.markupTextBox = new System.Windows.Forms.TextBox();
            this.wholesaleLabel = new System.Windows.Forms.Label();
            this.markupLabel = new System.Windows.Forms.Label();
            this.retailPriceTextLabel = new System.Windows.Forms.Label();
            this.retailPriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wholesaleTextBox
            // 
            this.wholesaleTextBox.Location = new System.Drawing.Point(202, 12);
            this.wholesaleTextBox.Name = "wholesaleTextBox";
            this.wholesaleTextBox.Size = new System.Drawing.Size(100, 20);
            this.wholesaleTextBox.TabIndex = 0;
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(202, 47);
            this.markupTextBox.Name = "markupTextBox";
            this.markupTextBox.Size = new System.Drawing.Size(100, 20);
            this.markupTextBox.TabIndex = 1;
            // 
            // wholesaleLabel
            // 
            this.wholesaleLabel.AutoSize = true;
            this.wholesaleLabel.Location = new System.Drawing.Point(26, 15);
            this.wholesaleLabel.Name = "wholesaleLabel";
            this.wholesaleLabel.Size = new System.Drawing.Size(126, 13);
            this.wholesaleLabel.TabIndex = 2;
            this.wholesaleLabel.Text = "Enter the wholesale cost:";
            // 
            // markupLabel
            // 
            this.markupLabel.AutoSize = true;
            this.markupLabel.Location = new System.Drawing.Point(26, 50);
            this.markupLabel.Name = "markupLabel";
            this.markupLabel.Size = new System.Drawing.Size(148, 13);
            this.markupLabel.TabIndex = 3;
            this.markupLabel.Text = "Enter the markup percentage:";
            // 
            // retailPriceTextLabel
            // 
            this.retailPriceTextLabel.AutoSize = true;
            this.retailPriceTextLabel.Location = new System.Drawing.Point(26, 86);
            this.retailPriceTextLabel.Name = "retailPriceTextLabel";
            this.retailPriceTextLabel.Size = new System.Drawing.Size(90, 13);
            this.retailPriceTextLabel.TabIndex = 4;
            this.retailPriceTextLabel.Text = "The retail price is:";
            // 
            // retailPriceLabel
            // 
            this.retailPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retailPriceLabel.Location = new System.Drawing.Point(202, 81);
            this.retailPriceLabel.Name = "retailPriceLabel";
            this.retailPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.retailPriceLabel.TabIndex = 5;
            this.retailPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(70, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Retail Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(191, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 198);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.retailPriceLabel);
            this.Controls.Add(this.retailPriceTextLabel);
            this.Controls.Add(this.markupLabel);
            this.Controls.Add(this.wholesaleLabel);
            this.Controls.Add(this.markupTextBox);
            this.Controls.Add(this.wholesaleTextBox);
            this.Name = "Form1";
            this.Text = "Retail Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wholesaleTextBox;
        private System.Windows.Forms.TextBox markupTextBox;
        private System.Windows.Forms.Label wholesaleLabel;
        private System.Windows.Forms.Label markupLabel;
        private System.Windows.Forms.Label retailPriceTextLabel;
        private System.Windows.Forms.Label retailPriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}


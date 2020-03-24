namespace TrackerUI
{
    partial class PrizeCreatorForm
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
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberTextBox = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(116, 246);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(124, 35);
            this.createPrizeButton.TabIndex = 30;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(202, 186);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(126, 27);
            this.phoneNumberTextBox.TabIndex = 29;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(28, 180);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(174, 30);
            this.prizePercentageLabel.TabIndex = 28;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(202, 129);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(126, 27);
            this.emailTextBox.TabIndex = 27;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.prizeAmountLabel.Location = new System.Drawing.Point(28, 124);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.prizeAmountLabel.TabIndex = 26;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameTextBox.Location = new System.Drawing.Point(202, 98);
            this.placeNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(126, 27);
            this.placeNameTextBox.TabIndex = 25;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(28, 93);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(127, 30);
            this.placeNameLabel.TabIndex = 24;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeNumberTextBox
            // 
            this.placeNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberTextBox.Location = new System.Drawing.Point(202, 67);
            this.placeNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.placeNumberTextBox.Name = "placeNumberTextBox";
            this.placeNumberTextBox.Size = new System.Drawing.Size(126, 27);
            this.placeNumberTextBox.TabIndex = 23;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(28, 62);
            this.placeNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(149, 30);
            this.placeNumberLabel.TabIndex = 22;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.createPrizeLabel.Location = new System.Drawing.Point(9, 18);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(142, 32);
            this.createPrizeLabel.TabIndex = 21;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(75, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "or";
            // 
            // PrizeCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberTextBox);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrizeCreatorForm";
            this.Text = "Prize Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox placeNumberTextBox;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Label label1;
    }
}
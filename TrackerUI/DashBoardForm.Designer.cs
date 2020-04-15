namespace TrackerUI
{
    partial class DashBoardForm
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
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.tournamentSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.loadingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.dashboardLabel.Location = new System.Drawing.Point(39, 49);
            this.dashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(393, 51);
            this.dashboardLabel.TabIndex = 1;
            this.dashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadButton
            // 
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.loadButton.Location = new System.Drawing.Point(164, 196);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(124, 35);
            this.loadButton.TabIndex = 24;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // tournamentSelectionComboBox
            // 
            this.tournamentSelectionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentSelectionComboBox.FormattingEnabled = true;
            this.tournamentSelectionComboBox.Location = new System.Drawing.Point(97, 162);
            this.tournamentSelectionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tournamentSelectionComboBox.Name = "tournamentSelectionComboBox";
            this.tournamentSelectionComboBox.Size = new System.Drawing.Size(261, 29);
            this.tournamentSelectionComboBox.TabIndex = 23;
            // 
            // loadingTournamentLabel
            // 
            this.loadingTournamentLabel.AutoSize = true;
            this.loadingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.loadingTournamentLabel.Location = new System.Drawing.Point(76, 126);
            this.loadingTournamentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingTournamentLabel.Name = "loadingTournamentLabel";
            this.loadingTournamentLabel.Size = new System.Drawing.Size(324, 32);
            this.loadingTournamentLabel.TabIndex = 22;
            this.loadingTournamentLabel.Text = "Loading Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(128, 280);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(197, 54);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 366);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.tournamentSelectionComboBox);
            this.Controls.Add(this.loadingTournamentLabel);
            this.Controls.Add(this.dashboardLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox tournamentSelectionComboBox;
        private System.Windows.Forms.Label loadingTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
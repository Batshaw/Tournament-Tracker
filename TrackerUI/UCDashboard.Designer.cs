namespace TrackerUI
{
    partial class UCDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.loadingTournamentLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.tournamentSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.dashboardLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardLabel.Location = new System.Drawing.Point(221, 26);
            this.dashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(397, 46);
            this.dashboardLabel.TabIndex = 25;
            this.dashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadingTournamentLabel
            // 
            this.loadingTournamentLabel.AutoSize = true;
            this.loadingTournamentLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.loadingTournamentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadingTournamentLabel.Location = new System.Drawing.Point(274, 101);
            this.loadingTournamentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingTournamentLabel.Name = "loadingTournamentLabel";
            this.loadingTournamentLabel.Size = new System.Drawing.Size(290, 30);
            this.loadingTournamentLabel.TabIndex = 26;
            this.loadingTournamentLabel.Text = "Loading Existing Tournament";
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(199)))), ((int)(((byte)(172)))));
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.loadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadButton.Location = new System.Drawing.Point(357, 231);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(124, 35);
            this.loadButton.TabIndex = 28;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // tournamentSelectionComboBox
            // 
            this.tournamentSelectionComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentSelectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentSelectionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentSelectionComboBox.FormattingEnabled = true;
            this.tournamentSelectionComboBox.Location = new System.Drawing.Point(289, 145);
            this.tournamentSelectionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tournamentSelectionComboBox.MaxDropDownItems = 2;
            this.tournamentSelectionComboBox.Name = "tournamentSelectionComboBox";
            this.tournamentSelectionComboBox.Size = new System.Drawing.Size(261, 29);
            this.tournamentSelectionComboBox.TabIndex = 27;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dashboardLabel);
            this.Controls.Add(this.loadingTournamentLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.tournamentSelectionComboBox);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(860, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label loadingTournamentLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox tournamentSelectionComboBox;
    }
}

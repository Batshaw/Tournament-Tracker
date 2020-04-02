namespace TrackerUI
{
    partial class TournamentCreatorForm
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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.teamSelectLabel = new System.Windows.Forms.Label();
            this.teamCreatorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamSelectDropDown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.teamsPlayersListBox = new System.Windows.Forms.ListBox();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(9, 25);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(215, 32);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameTextBox.Location = new System.Drawing.Point(14, 61);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(261, 29);
            this.tournamentNameTextBox.TabIndex = 1;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(9, 109);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(114, 32);
            this.entryFeeLabel.TabIndex = 2;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeTextBox.Location = new System.Drawing.Point(118, 115);
            this.entryFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(90, 29);
            this.entryFeeTextBox.TabIndex = 3;
            this.entryFeeTextBox.Text = "0";
            // 
            // teamSelectLabel
            // 
            this.teamSelectLabel.AutoSize = true;
            this.teamSelectLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.teamSelectLabel.Location = new System.Drawing.Point(9, 163);
            this.teamSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamSelectLabel.Name = "teamSelectLabel";
            this.teamSelectLabel.Size = new System.Drawing.Size(143, 32);
            this.teamSelectLabel.TabIndex = 4;
            this.teamSelectLabel.Text = "Select Team";
            // 
            // teamCreatorLinkLabel
            // 
            this.teamCreatorLinkLabel.AutoSize = true;
            this.teamCreatorLinkLabel.Location = new System.Drawing.Point(217, 183);
            this.teamCreatorLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamCreatorLinkLabel.Name = "teamCreatorLinkLabel";
            this.teamCreatorLinkLabel.Size = new System.Drawing.Size(60, 13);
            this.teamCreatorLinkLabel.TabIndex = 5;
            this.teamCreatorLinkLabel.TabStop = true;
            this.teamCreatorLinkLabel.Text = "create new";
            this.teamCreatorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teamCreatorLinkLabel_LinkClicked);
            // 
            // teamSelectDropDown
            // 
            this.teamSelectDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectDropDown.FormattingEnabled = true;
            this.teamSelectDropDown.Location = new System.Drawing.Point(14, 202);
            this.teamSelectDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.teamSelectDropDown.Name = "teamSelectDropDown";
            this.teamSelectDropDown.Size = new System.Drawing.Size(261, 29);
            this.teamSelectDropDown.TabIndex = 6;
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(104, 241);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(104, 35);
            this.addTeamButton.TabIndex = 7;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(104, 305);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(104, 35);
            this.createPrizeButton.TabIndex = 8;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.teamsPlayersLabel.Location = new System.Drawing.Point(318, 25);
            this.teamsPlayersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(165, 32);
            this.teamsPlayersLabel.TabIndex = 9;
            this.teamsPlayersLabel.Text = "Teams/Players";
            // 
            // teamsPlayersListBox
            // 
            this.teamsPlayersListBox.FormattingEnabled = true;
            this.teamsPlayersListBox.Location = new System.Drawing.Point(323, 61);
            this.teamsPlayersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamsPlayersListBox.Name = "teamsPlayersListBox";
            this.teamsPlayersListBox.Size = new System.Drawing.Size(255, 147);
            this.teamsPlayersListBox.TabIndex = 10;
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.deletePrizeButton.Location = new System.Drawing.Point(582, 274);
            this.deletePrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(140, 35);
            this.deletePrizeButton.TabIndex = 14;
            this.deletePrizeButton.Text = "Remove Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = true;
            this.deletePrizeButton.Click += new System.EventHandler(this.deletePrizeButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.Location = new System.Drawing.Point(322, 274);
            this.prizeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(255, 82);
            this.prizeListBox.TabIndex = 13;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.prizesLabel.Location = new System.Drawing.Point(317, 238);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(76, 32);
            this.prizesLabel.TabIndex = 12;
            this.prizesLabel.Text = "Prizes";
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.deleteTeamButton.Location = new System.Drawing.Point(582, 61);
            this.deleteTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(140, 35);
            this.deleteTeamButton.TabIndex = 15;
            this.deleteTeamButton.Text = "Remove Selected";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(241, 384);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(197, 54);
            this.createTournamentButton.TabIndex = 16;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // TournamentCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 448);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamsPlayersListBox);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamSelectDropDown);
            this.Controls.Add(this.teamCreatorLinkLabel);
            this.Controls.Add(this.teamSelectLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TournamentCreatorForm";
            this.Text = "Tournament Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label teamSelectLabel;
        private System.Windows.Forms.LinkLabel teamCreatorLinkLabel;
        private System.Windows.Forms.ComboBox teamSelectDropDown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.ListBox teamsPlayersListBox;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
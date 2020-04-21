namespace TrackerUI
{
    partial class UCTournamentCreator
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
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.teamsPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.teamSelectDropDown = new System.Windows.Forms.ComboBox();
            this.teamCreatorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamSelectLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.Location = new System.Drawing.Point(306, 366);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(197, 54);
            this.createTournamentButton.TabIndex = 32;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteTeamButton.Location = new System.Drawing.Point(647, 43);
            this.deleteTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(140, 35);
            this.deleteTeamButton.TabIndex = 31;
            this.deleteTeamButton.Text = "Remove Selected";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletePrizeButton.Location = new System.Drawing.Point(647, 256);
            this.deletePrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(140, 35);
            this.deletePrizeButton.TabIndex = 30;
            this.deletePrizeButton.Text = "Remove Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = true;
            this.deletePrizeButton.Click += new System.EventHandler(this.deletePrizeButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.Location = new System.Drawing.Point(387, 256);
            this.prizeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(255, 82);
            this.prizeListBox.TabIndex = 29;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.prizesLabel.Location = new System.Drawing.Point(382, 220);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(76, 32);
            this.prizesLabel.TabIndex = 28;
            this.prizesLabel.Text = "Prizes";
            // 
            // teamsPlayersListBox
            // 
            this.teamsPlayersListBox.FormattingEnabled = true;
            this.teamsPlayersListBox.Location = new System.Drawing.Point(388, 43);
            this.teamsPlayersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamsPlayersListBox.Name = "teamsPlayersListBox";
            this.teamsPlayersListBox.Size = new System.Drawing.Size(255, 147);
            this.teamsPlayersListBox.TabIndex = 27;
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsPlayersLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.teamsPlayersLabel.Location = new System.Drawing.Point(383, 7);
            this.teamsPlayersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(165, 32);
            this.teamsPlayersLabel.TabIndex = 26;
            this.teamsPlayersLabel.Text = "Teams/Players";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeButton.Location = new System.Drawing.Point(169, 287);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(104, 35);
            this.createPrizeButton.TabIndex = 25;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamButton.Location = new System.Drawing.Point(169, 223);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(104, 35);
            this.addTeamButton.TabIndex = 24;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // teamSelectDropDown
            // 
            this.teamSelectDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectDropDown.FormattingEnabled = true;
            this.teamSelectDropDown.Location = new System.Drawing.Point(79, 184);
            this.teamSelectDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.teamSelectDropDown.Name = "teamSelectDropDown";
            this.teamSelectDropDown.Size = new System.Drawing.Size(261, 29);
            this.teamSelectDropDown.TabIndex = 23;
            // 
            // teamCreatorLinkLabel
            // 
            this.teamCreatorLinkLabel.AutoSize = true;
            this.teamCreatorLinkLabel.ForeColor = System.Drawing.Color.White;
            this.teamCreatorLinkLabel.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.teamCreatorLinkLabel.Location = new System.Drawing.Point(282, 165);
            this.teamCreatorLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamCreatorLinkLabel.Name = "teamCreatorLinkLabel";
            this.teamCreatorLinkLabel.Size = new System.Drawing.Size(60, 13);
            this.teamCreatorLinkLabel.TabIndex = 22;
            this.teamCreatorLinkLabel.TabStop = true;
            this.teamCreatorLinkLabel.Text = "create new";
            this.teamCreatorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teamCreatorLinkLabel_LinkClicked);
            // 
            // teamSelectLabel
            // 
            this.teamSelectLabel.AutoSize = true;
            this.teamSelectLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.teamSelectLabel.Location = new System.Drawing.Point(74, 145);
            this.teamSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamSelectLabel.Name = "teamSelectLabel";
            this.teamSelectLabel.Size = new System.Drawing.Size(143, 32);
            this.teamSelectLabel.TabIndex = 21;
            this.teamSelectLabel.Text = "Select Team";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeTextBox.Location = new System.Drawing.Point(183, 97);
            this.entryFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(90, 29);
            this.entryFeeTextBox.TabIndex = 20;
            this.entryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.entryFeeLabel.Location = new System.Drawing.Point(74, 91);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(114, 32);
            this.entryFeeLabel.TabIndex = 19;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameTextBox.Location = new System.Drawing.Point(79, 43);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(261, 29);
            this.tournamentNameTextBox.TabIndex = 18;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentNameLabel.Location = new System.Drawing.Point(74, 7);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(215, 32);
            this.tournamentNameLabel.TabIndex = 17;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // UCTournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
            this.Name = "UCTournamentCreator";
            this.Size = new System.Drawing.Size(860, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox teamsPlayersListBox;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.ComboBox teamSelectDropDown;
        private System.Windows.Forms.LinkLabel teamCreatorLinkLabel;
        private System.Windows.Forms.Label teamSelectLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label tournamentNameLabel;
    }
}

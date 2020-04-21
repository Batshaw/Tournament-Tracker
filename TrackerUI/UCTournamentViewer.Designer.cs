namespace TrackerUI
{
    partial class UCTournamentViewer
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
            this.scoreButton = new System.Windows.Forms.Button();
            this.versusLabel = new System.Windows.Forms.Label();
            this.team2ScoreTextBox = new System.Windows.Forms.TextBox();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team2NameLabel = new System.Windows.Forms.Label();
            this.team1ScoreTextBox = new System.Windows.Forms.TextBox();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team1NameLabel = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.uplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scoreButton.Location = new System.Drawing.Point(716, 216);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(107, 51);
            this.scoreButton.TabIndex = 27;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.versusLabel.Location = new System.Drawing.Point(520, 216);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 37);
            this.versusLabel.TabIndex = 26;
            this.versusLabel.Text = "-VS-";
            // 
            // team2ScoreTextBox
            // 
            this.team2ScoreTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.team2ScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.team2ScoreTextBox.Location = new System.Drawing.Point(566, 336);
            this.team2ScoreTextBox.Name = "team2ScoreTextBox";
            this.team2ScoreTextBox.Size = new System.Drawing.Size(67, 33);
            this.team2ScoreTextBox.TabIndex = 25;
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.team2ScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team2ScoreLabel.Location = new System.Drawing.Point(461, 337);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(75, 31);
            this.team2ScoreLabel.TabIndex = 24;
            this.team2ScoreLabel.Text = "Score:";
            // 
            // team2NameLabel
            // 
            this.team2NameLabel.AutoSize = true;
            this.team2NameLabel.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.team2NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team2NameLabel.Location = new System.Drawing.Point(461, 297);
            this.team2NameLabel.Name = "team2NameLabel";
            this.team2NameLabel.Size = new System.Drawing.Size(132, 36);
            this.team2NameLabel.TabIndex = 23;
            this.team2NameLabel.Text = "<Team 2>";
            // 
            // team1ScoreTextBox
            // 
            this.team1ScoreTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.team1ScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.team1ScoreTextBox.Location = new System.Drawing.Point(566, 129);
            this.team1ScoreTextBox.Name = "team1ScoreTextBox";
            this.team1ScoreTextBox.Size = new System.Drawing.Size(67, 33);
            this.team1ScoreTextBox.TabIndex = 22;
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.team1ScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team1ScoreLabel.Location = new System.Drawing.Point(461, 130);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(75, 31);
            this.team1ScoreLabel.TabIndex = 21;
            this.team1ScoreLabel.Text = "Score:";
            // 
            // team1NameLabel
            // 
            this.team1NameLabel.AutoSize = true;
            this.team1NameLabel.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.team1NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team1NameLabel.Location = new System.Drawing.Point(461, 90);
            this.team1NameLabel.Name = "team1NameLabel";
            this.team1NameLabel.Size = new System.Drawing.Size(132, 36);
            this.team1NameLabel.TabIndex = 20;
            this.team1NameLabel.Text = "<Team 1>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(48, 142);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(342, 262);
            this.matchupListBox.TabIndex = 19;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // uplayedOnlyCheckBox
            // 
            this.uplayedOnlyCheckBox.AutoSize = true;
            this.uplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uplayedOnlyCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uplayedOnlyCheckBox.Location = new System.Drawing.Point(209, 102);
            this.uplayedOnlyCheckBox.Name = "uplayedOnlyCheckBox";
            this.uplayedOnlyCheckBox.Size = new System.Drawing.Size(181, 35);
            this.uplayedOnlyCheckBox.TabIndex = 18;
            this.uplayedOnlyCheckBox.Text = "Unplayed Only";
            this.uplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.uplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.uplayedOnlyCheckBox_CheckedChanged);
            // 
            // roundDropDown
            // 
            this.roundDropDown.BackColor = System.Drawing.Color.Gainsboro;
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(133, 75);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(257, 21);
            this.roundDropDown.TabIndex = 17;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.roundLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundLabel.Location = new System.Drawing.Point(42, 64);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(85, 31);
            this.roundLabel.TabIndex = 16;
            this.roundLabel.Text = "Round:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.tournamentName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentName.Location = new System.Drawing.Point(249, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(142, 47);
            this.tournamentName.TabIndex = 15;
            this.tournamentName.Text = "<none>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(40, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(203, 47);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Tournament:";
            // 
            // UCTournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.team2ScoreTextBox);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team2NameLabel);
            this.Controls.Add(this.team1ScoreTextBox);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team1NameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.uplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Name = "UCTournamentViewer";
            this.Size = new System.Drawing.Size(860, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.TextBox team2ScoreTextBox;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label team2NameLabel;
        private System.Windows.Forms.TextBox team1ScoreTextBox;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label team1NameLabel;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox uplayedOnlyCheckBox;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label headerLabel;
    }
}

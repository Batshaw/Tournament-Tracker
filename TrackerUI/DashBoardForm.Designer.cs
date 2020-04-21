using System.Runtime.CompilerServices;
using TrackerLibrary.Models;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.tournamentSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.loadingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.createPrizeViewerButton = new System.Windows.Forms.Button();
            this.creatTeamViewerButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.tournamentViewButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucTournamentViewer = new TrackerUI.UCTournamentViewer(firstTournament);
            this.ucDashboard = new TrackerUI.UCDashboard(this);
            this.ucPrizeCreator = new ClassLibrary2.UCPrizeCreator(this);
            this.ucTeamCreator = new UCTeamCreator(this);
            this.ucTournamentCreator = new UCTournamentCreator(this);
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.dashboardLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardLabel.Location = new System.Drawing.Point(-218, 391);
            this.dashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(397, 46);
            this.dashboardLabel.TabIndex = 1;
            this.dashboardLabel.Text = "Tournament Dashboard";
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
            this.loadButton.Location = new System.Drawing.Point(-82, 597);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(124, 35);
            this.loadButton.TabIndex = 24;
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
            this.tournamentSelectionComboBox.Location = new System.Drawing.Point(-150, 511);
            this.tournamentSelectionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tournamentSelectionComboBox.MaxDropDownItems = 2;
            this.tournamentSelectionComboBox.Name = "tournamentSelectionComboBox";
            this.tournamentSelectionComboBox.Size = new System.Drawing.Size(261, 29);
            this.tournamentSelectionComboBox.TabIndex = 23;
            // 
            // loadingTournamentLabel
            // 
            this.loadingTournamentLabel.AutoSize = true;
            this.loadingTournamentLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.loadingTournamentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadingTournamentLabel.Location = new System.Drawing.Point(-165, 453);
            this.loadingTournamentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingTournamentLabel.Name = "loadingTournamentLabel";
            this.loadingTournamentLabel.Size = new System.Drawing.Size(290, 30);
            this.loadingTournamentLabel.TabIndex = 22;
            this.loadingTournamentLabel.Text = "Loading Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Transparent;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.Location = new System.Drawing.Point(16, 270);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(0);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(197, 54);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.activePanel);
            this.panel2.Controls.Add(this.createPrizeViewerButton);
            this.panel2.Controls.Add(this.creatTeamViewerButton);
            this.panel2.Controls.Add(this.dashboardLabel);
            this.panel2.Controls.Add(this.loadingTournamentLabel);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.loadButton);
            this.panel2.Controls.Add(this.tournamentViewButton);
            this.panel2.Controls.Add(this.tournamentSelectionComboBox);
            this.panel2.Controls.Add(this.createTournamentButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 584);
            this.panel2.TabIndex = 27;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(127)))), ((int)(((byte)(121)))));
            this.activePanel.Location = new System.Drawing.Point(0, 167);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(17, 54);
            this.activePanel.TabIndex = 30;
            // 
            // createPrizeViewerButton
            // 
            this.createPrizeViewerButton.BackColor = System.Drawing.Color.Transparent;
            this.createPrizeViewerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeViewerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeViewerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.createPrizeViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeViewerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeViewerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeViewerButton.Location = new System.Drawing.Point(16, 375);
            this.createPrizeViewerButton.Margin = new System.Windows.Forms.Padding(0);
            this.createPrizeViewerButton.Name = "createPrizeViewerButton";
            this.createPrizeViewerButton.Size = new System.Drawing.Size(197, 54);
            this.createPrizeViewerButton.TabIndex = 29;
            this.createPrizeViewerButton.Text = "Create Prize";
            this.createPrizeViewerButton.UseVisualStyleBackColor = false;
            this.createPrizeViewerButton.Click += new System.EventHandler(this.createPrizeViewerButton_Click);
            // 
            // creatTeamViewerButton
            // 
            this.creatTeamViewerButton.BackColor = System.Drawing.Color.Transparent;
            this.creatTeamViewerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.creatTeamViewerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.creatTeamViewerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.creatTeamViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatTeamViewerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatTeamViewerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creatTeamViewerButton.Location = new System.Drawing.Point(16, 323);
            this.creatTeamViewerButton.Margin = new System.Windows.Forms.Padding(0);
            this.creatTeamViewerButton.Name = "creatTeamViewerButton";
            this.creatTeamViewerButton.Size = new System.Drawing.Size(197, 54);
            this.creatTeamViewerButton.TabIndex = 28;
            this.creatTeamViewerButton.Text = "Create Team";
            this.creatTeamViewerButton.UseVisualStyleBackColor = false;
            this.creatTeamViewerButton.Click += new System.EventHandler(this.creatTeamViewerButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeButton.Location = new System.Drawing.Point(16, 167);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(197, 54);
            this.homeButton.TabIndex = 27;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // tournamentViewButton
            // 
            this.tournamentViewButton.BackColor = System.Drawing.Color.Transparent;
            this.tournamentViewButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tournamentViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.tournamentViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentViewButton.Location = new System.Drawing.Point(16, 220);
            this.tournamentViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.tournamentViewButton.Name = "tournamentViewButton";
            this.tournamentViewButton.Size = new System.Drawing.Size(197, 54);
            this.tournamentViewButton.TabIndex = 26;
            this.tournamentViewButton.Text = "Tournament Viewer";
            this.tournamentViewButton.UseVisualStyleBackColor = false;
            this.tournamentViewButton.Click += new System.EventHandler(this.tournamentViewButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ucTournamentViewer);
            this.panel3.Controls.Add(this.ucDashboard);
            this.panel3.Controls.Add(this.ucPrizeCreator);
            this.panel3.Controls.Add(this.ucTeamCreator);
            this.panel3.Controls.Add(this.ucTournamentCreator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(213, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 427);
            this.panel3.TabIndex = 29;
            // 
            // ucTournamentViewer
            // 
            this.ucTournamentViewer.BackColor = System.Drawing.Color.Transparent;
            this.ucTournamentViewer.Location = new System.Drawing.Point(0, 0);
            this.ucTournamentViewer.Name = "ucTournamentViewer";
            this.ucTournamentViewer.Size = new System.Drawing.Size(860, 427);
            this.ucTournamentViewer.TabIndex = 32;
            this.ucTournamentViewer.Load += new System.EventHandler(this.ucTournamentViewer_Load);
            // 
            // ucDashboard
            // 
            this.ucDashboard.BackColor = System.Drawing.Color.Transparent;
            this.ucDashboard.Location = new System.Drawing.Point(0, 0);
            this.ucDashboard.Name = "ucDashboard";
            this.ucDashboard.Size = new System.Drawing.Size(860, 427);
            this.ucDashboard.TabIndex = 31;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.Location = new System.Drawing.Point(161, -1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 28);
            this.exitButton.TabIndex = 26;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(127)))), ((int)(((byte)(121)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 10);
            this.panel1.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(127)))), ((int)(((byte)(121)))));
            this.panel5.Controls.Add(this.exitButton);
            this.panel5.Location = new System.Drawing.Point(873, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 34);
            this.panel5.TabIndex = 25;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(46)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 594);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox tournamentSelectionComboBox;
        private System.Windows.Forms.Label loadingTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button tournamentViewButton;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button creatTeamViewerButton;
        private UCTeamCreator ucTeamCreator;
        private System.Windows.Forms.Button createPrizeViewerButton;
        private ClassLibrary2.UCPrizeCreator ucPrizeCreator;
        private UCTournamentCreator ucTournamentCreator;
        private UCDashboard ucDashboard;
        private UCTournamentViewer ucTournamentViewer;
        private System.Windows.Forms.Panel activePanel;
    }
}
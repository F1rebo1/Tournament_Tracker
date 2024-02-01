namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            headerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(31, 128);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(298, 35);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(26, 88);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(162, 196);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 35);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(31, 192);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(31, 320);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(298, 38);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(31, 278);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewTeamLink.Location = new Point(213, 288);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(116, 25);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create Team";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(103, 364);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(159, 45);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(103, 493);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(159, 45);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(458, 128);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(319, 152);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(458, 88);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(198, 37);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.ForeColor = Color.Firebrick;
            deleteSelectedPrizeButton.Location = new Point(802, 423);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(159, 78);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            deleteSelectedPrizeButton.Click += deleteSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(458, 346);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(85, 37);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(458, 386);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(319, 152);
            prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.ForeColor = Color.Firebrick;
            deleteSelectedPlayerButton.Location = new Point(802, 165);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(159, 78);
            deleteSelectedPlayerButton.TabIndex = 24;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(317, 587);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(226, 61);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(973, 660);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}
namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameValue.Location = new Point(33, 132);
            teamNameValue.Margin = new Padding(5, 6, 5, 6);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(409, 35);
            teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(33, 89);
            teamNameLabel.Margin = new Padding(5, 0, 5, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(21, 18);
            headerLabel.Margin = new Padding(5, 0, 5, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(213, 50);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            headerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(176, 311);
            addMemberButton.Margin = new Padding(5, 6, 5, 6);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(222, 48);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(33, 249);
            selectTeamMemberDropDown.Margin = new Padding(5, 6, 5, 6);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(409, 38);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(33, 206);
            selectTeamMemberLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            addNewMemberGroupBox.Location = new Point(33, 398);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(409, 366);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(90, 295);
            createMemberButton.Margin = new Padding(5, 6, 5, 6);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(222, 48);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneValue.Location = new Point(198, 231);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(184, 43);
            cellphoneValue.TabIndex = 28;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(21, 227);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(138, 37);
            cellphoneLabel.TabIndex = 27;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(198, 176);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(184, 43);
            emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(21, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(198, 115);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(184, 43);
            lastNameValue.TabIndex = 24;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(21, 111);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 23;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(198, 60);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(184, 43);
            firstNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(21, 56);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(501, 132);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(319, 632);
            teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.ForeColor = Color.Firebrick;
            deleteSelectedMemberButton.Location = new Point(850, 398);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(159, 78);
            deleteSelectedMemberButton.TabIndex = 25;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(353, 786);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(226, 61);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 870);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Form1";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}
namespace WeAreTheChampions.UI
{
    partial class OrganizeMatchDayForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvMatchDetails = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpMatchDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSecondTeamName = new System.Windows.Forms.ComboBox();
            this.cboFirstTeamName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTeam1 = new System.Windows.Forms.NumericUpDown();
            this.nudTeam2 = new System.Windows.Forms.NumericUpDown();
            this.matchDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatchDetails
            // 
            this.dgvMatchDetails.AllowUserToAddRows = false;
            this.dgvMatchDetails.AllowUserToDeleteRows = false;
            this.dgvMatchDetails.AutoGenerateColumns = false;
            this.dgvMatchDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatchDetails.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMatchDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchDateDataGridViewTextBoxColumn,
            this.team1DataGridViewTextBoxColumn,
            this.team2DataGridViewTextBoxColumn,
            this.score1DataGridViewTextBoxColumn,
            this.score2DataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dgvMatchDetails.DataSource = this.matchBindingSource;
            this.dgvMatchDetails.Location = new System.Drawing.Point(22, 194);
            this.dgvMatchDetails.MultiSelect = false;
            this.dgvMatchDetails.Name = "dgvMatchDetails";
            this.dgvMatchDetails.ReadOnly = true;
            this.dgvMatchDetails.RowHeadersVisible = false;
            this.dgvMatchDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchDetails.Size = new System.Drawing.Size(1048, 388);
            this.dgvMatchDetails.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(897, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(691, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpMatchDay
            // 
            this.dtpMatchDay.Location = new System.Drawing.Point(691, 15);
            this.dtpMatchDay.Name = "dtpMatchDay";
            this.dtpMatchDay.Size = new System.Drawing.Size(379, 43);
            this.dtpMatchDay.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Match Day :";
            // 
            // cboSecondTeamName
            // 
            this.cboSecondTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondTeamName.FormattingEnabled = true;
            this.cboSecondTeamName.Location = new System.Drawing.Point(242, 85);
            this.cboSecondTeamName.Name = "cboSecondTeamName";
            this.cboSecondTeamName.Size = new System.Drawing.Size(268, 45);
            this.cboSecondTeamName.TabIndex = 13;
            // 
            // cboFirstTeamName
            // 
            this.cboFirstTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstTeamName.FormattingEnabled = true;
            this.cboFirstTeamName.Location = new System.Drawing.Point(242, 17);
            this.cboFirstTeamName.Name = "cboFirstTeamName";
            this.cboFirstTeamName.Size = new System.Drawing.Size(268, 45);
            this.cboFirstTeamName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "2nd Team Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "1st Team Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 37);
            this.label4.TabIndex = 21;
            this.label4.Text = "Score :";
            // 
            // nudTeam1
            // 
            this.nudTeam1.Location = new System.Drawing.Point(691, 93);
            this.nudTeam1.Name = "nudTeam1";
            this.nudTeam1.Size = new System.Drawing.Size(93, 43);
            this.nudTeam1.TabIndex = 22;
            // 
            // nudTeam2
            // 
            this.nudTeam2.Location = new System.Drawing.Point(977, 91);
            this.nudTeam2.Name = "nudTeam2";
            this.nudTeam2.Size = new System.Drawing.Size(93, 43);
            this.nudTeam2.TabIndex = 23;
            // 
            // matchDateDataGridViewTextBoxColumn
            // 
            this.matchDateDataGridViewTextBoxColumn.DataPropertyName = "MatchDate";
            this.matchDateDataGridViewTextBoxColumn.HeaderText = "MatchDate";
            this.matchDateDataGridViewTextBoxColumn.Name = "matchDateDataGridViewTextBoxColumn";
            this.matchDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // team1DataGridViewTextBoxColumn
            // 
            this.team1DataGridViewTextBoxColumn.DataPropertyName = "Team1";
            this.team1DataGridViewTextBoxColumn.HeaderText = "Team1";
            this.team1DataGridViewTextBoxColumn.Name = "team1DataGridViewTextBoxColumn";
            this.team1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // team2DataGridViewTextBoxColumn
            // 
            this.team2DataGridViewTextBoxColumn.DataPropertyName = "Team2";
            this.team2DataGridViewTextBoxColumn.HeaderText = "Team2";
            this.team2DataGridViewTextBoxColumn.Name = "team2DataGridViewTextBoxColumn";
            this.team2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // score1DataGridViewTextBoxColumn
            // 
            this.score1DataGridViewTextBoxColumn.DataPropertyName = "Score1";
            this.score1DataGridViewTextBoxColumn.HeaderText = "Score1";
            this.score1DataGridViewTextBoxColumn.Name = "score1DataGridViewTextBoxColumn";
            this.score1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // score2DataGridViewTextBoxColumn
            // 
            this.score2DataGridViewTextBoxColumn.DataPropertyName = "Score2";
            this.score2DataGridViewTextBoxColumn.HeaderText = "Score2";
            this.score2DataGridViewTextBoxColumn.Name = "score2DataGridViewTextBoxColumn";
            this.score2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(WeAreTheChampions.UI.Models.Match);
            // 
            // OrganizeMatchDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1074, 588);
            this.Controls.Add(this.nudTeam2);
            this.Controls.Add(this.nudTeam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMatchDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpMatchDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSecondTeamName);
            this.Controls.Add(this.cboFirstTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "OrganizeMatchDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organize Match Day Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatchDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpMatchDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSecondTeamName;
        private System.Windows.Forms.ComboBox cboFirstTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTeam1;
        private System.Windows.Forms.NumericUpDown nudTeam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn score1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}
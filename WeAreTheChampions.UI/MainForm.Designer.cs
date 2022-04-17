namespace WeAreTheChampions.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkHideCompletedMatches = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.matchDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAllListMatch = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTeams,
            this.tsmiColors,
            this.tsmiPlayers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTeams
            // 
            this.tsmiTeams.Name = "tsmiTeams";
            this.tsmiTeams.Size = new System.Drawing.Size(65, 25);
            this.tsmiTeams.Text = "Teams";
            this.tsmiTeams.Click += new System.EventHandler(this.tsmiTeams_Click);
            // 
            // tsmiColors
            // 
            this.tsmiColors.Name = "tsmiColors";
            this.tsmiColors.Size = new System.Drawing.Size(67, 25);
            this.tsmiColors.Text = "Colors";
            this.tsmiColors.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiPlayers
            // 
            this.tsmiPlayers.Name = "tsmiPlayers";
            this.tsmiPlayers.Size = new System.Drawing.Size(72, 25);
            this.tsmiPlayers.Text = "Players";
            this.tsmiPlayers.Click += new System.EventHandler(this.tsmiPlayers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Match List";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoGenerateColumns = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchDateDataGridViewTextBoxColumn,
            this.team1DataGridViewTextBoxColumn,
            this.team2DataGridViewTextBoxColumn,
            this.score1DataGridViewTextBoxColumn,
            this.score2DataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dgvMatches.DataSource = this.matchBindingSource;
            this.dgvMatches.Location = new System.Drawing.Point(13, 136);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(1028, 332);
            this.dgvMatches.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(13, 476);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(236, 61);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(13, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(236, 61);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(13, 611);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(236, 61);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkHideCompletedMatches
            // 
            this.chkHideCompletedMatches.AutoSize = true;
            this.chkHideCompletedMatches.Location = new System.Drawing.Point(13, 678);
            this.chkHideCompletedMatches.Name = "chkHideCompletedMatches";
            this.chkHideCompletedMatches.Size = new System.Drawing.Size(203, 25);
            this.chkHideCompletedMatches.TabIndex = 8;
            this.chkHideCompletedMatches.Text = "Hide Completed Matches";
            this.chkHideCompletedMatches.UseVisualStyleBackColor = true;
            this.chkHideCompletedMatches.CheckedChanged += new System.EventHandler(this.chkHideCompletedMatches_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WeAreTheChampions.UI.Properties.Resources.stadium;
            this.pictureBox3.Location = new System.Drawing.Point(256, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(785, 227);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WeAreTheChampions.UI.Properties.Resources.supporter;
            this.pictureBox2.Location = new System.Drawing.Point(590, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeAreTheChampions.UI.Properties.Resources.volley;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // chkAllListMatch
            // 
            this.chkAllListMatch.AutoSize = true;
            this.chkAllListMatch.Location = new System.Drawing.Point(12, 701);
            this.chkAllListMatch.Name = "chkAllListMatch";
            this.chkAllListMatch.Size = new System.Drawing.Size(122, 25);
            this.chkAllListMatch.TabIndex = 10;
            this.chkAllListMatch.Text = "All List Match";
            this.chkAllListMatch.UseVisualStyleBackColor = true;
            this.chkAllListMatch.CheckedChanged += new System.EventHandler(this.chkAllListMatch_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 730);
            this.Controls.Add(this.chkAllListMatch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chkHideCompletedMatches);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are the Champions";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeams;
        private System.Windows.Forms.ToolStripMenuItem tsmiColors;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkHideCompletedMatches;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn score1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkAllListMatch;
    }
}
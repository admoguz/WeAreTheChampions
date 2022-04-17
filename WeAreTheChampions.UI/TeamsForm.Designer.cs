namespace WeAreTheChampions.UI
{
    partial class TeamsForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecondColor = new System.Windows.Forms.Label();
            this.lblFirstColor = new System.Windows.Forms.Label();
            this.cboSecondColor = new System.Windows.Forms.ComboBox();
            this.cboFirstColor = new System.Windows.Forms.ComboBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1stColor = new System.Windows.Forms.Label();
            this.lbl2ndColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListPlayers = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSecondColor);
            this.groupBox1.Controls.Add(this.lblFirstColor);
            this.groupBox1.Controls.Add(this.cboSecondColor);
            this.groupBox1.Controls.Add(this.cboFirstColor);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Team";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(490, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(336, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "List Teams";
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.BackColor = System.Drawing.Color.White;
            this.lblSecondColor.ForeColor = System.Drawing.Color.White;
            this.lblSecondColor.Location = new System.Drawing.Point(688, 145);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(34, 34);
            this.lblSecondColor.TabIndex = 3;
            // 
            // lblFirstColor
            // 
            this.lblFirstColor.BackColor = System.Drawing.Color.White;
            this.lblFirstColor.ForeColor = System.Drawing.Color.White;
            this.lblFirstColor.Location = new System.Drawing.Point(688, 95);
            this.lblFirstColor.Name = "lblFirstColor";
            this.lblFirstColor.Size = new System.Drawing.Size(34, 34);
            this.lblFirstColor.TabIndex = 3;
            // 
            // cboSecondColor
            // 
            this.cboSecondColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboSecondColor.FormattingEnabled = true;
            this.cboSecondColor.Location = new System.Drawing.Point(490, 143);
            this.cboSecondColor.Name = "cboSecondColor";
            this.cboSecondColor.Size = new System.Drawing.Size(180, 33);
            this.cboSecondColor.TabIndex = 2;
            this.cboSecondColor.SelectedIndexChanged += new System.EventHandler(this.cboSecondColor_SelectedIndexChanged);
            // 
            // cboFirstColor
            // 
            this.cboFirstColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboFirstColor.FormattingEnabled = true;
            this.cboFirstColor.Location = new System.Drawing.Point(490, 95);
            this.cboFirstColor.Name = "cboFirstColor";
            this.cboFirstColor.Size = new System.Drawing.Size(180, 33);
            this.cboFirstColor.TabIndex = 2;
            this.cboFirstColor.SelectedIndexChanged += new System.EventHandler(this.cboFirstColor_SelectedIndexChanged);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeamName.Location = new System.Drawing.Point(13, 102);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(309, 33);
            this.txtTeamName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(336, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "2nd Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "1st Color :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // lbl1stColor
            // 
            this.lbl1stColor.BackColor = System.Drawing.Color.Teal;
            this.lbl1stColor.ForeColor = System.Drawing.Color.White;
            this.lbl1stColor.Location = new System.Drawing.Point(19, 207);
            this.lbl1stColor.Name = "lbl1stColor";
            this.lbl1stColor.Size = new System.Drawing.Size(550, 50);
            this.lbl1stColor.TabIndex = 4;
            this.lbl1stColor.Text = "1st Color";
            this.lbl1stColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2ndColor
            // 
            this.lbl2ndColor.BackColor = System.Drawing.Color.Teal;
            this.lbl2ndColor.ForeColor = System.Drawing.Color.White;
            this.lbl2ndColor.Location = new System.Drawing.Point(19, 263);
            this.lbl2ndColor.Name = "lbl2ndColor";
            this.lbl2ndColor.Size = new System.Drawing.Size(550, 50);
            this.lbl2ndColor.TabIndex = 4;
            this.lbl2ndColor.Text = "2nd Color";
            this.lbl2ndColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tomato;
            this.btnAdd.Location = new System.Drawing.Point(569, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListPlayers.Location = new System.Drawing.Point(569, 273);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(175, 50);
            this.btnListPlayers.TabIndex = 5;
            this.btnListPlayers.Text = "List Players";
            this.btnListPlayers.UseVisualStyleBackColor = false;
            this.btnListPlayers.Click += new System.EventHandler(this.btnListPlayers_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 37;
            this.lstTeams.Location = new System.Drawing.Point(13, 329);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(731, 226);
            this.lstTeams.TabIndex = 6;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.Location = new System.Drawing.Point(569, 561);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 50);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Location = new System.Drawing.Point(388, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 50);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(756, 622);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl2ndColor);
            this.Controls.Add(this.lbl1stColor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teams Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSecondColor;
        private System.Windows.Forms.ComboBox cboFirstColor;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstColor;
        private System.Windows.Forms.Label lblSecondColor;
        private System.Windows.Forms.Label lbl1stColor;
        private System.Windows.Forms.Label lbl2ndColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnListPlayers;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}
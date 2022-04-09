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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFirstColor = new System.Windows.Forms.ComboBox();
            this.cboSecondColor = new System.Windows.Forms.ComboBox();
            this.lblFirstColor = new System.Windows.Forms.Label();
            this.lblSecondColor = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(731, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeamName.Location = new System.Drawing.Point(13, 94);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(309, 33);
            this.txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "1st Color :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(328, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "2nd Color :";
            // 
            // cboFirstColor
            // 
            this.cboFirstColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboFirstColor.FormattingEnabled = true;
            this.cboFirstColor.Location = new System.Drawing.Point(482, 46);
            this.cboFirstColor.Name = "cboFirstColor";
            this.cboFirstColor.Size = new System.Drawing.Size(180, 33);
            this.cboFirstColor.TabIndex = 2;
            // 
            // cboSecondColor
            // 
            this.cboSecondColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboSecondColor.FormattingEnabled = true;
            this.cboSecondColor.Location = new System.Drawing.Point(482, 94);
            this.cboSecondColor.Name = "cboSecondColor";
            this.cboSecondColor.Size = new System.Drawing.Size(180, 33);
            this.cboSecondColor.TabIndex = 2;
            // 
            // lblFirstColor
            // 
            this.lblFirstColor.BackColor = System.Drawing.Color.White;
            this.lblFirstColor.ForeColor = System.Drawing.Color.White;
            this.lblFirstColor.Location = new System.Drawing.Point(680, 46);
            this.lblFirstColor.Name = "lblFirstColor";
            this.lblFirstColor.Size = new System.Drawing.Size(34, 34);
            this.lblFirstColor.TabIndex = 3;
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.BackColor = System.Drawing.Color.White;
            this.lblSecondColor.ForeColor = System.Drawing.Color.White;
            this.lblSecondColor.Location = new System.Drawing.Point(680, 93);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(34, 34);
            this.lblSecondColor.TabIndex = 3;
            // 
            // lbl1stColor
            // 
            this.lbl1stColor.BackColor = System.Drawing.Color.Teal;
            this.lbl1stColor.ForeColor = System.Drawing.Color.White;
            this.lbl1stColor.Location = new System.Drawing.Point(13, 160);
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
            this.lbl2ndColor.Location = new System.Drawing.Point(13, 216);
            this.lbl2ndColor.Name = "lbl2ndColor";
            this.lbl2ndColor.Size = new System.Drawing.Size(550, 50);
            this.lbl2ndColor.TabIndex = 4;
            this.lbl2ndColor.Text = "2nd Color";
            this.lbl2ndColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tomato;
            this.btnAdd.Location = new System.Drawing.Point(569, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListPlayers.Location = new System.Drawing.Point(569, 216);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(175, 50);
            this.btnListPlayers.TabIndex = 5;
            this.btnListPlayers.Text = "List Players";
            this.btnListPlayers.UseVisualStyleBackColor = false;
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 37;
            this.lstTeams.Location = new System.Drawing.Point(13, 272);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(731, 226);
            this.lstTeams.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.Location = new System.Drawing.Point(569, 504);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 50);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Location = new System.Drawing.Point(388, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 50);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(756, 566);
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
    }
}
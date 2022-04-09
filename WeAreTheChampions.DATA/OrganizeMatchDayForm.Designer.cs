
namespace WeAreTheChampions.DATA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFirstTeamName = new System.Windows.Forms.ComboBox();
            this.cboSecondTeamName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMatchDay = new System.Windows.Forms.DateTimePicker();
            this.txtMatchTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvMatchDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Team Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd Team Name : ";
            // 
            // cboFirstTeamName
            // 
            this.cboFirstTeamName.FormattingEnabled = true;
            this.cboFirstTeamName.Location = new System.Drawing.Point(207, 16);
            this.cboFirstTeamName.Name = "cboFirstTeamName";
            this.cboFirstTeamName.Size = new System.Drawing.Size(268, 41);
            this.cboFirstTeamName.TabIndex = 2;
            // 
            // cboSecondTeamName
            // 
            this.cboSecondTeamName.FormattingEnabled = true;
            this.cboSecondTeamName.Location = new System.Drawing.Point(207, 85);
            this.cboSecondTeamName.Name = "cboSecondTeamName";
            this.cboSecondTeamName.Size = new System.Drawing.Size(268, 41);
            this.cboSecondTeamName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Match Day :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Match Time :";
            // 
            // dtpMatchDay
            // 
            this.dtpMatchDay.Location = new System.Drawing.Point(688, 13);
            this.dtpMatchDay.Name = "dtpMatchDay";
            this.dtpMatchDay.Size = new System.Drawing.Size(379, 40);
            this.dtpMatchDay.TabIndex = 5;
            // 
            // txtMatchTime
            // 
            this.txtMatchTime.Location = new System.Drawing.Point(688, 85);
            this.txtMatchTime.Name = "txtMatchTime";
            this.txtMatchTime.Size = new System.Drawing.Size(379, 40);
            this.txtMatchTime.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.Location = new System.Drawing.Point(688, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(894, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 50);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dgvMatchDetails
            // 
            this.dgvMatchDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatchDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatchDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchDetails.Location = new System.Drawing.Point(20, 192);
            this.dgvMatchDetails.MultiSelect = false;
            this.dgvMatchDetails.Name = "dgvMatchDetails";
            this.dgvMatchDetails.RowHeadersVisible = false;
            this.dgvMatchDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchDetails.Size = new System.Drawing.Size(1047, 388);
            this.dgvMatchDetails.TabIndex = 9;
            // 
            // OrganizeMatchDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1083, 592);
            this.Controls.Add(this.dgvMatchDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMatchTime);
            this.Controls.Add(this.dtpMatchDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSecondTeamName);
            this.Controls.Add(this.cboFirstTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "OrganizeMatchDayForm";
            this.Text = "Organize Match Day Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFirstTeamName;
        private System.Windows.Forms.ComboBox cboSecondTeamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMatchDay;
        private System.Windows.Forms.TextBox txtMatchTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvMatchDetails;
    }
}
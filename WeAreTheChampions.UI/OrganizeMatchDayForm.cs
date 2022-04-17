using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.UI.Models;

namespace WeAreTheChampions.UI
{
    public partial class OrganizeMatchDayForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public OrganizeMatchDayForm()
        {
            InitializeComponent();
            OrganizeMatchList();
            ListTeam();
        }

        private void ListTeam()
        {
            cboFirstTeamName.DataSource = db.Teams.ToList();
            cboFirstTeamName.DisplayMember = "TeamName";
            cboSecondTeamName.DataSource = db.Teams.ToList();
            cboSecondTeamName.DisplayMember = "TeamName";
        }

        private void OrganizeMatchList()
        {
            dgvMatchDetails.AutoGenerateColumns = false;
            dgvMatchDetails.DataSource = db.Matches.ToList();
            dgvMatchDetails.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            
            Match match = new Match();
            match = (Match)dgvMatchDetails.SelectedRows[0].DataBoundItem;

            if (cboFirstTeamName.SelectedItem == cboSecondTeamName.SelectedItem)
            {
                MessageBox.Show("There cannot be a match between the same teams.");
                return;
            }

            match.Team1 = (Team)cboFirstTeamName.SelectedItem;
            match.Team2 = (Team)cboSecondTeamName.SelectedItem;
            match.MatchDate = dtpMatchDay.Value;
            match.Score1 = (int?)nudTeam1.Value;
            match.Score2 = (int?)nudTeam2.Value;
            if (nudTeam1.Value > nudTeam2.Value)
            {
                match.Result = Result.Team1Win;
            }
            else if (nudTeam2.Value > nudTeam1.Value)
            {
                match.Result = Result.Team2Win;
            }
            else
            {
                match.Result = Result.Draw;
            }            
            db.SaveChanges();
            OrganizeMatchList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class MatchDayForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public MatchDayForm()
        {
            InitializeComponent();
            ListTeam();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            Team team1 = new Team();
            team1 = (Team)cboFirstTeamName.SelectedItem;
            Team team2 = new Team();
            team2 = (Team)cboSecondTeamName.SelectedItem;

            Match match = new Match();
            match.Team1Id = team1.Id;
            match.Team2Id = team2.Id;
            match.Team1 = team1;
            match.Team2 = team2;
            if (cboFirstTeamName.SelectedItem==cboSecondTeamName.SelectedItem)
            {
                MessageBox.Show("There cannot be a match between the same teams.");
                return;
            }

            match.MatchDate = dtpMatchDate.Value;           
            db.Matches.Add(match);
            db.SaveChanges();
            ListTeam();           
        }

        private void ListTeam()
        {
            cboFirstTeamName.DataSource = db.Teams.ToList();
            cboFirstTeamName.DisplayMember = "TeamName";
            cboSecondTeamName.DataSource = db.Teams.ToList();
            cboSecondTeamName.DisplayMember = "TeamName";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboFirstTeamName.SelectedItem = 0;
            cboSecondTeamName.SelectedItem = 0;
            dtpMatchDate.Value = DateTime.Now;          
        }
    }
}

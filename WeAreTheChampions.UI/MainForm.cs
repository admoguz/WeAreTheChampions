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
    public partial class MainForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public MainForm()
        {
            InitializeComponent();
            ListMatch();
        }

        public void ListMatch()
        {
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.DataSource = db.Matches.ToList();            
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.ShowDialog();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm();
            colorsForm.ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MatchDayForm matchDayForm = new MatchDayForm();
            matchDayForm.ShowDialog();
            ListMatch();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
            db.Matches.Remove(match);
            db.SaveChanges();
            ListMatch();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OrganizeMatchDayForm organizeMatchDayForm = new OrganizeMatchDayForm();
            organizeMatchDayForm.ShowDialog();
        }

        private void chkHideCompletedMatches_CheckedChanged(object sender, EventArgs e)
        {
            Match match = new Match();
            dgvMatches.DataSource = db.Matches.Where(x => x.MatchDate > DateTime.Now).ToList();
        }

        private void chkAllListMatch_CheckedChanged(object sender, EventArgs e)
        {
            ListMatch();
        }
    }
}

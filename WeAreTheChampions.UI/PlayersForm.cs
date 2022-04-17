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
    public partial class PlayersForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public PlayersForm()
        {
            InitializeComponent();
            ListPlayers();
            FillTeams();
        }

        private void FillTeams()
        {
            cboTeamName.DataSource = db.Teams.ToList();
            cboTeamName.DisplayMember = "TeamName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text=="")
            {
                MessageBox.Show("This field is not empty");
                return;
            }
            else
            {
                Player player = new Player();
                player.PlayerName = txtPlayerName.Text;
                Team team = new Team();
                team = (Team)cboTeamName.SelectedItem;
                player.TeamId = team.Id;
                db.Players.Add(player);
                db.SaveChanges();
                ListPlayers();
                txtPlayerName.Clear();
            }
        }

        private void ListPlayers()
        {
            lstPlayers.DataSource = db.Players.ToList();
            lstPlayers.DisplayMember = "PlayerName";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0) return;
            if (txtPlayerName.Text == "") return;

            Player player = new Player();
            player = (Player)lstPlayers.SelectedItem;            

            Team team = new Team();
            team = (Team)cboTeamName.SelectedItem;

            player.PlayerName = txtPlayerName.Text;            
            player.TeamId = team.Id;

            db.SaveChanges();
            ListPlayers();
            txtPlayerName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player = (Player)lstPlayers.SelectedItem;
            db.Players.Remove(player);
            db.SaveChanges();
            ListPlayers();
        }

        private void cboListPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPlayers();            
        }

        private void cboTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = new Team();
            team = (Team)cboTeamName.SelectedItem;

            lstPlayers.DataSource = db.Players.Where(x=>x.TeamId==team.Id).ToList();            
        }

        private void btnAllListPlayers_Click(object sender, EventArgs e)
        {
            lstPlayers.DataSource = db.Players.ToList();
        }
    }
}

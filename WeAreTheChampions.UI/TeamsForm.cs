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
    public partial class TeamsForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public TeamsForm()
        {
            InitializeComponent();
            ListTeams();
            FillColors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "")
            {
                MessageBox.Show("Plase fill teamname field");
                return;
            }
            else
            {
                Team team = new Team();
                team.TeamName = txtTeamName.Text;               
                db.Teams.Add(team);
                var selectedTeam = (Team)lstTeams.SelectedItem;
                

                db.SaveChanges();
                BackToOrginal();
                ListTeams();
            }
        }

        private void BackToOrginal()
        {
            txtTeamName.Clear();
            cboFirstColor.SelectedIndex = 0;
            cboSecondColor.SelectedIndex = 0;
            lblFirstColor.BackColor = System.Drawing.Color.White;
            lblSecondColor.BackColor = System.Drawing.Color.White;
            lbl1stColor.BackColor = System.Drawing.Color.Transparent;
            lbl2ndColor.BackColor = System.Drawing.Color.Transparent;
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
            lstTeams.DisplayMember = "TeamName";
        }

        private void FillColors()
        {
            cboFirstColor.DataSource = db.Colors.ToList();
            cboFirstColor.DisplayMember = "ColorName";
            cboSecondColor.DataSource = db.Colors.ToList();
            cboSecondColor.DisplayMember = "ColorName";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTeams.SelectedIndex < 0) return;
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                db.Teams.Remove(selectedTeam);
                db.SaveChanges();
                ListTeams();
            }
            catch (Exception)
            {
                MessageBox.Show("You can't delete this team. Because there are available matches!", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboFirstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFirstColor.SelectedIndex < 0) return;

            var selectedColor = (Models.Color)cboFirstColor.SelectedItem;
            byte r, g, b;
            r = selectedColor.Red;
            g = selectedColor.Green;
            b = selectedColor.Blue;

            lblFirstColor.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void cboSecondColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondColor.SelectedIndex < 0) return;

            var selectedColor = (Models.Color)cboSecondColor.SelectedItem;
            byte r, g, b;
            r = selectedColor.Red;
            g = selectedColor.Green;
            b = selectedColor.Blue;

            lblSecondColor.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0) return;

            var selectedTeam = (Team)lstTeams.SelectedItem;
            selectedTeam.TeamName = txtTeamName.Text;
            lstTeams.Enabled = false;

            var colors = selectedTeam.Colors.ToList();
            if (colors.Count == 1)
                cboFirstColor.SelectedItem = colors[0];
            else if (colors.Count == 2)
            {
                cboFirstColor.SelectedItem = colors[0];
                cboSecondColor.SelectedItem = colors[1];
            }
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = (Team)lstTeams.SelectedItem;
            List<Models.Color> colors = team.Colors.ToList();
            if (colors.Count == 0 || colors == null)
            {
                lbl1stColor.BackColor = System.Drawing.Color.Transparent;
                lbl2ndColor.BackColor = System.Drawing.Color.Transparent;
            }
            else if (colors.Count == 1)
            {
                lbl1stColor.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lbl2ndColor.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                lbl1stColor.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lbl2ndColor.BackColor = System.Drawing.Color.FromArgb(colors[1].Red, colors[1].Green, colors[1].Blue);
            }
        }
    }
}

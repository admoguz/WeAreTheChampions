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
    public partial class ColorsForm : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public ColorsForm()
        {
            InitializeComponent();
            ListColors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text == "")
            {
                MessageBox.Show("This field is not empty");
                return;
            }
            else
            {
                Models.Color color = new Models.Color();
                color.ColorName = txtColorName.Text;
                color.Blue = (byte)hsbBlue.Value;
                color.Green = (byte)hsbGreen.Value;
                color.Red = (byte)hsbRed.Value;
                db.Colors.Add(color);
                db.SaveChanges();
                BackToOrginal();
                ListColors();
            }
        }

        private void BackToOrginal()
        {
            txtColorName.Clear();
            hsbBlue.Value = hsbGreen.Value = hsbRed.Value = hsbRed.Minimum;
            lblBlue.Text = lblGreen.Text = lblRed.Text = "000";
            lblColor.BackColor = System.Drawing.Color.Black;
        }

        private void ListColors()
        {
            lstColors.DataSource = db.Colors.ToList();
            lstColors.DisplayMember = "ColorName"; // Adını görmemiz için
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex == 0)
                lblSelectedColor.BackColor = System.Drawing.Color.Transparent;
            if (lstColors.SelectedIndex < 0)
                return;
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            db.Colors.Remove(selectedColor);
            db.SaveChanges();
            ListColors();
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            lblSelectedColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Text = "Save";
            btnEdit.BackColor = System.Drawing.Color.Crimson;

            if (lstColors.SelectedIndex < 0) return;

            var selectedColor = (Models.Color)lstColors.SelectedItem;

            txtColorName.Text = lstColors.SelectedIndex.ToString();
            selectedColor.Blue = (byte)hsbBlue.Value;
            selectedColor.Green = (byte)hsbGreen.Value;
            selectedColor.Red = (byte)hsbRed.Value;
            db.SaveChanges();
            ListColors();
            BackToOrginal();          
        }
    }
}

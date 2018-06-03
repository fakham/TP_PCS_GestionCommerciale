using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PCS_GestionCommerciale2
{
    public partial class Form_ListeCommandes_ModeDeconnecte : Form
    {
        public Form_ListeCommandes_ModeDeconnecte()
        {
            InitializeComponent();
        }

        private void Form_ListeCommandes_ModeDeconnecte_Load(object sender, EventArgs e)
        {
            comboBox_nomClient.DisplayMember = "Nom";
            comboBox_nomClient.ValueMember = "CodeCl";
            comboBox_nomClient.DataSource = Program.DS.Tables["Client"];
        }

        private void ChargerDGV()
        {
            dataGridView_cmds.Rows.Clear();
            DataRow[] rows = Program.DS.Tables["Commande"].Select("CodeCl = " + comboBox_nomClient.SelectedValue);
            foreach (DataRow r in rows)
            {
                dataGridView_cmds.Rows.Add(r[0], r[1], "Voir", false);
            }
        }

        private void comboBox_nomClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_codeCl.Text = "Code : " + comboBox_nomClient.SelectedValue.ToString();
            DataRow dr = Program.DS.Tables["Client"].Rows.Find(comboBox_nomClient.SelectedValue);
            label_villeCl.Text = "Ville : " + dr["Ville"].ToString();

            ChargerDGV();
        }

        private void dataGridView_cmds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
                dataGridView_cmds.CurrentRow.Cells[3].Value = !((bool)dataGridView_cmds.CurrentRow.Cells[3].Value);
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView_cmds.Rows)
            {
                if ((bool)r.Cells[3].Value == true)
                    Program.DS.Tables["Commande"].Rows.Find(r.Cells[0].Value).Delete();
            }
            ChargerDGV();
        }
    }
}

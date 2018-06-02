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
    public partial class Form_ConsultationCommande : Form
    {
        public Form_ConsultationCommande()
        {
            InitializeComponent();
        }

        private void Form_ConsultationCommande_Load(object sender, EventArgs e)
        {
            comboBox_codeCl.DisplayMember = "CodeCl";
            comboBox_codeCl.ValueMember = "CodeCl";
            comboBox_codeCl.DataSource = Program.ExecuteCmdsSelection("select CodeCl from Client");

            dataGridView_cmds.DataSource = Program.ExecuteCmdsSelection("select * from Commande where CodeCl = " + comboBox_codeCl.Text);
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_codeCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecuteCmdsSelection("select * from Client where CodeCl = " + comboBox_codeCl.Text);
            textBox_nomCl.Text = dt.Rows[0]["Nom"].ToString();
            textBox_villeCl.Text = dt.Rows[0]["Ville"].ToString();

            dataGridView_cmds.DataSource = Program.ExecuteCmdsSelection("select * from Commande where CodeCl = " + comboBox_codeCl.Text);

            CalculerCA();
        }

        private void dataGridView_cmds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_cmds.CurrentRow != null)
            {
                string numCmd = dataGridView_cmds.CurrentRow.Cells[0].Value.ToString();

                DataTable dt = Program.ExecuteCmdsSelection(
                                            @"select A.CodeArt as 'Code Article', A.Designation, A.PU, 
                                            D.Qte as 'Quantité', (A.PU * D.Qte) as 'Montant'
                                            from Detail D
                                            inner join Article A on D.CodeArt = A.CodeArt
                                            where NumCom = " + numCmd);

                dataGridView_articles.DataSource = dt;

                decimal total = 0M;

                foreach (DataGridViewRow r in dataGridView_articles.Rows)
                {
                    total += decimal.Parse(r.Cells[4].Value.ToString());
                }

                textBox_total.Text = total.ToString();
                textBox_tva.Text = "0%";
                textBox_ttc.Text = total.ToString();
            }
        }

        private void button_supprimerCmd_Click(object sender, EventArgs e)
        {
            if (dataGridView_cmds.CurrentRow != null)
            {
                string numCmd = dataGridView_cmds.CurrentRow.Cells[0].Value.ToString();

                Program.ExecuteCmdsNonQuery("delete detail where NumCom = " + numCmd);
                Program.ExecuteCmdsNonQuery("delete commande where NumCom = " + numCmd);

                CalculerCA();

                MessageBox.Show("La commande à été supprimée!");
            }
        }

        private void CalculerCA()
        {
            textBox_CA.Text = Program.ExecuteCmdsScalar(@"select sum(A.PU * D.Qte)
                                                        from Detail D
                                                        inner join Article A on D.CodeArt = A.CodeArt
                                                        inner join Commande C on D.NumCom = C.NumCom
                                                        where C.CodeCl = " + comboBox_codeCl.Text);
        }
    }
}

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
    public partial class Form_AjouterCommande : Form
    {
        public Form_AjouterCommande()
        {
            InitializeComponent();
        }

        private void Form_AjouterCommande_Load(object sender, EventArgs e)
        {
            comboBox_codeCl.DisplayMember = "CodeCl";
            comboBox_codeCl.ValueMember = "CodeCl";
            comboBox_codeCl.DataSource = Program.ExecuteCmdsSelection("select CodeCl from client");

            comboBox_codeArt.DisplayMember = "CodeArt";
            comboBox_codeArt.ValueMember = "CodeArt";
            comboBox_codeArt.DataSource = Program.ExecuteCmdsSelection("select CodeArt from Article");
        }

        private void comboBox_codeCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecuteCmdsSelection("select * from Client where CodeCl = " + comboBox_codeCl.Text);
            textBox_nomCl.Text = dt.Rows[0]["Nom"].ToString();
            textBox_villeCl.Text = dt.Rows[0]["Ville"].ToString();
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_codeArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecuteCmdsSelection("select * from Article where codeArt = " + comboBox_codeArt.Text);
            textBox_designationArt.Text = dt.Rows[0]["Designation"].ToString();
            textBox_puArt.Text = dt.Rows[0]["PU"].ToString();
        }

        private void button_AjouterLigne_Click(object sender, EventArgs e)
        {
            int QStock = int.Parse(Program.ExecuteCmdsSelection("select QStock from Article where CodeArt = " 
                         + comboBox_codeArt.Text).Rows[0]["QStock"].ToString());

            if (QStock >= int.Parse(textBox_qunatiteArt.Text))
            {
                dataGridView_articles.Rows.Add(comboBox_codeArt.Text, textBox_designationArt.Text, textBox_puArt.Text,
                                               textBox_qunatiteArt.Text,
                                               decimal.Parse(textBox_qunatiteArt.Text) * decimal.Parse(textBox_puArt.Text));
            }
            else
                MessageBox.Show("Stock insuffisant !");


            CalculerTotal();
        }

        private void CalculerTotal()
        {
            decimal total = 0M;

            foreach (DataGridViewRow r in dataGridView_articles.Rows)
            {
                total += decimal.Parse(r.Cells[4].Value.ToString());
            }

            textBox_total.Text = total.ToString();
        }

        private void button_supprimerLigne_Click(object sender, EventArgs e)
        {
            dataGridView_articles.Rows.Remove(dataGridView_articles.CurrentRow);

            CalculerTotal();
        }

        private void button_enregistrerCmd_Click(object sender, EventArgs e)
        {
            string reqCmd = string.Format("insert into Commande values({0}, '{1}', {2})", textBox_numeroCmd.Text,
                                          dateTimePicker_dateCmd.Text, comboBox_codeCl.Text);

            Program.ExecuteCmdsNonQuery(reqCmd);

            foreach(DataGridViewRow r in dataGridView_articles.Rows)
            {
                string reqDet = string.Format("insert into Detail values({0}, {1}, {2})", textBox_numeroCmd.Text,
                                              r.Cells[0].Value.ToString(), r.Cells[3].Value.ToString());

                Program.ExecuteCmdsNonQuery(reqDet);

                string reqArt = string.Format("update article set QStock = QStock - {0} where codeArt = {1}",
                                              r.Cells[3].Value.ToString(), r.Cells[0].Value.ToString());

                Program.ExecuteCmdsNonQuery(reqArt);
            }

            textBox_designationArt.Clear();
            textBox_nomCl.Clear();
            textBox_numeroCmd.Clear();
            textBox_puArt.Clear();
            textBox_qunatiteArt.Clear();
            textBox_total.Text = "0";
            textBox_villeCl.Clear();
            dateTimePicker_dateCmd.Value = DateTime.Now;
            dataGridView_articles.Rows.Clear();
            comboBox_codeArt.SelectedIndex = 0;
            comboBox_codeCl.SelectedIndex = 0;

            MessageBox.Show("La commande à été bien enregistrée!");
        }
    }
}

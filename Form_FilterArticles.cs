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
    public partial class Form_FilterArticles : Form
    {
        public Form_FilterArticles()
        {
            InitializeComponent();
        }

        private void Form_FilterArticles_Load(object sender, EventArgs e)
        {
            dataGridView_articles.DataSource = Program.DS.Tables["Article"];
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.Text = "Delete";
            link.HeaderText = "Supprimer";
            link.UseColumnTextForLinkValue = true;
            dataGridView_articles.Columns.Add(link);
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            string description = "%";
            string PU = ">= 0";
            string Qtte = ">= 0";

            if (checkBox_description.Checked)
                description = textBox_description.Text;
            if (checkBox_PU.Checked)
                PU = " = " + textBox_PU.Text;
            if (checkBox_QtteStock.Checked)
                Qtte = " = " + textBox_QtteStock.Text;

            DataView dv = new DataView(Program.DS.Tables["Article"]);
            dv.RowFilter = string.Format("Designation like '{0}' and PU {1} and QStock {2}", description, PU, Qtte);
            dataGridView_articles.DataSource = dv;
        }

        private void dataGridView_articles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string art = dataGridView_articles.CurrentRow.Cells[0].Value.ToString();
                Program.DS.Tables["Article"].Rows.Find(art).Delete();
                button_recherche_Click(sender, e);
            }
        }

        private void button_XML_Click(object sender, EventArgs e)
        {
            Program.DS.WriteXml("Articles.xml", XmlWriteMode.DiffGram);
            MessageBox.Show("Export terminé!");
        }

        private void button_imprimer_Click(object sender, EventArgs e)
        {
            Form_ImprimerArticles f = new Form_ImprimerArticles();
            f.Show();
        }
    }
}

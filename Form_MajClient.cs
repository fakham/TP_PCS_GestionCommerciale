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
    public partial class Form_MajClient : Form
    {
        BindingSource bs = new BindingSource();

        public Form_MajClient()
        {
            InitializeComponent();
        }

        private void Form_MajClient_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.ExecuteCmdsSelection("select * from client");

            textBox_code.DataBindings.Add("Text", bs, "CodeCl");
            textBox_nom.DataBindings.Add("Text", bs, "Nom");
            textBox_ville.DataBindings.Add("Text", bs, "Ville");
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button_first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Find("CodeCl", textBox_codeR.Text);
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (button_ajouter.Text == "Nouveau")
            {
                bs.AddNew();
                button_ajouter.Text = "Ajouter";
                MessageBox.Show("Veuillez saisir les informations.");
            }
            else
            {
                bs.EndEdit();
                button_ajouter.Text = "Nouveau";
                MessageBox.Show("Client ajoutée avec succès!");
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            MessageBox.Show("Client modifié avec succès!");
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            MessageBox.Show("Client supprimée avec succès!");
        }
    }
}

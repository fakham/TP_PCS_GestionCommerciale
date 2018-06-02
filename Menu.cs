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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listeNomClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeNomClients f = new Form_ListeNomClients();
            f.Show();
        }

        private void listeClientsParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeClientsVille f = new Form_ListeClientsVille();
            f.Show();
        }

        private void nombreClientsParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NombreClientsParVille f = new Form_NombreClientsParVille();
            f.Show();
        }

        private void mAJClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MajClient f = new Form_MajClient();
            f.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AjouterCommande f = new Form_AjouterCommande();
            f.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ConsultationCommande f = new Form_ConsultationCommande();
            f.Show();
        }
    }
}

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
    public partial class Form_NombreClientsParVille : Form
    {
        public Form_NombreClientsParVille()
        {
            InitializeComponent();
        }

        private void Form_NombreClientsParVille_Load(object sender, EventArgs e)
        {
            comboBox_ville.DisplayMember = "Ville";
            comboBox_ville.ValueMember = "Ville";

            comboBox_ville.DataSource = Program.ExecuteCmdsSelection("select distinct ville from client");
        }

        private void comboBox_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = "select count(*) from client where ville = '" + comboBox_ville.Text + "'";
            label_nombre.Text = Program.ExecuteCmdsScalar(req);
        }
    }
}

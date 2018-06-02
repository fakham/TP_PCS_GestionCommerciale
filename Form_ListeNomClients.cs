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
    public partial class Form_ListeNomClients : Form
    {
        public Form_ListeNomClients()
        {
            InitializeComponent();
        }

        private void Form_ListeNomClients_Load(object sender, EventArgs e)
        {
            listBox_nomClients.DisplayMember = "Nom";
            listBox_nomClients.ValueMember = "CodeCl";

            listBox_nomClients.DataSource = Program.ExecuteCmdsSelection("select * from Client");
        }
    }
}

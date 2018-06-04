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
    public partial class Form_EtatClient : Form
    {
        public Form_EtatClient()
        {
            InitializeComponent();
        }

        private void Form_EtatClient_Load(object sender, EventArgs e)
        {
            comboBox_client.DisplayMember = "Nom";
            comboBox_client.ValueMember = "CodeCl";
            comboBox_client.DataSource = Program.DS.Tables["Client"];


            //CrystalReport2 cr = new CrystalReport2();
            //crystalReportViewer1.ReportSource = cr;
        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            //crystalReportViewer1.SelectionFormula = "{Commande.CodeCl} = " + comboBox_client.SelectedValue.ToString();
            //crystalReportViewer1.ReportSource = new CrystalReport2();
            CrystalReport_parametres cr = new CrystalReport_parametres();
            cr.SetParameterValue(0, comboBox_client.SelectedValue.ToString());
            crystalReportViewer1.ReportSource = cr;
            if (!cr.HasRecords)
            {
                crystalReportViewer1.Visible = false;
                MessageBox.Show("le client n'a pas de commandes!");
            }
            else
                crystalReportViewer1.Visible = true;
        }
    }
}

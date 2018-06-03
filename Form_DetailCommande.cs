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
    public partial class Form_DetailCommande : Form
    {
        public string numCom = "0";
        public Form_DetailCommande()
        {
            InitializeComponent();
        }

        private void Form_DetailCommande_Load(object sender, EventArgs e)
        {
            DataRow dr = Program.DS.Tables["Commande"].Rows.Find(numCom);
            label_NumCmd.Text = "NumCommande : " + numCom;
            label_DateCmd.Text = "Date : " + dr["DateCom"];
            label_NumCl.Text = "Num Client : " + dr["CodeCl"];

            DataRow[] rows = dr.GetChildRows("R_commande_detail");
            dataGridView_articles.Rows.Clear();
            foreach (DataRow r in rows)
            {
                DataRow art = Program.DS.Tables["Article"].Rows.Find(r[1]);
                dataGridView_articles.Rows.Add(art[0], art[1], art[2], r[2]);
            }
        }

        private void dataGridView_articles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && int.Parse(e.Value.ToString()) > 5)
            {
                e.CellStyle.BackColor = Color.LawnGreen;
            }
        }
    }
}

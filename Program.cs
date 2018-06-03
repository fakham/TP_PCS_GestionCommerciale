using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TP_PCS_GestionCommerciale2
{
    static class Program
    {
        static string conString = @"Data Source=.\SQLExpress;Initial Catalog=Vente;Integrated Security=True";
        static SqlConnection con = new SqlConnection(conString);
        static SqlCommand cmd = new SqlCommand("", con);
        static SqlDataReader dr;
        public static DataSet DS = new DataSet();
        static SqlDataAdapter da_client = new SqlDataAdapter("select * from client", conString);
        static SqlDataAdapter da_detail = new SqlDataAdapter("select * from detail", conString);
        static SqlDataAdapter da_cmd = new SqlDataAdapter("select * from Commande", conString);
        static SqlDataAdapter da_art = new SqlDataAdapter("select * from article", conString);

        public static void ChargerDataSet()
        {
            Program.da_client.Fill(Program.DS, "Client");
            Program.da_detail.Fill(Program.DS, "Detail");
            Program.da_cmd.Fill(Program.DS, "Commande");
            Program.da_art.Fill(Program.DS, "Article");

            Program.DS.Tables["Client"].PrimaryKey = new DataColumn[] { Program.DS.Tables["Client"].Columns[0] };
            Program.DS.Tables["Commande"].PrimaryKey = new DataColumn[] { Program.DS.Tables["Commande"].Columns[0] };
            Program.DS.Tables["Article"].PrimaryKey = new DataColumn[] { Program.DS.Tables["Article"].Columns[0] };
            Program.DS.Tables["Detail"].PrimaryKey = new DataColumn[] { Program.DS.Tables["Detail"].Columns[0], 
                                                                        Program.DS.Tables["Detail"].Columns[1] };

            DataRelation dr_art_detail = new DataRelation("R_article_detail", Program.DS.Tables["Article"].Columns[0],
                                                            Program.DS.Tables["Detail"].Columns[1]);
            DataRelation dr_cmd_detail = new DataRelation("R_commande_detail", Program.DS.Tables["Commande"].Columns[0],
                                                            Program.DS.Tables["Detail"].Columns[0]);
            DataRelation dr_cmd_clt = new DataRelation("R_commande_client", Program.DS.Tables["Client"].Columns[0],
                                                            Program.DS.Tables["Commande"].Columns[2]);

            Program.DS.Relations.Add(dr_art_detail);
            Program.DS.Relations.Add(dr_cmd_detail);
            Program.DS.Relations.Add(dr_cmd_clt);
        }

        public static DataTable ExecuteCmdsSelection(string req)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = req;
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            con.Close();

            return dt;
        }

        public static string ExecuteCmdsScalar(string req)
        {
            string res = "";

            cmd.CommandText = req;
            con.Open();
            res = cmd.ExecuteScalar().ToString();
            con.Close();

            return res;
        }

        public static void ExecuteCmdsNonQuery(string req)
        {
            cmd.CommandText = req;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}

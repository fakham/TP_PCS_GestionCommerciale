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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;
using System.Text;

namespace Kost_Q.src
{
    public partial class Tambah_Laporan_Keuangan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tambah_keuangan_Click(object sender, EventArgs e)
        {
            try
            {
                double _id;
                string _nama = nama.Text.ToString();
                DateTime _tanggal = Convert.ToDateTime(tanggal.Text.ToString());
                double _keuntungan = Convert.ToDouble(keuntungan.Text.ToString());

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM laporan_keuangan";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    _id = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO laporan_keuangan VALUES(@ID,@nama,@tanggal,@untung)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", _id));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal", _tanggal));
                    cmd.Parameters.Add(new NpgsqlParameter("@untung", _keuntungan));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    connection.Close();

                    Response.Redirect("Laporan_Keuangan.aspx");
                }
            }
            catch (Exception ex) {
            }
        }
    }
}
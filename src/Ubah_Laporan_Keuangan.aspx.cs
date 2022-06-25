using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;

namespace Kost_Q.src
{
    public partial class Ubah_Laporan_Keuangan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbl_ubah_keuangan_Click(object sender, EventArgs e)
        {
            string _id = Request.QueryString["data"].ToString();
            string _nama = nama.Text.ToString();
            DateTime _tanggal = Convert.ToDateTime(tanggal.Text.ToString());
            double _untung = Convert.ToDouble(keuntungan.Text.ToString());

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE laporan_keuangan SET nama=@nama,tanggal=@tanggal,keuntungan=@untung WHERE id_laporan_keuangan=" + _id;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal", _tanggal));
                    cmd.Parameters.Add(new NpgsqlParameter("@untung", _untung));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    Response.Redirect("Laporan_Keuangan.aspx");
                }
            }
            catch (Exception ex) { }
        }

    }
}
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
    public partial class Tambah_Data_Penyewa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbl_tambah_penyewa_Click(object sender, EventArgs e)
        {
            try
            {
                string _nama = nama.Text.ToString();
                string _tanggal_masuk = Convert.ToDateTime(tanggal_masuk.Text.ToString()).ToString("yyyy-MM-dd");
                string _data_diri = data_diri.Text.ToString();

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM penyewa";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    double _id = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO penyewa values(@ID,@nama,@tanggal_masuk,@data_diri)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", _id));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal_masuk", _tanggal_masuk));
                    cmd.Parameters.Add(new NpgsqlParameter("@data_diri", _data_diri));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    Response.Redirect("Data_Penyewa.aspx");
                }
            }
            catch (Exception ex) { }
        }
    }
}
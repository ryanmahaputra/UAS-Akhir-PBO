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
    public partial class Tambah_Data_Kamar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tambah_kamar_Click(object sender, EventArgs e)
        {
            try
            {
                double _id;
                string _nama_kamar = nama_kamar.Text;
                string _status = status.Text;
                string _deskripsi = deskripsi.Text;
                double _harga = Convert.ToDouble(harga.Text);

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM kamar";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    _id = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO kamar VALUES(@ID,@nama,@status,@harga)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", _id));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama_kamar));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", _status));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga", _harga));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    connection.Close();

                    Response.Redirect("Data_Kamar_Kost_A.aspx");
                }
            }
            catch (Exception ex) { }
        }
    }
}
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
    public partial class Ubah_Data_Kamar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbl_ubah_kamar_Click(object sender, EventArgs e)
        {
            try
            {
                string _id = Request.QueryString["data"].ToString();
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
                    cmd.CommandText = "UPDATE kamar SET nama_kamar = @nama_kamar, status = @status, harga = @harga WHERE id_kamar = " + _id;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_kamar", _nama_kamar));
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
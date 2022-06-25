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
    public partial class Data_Penyewa_Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string _id = Request.QueryString["data"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * from penyewa WHERE id_penyewa=" + _id;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<h5 style='height: 5.5rem;'>" + dt.Rows[i][1]);
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem;'>" + Convert.ToDateTime(dt.Rows[i][2]).ToString("dd-MM-yyyy"));
                        sb.Append("</h5>");
                    }

                    data_penyewa.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }
        }

        protected void tbl_hapus_penyewa_Click(object sender, EventArgs e)
        {
            try
            {
                string _id = Request.QueryString["data"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM penyewa WHERE id_penyewa=" + _id;
                    cmd.CommandType = CommandType.Text;
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
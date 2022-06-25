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
    public partial class Laporan_Keuangan_Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string _id = Request.QueryString["id"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * from laporan_keuangan WHERE id_laporan_keuangan=" + _id ;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<div class='col-5'>");
                        sb.Append("<h5 style='height: 5.5rem;'>" + dt.Rows[i][1]);
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem;'>" + Convert.ToDateTime(dt.Rows[i][2]).ToString("dd-MM-yyyy"));
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem;'>Rp " + dt.Rows[i][3]);
                        sb.Append("</h5>");
                        sb.Append("</div>");
                    }

                    detail_laporan.Controls.Add(new LiteralControl(sb.ToString()));    
                
                    sb = new StringBuilder();

                    sb.Append("<a href='Ubah_Laporan_Keuangan.aspx?data=" + dt.Rows[0][0] + "' class='btn btn-warning btn-lg text-white'>");
                    sb.Append("<i class='bi bi-pencil'></i>");
                    sb.Append("</a>");

                    edit_keuangan.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }
        }

        protected void delete_laporan_Click(object sender, EventArgs e)
        {
            try
            {
                string _id = Request.QueryString["id"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM laporan_keuangan WHERE id_laporan_keuangan=" + _id;
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
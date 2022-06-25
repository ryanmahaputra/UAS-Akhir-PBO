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
    public partial class Detail_Data_Kamar : System.Web.UI.Page
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
                    cmd.CommandText = "SELECT * FROM kamar WHERE id_kamar=" + _id;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<div class='col-3'>");
                        sb.Append("<p style='height: 5rem; font-weight: 600; font-size: 1.1rem;'>");
                        sb.Append("Nama Kamar");
                        sb.Append("</p>");
                        sb.Append("<p style='height: 5rem; font-weight: 600; font-size: 1.1rem;'>");
                        sb.Append("Status");
                        sb.Append("</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='col-3'>");
                        sb.Append("<h5 style='height: 5.5rem;'>");
                        sb.Append(dt.Rows[i][1]);
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem;'>");
                        sb.Append(dt.Rows[i][2]);
                        sb.Append("</h5>");
                        sb.Append("</div>");
                        sb.Append("<div class='col-2'>");
                        sb.Append("</div>");
                    }

                    detail_kamar_a.Controls.Add(new LiteralControl(sb.ToString()));

                    sb = new StringBuilder();

                    sb.Append("<a href='Ubah_Data_Kamar.aspx?data=" + dt.Rows[0][0] + "' class='btn btn-warning btn-lg text-dark'>");
                    sb.Append("<i class='bi bi-pencil'></i>");
                    sb.Append("</a>");

                    edit_kamar.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }

        }

        protected void hapus_kamar_a_Click(object sender, EventArgs e)
        {
            try
            {
                string _id_kamar = Request.QueryString["id"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM kamar WHERE id_kamar = @ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(_id_kamar)));
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
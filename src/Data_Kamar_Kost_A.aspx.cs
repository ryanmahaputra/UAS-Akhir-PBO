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
    public partial class Data_Kamar_Kost_A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM kamar ORDER BY id_kamar ASC";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    sb.Append("<table class='table table-hover table-borderless align-middle text-center fs-5' style='background-color: rgb(255, 239, 208);'>");
                    sb.Append("<thead style='border-bottom: 2px solid black;'>");
                    sb.Append("<tr>");
                    sb.Append("<th scope='col' class='py-3'>Nama Kamar</th>");
                    sb.Append("<th scope='col' class='py-3'>Status</th>");
                    sb.Append("<th scope='col' class='py-3'>Harga</th>");
                    sb.Append("<th scope='col' class='py-3'>Aksi</th>");
                    sb.Append("</tr>");
                    sb.Append("</thead>");
                    sb.Append("<tbody>");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<tr>");
                        sb.Append("<td class='py-3'>" + dt.Rows[i][1] + "</td>");
                        sb.Append("<td class='py-3'>" + dt.Rows[i][2] + "</td>");
                        sb.Append("<td class='py-3'>Rp " + dt.Rows[i][3] + "</td>");
                        sb.Append("<td class='py-3'>");
                        sb.Append("<a href='Data_Kamar_Detail.aspx?id=" + dt.Rows[i][0] + "' class='btn btn-info btn-sm' style='color: black;'>");
                        sb.Append("Detail");
                        sb.Append("</a>");
                        sb.Append("</td>");
                        sb.Append("</tr>");
                    }

                    sb.Append("</tbody>");
                    sb.Append("</table>");

                    info_data_kost_a.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }
        }

        protected void keluar_A_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("Login_Owner.aspx");
        }
    }
}
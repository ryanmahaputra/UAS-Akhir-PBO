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
    public partial class Data_Penyewa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM penyewa ORDER BY id_penyewa ASC";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    StringBuilder sb = new StringBuilder();
                                
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<tr>");
                        sb.Append("<td class='py-3'>" + dt.Rows[i][1] + "</td>");
                        sb.Append("<td class='py-3'>" + Convert.ToDateTime(dt.Rows[i][2]).ToString("dd-MM-yyyy") + "</td>");
                        sb.Append("<td class='py-3'>");
                        sb.Append("<a href='Data_Penyewa_Detail.aspx?data=" + dt.Rows[i][0] + "' class='btn btn-info btn-sm' style='color: black;'>Detail");
                        sb.Append("</a>");
                        sb.Append("</td>");
                        sb.Append("</tr>");
                    }

                    data_penyewa.Controls.Add(new LiteralControl(sb.ToString()));

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
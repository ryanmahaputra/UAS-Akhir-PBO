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
    public partial class Detail_Kamar_Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _i = Request.QueryString["i"].ToString();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM kamar WHERE id_kamar=" + _i;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<div class='col-3'>");
                        sb.Append("<img src='../img/" + dt.Rows[i][0] + ".jpeg' class='img-fluid' alt='Kamar Kost' />");
                        sb.Append("</div>");

                        sb.Append("<div class='col-3'>");
                        sb.Append("<p style='height: 5rem; font-weight:600; font-size: 1.1rem;'>");
                        sb.Append("Nama Produk");
                        sb.Append("</p>");
                        sb.Append("<p style='height: 5rem; font-weight:600; font-size: 1.1rem;'>");
                        sb.Append("Status");
                        sb.Append("</p>");
                        sb.Append("<p style='height: 5rem; font-weight:600; font-size: 1.1rem;'>");
                        sb.Append("Harga");
                        sb.Append("</p>");
                        sb.Append("<p style='height: 8rem; font-weight:600; font-size: 1.1rem;'>");
                        sb.Append("Deskripsi");
                        sb.Append("</p>");
                        sb.Append("</div>");

                        sb.Append("<div class='col-3'>");
                        sb.Append("<h5 style='height: 5.5rem; '>");
                        sb.Append(dt.Rows[i][1]);
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem; '>");
                        sb.Append(dt.Rows[i][2]);
                        sb.Append("</h5>");
                        sb.Append("<h5 style='height: 5.5rem; '>");
                        sb.Append("Rp " + dt.Rows[i][3]);
                        sb.Append("</h5>");
                        sb.Append("<p>");
                        sb.Append("1. AC 1 pk <br />");
                        sb.Append("2. TV LED <br />");
                        sb.Append("3. Free air panas solar panel system <br />");
                        sb.Append("4. Listrik token sendiri <br />");
                        sb.Append("5. Full furnish <br />");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- meja <br />");
                        sb.Append("</span>");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- lemari <br />");
                        sb.Append("</span>");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- cermin <br />");
                        sb.Append("</span>");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- nakas <br />");
                        sb.Append("</span>");
                        sb.Append("6. Spring bed");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- bantal <br />");
                        sb.Append("</span>");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- guling <br />");
                        sb.Append("</span>");
                        sb.Append("<span class='ps-3'>");
                        sb.Append("- sprei <br />");
                        sb.Append("</span>");
                        sb.Append("7. Exhaust fan <br />");
                        sb.Append("</p>");
                        sb.Append("</div>");
                    }

                    info_detail_kamar.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }
        }
    }
}
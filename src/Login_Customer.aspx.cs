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
    public partial class Login_Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_C_Click(object sender, EventArgs e)
        {
            try
            {
                string _email = email.Text;
                string _pass = password.Text;

                int hasil = 0;

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["kost_q"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM akun WHERE email = '" + _email + "' AND password = '" + _pass + "';";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (dt.Rows[0][4].ToString() == "penyewa")
                    {
                        hasil++;
                    }

                    connection.Close();

                    if (hasil == 1)
                    {
                        Response.Redirect("~/src/Data_Kamar_Kost_C.aspx", true);
                    }
                    else
                    {
                        Response.Redirect("~/src/Login_Customer.aspx", true);
                    }

                }
            }
            catch (Exception ex) { }
        }
    }
}
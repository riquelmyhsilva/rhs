using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rhs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailAdress.Text))
            {
                emailAdress.Text = string.Empty;
            }

            string connectionString = "Data Source=RikGalaxyBook;Initial Catalog=EmailDb;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    var sql = "INSERT INTO Email (Email,SentDate) VALUES (@emailAdress,@sentDate)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("emailAdress", emailAdress.Text);
                        cmd.Parameters.AddWithValue("sentDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        emailAdress.Text = "";
                        string script = "<script>window.location.hash = '#emailForm';</script>";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ScrollToEmailForm", script);
                    }
                    sendButton.Text = "sent!";
                }
                catch (Exception ex)
                {
                    sendButton.Text = "Erro:" + ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        protected void emailAdress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
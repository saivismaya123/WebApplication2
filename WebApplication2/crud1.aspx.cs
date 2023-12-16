using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class crud1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7G8U6PN\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[iudc]
           ([ID]
           ,[name]
           ,[phone]
           ,[address])
     VALUES
           ('" + txtid.Text + "','" + txtname.Text + "','" + txtphn.Text + "','" + txtadd.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("data inserted succesfyully");
            con.Close();

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7G8U6PN\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[iudc]
      WHERE [ID]='" + txtid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("deleted succesfyully");

            con.Close();

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7G8U6PN\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[iudc]
   SET[ID] = '" + txtid.Text + "',[name] = '" + txtname.Text + "',[phone] = '" + txtphn.Text + "',[address] = '" + txtadd.Text + "'WHERE [ID]='" + txtid.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("updated succesfyully");
            con.Close();
        }
    }
}

















































 new  
using System;

namespace OtoServisSatis.WebFormUI
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Session.Remove("admin");
                Response.Redirect("/Login.aspx");
            }
        }
    }
}
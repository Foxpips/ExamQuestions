using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_OnClick(object sender, EventArgs e)
        {
            Session["userName"] = txtUser.Value;

            Response.Redirect("About.aspx");
        }
    }
}
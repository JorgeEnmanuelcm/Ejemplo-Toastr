using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ratodelab
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {

           utilitarios.ShowToastr(this, "bien", "Se limpio con exito!", "success");
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            utilitarios.ShowToastr(this, "bien", "Se elimino con exito!", "success");
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            utilitarios.ShowToastr(this, "bien", "Se guardo con exito!", "success");
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            utilitarios.ShowToastr(this, "error", "Mensaje", "error");
        }
    }
}
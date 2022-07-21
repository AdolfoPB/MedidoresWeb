using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {

        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {

            usuario usuarios = new usuario();
            usuarios.rut = this.rutTxt.Text.Trim();
            usuarios.nombre = this.nombreTxt.Text.Trim();
            usuarios.contrasena = this.contrasenaTxt.Text.Trim();
            usuarios.email = this.emailTxt.Text.Trim();

            this.usuariosDAL.AgregarUsuarios(usuarios);
            Response.Redirect("VerUsuario.aspx");

        }
    }

    
}
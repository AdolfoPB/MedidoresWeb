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
    public partial class VerUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        private void cargaGrilla(List<usuario> usuarios)
        {
            this.grillaAsistente.DataSource = usuarios;
            this.grillaAsistente.DataBind();
        }

        private void cargaGrilla()
        {
            List<usuario> usuarios;
            usuarios = this.usuariosDAL.ObtenerUsuarios();
            this.cargaGrilla(usuarios);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargaGrilla();
        }

        //protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.cargaGrilla();
        //}

        //protected void todosChk_CheckedChanged(object sender, EventArgs e)
        //{
        //    this.estadoDDL.Enabled = !this.todosChk.Checked;
        //    this.cargaGrilla();
        //}

        protected void grillaAsistente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.usuariosDAL.EliminarUsuarios(id);
                this.cargaGrilla();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.CapaPresentacion
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM cliente", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           if (Capa_Logica.Cliente_Logica.Agregarclientes(int.Parse(txtcodigo.Text), txtnombre.Text, int.Parse(txtedad.Text), float.Parse(txtsaldo.Text)) > 0)
            {
                LlenarGrid();
               
            }
            
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Cliente_Logica.Modificarclientes(int.Parse(txtcodigo.Text), txtnombre.Text, int.Parse(txtedad.Text), float.Parse(txtsaldo.Text)) > 0)
            {
                LlenarGrid();

            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Cliente_Logica.Borrarclientes(int.Parse(txtcodigo.Text)) > 0)
            {
                LlenarGrid();

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
    }
}
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace ExamenFinal.Presentacion
{
    public partial class Login : Page
    {
        // Simulación de una base de datos de usuarios y contraseñas
        private Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "usuario1", "contraseña1" },
            { "usuario2", "contraseña2" },
            // Agrega más usuarios según sea necesario
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            
            if (usuarios.ContainsKey(usuario))
            {
               
                if (usuarios[usuario] == contraseña)
                {
                   
                    Response.Write("Inicio de sesión exitoso. Redireccionando...");
                   
                }
                else
                {
                    
                    Response.Write("Contraseña incorrecta. Por favor, inténtelo de nuevo.");
                }
            }
            else
            {
               
                Response.Write("Usuario no encontrado. Por favor, inténtelo de nuevo.");
            }
        }
    }
}

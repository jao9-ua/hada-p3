using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace usuWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs ex)
        {
            MError.Text = "";
        }

        protected void CLeer(object sender, EventArgs ex)
        {
            if(TNIF.Text == "")
            {
                MError.Text = "NIF no introducido";
            }
            else
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._nif = TNIF.Text;

                if (nuevo.readUsuario())
                {
                    TNombre.Text = nuevo._nombre;
                    TEdad.Text = nuevo._edad.ToString();
                    MError.Text = "Usuario leído";
                }
                else
                {
                    MError.Text = "No existe este usuario en la base de datos.";
                }
            }
        }

        protected void LeerP(object sender, EventArgs ex)
        {
            ENUsuario nuevo = new ENUsuario();
            if (nuevo.readFirstUsuario())
            {
                TNIF.Text = nuevo._nif;
                TNombre.Text = nuevo._nombre;
                TEdad.Text = nuevo._edad.ToString();

            }
            else
            {
                MError.Text = "La base de datos no contiene usuarios registrados";
            }
        }
        protected void CCrear(object sender, EventArgs ex)
        {
            if(TNIF.Text != "" && TNombre.Text !="" && TEdad.Text != "")
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._nif = TNIF.Text;
                nuevo._nombre = TNombre.Text;
                nuevo._edad = int.Parse(TEdad.Text);
                if (nuevo.createUsuario())
                {
                    MError.Text = "Usuario creado";
                }
                else
                {
                    MError.Text = "Error al crear el usuario";
                }
            }
            else
            {
                MError.Text = "Has dejado un campo vacío";

            }
        }

        protected void LeerA(object sender, EventArgs ex)
        {
            if (TNIF.Text != "")
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._nif = TNIF.Text;
                if (nuevo.readPrevUsuario())
                {
                    TNIF.Text = nuevo._nif;
                    TNombre.Text = nuevo._nombre;
                    TEdad.Text = nuevo._edad.ToString();
                    MError.Text = "Leído correctamente";
                }
                else
                {
                    MError.Text = "Error en la lectura";

                }
            }
            else
            {
                MError.Text = "Introduce el NIF";
            }
        }

        protected void LeerS(object sender, EventArgs ex)
        {
            if (TNIF.Text!="")
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._nif = TNIF.Text;
                if (nuevo.readNextUsuario())
                {
                    TNIF.Text = nuevo._nif;
                    TNombre.Text = nuevo._nombre;
                    TEdad.Text = nuevo._edad.ToString();
                    MError.Text = "Leído correctamente";
                }
                else
                {
                    MError.Text = "Error en la lectura";

                }
            }
            else
            {
                MError.Text = "Introduce el NIF";
            }
        }

        protected void Act(object sender, EventArgs ex)
        {
            if (TNIF.Text != "" && TNombre.Text != "" && TEdad.Text != "")
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._edad = int.Parse(TEdad.Text);
                nuevo._nif = TNIF.Text;
                nuevo._nombre = TNombre.Text;
                if (nuevo.updateUsuario())
                {
                    MError.Text = "Usuario actualizado";
                }
                else
                {
                    MError.Text = "El nif del usuario introducido no existe";
                }
            }
            else
            {
                MError.Text = "Has dejado un campo vacío";
            }
        }

        protected void Borr(object sender, EventArgs ex)
        {
            if (TNIF.Text != "")
            {
                ENUsuario nuevo = new ENUsuario();
                nuevo._nif = TNIF.Text;
                if (nuevo.deleteUsuario())
                {
                    MError.Text = "Usuario Borrado";
                }
                else
                {
                    MError.Text = "El NIf introducido no corresponde a ningún usuario existente";
                }
            }
            else
            {
                MError.Text = "Introduce el nif para borrar el usuario";
            }
        }

    }
}
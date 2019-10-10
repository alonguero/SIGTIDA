using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Cliente
    {
        #region Atributos
        protected int id_Cliente;
        protected string nombre_Cliente;
        protected string apellido_Cliente;
        protected string telefono_Cliente;
        protected string email;
        protected string direccion_Cliente;
        protected string estado_Cliente;


        #endregion

        #region Constructores

        public Cliente(string Pnombre_Cliente, string Papellido_Cliente, string Ptelefono_Cliente, string Pemail,
                       string Pdireccion_Cliente, string Pestado_Cliente)
        {
            id_Cliente = 0;
            nombre_Cliente = Pnombre_Cliente;
            apellido_Cliente = Papellido_Cliente;
            telefono_Cliente = Ptelefono_Cliente;
            email = Pemail;
            direccion_Cliente = Pdireccion_Cliente;
            estado_Cliente = Pestado_Cliente;
        }

        public Cliente(int Pid_Cliente,string Pnombre_Cliente, string Papellido_Cliente, string Ptelefono_Cliente, string Pemail,
                       string Pdireccion_Cliente, string Pestado_Cliente)
        {
            id_Cliente = Pid_Cliente;
            nombre_Cliente = Pnombre_Cliente;
            apellido_Cliente = Papellido_Cliente;
            telefono_Cliente = Ptelefono_Cliente;
            email = Pemail;
            direccion_Cliente = Pdireccion_Cliente;
            estado_Cliente = Pestado_Cliente;
        }

        #endregion

        #region Set´s y Get´s
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public string Nombre_Cliente { get => nombre_Cliente; set => nombre_Cliente = value; }
        public string Apellido_Cliente { get => apellido_Cliente; set => apellido_Cliente = value; }
        public string Telefono_Cliente { get => telefono_Cliente; set => telefono_Cliente = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion_Cliente { get => direccion_Cliente; set => direccion_Cliente = value; }
        public string Estado_Cliente { get => estado_Cliente; set => estado_Cliente = value; }
        #endregion
    }
}

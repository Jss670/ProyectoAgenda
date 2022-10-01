using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    public class Contacto
    {
        private readonly string connectionString;

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public Contacto()
        {
            connectionString = "Server=localhost;DataBase=AgendaDB;Trusted_Connectio=true;";
        }
        public void AgregarContacto()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

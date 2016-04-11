using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class ClienteView
    {

        public int idCliente { get; set; }
        public string VCedula { get; set; }
        public string VNombres { get; set; }
        public string VApellidos { get; set; }
        public string VSede { get; set; }
        public DateTime? FechaRegistro { get; set; }


        public List<ClienteView> ListarCliente()
        {
            List<ClienteView> lstCliente = new List<ClienteView>();

            using (var context = new PruebasVariasEntities())
            {
                var query = (from c in context.Cliente
                             select new
                             {
                                 idCliente = c.IdCliente,
                                 cedula = c.Cedula,
                                 nombres = c.Nombres,
                                 apelllidos = c.Apellidos,
                                 sede = c.Sede.Nombre,
                                 fecha = c.FechaRegistro
                             }).ToList();

                foreach (var cl in query)
                {
                    lstCliente.Add(new ClienteView { 
                        idCliente = cl.idCliente,
                        VCedula = cl.cedula,
                        VNombres = cl.nombres,
                        VApellidos = cl.apelllidos,
                        VSede = cl.sede,
                        FechaRegistro = cl.fecha
                    });
                }
            }

            return lstCliente;
        }
    }
}

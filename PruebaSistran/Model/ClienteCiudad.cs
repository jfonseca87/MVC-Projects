using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class ClienteCiudad
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Sede { get; set; }
        public string Ciudad { get; set; }

        public List<ClienteCiudad> listarClienteCiudad()
        {
            List<ClienteCiudad> lstClienteCiudad = new List<ClienteCiudad>();

            try
            {
                using (var context = new PruebasVariasEntities())
                {
                    var query = (from c in context.Cliente
                                 join s in context.Sede on c.IdSede equals s.IdSede
                                 join t in context.Ciudad on s.IdCiudad equals t.IdCiudad
                                 select new
                                 {
                                     DNI = c.Cedula,
                                     Nombres = c.Nombres + " " + c.Apellidos,
                                     Sede = s.Nombre,
                                     Ciudad = t.Nombre
                                 }).ToList();

                    foreach (var item in query)
                    {
                        lstClienteCiudad.Add(new ClienteCiudad { 
                            DNI = item.DNI,
                            Nombres = item.Nombres,
                            Sede = item.Sede,
                            Ciudad = item.Ciudad
                        });
                    }        
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstClienteCiudad;
        }
    }
}

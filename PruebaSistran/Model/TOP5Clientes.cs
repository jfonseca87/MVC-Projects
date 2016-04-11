using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class TOP5Clientes
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public decimal Valor { get; set; }
        public string Sede { get; set; }
        public string Ciudad { get; set; }

        public List<TOP5Clientes> listarTop5Clientes()
        {
            List<TOP5Clientes> lstTopClientes = new List<TOP5Clientes>();

            try
            {
                using (var context = new PruebasVariasEntities())
                {
                    var query = context.TOP5ClientesValor().ToList();

                    foreach (var item in query)
                    {
                        lstTopClientes.Add(new TOP5Clientes { 
                            Cedula = item.Cedula,
                            Nombres = item.Nombres,
                            Valor = item.Valor,
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

            return lstTopClientes;
        }
    }
}

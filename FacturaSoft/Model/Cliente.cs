namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Factura = new List<Factura>();
        }

        [Key]
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage="El campo Nombre es requerido")]
        [StringLength(50)]
        public string nom_Cliente { get; set; }

        [Required(ErrorMessage="El campo Documento es requerido")]
        [StringLength(15)]
        public string Doc_Cliente { get; set; }

        public ICollection<Factura> Factura { get; set; }

        public List<Cliente> listarClientes ()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try 
            {
                using (var context = new FacturaSoftContext())
                {
                    lstCliente = context.Cliente.ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstCliente;

        }

        //Método que trae el ultimo registro de los clientes ingresados
        public int traeCliente()
        {
            int ClienteID = 0;

            try
            {
                using (var context = new FacturaSoftContext())
                {
                    ClienteID = (from cliente in context.Cliente
                                 orderby cliente.Id_Cliente descending
                                select cliente.Id_Cliente).First();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ClienteID;
        }

        //Método sobrecargado que consulta un cliente y lo agrega al modelo
        public Cliente traeCliente(int id)
        {
            Cliente cliente = new Cliente();

            try
            {
                using(var context = new FacturaSoftContext())
                {
                    cliente = context.Cliente.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cliente;
        }

        public void GuardarCliente()
        {
            try
            {
                using (var context = new FacturaSoftContext())
                {
                    context.Cliente.Add(this);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new FacturaSoftContext())
                {
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                using (var context = new FacturaSoftContext())
                {
                    Cliente cliente = context.Cliente.Find(id);
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

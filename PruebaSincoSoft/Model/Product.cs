namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
  

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(10)]
        [Required(ErrorMessage="El campo código es requerido")]
        public string Code { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        [Required(ErrorMessage = "El campo vamor es requerido")]
        public decimal? Amount { get; set; }

        public void Guardar()
        {
            try
            {
                using (var context = new PruebaSincoSoftContext())
                {
                    context.Product.Add(this);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Product> listarProduct()
        {
            List<Product> lstProduct = new List<Product>();

            try
            {
                using (var context = new PruebaSincoSoftContext())
                {
                    lstProduct = context.Product.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstProduct;
        }

        public List<Product> ConsultaValor(string codigo)
        {
            List<Product> consulta = new List<Product>();
            using( var context = new PruebaSincoSoftContext())
            {
                consulta = context.Product.Where(x => x.Code == codigo).ToList();

            }

            return consulta;
        }
    }
}

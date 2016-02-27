namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Bill")]
    public partial class Bill
    {
        [Key]
        public int idFactura { get; set; }

        [StringLength(10)]
        public string codCustomer { get; set; }

        [StringLength(10)]
        public string codProduct { get; set; }

        [Column(TypeName = "money")]
        public decimal? valUnit { get; set; }

        public int? cantProduct { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? IVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public void Guardar()
        {

            using (var context = new PruebaSincoSoftContext())
            {
                context.Bill.Add(this);
                context.SaveChanges();
            }

            //try
            //{
            //    using (var context = new PruebaSincoSoftContext())
            //    {
            //        context.Bill.Add(this);
            //        context.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        public List<Bill> listarFactura()
        {
            List<Bill> lstFactura = new List<Bill>();

            try
            {
                using (var context = new PruebaSincoSoftContext())
                {
                    lstFactura = context.Bill.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstFactura;
        }
    }
}

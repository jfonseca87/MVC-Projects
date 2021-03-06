namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Bitacora
    {
        [Key]
        public int Id_Detalle { get; set; }

        public string Fotografia { get; set; }

        public string Observacion_Foto { get; set; }

        public int? Id_Bitacora { get; set; }

        public Bitacora Bitacora { get; set; }
    }
}

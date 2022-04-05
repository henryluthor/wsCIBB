using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CIBB_Data.Models
{
    //[Keyless]
    [Table("TBL_CIBB_REGISTRO", Schema = "ESPOL")]
    public partial class TblCibbRegistro
    {
        [Required]
        [Column("TIPOESTUDIANTE", TypeName = "character(1)")]
        public string Tipoestudiante { get; set; }
        [Required]
        [Column("EMAIL", TypeName = "vargraphic(40)")]
        public string Email { get; set; }
        [Required]
        [Column("CELULAR")]
        [StringLength(10)]
        public string Celular { get; set; }
        [Required]
        [Column("TIPOPARTICIPACION", TypeName = "character(1)")]
        public string Tipoparticipacion { get; set; }
        [Required]
        [Column("RUTAPRESENTACION", TypeName = "vargraphic(255)")]
        public string Rutapresentacion { get; set; }
        [Required]
        [Column("MODOINFORMADO", TypeName = "character(1)")]
        public string Modoinformado { get; set; }
        [Required]
        [Column("OTROMODOINFORMADO", TypeName = "vargraphic(255)")]
        public string Otromodoinformado { get; set; }
        [Required]
        [Column("ESESPOL", TypeName = "character(1)")]
        public string Esespol { get; set; }
        [Column("FECHAREGISTRO", TypeName = "date(4)")]
        public DateTime Fecharegistro { get; set; }
        [Column("ANIOCONGRESO", TypeName = "integer(4)")]
        public int Anioregistro { get; set; }
        [Column("ULTIMO_CAMBIO")]
        [MaxLength(10)]
        public DateTime UltimoCambio { get; set; }
        [Key]
        [Column("IDCIBBREGISTRO", TypeName = "integer(4)")]
        public int Idcibbregistro { get; set; }
        [Required]
        [Column("APELLIDOS", TypeName = "vargraphic(50)")]
        public string Apellidos { get; set; }
        [Required]
        [Column("NOMBRES", TypeName = "vargraphic(50)")]
        public string Nombres { get; set; }
        [Required]
        [Column("NUMEROIDENTIFICACION")]
        [StringLength(14)]
        public string Numeroidentificacion { get; set; }
        [Column("IDPAIS", TypeName = "integer(4)")]
        public int Idpais { get; set; }
        [Column("IDCANTON", TypeName = "integer(4)")]
        public int Idcanton { get; set; }
        [Required]
        [Column("TIPOINSTITUCION", TypeName = "character(1)")]
        public string Tipoinstitucion { get; set; }
        [Required]
        [Column("NOMBREINSTITUCION", TypeName = "vargraphic(255)")]
        public string Nombreinstitucion { get; set; }
        [Required]
        [Column("TIPOPARTICIPANTE", TypeName = "character(1)")]
        public string Tipoparticipante { get; set; }
    }
}

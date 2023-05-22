using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Consults
    {
        [Column("CONS_ID")]
        public int Id { get; set; }

        [Column("CONS_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("CONS_DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [Column("CONS_HORA_CONS")]
        public TimeSpan HORA { get; set; }

        [Column("MSN_CONSULT_DISP")]
        public StateConsult ConsultDisp { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}

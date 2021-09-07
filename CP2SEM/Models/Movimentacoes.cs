using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CP2SEM.Models
{
    [Table("Tb_Movimentacoes")]
    public class Movimentacoes
    {
        [Column("pk_idMovimentacao")]

        public int Id { get; set; }
        public string TipoDeMovimentacao { get; set; }
    }
}

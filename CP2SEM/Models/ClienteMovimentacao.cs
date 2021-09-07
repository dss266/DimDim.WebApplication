using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CP2SEM.Models
{
    [Table("Tb_Cliente_X_Movimentacoes")]
    public class ClienteMovimentacao
    {
        [Column("pk_cliente_x_movimentacao")]
        public int Id { get; set; }
        [Column("fk_idCliente")]

        public int IdCliente { get; set; }
        [Column("fk_idMovimentacao")]

        public int IdMovimentacao { get; set; }
    }
}

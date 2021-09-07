using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CP2SEM.Models
{
    [Table("Tb_Cliente")]
    public class Cliente
    {
        [Column("pk_idCliente")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
    }
}

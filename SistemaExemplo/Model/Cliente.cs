using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExemplo.Model
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(150)]
        public string Nome { get; set; }
        [MaxLength(150)]
        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public decimal? LimiteDeCredito { get; set; }

        public bool Ativo { get; set; }

        public int? Idade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExemplo.Model
{
    public class Empresa
    {
        [Key]
        public int  ID { get; set; }
        [MaxLength(150)]
        public string  RazaoSocial { get; set; }
        [MaxLength(14)]
        public string  CNPJ { get; set; }
    }
}

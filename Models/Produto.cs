using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Armazen.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }

       // [Range(1,32,ErrorMessage ="não compramos mais que 32 produtos iguais")]
        //public int qtd { get; set; }
        public int utilitarioId { get; set; }
        public Utilitario utilitario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Armazen.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int utilitarioId { get; set; }
        public Utilitario utilitario { get; set; }
    }
}

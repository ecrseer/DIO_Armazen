using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Armazen.Models
{
    public class Utilitario
    {
        public int id { get; set; }
        [Display(Name ="Descrição")]
        public string descricao { get; set; }
        public List<Produto> produtos { get; set; }
    }
}

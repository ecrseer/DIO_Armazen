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
        [Required(ErrorMessage =" Não pode ter um utilitario sem nome")]
        public string descricao { get; set; }
        public List<Produto> produtos { get; set; }
    }
}

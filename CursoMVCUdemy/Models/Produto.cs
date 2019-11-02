using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVCUdemy.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }    
        public string observacao { get; set; }
    }
}
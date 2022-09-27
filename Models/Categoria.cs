
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetApp.Models
{
    public class Categoria
    {
       public int Id {get; set;}
       public string Nome {get; set;}
       public string Descricao {get; set;}


       public virtual List<Produto> Produto {get; set;}
    }
}
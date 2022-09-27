
using System;
using System.ComponentModel.DataAnnotations;


namespace NetApp.Models
{

    public class Produto
    {

        public int Id {get; set;}
        public string Nome {get; set;}
        [DataType(DataType.Currency)]
        public double preco {get;set;}
        public int IdCategoria {get; set;}

        public virtual Categoria Categoria {get; set;}


    }
}

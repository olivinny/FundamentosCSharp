using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public void Apresentar()
        {            
            Console.WriteLine($"Olá, meu nome é " + 
                $"\n{Nome}, e tenho {Idade} anos");
        }

    }
}

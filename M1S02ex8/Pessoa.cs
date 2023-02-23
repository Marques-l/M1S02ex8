using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02ex8
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa(string nome, DateTime dataNascimento)
        { 
            Nome= nome;
            DataNascimento = dataNascimento;
        }
        public void MostrarIdade()
        {
            CalcularIdade();
        }
        public void CalcularIdade()
        {
           
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            Console.WriteLine(idade); 
           // if (DataNascimento > dataAtual.AddYears(-idade))
           // {
              //  idade--;
             //  
          //  }

        }
      
    }
}

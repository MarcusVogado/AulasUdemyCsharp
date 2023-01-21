using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int AnoDeNascimento{ get; set; }
        //MÉTODO SIMPLES SEM RETORNO VOID
        public void Comprimentar()
        {
            Console.WriteLine("Olá "+this.Nome+" "+this.SobreNome);
        }
        //MÉTODO COM PARÂMETROS      
        public void Apresentar(string nome,int anoNascimento)
        {
            int idade = DateTime.Now.Year-anoNascimento;
            Console.WriteLine("Olá " + nome + " de idade= " + idade);
        }
        //MÉTODO POR VALOR
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor Final é: " + valor);
        }
        //MÉTODO POR REFERÊNCIA
        public void AumentarValorRef(ref int valor)
        {
            valor += 15;
            Console.WriteLine("Valor Final é: " + valor);
        }
    }
}

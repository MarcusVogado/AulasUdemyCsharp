﻿using POO;
using System;

class Program
{
    //UTILIZANDO DELEGATE
    delegate void Operacao(int num1, int num2);
    public static void Main(string[] args)
    {
        MinhaClasse mClasse = new MinhaClasse();
        MinhaClasse mrClasse = mClasse;

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Marcus";
        pessoa1.SobreNome = "Vogado";
        pessoa1.AnoDeNascimento = 1993;

        Pessoa pessoa2 = new Pessoa()
        {
            Nome = "Junior",
            SobreNome = "Alberto",
            AnoDeNascimento = 1998
        };
        List<Pessoa> pessoaList = new List<Pessoa>()
        {
            new Pessoa(){Nome="Carlos",SobreNome="Vogado",AnoDeNascimento=1993},
            new Pessoa(){Nome="José",SobreNome="Alberto",AnoDeNascimento=1987} 
        };
        pessoaList.Add(pessoa1);
        pessoaList.Add(pessoa2);
        foreach(Pessoa pessoa in pessoaList)
        {
            //método simples
            pessoa.Comprimentar();
            //método com parâmetros
            pessoa.Apresentar(pessoa.Nome, pessoa.AnoDeNascimento);
        }
        int valor1 = 100;
        int valorRef = 100;
        //Método Por parâmetros e por referencia
        pessoa1.AumentarValor(valor1);
        pessoa1.AumentarValorRef(ref valorRef);

        // Método com retorno de valores
        string nomeCompleto= pessoa1.MontarNome("Marcus", "Vogado");
        Console.WriteLine(nomeCompleto);
       
        int codigo=pessoa1.CodigoChar('J');
        Console.WriteLine(codigo);

        //Sobrecarga de Métodos
        Console.WriteLine(pessoa1.Comprimentar(nomeCompleto));

        //utilizando o termo This
        Acessar acesso = new Acessar();
        bool verificar= acesso.Login("abc123");
        if (verificar)
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            Console.WriteLine("Acesso Negado");
        }
        //DELEGATES
        Matematica m= new Matematica();
        Operacao conta = null;       
        conta += m.Somar;
        conta += m.Subtrair;
        conta += m.Multiplicar;
        conta += m.Dividir;
        conta(15, 10);
        Console.ReadKey();
    }
}
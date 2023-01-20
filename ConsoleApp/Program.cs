
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    enum Notas
    {
        Minimo = 10,
        Media = 15,
        Maxima = 30
    }
    struct Pessoa
    {
        public string nome;
        public double altura;
        public int idade;
    }

    static void Main(string[] args)
    {
        //*Region* Serve para separar blocos do código e torna-lo de facil vizualização e entendimento

        #region Declaração e tipos de variaveis

        //Integral assinado
        sbyte numSbyte = 10; // 8 bits, -128 a 127
        short numShort = 10;// 16 bits, -32.768 a 32.767
        int numInt = 10;// 32 bits, -2.147.483.648 a 2.147.483.647
        long numLong = 10L;// 64 bits, -9.223.372.036.854.775.808 a  9.223.372.036.854.775.807

        //Integral sem sinal
        byte numByte = 10; // 8 bits, intervalo de 0 a 255
        ushort numUShort = 10;// 16 bits, de 0 a 65.535
        uint numUInt = 10; // 32 bits, 0 a 4.294.967.295
        ulong numULong = 10L;//64 bits, de 0 a 18.446.744.073.709.551.615        
        #endregion

        #region Caractere
        char letra = 'A';
        char letraExaDecimal = '\u0061'; // Podemos usar Código Exadecimais        
        #endregion

        #region Boolean
        bool verificar = true;
        verificar = false;
        #endregion

        #region Tipo String(Cadeia de Caracteres) 
        string text = "abcdefghijklmn\nopqrstuvwxyz";
        string menssage = text;
        #endregion

        #region Tipo Var
        var variavel = 15.155;
        #endregion

        #region Tipo Object(Base para todos os tipos)
        //Tipo Object pode ser alterado pois é a base
        //dos tipos do C# e a qualquer momento pode ser mudada
        object obj = 10;
        obj = 10;
        obj = "Texto";
        #endregion

        #region Tipo Constantes
        const double valor = 10;
        const string constText = "\nMarcus";
        #endregion

        #region Enumumerações
        Notas notasAlunos = Notas.Maxima;
        #endregion        

        #region Estruturas
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Marcus";
        pessoa1.altura = 1.82;
        pessoa1.idade = 29;

        Pessoa pessoa2 = new Pessoa()
        {
            nome = "Marcus",
            altura = 1.82,
            idade = 29
        };
        #endregion

        #region Valor e Referencia
        /* int num = 10;
         PassagemValorReferencia(ref num);
         Console.WriteLine(num);
         //Se não utilizarmos o ref ele não irar imprimir o resultado do método que seria 20. */
        #endregion

        
    }

    static void EntradaSaida()
    {
        Console.WriteLine("\nMarcus");
        Console.Write("Vogado do Lago");
        int numTeste = int.Parse(Console.ReadLine());
        Console.WriteLine("Você Digitou: " + numTeste);
        Console.ReadKey();
    }

    static void CadastrarImprimeNomes()
    {


        string pergunta = "S";
        List<string> nome = new List<string>();
        while (pergunta == "S")
        {
            Console.WriteLine("DIGITE UM NOME");
            nome.Add(Console.ReadLine());
            Console.WriteLine("DESEJA ADIGICONAR MAIS NOMES? S/N?");
            pergunta = Console.ReadLine().ToUpper();
            while (pergunta != "N" && pergunta != "S")
            {
                Console.WriteLine("OPÇÃO ERRADA, ESCOLHA S/N PARA CONTINUAR OU FECHAR O PROGRAMA");
                pergunta = Console.ReadLine();
            }
        }
        foreach (string nomes in nome)
        {
            Console.WriteLine("Nomes Didigitados= " + nomes);
        }

    }

    static void Conversores()
    {
        #region Conversão Implícita
        byte numByte = 100;
        ushort numShort;
        numShort = numByte;
        float numFloat = 1250.45f;
        double numDouble = numFloat;
        #endregion

        #region Conversão Explícita
        ushort num1 = 1000;
        byte num2 = (byte)num1;

        float num3 = 2500.589f;
        int num4 = (int)num3;

        #endregion

        #region Método Parse
        try
        {
            string txtNumero = "1985Ase";
            int numero = int.Parse(txtNumero);
            Console.WriteLine(numero);
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            //Colocando letra no txtNumero ele gera um erro, e o Try catch está tratando esse erro.
        }

        #endregion


    }

    static void VeficcarMaiorIdadeLista()
    {
        List<Usuario> pessoas = new List<Usuario>();
        pessoas.Add(new Usuario() { Nome = "Sergio", Idade = 24 });
        pessoas.Add(new Usuario() { Nome = "Marcus", Idade = 30 });
        pessoas.Add(new Usuario() { Nome = "Carlos", Idade = 35 });
        pessoas.Add(new Usuario() { Nome = "José", Idade = 29 });
        pessoas.Add(new Usuario() { Nome = "Alberto", Idade = 55 });
        IEnumerable<Usuario> maiorIdade = pessoas.OrderBy(u => u.Idade);
        Console.WriteLine("***************************************");
        Console.WriteLine("A pessoa com a maior idade da lista é o: " + maiorIdade.Last().Nome + " Com a idade de: " + maiorIdade.Last().Idade + " Anos");
        Console.WriteLine("***************************************");
        Console.WriteLine("A pessoa com a menor idade da lista é o: " + maiorIdade.First().Nome + " Com a idade de: " + maiorIdade.First().Idade + " Anos");
        Console.WriteLine("***************************************");
        Console.WriteLine("Lista De Usuários e suas idades");
        Console.WriteLine("***************************************");
        foreach (Usuario maior in maiorIdade)
        {

            Console.WriteLine(maior.Nome + ' ' + maior.Idade);
        }
    }

    static void VetoresUnidimensional()
    {
        //Vetor ou Array -Coleção de dados do mesmo tipo ex Int ou Strings
        int[] numeros = new int[5];
        numeros[0] = 10;
        numeros[1] = 15;
        numeros[2] = 20;
        numeros[3] = 25;
        numeros[4] = 30;

        int[] numeros2 =
        {
            10,
            15,
            20,
            25,
            30
        };

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        string[] nomes =
        {
            "marcus",
            "junior",
            "theo"
        };

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void VetoresBidimencilnal()
    {
        //Podendo ter varias dimenções, precisamos informar indice da linha e coluna do item em questão
        //Virgula na declaração separa a Linha e a coluna
        int[,] numeros = new int[2, 3];

        numeros[0, 0] = 10;
        numeros[0, 1] = 15;
        numeros[0, 2] = 20;

        numeros[1, 0] = 25;
        numeros[1, 1] = 30;
        numeros[1, 2] = 35;

        Console.WriteLine("[" + numeros[0, 1] + "]");
        string[,] nomes =
        {
            {
                "Marcus","Daniel","Pedro"
            },
            {
                "Alberto","Mario","Carlos"
            }
            // Ao Declarar os elentos da primeira linha e coluna precisamos igualar a quantidade de elementos em todas as colunas.
        };
        Console.WriteLine("[" + nomes[0, 1] + "]");

    }

    static void PassagemValorReferencia(ref int valor)
    {
        valor *= 2;
        // utilizando o ref estamos usando a referencia, assim ele
        // não irar criar outra variavel na memoria mas utilizarar o endereço da variavel passada na chamada do método.
        // para utilizar o valor e não referencia basta retirar o ref. assim a variavel receberar outro endereço na memória e não sera impresso o resultado 20
    }

    static void MultiplicarMatrizes()
    {
        int[,] matriz1 = new int[2, 3];
        int[,] matriz2 = new int[3, 2];
        int[,] matrizResultado = new int[2, 2];
        Console.WriteLine("Preencha a Matriz1");
        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write("#1 Matriz.Posição: [" + linha + "-" + coluna + "]");
                matriz1[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Preencha a Matriz2\n");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write("#1 Matriz.Posição: [" + linha + "-" + coluna + "]");
                matriz2[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\n Resultado da matriz 1# x matriz 2#");
        matrizResultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
        matrizResultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
        matrizResultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
        matrizResultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

        Console.WriteLine("[" + matrizResultado[0, 0] + "] [" + matrizResultado[0, 1] + "]");
        Console.WriteLine("[" + matrizResultado[1, 0] + "] [" + matrizResultado[1, 1] + "]");
        Console.ReadKey();
    }

    #region Utilizando Estrutura Condicionais if else elseif
    static void CalcularIMC()
    {
        Console.WriteLine("Informe o peso em Kg: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a altura em metros");
        double altura = double.Parse(Console.ReadLine());
        double valorImc = peso / (altura * altura);

        if (valorImc < 20)
        {
            Console.WriteLine("\n IMC= " + valorImc + "-> Abaixo do Peso");
        }
        else if (valorImc >= 20 && valorImc <= 24)
        {
            Console.WriteLine("\n IMC= " + valorImc + "-> Peso Normal");
        }
        else if (valorImc >= 25 && valorImc <= 29)
        {
            Console.WriteLine("\n IMC= " + valorImc + "-> Acima do Peso");
        }
        else if (valorImc >= 30 && valorImc <= 34)
        {
            Console.WriteLine("\n IMC= " + valorImc + "-> Você está Obeso");
        }
        else
        {
            Console.WriteLine("\nIMC = " + valorImc + "Você Muito Obeso");
        }
        Console.ReadKey();
    }
    #endregion
    static void SwitchCase()
    {
        int escolha = 2;
        switch (escolha)
        {
            default:
                Console.WriteLine("Opção Default");
                break;
            case 1:
                Console.WriteLine("Opção 1");
                break;
            case 2:
                Console.WriteLine("Opção 2");
                break;
            case 3:
            case 4:
                Console.WriteLine("Opção Combinada");
                break;

        }
        Console.ReadKey();
    }
    static void Goto()
    {
    inicio:
        Console.WriteLine("Escolha um opção: ");
        int op = int.Parse(Console.ReadLine());
        int valor = 0;

        switch (op)
        {
            default:
                Console.WriteLine("Opção invalida Tente novamente");
                goto inicio;
            case 1:
                valor += 100;
                break;
            case 2:
                valor += 50;
                goto case 1;
        }
        Console.WriteLine($"Valor Final= {valor}");
    }
    static void Calculadora()
    {
        Console.WriteLine("***--CALCULADORA--***");
    inicio:
        Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("INFORME O SEGUNDO NÚMERO: ");
        double num2 = double.Parse(Console.ReadLine());
    operacao:
        Console.WriteLine("INFORME A OPERAÇÃO + - * /");
        char op = char.Parse(Console.ReadLine());
        double resultado = 0;

        switch (op)
        {
            default:
                Console.WriteLine("OPERAÇÃO INVÁLIDA");
                goto operacao;
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;
        }
        Console.WriteLine($"Resultado= {resultado}");
        goto inicio;
    }
    static void Quadrante()
    {

        int x, y;
        bool teste = true;
        while (teste)
        {
            string[] s = Console.ReadLine().Split(' ');
            var steste = s.Length;
            try
            {
                if (steste > 1 && !string.IsNullOrEmpty(s[1]) && !string.IsNullOrEmpty(s[0]))
                {
                    x = int.Parse(s[0]);
                    y = int.Parse(s[1]);
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("segundo ");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    Console.WriteLine("NULO, APLICAÇÃO FECHADA");
                    break;
                }
            }
            catch
            {
                break;
            }
        }
    }
    static void EstruturasRepeticao()
    {
        #region WHILE + DO WHILE
        int whileValor = 11;
        while (whileValor <= 10)
        {
            Console.WriteLine("O Valor é: " + whileValor);
            whileValor++;
        }
        // do while é a certeza que o processo será executado pelomenos uma vez.
        int doWhileValor = 0;
        do
        {
            Console.WriteLine("O Valor é: " + doWhileValor);
            doWhileValor++;
        }
        while (doWhileValor <= 10);
        #endregion

        #region FOR + FOREACH

        for (int i = 0, j = 10; i <= 10; i++, j--)
        {
            Console.WriteLine("ÍNDICE I: " + i + ' ' + "ÍNDICE J: " + j);
        }
        string[] nomes = { "MARCUS", "CARLOS", "JOÃO VICTOR" };
        foreach (string nome in nomes)
        {
            Console.WriteLine("NOME: " + nome);
        }
        #endregion

        #region SEQUÊNCIA DE FIBONACCI
        int a = 0, b = 1, c = 0;
        Console.WriteLine("Quantos valores? ");
        int valores = int.Parse(Console.ReadLine());
        Console.WriteLine("Sequência de Fibonacci com: " + valores + " valores");

        for (int i = 0; i < valores; i++)
        {
            if (i < valores -1)
            {
                Console.Write(a+",");
            }
            else
            {
                Console.Write(a);
            }            
            c = a + b;
            a = b;
            b = c;
           // sequencia de Fibonnaci se da a soma dos numeros avançando sempre uma casa. ex.: sequencia de 4 numeros a0+b1=c1
           // "a" ira avançar uma casa então receberar o valor de "b" a=b e "b" avançara uma casa recebendo o valor de "c" que é o resultado da soma de a+b
           // ai o siclo se repete mais uma vez a1+b1=c2
            
        }
        #endregion

        Console.ReadKey();
    }
    public class Nomes
    {
        public string Nome { get; set; }
    }
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}

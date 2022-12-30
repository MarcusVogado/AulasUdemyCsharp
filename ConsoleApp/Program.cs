
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    enum Notas
    {
        Minimo=10,
        Media=15,
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
        string menssage=text;
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
       

        Console.Write("Nome "+pessoa1.nome+" Altura " +pessoa1.altura +" Idade "+pessoa1.idade);
    }
}

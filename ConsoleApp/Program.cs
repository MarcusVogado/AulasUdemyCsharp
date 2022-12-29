
class Program
{
    static void Main(string[] args)
    {
        //*Region* Serve para separar blocos do código e torna-lo de facil vizualização e entendimento
        #region Olá mundo
        Console.WriteLine("OLÁ MUNDO");
        #endregion

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

    }
}

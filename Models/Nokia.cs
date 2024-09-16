namespace DesafioPOO.Models
{
    using System.Threading;
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
            public Nokia()
            {

            }

            public Nokia(string numero, string modelo, string imei, int memoria)
            {
                Numero = numero;
                Modelo = modelo;
                IMEI = imei;
                Memoria = memoria;
            }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando {nomeApp} no Nokia");

             for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
            Console.WriteLine("");
        }

    }
}   
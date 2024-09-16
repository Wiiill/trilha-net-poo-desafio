namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone()
        {

        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        {
                Numero = numero;
                Modelo = modelo;
                IMEI = imei;
                Memoria = memoria;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando {nomeApp} no Iphone");

           for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
                 
        }
    }
}
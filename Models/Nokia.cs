namespace DesafioPOO.Models
{
    using System.Threading;
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
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
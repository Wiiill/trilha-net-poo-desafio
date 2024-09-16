namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
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
using DesafioPOO.Models;
using System;

Nokia n = new Nokia();
n.IMEI = "123";
n.Memoria = 128;
n.Modelo = "Nokia N2024";
n.Numero = "4002-8922";

Console.WriteLine("AS informações do Nokia são: ");
    Console.WriteLine($"Seu IMEI é {n.IMEI}");
    Console.WriteLine($"Sua memória é {n.Memoria}");
    Console.WriteLine($"Seu modelo é {n.Modelo}");
    Console.WriteLine($"Seu número é {n.Numero}");

Console.WriteLine("Em seguida, instalando aplicativo no Nokia");
    n.InstalarAplicativo("Whatsapp");
Console.WriteLine("Ligando o Nokia");
    n.Ligar();
Console.WriteLine("Recebendo ligação no Nokia");
    n.ReceberLigacao();

Iphone i = new Iphone();
i.IMEI = "321";
i.Memoria = 128;
i.Modelo = "18 pro max";
i.Numero = "1123-4456";

Console.WriteLine("AS informações do Iphone são: ");
    Console.WriteLine($"Seu IMEI é {i.IMEI}");
    Console.WriteLine($"Sua memória é {i.Memoria}");
    Console.WriteLine($"Seu modelo é {i.Modelo}");
    Console.WriteLine($"Seu número é {i.Numero}");


Console.WriteLine("Em seguida, instalando aplicativo no Iphone");
    n.InstalarAplicativo("Instagram");
Console.WriteLine("Ligando o Iphone");
    n.Ligar();
Console.WriteLine("Recebendo ligação no Iphone");
    n.ReceberLigacao();

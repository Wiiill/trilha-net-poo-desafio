using DesafioPOO.Models;
using System;

Nokia nokia = new Nokia(numero: "4002-8922", modelo: "modelo 1", imei: "111111111", memoria: 64);
Console.WriteLine("Nokia: ");
    nokia.Ligar();
    nokia.InstalarAplicativo("Whatsapp");
    

Iphone iphone = new Iphone(numero: "4987", modelo: "modelo 2", imei: "222222222", memoria: 128);
Console.WriteLine("Iphone: ");
    iphone.Ligar();
    iphone.InstalarAplicativo("Whatsapp");
        

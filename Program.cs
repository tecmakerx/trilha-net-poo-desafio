using DesafioPOO.Models;

// Implementado

Iphone nokia = new Iphone("123456", "Nokia", "762G565UI", 128);

Console.WriteLine($"Numero: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.Imei}");
Console.WriteLine($"Memoria: {nokia.Memoria}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("---------------------");

Nokia iphone = new Nokia("123456", "Iphone", "762G565UI", 128);

Console.WriteLine($"Numero: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.Imei}");
Console.WriteLine($"Memoria: {iphone.Memoria}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

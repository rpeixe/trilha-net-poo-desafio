using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "1234 5678", modelo: "Nokia 1", imei: "123456789", memoria: 1024);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Aplicativo");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");

Smartphone iphone = new Iphone(numero: "1234 5678", modelo: "iPhone 1", imei: "123456789", memoria: 1024);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Aplicativo");
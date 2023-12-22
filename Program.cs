using DesafioPOO.Models;

Console.WriteLine("No Smartphone NOKIA:");
Smartphone nokia = new Nokia(numero: "87381273", modelo: "132", imei: "1238497", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("No Smartphone IPHONE:");
Smartphone iphone = new Iphone(numero: "90531742", modelo: "728", imei: "0192832", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crush");
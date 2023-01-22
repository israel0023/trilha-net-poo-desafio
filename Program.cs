using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "01010101", memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("PUBG");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "10101010", memoria: 64 );
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Valorant");
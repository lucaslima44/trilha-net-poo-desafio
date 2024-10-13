using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Modelo 1", imei: "IMEI 1", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Snapchat");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "11999999999", modelo: "Modelo 1", imei: "IMEI 1", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
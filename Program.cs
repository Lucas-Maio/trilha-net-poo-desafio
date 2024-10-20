using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", emei: "129748ji237", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "456", modelo: "Modelo 2", emei: "jjgj21348", memoria: 24);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
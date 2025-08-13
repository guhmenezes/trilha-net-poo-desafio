using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("12345", "Modelo A", "111111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("56789", "Modelo B", "222222222", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

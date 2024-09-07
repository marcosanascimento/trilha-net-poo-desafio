using DesafioPOO.Models;

Console.Clear();

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"(11) 9 9876-4321", modelo:"Mod. Nokya-1", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"(12) 9 8765-1234", modelo:"Mod. iPhone-2", imei:"2222222", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

using DesafioPOO.Models;

// Criando um objeto Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

// Criando um objeto Iphone
Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 13", imei: "987654321098765", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


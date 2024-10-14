using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");
Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "45585", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

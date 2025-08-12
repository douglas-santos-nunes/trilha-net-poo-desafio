﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "789", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

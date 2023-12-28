using DesafioPOO.Models;

Smartphone nokia = new Nokia (numero: "12344", modelo: "A22", imei: "123456789123456", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Termux");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "44311", modelo: "Iphone X", imei: "987654321987654", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Android Simulator");

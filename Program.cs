using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new Nokia(numero: "(19) 99999-9999", modelo:"Tijolão", imei:"312233", memoria: 16);
Console.WriteLine("-------- NOKIA --------");
Console.WriteLine
(
    $"Número: {n.Numero}\nModelo: {n.Modelo}\nIMEI: {n.IMEI}\nMemória: {n.Memoria}GB\n"
);
n.InstalarAplicativo("Youtube");
n.Ligar();
n.ReceberLigacao();

Iphone i = new Iphone(numero: "(19) 99999-9999", modelo:"13 Pro Max Plus Vital Ultra Megatron", imei:"0646203", memoria: 64);
Console.WriteLine("\n-------- IPHONE --------");
Console.WriteLine
(
    $"Número: {i.Numero}\nModelo: {i.Modelo}\nIMEI: {i.IMEI}\nMemória: {i.Memoria}GB\n"
);
i.InstalarAplicativo("Youtube");
i.Ligar();
i.ReceberLigacao();
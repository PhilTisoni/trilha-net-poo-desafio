using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new (numero: "99999-9999", modelo: "1234", imei: "11111111", memoria: 32);
Iphone iphone = new (numero: "88888-8888", modelo: "4567", imei: "2222222", memoria: 16);

Console.WriteLine("Teste Nókia: ");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\nTeste Iphone: ");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

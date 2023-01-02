using DesafioPOO.Models;


Console.WriteLine("Smartphone IPHONE: \n\n");
Smartphone iphone = new Iphone(numero: "(51)123333", modelo: "Iphone 17", imei: "423432", 128);
iphone.Ligar();
Console.WriteLine();
iphone.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone NOKIA:\n\n ");
Smartphone nokia = new Nokia(numero: "(19)12341234", modelo: "Tijolão", imei: "321312", 32);
nokia.ReceberLigacao();
Console.WriteLine();
nokia.InstalarAplicativo("WhatsApp Business");
using DesafioPOO.Models;

Nokia nokia = new("+55 (11) 95050-5050", "Nokia Modelo A", "111", 32);
nokia.VerConfigurações();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Iphone iPhone = new("+55 (11) 99090-9090", "IPhone 15 Pro", "222", 128);
iPhone.VerConfigurações();
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Discord");

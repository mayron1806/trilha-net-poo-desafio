using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "999999999", "8s", "00000000000001", 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia(numero: "888888888", "1", "00000000011", 1);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Calculadora");

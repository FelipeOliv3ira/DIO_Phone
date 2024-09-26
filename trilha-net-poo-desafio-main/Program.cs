using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Smartphone nokia = new Nokia("123456789", "Nokia 15", "IMEI2", 48);
            Smartphone iphone = new Iphone("987654321", "iPhone 13", "IMEI1", 128);

            // Nokia
            Console.WriteLine("Teste com Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            // iPhone
            Console.WriteLine("\nTeste com iPhone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
using System;
using System.Threading.Channels;

namespace ISP
{
    // Interface Segragation principle - zasada segregacji interfejsów 
    // Wiele dedykowanych interfejsów jest lepsza niż jeden ogólny
    public interface IPrinter
    {
        void PrintGrey(string content);
        void PrintColor(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }
    
    // drukarka która również skanuje
    public class ConcretePrinterX : IPrinter, IScanner
    {
        public void PrintGrey(string content)
        {
            Console.WriteLine($"print in grey {content} using printer X");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine($"print in color {content} using printer X");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"scan {content} by printer X");
        }
    }

    // Drukarka która nie ma opcji skanowania 
    public class ConcretePrinterY : IPrinter
    {
        public void PrintGrey(string content)
        {
            Console.WriteLine($"print in grey {content} using printer Y");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine($"print in color {content} using printer Y");
        }
    }
}
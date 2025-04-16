using System;

namespace ConsoleApp110425_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler docHandler = new DOCHandler();
            TXTHandler txtHandler = new TXTHandler();
            XMLHandler xmlHandler = new XMLHandler();

            while (true)
            {
                Console.Write("Ввведите формат документа (DOC, TXT, XML) - ");
                string name = Console.ReadLine();
                switch (name)
                {
                    case "DOC":
                        docHandler.Open();
                        docHandler.Create();
                        docHandler.Change();
                        docHandler.Save();
                        break;
                    case "TXT":
                        txtHandler.Open();
                        txtHandler.Create();
                        txtHandler.Change();
                        txtHandler.Save();
                        break;
                    case "XML":
                        xmlHandler.Open();
                        xmlHandler.Create();
                        xmlHandler.Change();
                        xmlHandler.Save();
                        break;
                    default:
                        Console.WriteLine("Неверный формат. Попробуй снова");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

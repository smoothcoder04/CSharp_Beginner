using System;

namespace Printer
{
    class Program
    {
        public static void Main()
        {
            Printer MyPrinter = new Printer();
            Printer MyColourPrinter = new Colourprinter();
            Printer MyBlackandWhite = new BlackandWhiteprinter();
            BlackandWhiteprinter MyBlackandWhitePrinter = new BlackandWhiteprinter();

            MyPrinter.Print();
            MyColourPrinter.Print();
            MyBlackandWhite.Print();
            MyBlackandWhitePrinter.Print();
        }
    }
}
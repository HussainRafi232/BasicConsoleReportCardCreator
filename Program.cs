using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCardCreator
{
    class Program
    {
        public static void Main()   /// Main function
        {
            //ConsoleWindowSize CSZ = new ConsoleWindowSize();
            //CSZ.setConsoleSize();

            Console.Title = "Report Card Creator"; /// Title for the Console Application

            Frontend fe = new Frontend();   /// Frontend.cs Object to call Instructions() method
            fe.Instructions();
            Options op = new Options(); /// Options.cs Object to call OptionsFrontend() method
            op.OptionsFrontend();


            Console.ReadKey();
        }
    }
}

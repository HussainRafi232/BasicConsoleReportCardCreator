using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCardCreator
{
    class Options
    {
        public void OptionsFrontend() /// Options to choose from the Main Menu
        {
            Backend be = new Backend(); /// Backend.cs Object to call CreateReportCard() method
            ReturnManagement RMF = new ReturnManagement(); /// ReturnManagement.cs Object to call ReturnFrontend() method
            ConsoleWindowSize CSZ = new ConsoleWindowSize();
            int option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Minimum 5 subjects are required to create a report card");
                Console.WriteLine("Enter the amount of subjects:");
                be.CreateReportCard();
            }
            else if (option == 2)
            {
                System.Environment.Exit(0);
            }   
            else
            {
                Console.WriteLine("Wrong option! Please try again. Press any key to retry");
                RMF.ReturnFrontend();
            }
            RMF.ReturnFrontend();
        }
    }
}

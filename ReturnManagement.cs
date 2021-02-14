using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCardCreator
{
    class ReturnManagement
    {
        /// Returns end user to Frontend if they want to create another table
        public void ReturnFrontend()    
        {
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
        /// Returns end user to Backend if they want to create another table
        public void ReturnBackend()
        {
            ReturnManagement RM = new ReturnManagement();
            Backend be = new Backend();
            String input = Console.ReadLine();
            /// If the user inputs "y" or "Y" than it sends you
            /// to the create report card menu
            if (input == "y" || input == "Y") 
            {

                Console.WriteLine("Enter the amount of subjects:");
                be.CreateReportCard();
            }
            else if (input == "n" || input == "N")  /// If the user inputs "n" or "N" than it exits the program
            {
                System.Environment.Exit(0);
            }
            else
            {
                /// If the user's input is neither the first two inputs than it gives you an error 
                /// and you can retry entering one of the first two inputs to proceed or exit the
                /// program
                Console.WriteLine("Wrong option");
                RM.ReturnBackend();
            }
        }

        /// Asks the end user if they want to create another report card
        public void ReturnMessage()
        {
            String message = "Would you like to create another report card? Y/n";
            Console.WriteLine(message);
        }
    }
}

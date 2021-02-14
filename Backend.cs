using System;
using System.Collections.Generic;

namespace ReportCardCreator
{
    class Backend
    {

        ReturnManagement RMB = new ReturnManagement();
        
        
        public void CreateReportCard()  /// Function to create the Report Card
        {
            ErrorManagement EM = new ErrorManagement();
            int aos = Int32.Parse(Console.ReadLine()); /// Amount of Subjects

            if (aos < 5)    /// If statement for if the entered subjects are less than 5
            {
                EM.ErrorMessage();
                CreateReportCard();
            }
            else /// Else statement for if the entered subjects are 5 or greater than 5
            { 
            List<String> SubjectName = new List<String>(); /// List for Entering Subject Names
            List<String> TotalMarks = new List<String>();/// List for Entering Total Marks of a Subject
            List<String> ObtainedMarks = new List<String>(); /// List for Entering Obtained Marks of a Subject

            for (int i = 1; i <= aos; i++)  /// For loop to generate the report card user inputs
            {
                Console.WriteLine("Enter Subject # " + i + " Name:");
                String input1 = Console.ReadLine();
                SubjectName.Add(input1);
                Console.WriteLine("Enter Total Marks:");
                String input2 = Console.ReadLine();
                TotalMarks.Add(input2);
                Console.WriteLine("Enter Obtained Marks:");
                String input3 = Console.ReadLine();
                ObtainedMarks.Add(input3);
            }

            Console.Clear();
            Console.WriteLine("REPORT CARD:"); /// Some terrible formatting for the report card
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Subject Name" + "            " + " Total Marks " + "               " + " Obtained Marks ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < aos; j++) /// For loop to print the Report Card on the console.
                {
                    /// I know it's terrible formatting
                    Console.WriteLine(SubjectName[j] + "                        " + TotalMarks[j] + "                                " + ObtainedMarks[j]);
                }
            }

            Console.WriteLine();
            RMB.ReturnMessage();    /// Asks the end user if they want to create another report card
            RMB.ReturnBackend();    /// Asks the end user for input to create another report card
            Console.Clear();    /// Clears the console screen

        }
    }
}

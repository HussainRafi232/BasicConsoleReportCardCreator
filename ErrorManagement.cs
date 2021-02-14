using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCardCreator
{
    class ErrorManagement
    {
        public void ErrorMessage()  /// Error message when the end user types less than 5 subjects 
        {
            Console.WriteLine("Incorrect amount of subjects. Please try again");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AccountRegistration
{
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static string FirstName = string.Empty;
        public static string LastName = string.Empty;
        public static string MiddleName = string.Empty;
        public static string Address = string.Empty;
        public static string Program = string.Empty;

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string txt) => txt;
        public static string GetLastName(string txt) => txt;
        public static string GetMiddleName(string txt) => txt;
        public static string GetAddress(string txt) => txt;
        public static string GetProgram(string txt) => txt;
        public static long GetAge(long number) => number;
        public static long GetContactNo(long number) => number;
        public static long GetStudentNo(long number) => number;

    }

    

    
}

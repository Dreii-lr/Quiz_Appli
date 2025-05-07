using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Appli
{
    public static class AppContext
    {
        public static int CurrentStudentId { get; set; }
        public static string CurrentUsername { get; set; }
        public static int CurrentTeacherId { get; set; }

        public static string CurrentTeacherUsername { get; set; }
    }
    public static class CurrentUser
    {
        public static int StudentId { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string LastName { get; set; }
        public static string Username { get; set; }
        public static DateTime Birthdate { get; set; }
        public static int TeacherId { get; set; }
    }
    
}

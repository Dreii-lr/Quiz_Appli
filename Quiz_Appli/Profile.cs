using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Appli
{
    internal class Profile
    {
        public static int StudentID { get; set; }


    }
    public static class AppContext
    {
        public static int CurrentStudentId { get; set; }
    }
}

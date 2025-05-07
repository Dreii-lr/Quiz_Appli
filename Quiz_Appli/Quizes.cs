using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Appli
{
    internal class Quizes
    {
        public List<QuizApp> QuizId { get; set; }
        public string QuestionID { get; set; }            // ID of the question from the database
        public string QuestionText { get; set; }       // The actual question text
        public List<string> ShuffledChoices { get; set; } // Shuffled list of choices (including the correct answer)
        public int CorrectIndex { get; set; }          // Index in ShuffledChoices that contains the correct answer
    }
}

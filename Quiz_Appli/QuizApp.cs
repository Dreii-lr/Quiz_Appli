using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quiz_Appli
{
    internal class QuizApp
    {
        public string Id { get; set;}

        public string QuizId { get; set; }

        public string Title { get; set;}

        public string CreatedBy { get; set; }

        public string QuestionID { get; set; }

        public string QuestionText { get; set; }

        public string ChoiceID { get; set; }

        public string Choice1 { get; set; }

        public string Choice2 { get; set; }

        public string Choice3 { get; set; }

        public string Answer { get; set; }
    }
}

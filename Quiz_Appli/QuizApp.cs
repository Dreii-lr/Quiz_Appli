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
        public string QuestionID { get; set; }

        public string QuestionText { get; set; }

        public string ChoiceID { get; set; }

        public string choices_a { get; set; }

        public string choices_b { get; set; }

        public string choices_c { get; set; }

        public string answer { get; set; }
    }
}

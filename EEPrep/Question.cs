using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    public class Question
    {
        public Question()
        {
            
        }
        public String QuestionText { get; set; }
        public String OptionA { get; set; }
        public String OptionB { get; set; }
        public String OptionC { get; set; }
        public String OptionD { get; set; }
        public String OptionE { get; set; }
        public Char Answer { get; set; }
        public String Topic { get; set; }
        public String Reason { get; set; }

        
    }

}

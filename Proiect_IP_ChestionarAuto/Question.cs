using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP_ChestionarAuto
{
    internal class Question
    {
        public Question(int id, string title, string optionA, string optionB, string optionC, int answer, string image)
        {
            Id = id;
            Title = title;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            Answer = answer;
            Image = image;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public int Answer { get; set; }
        public string Image { get; set; }
    }
}

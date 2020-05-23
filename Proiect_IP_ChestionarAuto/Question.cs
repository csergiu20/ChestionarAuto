namespace Proiect_IP_ChestionarAuto
{
    internal class Question
    {
        public Question(int id, string title, string optionA, string optionB, string optionC, string answer, string image)
        {
            Id = id;
            Title = title;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            Answer = answer;
            Image = image;
        }

        public int Id { get; }
        public string Title { get; }
        public string OptionA { get; }
        public string OptionB { get; }
        public string OptionC { get; }
        public string Answer { get; }
        public string Image { get; }
    }
}

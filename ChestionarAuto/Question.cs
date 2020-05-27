using System.Collections.Generic;

namespace ChestionarAuto
{
    internal class Question
    {
        public Question(string title, Dictionary<string, bool> options, string image)
        {
            Title = title;
            Options = options;
            Image = image;
        }

        public string Title { get; }
        public Dictionary<string, bool> Options { get; }
        public string Image { get; }
    }
}

using System.Collections.Generic;

namespace Proiect_IP_ChestionarAuto
{
    internal class Question
    {
        public Question(int id, string title, List<KeyValuePair<string, bool>> options, string image)
        {
            Id = id;
            Title = title;
            Options = options;
            Image = image;
        }

        public int Id { get; }
        public string Title { get; }
        public List<KeyValuePair<string, bool>> Options { get; }
        public string Image { get; }

    }
}

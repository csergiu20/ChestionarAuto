using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ChestionarAuto
{
    internal class JsonManager
    {
        public JsonManager(string category, string questionsPath)
        {
            using (var r = new StreamReader(questionsPath + "cat" + category + ".json"))
            {
                var jsonFile = r.ReadToEnd();
                Questions = JsonConvert.DeserializeObject<List<Question>>(jsonFile);
                CountQuestions = Questions.Count;
            }
        }

        public List<Question> Questions { get; }

        public int CountQuestions { get; }
    }
}

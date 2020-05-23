using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Proiect_IP_ChestionarAuto
{
    internal class XmlManager
    {
        private readonly string _imagesPath;
        private readonly string _questionsPath;
        private readonly string _category;

        public XmlManager(string category, string imagesPath, string questionsPath)
        {
            _category = category;
            _imagesPath = imagesPath;
            _questionsPath = questionsPath;
        }

        public int CountQuestions()
        {
            var document = new XmlDocument();
            document.Load(_questionsPath + "cat" + _category + ".xml");

            return document.DocumentElement.Cast<XmlNode>().Count();
        }

        public List<Question> GetQuestions(List<int> numbers)
        {
            var doc = new XmlDocument();
            doc.Load(_questionsPath + "cat" + _category + ".xml");

            var questions = new List<Question>();

            foreach (var number in numbers)
            {
                foreach (XmlNode node in doc.DocumentElement)
                {
                    var id = int.Parse(node.Attributes[0].InnerText);

                    if (id != number) continue;
                    var title = node.ChildNodes[0].InnerText;
                    var optionA = node.ChildNodes[1].InnerText;
                    var optionB = node.ChildNodes[2].InnerText;
                    var optionC = node.ChildNodes[3].InnerText;
                    var image = _imagesPath + node.ChildNodes[4].InnerText.ToLower();
                    var answerString = node.ChildNodes[5].InnerText.ToUpper();

                    var optionAndAnswerA = new KeyValuePair<string, bool>(optionA, answerString.Contains("A"));
                    var optionAndAnswerB = new KeyValuePair<string, bool>(optionB, answerString.Contains("B"));
                    var optionAndAnswerC = new KeyValuePair<string, bool>(optionC, answerString.Contains("C"));

                    var options = new List<KeyValuePair<string, bool>> {optionAndAnswerA, optionAndAnswerB, optionAndAnswerC};

                    questions.Add(new Question(id, title, options, image));
                }
            }

            return questions;
        }
    }
}

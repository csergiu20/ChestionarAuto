using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proiect_IP_ChestionarAuto
{
    internal class XmlExtractor
    {
        private const string ImagesPath = "$(SolutionDir)\\..\\..\\..\\resources\\images\\";
        private const string QuestionsPath = "$(SolutionDir)\\..\\..\\..\\resources\\questions\\catB.xml";

        public int Count()
        {
            var document = new XmlDocument();
            document.Load(QuestionsPath);

            return document.DocumentElement.Cast<XmlNode>().Count();
        }

        public List<Question> Questions(List<int> numbers)
        {
            var doc = new XmlDocument();
            doc.Load(QuestionsPath);

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
                    var image = ImagesPath + node.ChildNodes[4].InnerText;
                    var answer = int.Parse(node.ChildNodes[5].InnerText);

                    questions.Add(new Question(id, title, optionA, optionB, optionC, answer, image));
                }
            }

            return questions;
        }
    }
}

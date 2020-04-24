using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_IP_ChestionarAuto
{
    internal class XmlManager
    {
        private const string ImagesPath = "resources\\images\\";
        private const string QuestionsPath = "resources\\questions\\";
        private readonly string _category;

        public XmlManager(string category)
        {
            _category = category;
        }

        public int CountQuestions()
        {
            var document = new XmlDocument();
            document.Load(QuestionsPath + "cat" + _category + ".xml");

            return document.DocumentElement.Cast<XmlNode>().Count();
        }

        public bool IsXmlValid(int maxQuestions)
        {
            // TO DO
            //
            // Validate if the xml is written correctly (dtd or something) so that CountQuestions will not give error
            //

            if (!File.Exists("resources\\images\\0.jpg")
                || !File.Exists(QuestionsPath + "cat" + _category + ".xml"))
            {
                return false;
            }
            if (CountQuestions() < maxQuestions)
            {
                return false;
            }

            return true;
        }

        public void AddQuestion(Question question)
        {
            //Adds question to xml file
            throw new NotImplementedException();
        }

        public List<Question> GetQuestions(List<int> numbers)
        {
            var doc = new XmlDocument();
            doc.Load(QuestionsPath + "cat" + _category + ".xml");

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
                    var image = ImagesPath + node.ChildNodes[4].InnerText.ToUpper();
                    var answer = node.ChildNodes[5].InnerText;

                    questions.Add(new Question(id, title, optionA, optionB, optionC, answer, image));
                }
            }

            return questions;
        }
    }
}

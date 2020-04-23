using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_IP_ChestionarAuto
{
    public partial class QuestionForm : Form
    {
        private const int MaxQuestions = 3;

        private readonly List<Question> _questions;
        private int _questionIndex = 0;

        private int _currentCorrectAnswer = 0;

        private int _correctAnswers = 0;
        private int _wrongAnswers = 0;
        private int _percentage = 0;

        public QuestionForm()
        {
            InitializeComponent();

            var qXml = new XmlExtractor();
            var totalQuestions = qXml.Count();
            var randomNumbers = RandomNumbers.Generate(totalQuestions, MaxQuestions);
            _questions = qXml.Questions(randomNumbers);

            LoadQuestions();
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            var buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == _currentCorrectAnswer)
            {
                _correctAnswers++;
            }
            else
            {
                _wrongAnswers++;
            }

            LoadStatistics();

            _questionIndex++;

            if (_questionIndex < MaxQuestions)
            {
                LoadQuestions();
            }
            else
            {
                Hide();
                var message = _percentage.ToString() + "% Corecte!";
                const string title = "Scor";
                MessageBox.Show(message, title);
                Close();
            }
        }

        private void LoadQuestions()
        {
            lblQTitle.Text = _questions[_questionIndex].Title;
            btnA.Text = _questions[_questionIndex].OptionA;
            btnB.Text = _questions[_questionIndex].OptionB;
            btnC.Text = _questions[_questionIndex].OptionC;
            picBoxQImage.Image = Image.FromFile(_questions[_questionIndex].Image);
            _currentCorrectAnswer = _questions[_questionIndex].Answer;
        }

        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            _percentage = (int)Math.Round((double)(_correctAnswers * 100) / MaxQuestions);
        }
    }
}

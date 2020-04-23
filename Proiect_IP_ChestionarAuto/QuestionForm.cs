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
        private const string Category = "B";

        private readonly List<Question> _questions;
        private int _questionIndex = 0;

        private int _currentCorrectAnswer = 0;

        private int buttonTag = 0;

        private int _correctAnswers = 0;
        private int _wrongAnswers = 0;
        private int _percentage = 0;

        public QuestionForm()
        {
            InitializeComponent();

            var xmlManager = new XmlManager(Category);
            var totalQuestions = xmlManager.CountQuestions();
            var randomNumbers = RandomNumbers.Generate(totalQuestions, MaxQuestions);
            _questions = xmlManager.GetQuestions(randomNumbers);

            LoadQuestions();
            LoadStatistics();
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            buttonTag = Convert.ToInt32(senderObject.Tag);

            switch (buttonTag)
            {
                case 1:
                    btnA.Enabled = false;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    break;
                case 2:
                    btnA.Enabled = true;
                    btnB.Enabled = false;
                    btnC.Enabled = true;
                    break;
                case 3:
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = false;
                    break;
            }

            btnChangeAnswer.Enabled = true;
            btnAnswer.Enabled = true;
        }

        private void LoadQuestions()
        {
            lblQTitle.Text = _questions[_questionIndex].Title;
            btnA.Text = _questions[_questionIndex].OptionA;
            btnB.Text = _questions[_questionIndex].OptionB;
            btnC.Text = _questions[_questionIndex].OptionC;
            picBoxQImage.Image = Image.FromFile(_questions[_questionIndex].Image);
            picBoxQImage.SizeMode = PictureBoxSizeMode.StretchImage;
            _currentCorrectAnswer = _questions[_questionIndex].Answer;
        }

        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            _percentage = (int)Math.Round((double)(_correctAnswers * 100) / MaxQuestions);

            lblInitialQuestions.Text = MaxQuestions.ToString();
            lblRemainingQuestions.Text = "error";

            lblRemainingTime.Text = "error";

        }

        private void btnExitQForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
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

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;

                btnChangeAnswer.Enabled = false;
                btnAnswer.Enabled = false;
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

        private void btnChangeAnswer_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

            btnChangeAnswer.Enabled = false;
            btnAnswer.Enabled = false;
        }
    }
}

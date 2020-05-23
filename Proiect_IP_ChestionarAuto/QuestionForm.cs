using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class QuestionForm : Form
    {
        private readonly int _maxQuestions;
        private readonly int _maxWrongAnswers;

        private int _remainingQuestions;
        private int _timerCounter = 1800;
        private int _correctAnswers;
        private int _wrongAnswers;

        private readonly List<Question> _questions;
        private List<char> _currentCorrectAnswers;
        private int _questionIndex;

        private int _pressedButtonTag;

        public QuestionForm(string category, int maxQuestions, int maxWrongAnswers)
        {
            InitializeComponent();

            _maxQuestions = maxQuestions;
            _maxWrongAnswers = maxWrongAnswers;
            _remainingQuestions = _maxQuestions;

            timerRemaining = new Timer();
            timerRemaining.Tick += timerRemaining_Tick;
            timerRemaining.Interval = 1000;
            timerRemaining.Start();

            lblInitialQuestions.Text = _maxQuestions.ToString();

            var xmlManager = new XmlManager(category);
            var totalQuestions = xmlManager.CountQuestions();

            var randomNumbers = RandomNumbers.Generate(totalQuestions, _maxQuestions);
            _questions = xmlManager.GetQuestions(randomNumbers);

            LoadQuestions();
            LoadStatistics();
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            _pressedButtonTag = Convert.ToInt32(senderObject.Tag);

            switch (_pressedButtonTag)
            {
                case 1:
                    btnA.Enabled = false;
                    break;
                case 2:
                    btnB.Enabled = false;
                    break;
                case 3:
                    btnC.Enabled = false;
                    break;
            }

            btnResetAnswer.Enabled = true;
            btnAnswer.Enabled = true;
        }

        private void LoadQuestions()
        {
            lblQTitle.Text = _questions[_questionIndex].Title;
            btnA.Text = _questions[_questionIndex].OptionA;
            btnB.Text = _questions[_questionIndex].OptionB;
            btnC.Text = _questions[_questionIndex].OptionC;

            try
            {
                picBoxQImage.Image = Image.FromFile(_questions[_questionIndex].Image);
            }
            catch (FileNotFoundException)
            {
                picBoxQImage.Image = Image.FromFile("resources\\images\\0.jpg");
            }

            picBoxQImage.SizeMode = PictureBoxSizeMode.StretchImage;

            _currentCorrectAnswers = new List<char>();

            foreach (var singleAnswer in _questions[_questionIndex].Answer)
            {
                _currentCorrectAnswers.Add(singleAnswer);
            }
        }

        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            lblRemainingQuestions.Text = (_remainingQuestions--).ToString();
        }

        private void EndQuestionnaire()
        {
            Hide();

            var message = _wrongAnswers == _maxWrongAnswers ? "Ati fost respins!\n" : "Felicitari, ati promovat!\n";
            message += "Ati raspuns corect la " + _correctAnswers + " din cele " + _maxQuestions + " intrebari.";
            const string title = "Rezultat";

            MessageBox.Show(message, title);
            Close();
        }

        private void btnAnswerLater_Click(object sender, EventArgs e)
        {
            var temp = _questions[_questionIndex];
            _questions.Remove(_questions[_questionIndex]);
            _questions.Add(temp);

            btnResetAnswer_Click(sender, e);
            LoadQuestions();
        }

        private void btnResetAnswer_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

            btnResetAnswer.Enabled = false;
            btnAnswer.Enabled = false;
        }

        private void CheckIfPressedButtonsAreTheCorrectAnswerV2()
        {

        }

        private void CheckIfPressedButtonsAreTheCorrectAnswer()
        {
            if (btnA.Enabled == false && _currentCorrectAnswers.Contains('A')
                                            && btnB.Enabled == false && _currentCorrectAnswers.Contains('B')
                                            && btnC.Enabled == false && _currentCorrectAnswers.Contains('C')
                                            && _currentCorrectAnswers.Count() == 3)
            {
                _correctAnswers++;
            }
            else if (btnA.Enabled == false && _currentCorrectAnswers.Contains('A')
                                            && btnB.Enabled == false && _currentCorrectAnswers.Contains('B')
                                            && btnC.Enabled
                                            && _currentCorrectAnswers.Count() == 2)
            {
                _correctAnswers++;
            }
            else if (btnA.Enabled == false && _currentCorrectAnswers.Contains('A')
                                           && btnC.Enabled == false && _currentCorrectAnswers.Contains('C')
                                           && btnB.Enabled
                                           && _currentCorrectAnswers.Count() == 2)
            {
                _correctAnswers++;
            }
            else if (btnB.Enabled == false && _currentCorrectAnswers.Contains('B')
                                           && btnC.Enabled == false && _currentCorrectAnswers.Contains('C')
                                           && btnA.Enabled
                                           && _currentCorrectAnswers.Count() == 2)
            {
                _correctAnswers++;
            }
            else if (btnA.Enabled == false && _currentCorrectAnswers.Contains('A')
                                           && btnC.Enabled
                                           && btnB.Enabled
                                           && _currentCorrectAnswers.Count() == 1)
            {
                _correctAnswers++;
            }
            else if (btnB.Enabled == false && _currentCorrectAnswers.Contains('B')
                                           && btnC.Enabled
                                           && btnA.Enabled
                                           && _currentCorrectAnswers.Count() == 1)
            {
                _correctAnswers++;
            }
            else if (btnC.Enabled == false && _currentCorrectAnswers.Contains('C')
                                           && btnB.Enabled
                                           && btnA.Enabled
                                           && _currentCorrectAnswers.Count() == 1)
            {
                _correctAnswers++;
            }
            else
            {
                _wrongAnswers++;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckIfPressedButtonsAreTheCorrectAnswer();

            _questionIndex++;

            LoadStatistics();

            if (_wrongAnswers == _maxWrongAnswers)
            {
                EndQuestionnaire();
            }

            if (_questionIndex < _maxQuestions)
            {
                LoadQuestions();
                btnResetAnswer_Click(sender, e);

                if (_questionIndex == _maxQuestions - 1)
                {
                    btnAnswerLater.Enabled = false;
                }
            }
            else
            {
                EndQuestionnaire();
            }
        }

        private void btnExitQForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerRemaining_Tick(object sender, EventArgs e)
        {
            if (_timerCounter == 0)
            {
                timerRemaining.Stop();
                EndQuestionnaire();
            }
            else
            {
                _timerCounter--;
                var minutes = _timerCounter / 60;
                var seconds = _timerCounter - (minutes * 60);
                lblRemainingTime.Text = minutes + " : " + seconds;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class QuestionForm : Form
    {
        private readonly int _maxQuestions;
        private readonly int _maxWrongAnswers;

        private readonly string _defaultImagePath;

        private int _remainingQuestions;
        private int _timerCounter = 1800;
        private int _correctAnswers;
        private int _wrongAnswers;

        private readonly List<Question> _questions;
        private int _qIndex;

        public QuestionForm(string category, int maxQuestions, int maxWrongAnswers, string imagesPath, string defaultImagePath, string questionsPath)
        {
            InitializeComponent();

            _maxQuestions = maxQuestions;
            _maxWrongAnswers = maxWrongAnswers;
            _remainingQuestions = _maxQuestions;

            _defaultImagePath = defaultImagePath;

            timerRemaining = new Timer();
            timerRemaining.Tick += timerRemaining_Tick;
            timerRemaining.Interval = 1000;
            timerRemaining.Start();

            var xmlManager = new XmlManager(category, imagesPath, questionsPath);
            var totalQuestions = xmlManager.CountQuestions();

            var randomNumbers = RandomNumbers.Generate(totalQuestions, _maxQuestions);
            _questions = xmlManager.GetQuestions(randomNumbers);

            LoadQuestionsAndImage();
            LoadStatistics();
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            var _pressedButtonTag = Convert.ToInt32(senderObject.Tag);

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

        private void LoadQuestionsAndImage()
        {
            lblQTitle.Text = _questions[_qIndex].Title;
            btnA.Text = _questions[_qIndex].Options[0].Key;
            btnB.Text = _questions[_qIndex].Options[1].Key;
            btnC.Text = _questions[_qIndex].Options[2].Key;

            try
            {
                picBoxQImage.Image = Image.FromFile(_questions[_qIndex].Image);
            }
            catch (FileNotFoundException)
            {
                picBoxQImage.Image = Image.FromFile(_defaultImagePath);
            }

            picBoxQImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            lblRemainingQuestions.Text = (_remainingQuestions--).ToString();
            lblInitialQuestions.Text = _maxQuestions.ToString();
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
            var temp = _questions[_qIndex];
            _questions.Remove(_questions[_qIndex]);
            _questions.Add(temp);

            btnResetAnswer_Click(sender, e);
            LoadQuestionsAndImage();
        }

        private void btnResetAnswer_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

            btnResetAnswer.Enabled = false;
            btnAnswer.Enabled = false;
        }

        private void CheckIfPressedButtonsAreTheCorrectAnswer()
        {
            if (btnA.Enabled != _questions[_qIndex].Options[0].Value
                && btnB.Enabled != _questions[_qIndex].Options[1].Value
                && btnC.Enabled != _questions[_qIndex].Options[2].Value)
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

            _qIndex++;

            LoadStatistics();

            if (_wrongAnswers == _maxWrongAnswers)
            {
                EndQuestionnaire();
            }

            if (_qIndex < _maxQuestions)
            {
                LoadQuestionsAndImage();
                btnResetAnswer_Click(sender, e);

                if (_qIndex == _maxQuestions - 1)
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

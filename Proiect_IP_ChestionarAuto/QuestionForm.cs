using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proiect_IP_ChestionarAuto.Properties;

namespace Proiect_IP_ChestionarAuto
{
    public partial class QuestionForm : Form
    {
        private readonly int _maxQuestions;
        private readonly int _maxWrongAnswers;

        private readonly string _imagePath;

        private int _remainingQuestions;
        private int _timerCounter = 1800;
        private int _correctAnswers;
        private int _wrongAnswers;

        private List<Question> _questions;
        private int _qIndex;

        public QuestionForm(string category, int maxQuestions, int maxWrongAnswers, string imagesPath, string questionsPath)
        {
            InitializeComponent();
            Icon = Resources.icon;

            _maxQuestions = maxQuestions;
            _maxWrongAnswers = maxWrongAnswers;
            _remainingQuestions = _maxQuestions;
            _imagePath = imagesPath;

            InitTimer();
            InitQuestions(category, questionsPath);
            LoadQuestionsAndImage();
            LoadStatistics();
        }

        // If times ends, the questionnaire ends. Else, time decreases and is updated in the form.
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

        /* If One of the answer buttons is pressed (A, B or C),
         then the respective button is disabled and
         reset and answer buttons are then enabled.*/
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

        /* If answer later button is pressed, then the current
         question is moved to the end and buttons will reset.*/
        private void btnAnswerLater_Click(object sender, EventArgs e)
        {
            var temp = _questions[_qIndex];
            _questions.Remove(_questions[_qIndex]);
            _questions.Add(temp);

            ResetAnswer();
            LoadQuestionsAndImage();
        }

        // If reset answer button is pressed, then the buttons will reset.
        private void btnResetAnswer_Click(object sender, EventArgs e)
        {
            ResetAnswer();
        }

        /* If the answer button is pressed, it checks if the A,B and C
         buttons are pressed accordingly to the correct answers.
         If that's so, then the correct answers count increases. Else it decreases.
         The question index is incremented and statistics are loaded.
         If the user got to the maximum of wrong answers, the questionnaire ends.
         Else the buttons will reset and the next question is loaded (if it's not the last one).*/
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (btnA.Enabled != _questions[_qIndex].Options.Values.ElementAt(0)
                && btnB.Enabled != _questions[_qIndex].Options.Values.ElementAt(1)
                && btnC.Enabled != _questions[_qIndex].Options.Values.ElementAt(2))
            {
                _correctAnswers++;
            }
            else
            {
                _wrongAnswers++;
            }

            _qIndex++;

            LoadStatistics();

            if (_wrongAnswers == _maxWrongAnswers)
            {
                EndQuestionnaire();
            }

            if (_qIndex < _maxQuestions)
            {
                ResetAnswer();
                LoadQuestionsAndImage();

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

        // If exit button is pressed, then the from closes and the main window appears.
        private void btnExitQForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Initializes the timer.
        private void InitTimer()
        {
            timerRemaining = new Timer();
            timerRemaining.Tick += timerRemaining_Tick;
            timerRemaining.Interval = 1000;
            timerRemaining.Start();
        }

        /* It takes all the questions from the json and counts them.
         A set of random numbers are generated by taking the number questions
         in the json and the maximum allowed questions in the questionnaire.
         The _questions variable is then initialized with random questions.*/
        private void InitQuestions(string category, string questionsPath)
        {
            var jsonManager = new JsonManager(category, questionsPath);
            var totalQuestions = jsonManager.CountQuestions;
            var randomNumbers = RandomNumbers.Generate(totalQuestions, _maxQuestions);

            _questions = new List<Question>();

            foreach (var number in randomNumbers)
            {
                _questions.Add(jsonManager.Questions.ElementAt(number));
            }
        }

        /* It initializes the form with the questions and the
         picture of that questions (if it has one).
         If the question have no picture or the picture's path is invalid,
         the default picture will be loaded.*/
        private void LoadQuestionsAndImage()
        {
            lblQTitle.Text = _questions[_qIndex].Title;

            try
            {
                btnA.Text = _questions[_qIndex].Options.Keys.ElementAt(0);
                btnB.Text = _questions[_qIndex].Options.Keys.ElementAt(1);
                btnC.Text = _questions[_qIndex].Options.Keys.ElementAt(2);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                const string message = "Fisierul JSON este invalid! La o intrebare lipseste una din optiuni!";
                MessageBox.Show(message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (_questions[_qIndex].Image == null)
            {
                picBoxQImage.Image = Resources._default;
            }
            else
            {
                try
                {
                    picBoxQImage.Image = Image.FromFile(_imagePath + _questions[_qIndex].Image);
                }
                catch (FileNotFoundException)
                {
                    picBoxQImage.Image = Resources._default;
                }
            }

            picBoxQImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // It loads all statistics in the form, except for the remaining time.
        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            lblRemainingQuestions.Text = (_remainingQuestions--).ToString();
            lblInitialQuestions.Text = _maxQuestions.ToString();
        }

        // Resets the A,B and C buttons and disables the reset and answer buttons.
        private void ResetAnswer()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

            btnResetAnswer.Enabled = false;
            btnAnswer.Enabled = false;
        }

        /* Hides the current form and shows a text box with the result.
         Then it closes the hidden form and the main form will appear.*/
        private void EndQuestionnaire()
        {
            Hide();

            string message;

            if (_wrongAnswers == _maxWrongAnswers || _correctAnswers < _maxQuestions - _maxWrongAnswers + 1)
            {
                message = "Ati fost respins!\n";
            }
            else
            {
                message = "Felicitari, ati promovat!\n";
            }

            message += "Ati raspuns corect la " + _correctAnswers + " din cele " + _maxQuestions + " intrebari.";
            const string title = "Rezultat";

            MessageBox.Show(message, title);
            Close();
        }
    }
}

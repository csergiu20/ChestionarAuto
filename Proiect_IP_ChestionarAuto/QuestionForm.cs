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
        private int remainingQuestions = MaxQuestions;
        private const string Category = "B";

        private int counter = 1800;

        private readonly List<Question> _questions;
        private int _questionIndex = 0;

        private List<int> _currentCorrectAnswer;

        private int buttonTag = 0;

        private int _correctAnswers = 0;
        private int _wrongAnswers = 0;
        private int _percentage = 0;

        public QuestionForm()
        {
            InitializeComponent();

            timerRemaining = new Timer();
            timerRemaining.Tick += new EventHandler(timerRemaining_Tick);
            timerRemaining.Interval = 1000; // 1 second
            timerRemaining.Start();

            lblInitialQuestions.Text = MaxQuestions.ToString();

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
                    break;
                case 2:
                    btnB.Enabled = false;
                    break;
                case 3:
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

            var answerList = new System.Collections.Generic.List<int>();

            var temp = _questions[_questionIndex].Answer.Split(',');

            foreach (var num in temp)
            {
                answerList.Add(int.Parse(num));
            }

            foreach (var answer in answerList)
            {
                Console.WriteLine(answer);
            }

            _currentCorrectAnswer = new List<int>();
            _currentCorrectAnswer = answerList;
        }

        private void LoadStatistics()
        {
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            lblWrongAnswers.Text = _wrongAnswers.ToString();
            _percentage = (int)Math.Round((double)(_correctAnswers * 100) / MaxQuestions);

            lblRemainingQuestions.Text = (remainingQuestions--).ToString();

        }

        private void btnExitQForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {

            if (btnA.Enabled == false && _currentCorrectAnswer.Contains(1)
                                            && btnB.Enabled == false && _currentCorrectAnswer.Contains(2)
                                            && btnC.Enabled == false && _currentCorrectAnswer.Contains(3)
                                            && _currentCorrectAnswer.Count() == 3)
            {
                _correctAnswers++;
            }

            else if (btnA.Enabled == false && _currentCorrectAnswer.Contains(1)
                                            && btnB.Enabled == false && _currentCorrectAnswer.Contains(2)
                                            && btnC.Enabled
                                            && _currentCorrectAnswer.Count() == 2)
            {
                _correctAnswers++;
            }

            else if (btnA.Enabled == false && _currentCorrectAnswer.Contains(1)
                                           && btnC.Enabled == false && _currentCorrectAnswer.Contains(3)
                                           && btnB.Enabled
                                           && _currentCorrectAnswer.Count() == 2)
            {
                _correctAnswers++;
            }

            else if (btnB.Enabled == false && _currentCorrectAnswer.Contains(2)
                                           && btnC.Enabled == false && _currentCorrectAnswer.Contains(3)
                                           && btnA.Enabled
                                           && _currentCorrectAnswer.Count() == 2)
            {
                _correctAnswers++;
            }

            else if (btnA.Enabled == false && _currentCorrectAnswer.Contains(1)
                                           && btnC.Enabled
                                           && btnB.Enabled
                                           && _currentCorrectAnswer.Count() == 1)
            {
                _correctAnswers++;
            }

            else if (btnB.Enabled == false && _currentCorrectAnswer.Contains(2)
                                           && btnC.Enabled
                                           && btnA.Enabled
                                           && _currentCorrectAnswer.Count() == 1)
            {
                _correctAnswers++;
            }

            else if (btnC.Enabled == false && _currentCorrectAnswer.Contains(3)
                                           && btnB.Enabled
                                           && btnA.Enabled
                                           && _currentCorrectAnswer.Count() == 1)
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

        private void timerRemaining_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                timerRemaining.Stop();
                lblRemainingTime.Text = counter.ToString();

                Hide();
                var message = _percentage.ToString() + "% Corecte!";
                const string title = "Scor";
                MessageBox.Show(message, title);
                Close();
            }
            else
            {
                counter--;
                int minutes = counter / 60;
                int seconds = counter - (minutes * 60);
                lblRemainingTime.Text=minutes.ToString() + ":" + seconds.ToString();
            }
        }
    }
}

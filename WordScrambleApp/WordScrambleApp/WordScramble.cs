using gnuciDictionary;
using System;
using System.Diagnostics.Eventing.Reader;

namespace WordScrambleApp
{
    public partial class WordScramble : Form
    {
        private string currentWord;
        private string scrambledWord;
        private List<Word> filteredWords= new List<Word>();
        private int score;

        public WordScramble()
        {
            InitializeComponent();
           
         
            score = 0;
            ClearLabels();
            btnStart.Click += BtnStart_Click;
            btnAnswer.Click += BtnAnswer_Click;
        }

        private void ClearLabels()
        {
            txtGuessTheWord.Text = string.Empty;
            rdbEasy.Checked = false;
            rdbMedium.Checked = false;
            rdbHard.Checked = false;
            lblScrambledWord2.Text = string.Empty;
        }
        private void BtnAnswer_Click(object? sender, EventArgs e)
        {
            ClearLabels();
           string userGuess=txtGuessTheWord.Text.Trim().Normalize();
           string correctAnswer = currentWord.Trim().Normalize();

            if(string.Equals(userGuess, currentWord, StringComparison.OrdinalIgnoreCase))
            {
                score+=1;
                lblScore2.Text=score.ToString();
                lblFeedback.Text = "Great Job!! Your answer is correct.";
                lblFeedback.ForeColor = Color.Green;
                txtGuessTheWord.Text = string.Empty;
                lblScrambledWord2.Text = string.Empty;

                }
            else
            {
                score -= 1;
             
                lblFeedback.Text = "Try Again.";
                lblFeedback.ForeColor=Color.Green;
            }
            lblScore2.Text = score.ToString();
            txtGuessTheWord.Text=string.Empty;
            lblScrambledWord2.Text=string.Empty;
            lblAnswer.Text = correctAnswer;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            lblScrambledWord2.Text = string.Empty;

            if (rdbEasy.Checked == false && rdbMedium.Checked == false && rdbHard.Checked==false)
            {
                lblFeedback.Text = "Please select a level";
                lblFeedback.ForeColor = Color.Green;
                return;
            }
            
            List<Word> lstwords = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();

            FilterWordsByDifficulty(lstwords);

            if (filteredWords.Count > 0)
            {
                Random rnd = new Random();
                Word selectedWord = filteredWords[rnd.Next(filteredWords.Count)];
                currentWord = selectedWord.Value;
                scrambledWord = ScrambleWord(currentWord);

                lblScrambledWord2.Text = scrambledWord;
                lblAnswer.Text = string.Empty;
                lblFeedback.Text=string.Empty;
            }
             else
            {
                lblScrambledWord2.Text = " No words avail";
            }
        }

        private void FilterWordsByDifficulty(List<Word> words)
        {
            List<Word> wordList = words.Where(w => w.Value.All(char.IsLetter)).ToList(); 

            if (rdbEasy.Checked)
            {
                filteredWords = wordList
                    .Where(word => word.Value.Length >= 3 && word.Value.Length <= 5)  
                    .ToList();
            }
            else if (rdbMedium.Checked)
            {
                filteredWords = wordList
                    .Where(word => word.Value.Length >= 6 && word.Value.Length <= 8)
                    .ToList();
            }
            else if (rdbHard.Checked)
            {
                filteredWords = wordList
                    .Where(word => word.Value.Length >= 9)
                    .ToList();
            }
            else
            {
                filteredWords = wordList;
            }
        }

        private string ScrambleWord(string word)
        {
            Random rnd= new Random();
            char[] letters= word.ToLower().ToCharArray();
              letters = letters.OrderBy(c => rnd.Next()).ToArray();

            return new string(letters);
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

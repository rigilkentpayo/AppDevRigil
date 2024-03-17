using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        private string words = "hangman" ;
        private string selectedWord;
        private int guesses;
        private string[] ToGuess;
        private bool[] guessed;
        private Image[] Images;

        public Hangman()
        {
            InitializeComponent();
            LoadHangmanImages();
            loadGame();
        }

     
        private void LoadHangmanImages()
        {
            Images = new Image[6];
            for (int i = 0; i < 6; i++)
            {
                Images[i] = Image.FromFile($"hangman{i + 1}.gif");
            }
        }

      
        private void loadGame()
        {
            guesses = 6;
            selectedWord = words;
            ToGuess = new string[selectedWord.Length];
            guessed = new bool[26];
            for (int i = 0; i < selectedWord.Length; i++)
            {
               ToGuess[i] = "*";
            }
            Update();
            pictureBox1.Image = Images[0];
            buttonGuess.Text = "Guess";
        }

       
        private void Update()
        {
            string displayWord = string.Join(" ", ToGuess);
            labelWord.Text = displayWord;
            labelGuessesLeft.Text = $"Guesses left: {guesses}";
        }

       
        private void CheckLetter(char letter)
        {
            bool letterFound = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == letter)
                {
                   ToGuess[i] = letter.ToString();
                    letterFound = true;
                }
            }
            if (!letterFound)
            {
                guesses--;
                UpdateHangmanImage();
            }
            Update();
            CheckGameEnd();
        }

   
        private void UpdateHangmanImage()
        {
            int hangmanIndex = 6 - guesses;
            if (hangmanIndex >= 1 && hangmanIndex <= 5)
            {
                pictureBox1.Image = Images[hangmanIndex];
            }
        }

        
        private void CheckGameEnd()
        {
            if (guesses == 0)
            {
                MessageBox.Show($"You lost. The correct word  {selectedWord}");
                loadGame();
            }
            else if (!ToGuess.Contains("*"))
            {
                MessageBox.Show($"Congratulations! You guessed it Right ({selectedWord})");
                loadGame();
            }
        }
        private void buttonGuess_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxGuess.Text) && textBoxGuess.Text.Length == 1)
            {
                char guessedLetter = textBoxGuess.Text.ToLower()[0];
                if (guessed[guessedLetter - 'a'])
                {
                    MessageBox.Show("You cannot repeat this letter.");
                }
                else
                {
                    guessed[guessedLetter - 'a'] = true;
                    CheckLetter(guessedLetter);
                }
                textBoxGuess.Clear();
            }
        }

        private void buttonNewGame_Click_1(object sender, EventArgs e)
        {
            loadGame();
        }
    }
}

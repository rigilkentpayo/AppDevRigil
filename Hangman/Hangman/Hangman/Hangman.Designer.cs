namespace Hangman
{
    partial class Hangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelWord = new Label();
            labelGuessesLeft = new Label();
            textBoxGuess = new TextBox();
            buttonGuess = new Button();
            buttonNewGame = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 42);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 378);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.BackColor = SystemColors.Control;
            labelWord.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(210, 391);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(73, 29);
            labelWord.TabIndex = 1;
            labelWord.Text = "Word";
            // 
            // labelGuessesLeft
            // 
            labelGuessesLeft.AutoSize = true;
            labelGuessesLeft.BackColor = SystemColors.Control;
            labelGuessesLeft.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGuessesLeft.Location = new Point(35, 71);
            labelGuessesLeft.Name = "labelGuessesLeft";
            labelGuessesLeft.Size = new Size(98, 29);
            labelGuessesLeft.TabIndex = 2;
            labelGuessesLeft.Text = "Guesses";
            // 
            // textBoxGuess
            // 
            textBoxGuess.Location = new Point(558, 191);
            textBoxGuess.Margin = new Padding(3, 2, 3, 2);
            textBoxGuess.Multiline = true;
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(141, 34);
            textBoxGuess.TabIndex = 3;
            // 
            // buttonGuess
            // 
            buttonGuess.Location = new Point(716, 191);
            buttonGuess.Margin = new Padding(3, 2, 3, 2);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(95, 34);
            buttonGuess.TabIndex = 4;
            buttonGuess.Text = "Guess";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click_1;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(620, 368);
            buttonNewGame.Margin = new Padding(3, 2, 3, 2);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(110, 35);
            buttonNewGame.TabIndex = 5;
            buttonNewGame.Text = "Restart";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, -4);
            label1.Name = "label1";
            label1.Size = new Size(210, 44);
            label1.TabIndex = 6;
            label1.Text = "Hangman";
            // 
            // Hangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(857, 604);
            Controls.Add(label1);
            Controls.Add(buttonNewGame);
            Controls.Add(buttonGuess);
            Controls.Add(textBoxGuess);
            Controls.Add(labelGuessesLeft);
            Controls.Add(labelWord);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hangman";
            Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelWord;
        private Label labelGuessesLeft;
        private TextBox textBoxGuess;
        private Button buttonGuess;
        private Button buttonNewGame;
        private Label label1;
    }
}

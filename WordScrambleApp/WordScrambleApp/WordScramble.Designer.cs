namespace WordScrambleApp
{
    partial class WordScramble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            lblScrambledWord1 = new Label();
            lblScrambledWord2 = new Label();
            panel1 = new Panel();
            tblRadioButtons = new TableLayoutPanel();
            rdbEasy = new RadioButton();
            rdbMedium = new RadioButton();
            rdbHard = new RadioButton();
            tblStart = new TableLayoutPanel();
            btnStart = new Button();
            tblScore = new TableLayoutPanel();
            lblScore1 = new Label();
            lblScore2 = new Label();
            lblGuessTheWord = new Label();
            txtGuessTheWord = new TextBox();
            tblAnswer = new TableLayoutPanel();
            btnAnswer = new Button();
            lblAnswer = new Label();
            lblFeedback = new Label();
            tblMain.SuspendLayout();
            tblRadioButtons.SuspendLayout();
            tblStart.SuspendLayout();
            tblScore.SuspendLayout();
            tblAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.863813F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.1361847F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 407F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tblMain.Controls.Add(lblScrambledWord1, 1, 1);
            tblMain.Controls.Add(lblScrambledWord2, 3, 1);
            tblMain.Controls.Add(panel1, 1, 3);
            tblMain.Controls.Add(tblRadioButtons, 1, 4);
            tblMain.Controls.Add(tblStart, 1, 5);
            tblMain.Controls.Add(tblScore, 3, 5);
            tblMain.Controls.Add(lblGuessTheWord, 1, 7);
            tblMain.Controls.Add(txtGuessTheWord, 1, 9);
            tblMain.Controls.Add(tblAnswer, 3, 9);
            tblMain.Controls.Add(lblFeedback, 3, 11);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 12;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.25466F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80.74534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tblMain.Size = new Size(851, 594);
            tblMain.TabIndex = 0;
            // 
            // lblScrambledWord1
            // 
            lblScrambledWord1.AutoSize = true;
            lblScrambledWord1.BackColor = Color.FromArgb(255, 128, 128);
            lblScrambledWord1.Dock = DockStyle.Fill;
            lblScrambledWord1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScrambledWord1.ForeColor = Color.Crimson;
            lblScrambledWord1.Location = new Point(21, 13);
            lblScrambledWord1.Name = "lblScrambledWord1";
            lblScrambledWord1.Size = new Size(353, 54);
            lblScrambledWord1.TabIndex = 0;
            lblScrambledWord1.Text = "Scramble Word";
            lblScrambledWord1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScrambledWord2
            // 
            lblScrambledWord2.AutoSize = true;
            lblScrambledWord2.BackColor = Color.Crimson;
            lblScrambledWord2.Dock = DockStyle.Fill;
            lblScrambledWord2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScrambledWord2.ForeColor = SystemColors.ButtonHighlight;
            lblScrambledWord2.Location = new Point(427, 13);
            lblScrambledWord2.Name = "lblScrambledWord2";
            lblScrambledWord2.Size = new Size(401, 54);
            lblScrambledWord2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            tblMain.SetColumnSpan(panel1, 3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(21, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 5);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // tblRadioButtons
            // 
            tblRadioButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblRadioButtons, 3);
            tblRadioButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRadioButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRadioButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tblRadioButtons.Controls.Add(rdbEasy, 0, 0);
            tblRadioButtons.Controls.Add(rdbMedium, 1, 0);
            tblRadioButtons.Controls.Add(rdbHard, 2, 0);
            tblRadioButtons.Dock = DockStyle.Fill;
            tblRadioButtons.Location = new Point(21, 108);
            tblRadioButtons.Name = "tblRadioButtons";
            tblRadioButtons.RowCount = 1;
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRadioButtons.Size = new Size(807, 43);
            tblRadioButtons.TabIndex = 3;
            // 
            // rdbEasy
            // 
            rdbEasy.AutoSize = true;
            rdbEasy.BackColor = SystemColors.InactiveCaptionText;
            rdbEasy.Dock = DockStyle.Fill;
            rdbEasy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbEasy.ForeColor = SystemColors.Highlight;
            rdbEasy.Location = new Point(3, 3);
            rdbEasy.Name = "rdbEasy";
            rdbEasy.Size = new Size(266, 37);
            rdbEasy.TabIndex = 0;
            rdbEasy.TabStop = true;
            rdbEasy.Text = "Easy";
            rdbEasy.UseVisualStyleBackColor = false;
            // 
            // rdbMedium
            // 
            rdbMedium.AutoSize = true;
            rdbMedium.Dock = DockStyle.Fill;
            rdbMedium.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMedium.ForeColor = Color.FromArgb(128, 255, 128);
            rdbMedium.Location = new Point(275, 3);
            rdbMedium.Name = "rdbMedium";
            rdbMedium.Size = new Size(266, 37);
            rdbMedium.TabIndex = 1;
            rdbMedium.TabStop = true;
            rdbMedium.Text = "Medium";
            rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbHard
            // 
            rdbHard.AutoSize = true;
            rdbHard.Dock = DockStyle.Fill;
            rdbHard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbHard.ForeColor = Color.Crimson;
            rdbHard.Location = new Point(547, 3);
            rdbHard.Name = "rdbHard";
            rdbHard.Size = new Size(257, 37);
            rdbHard.TabIndex = 2;
            rdbHard.TabStop = true;
            rdbHard.Text = "Hard";
            rdbHard.TextAlign = ContentAlignment.MiddleCenter;
            rdbHard.UseVisualStyleBackColor = true;
            // 
            // tblStart
            // 
            tblStart.ColumnCount = 2;
            tblStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.57703F));
            tblStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.42297F));
            tblStart.Controls.Add(btnStart, 0, 1);
            tblStart.Location = new Point(21, 157);
            tblStart.Name = "tblStart";
            tblStart.RowCount = 2;
            tblStart.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            tblStart.RowStyles.Add(new RowStyle(SizeType.Percent, 76.92308F));
            tblStart.Size = new Size(353, 117);
            tblStart.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Chartreuse;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(3, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(144, 84);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // tblScore
            // 
            tblScore.ColumnCount = 4;
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.591835F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4081631F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tblScore.Controls.Add(lblScore1, 0, 1);
            tblScore.Controls.Add(lblScore2, 2, 1);
            tblScore.Dock = DockStyle.Fill;
            tblScore.Location = new Point(427, 157);
            tblScore.Name = "tblScore";
            tblScore.RowCount = 2;
            tblScore.RowStyles.Add(new RowStyle(SizeType.Percent, 28.2051277F));
            tblScore.RowStyles.Add(new RowStyle(SizeType.Percent, 71.79487F));
            tblScore.Size = new Size(401, 117);
            tblScore.TabIndex = 7;
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.BackColor = Color.FromArgb(255, 192, 128);
            lblScore1.Dock = DockStyle.Fill;
            lblScore1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore1.ForeColor = SystemColors.ButtonHighlight;
            lblScore1.Location = new Point(3, 33);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(150, 84);
            lblScore1.TabIndex = 0;
            lblScore1.Text = "Score:";
            lblScore1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.BackColor = Color.FromArgb(255, 255, 128);
            lblScore2.Dock = DockStyle.Fill;
            lblScore2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore2.ForeColor = SystemColors.ActiveCaptionText;
            lblScore2.Location = new Point(199, 33);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(157, 84);
            lblScore2.TabIndex = 1;
            // 
            // lblGuessTheWord
            // 
            lblGuessTheWord.AutoSize = true;
            lblGuessTheWord.BackColor = Color.Fuchsia;
            lblGuessTheWord.Dock = DockStyle.Fill;
            lblGuessTheWord.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuessTheWord.ForeColor = SystemColors.ButtonHighlight;
            lblGuessTheWord.Location = new Point(21, 312);
            lblGuessTheWord.Name = "lblGuessTheWord";
            lblGuessTheWord.Size = new Size(353, 75);
            lblGuessTheWord.TabIndex = 8;
            lblGuessTheWord.Text = "Guess the Word???";
            lblGuessTheWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGuessTheWord
            // 
            txtGuessTheWord.BackColor = Color.FromArgb(255, 128, 255);
            txtGuessTheWord.Dock = DockStyle.Fill;
            txtGuessTheWord.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuessTheWord.Location = new Point(21, 419);
            txtGuessTheWord.Name = "txtGuessTheWord";
            txtGuessTheWord.Size = new Size(353, 57);
            txtGuessTheWord.TabIndex = 9;
            // 
            // tblAnswer
            // 
            tblAnswer.ColumnCount = 3;
            tblAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.56872F));
            tblAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.43128F));
            tblAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tblAnswer.Controls.Add(btnAnswer, 0, 0);
            tblAnswer.Controls.Add(lblAnswer, 2, 0);
            tblAnswer.Dock = DockStyle.Fill;
            tblAnswer.Location = new Point(427, 419);
            tblAnswer.Name = "tblAnswer";
            tblAnswer.RowCount = 1;
            tblAnswer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblAnswer.Size = new Size(401, 58);
            tblAnswer.TabIndex = 10;
            // 
            // btnAnswer
            // 
            btnAnswer.BackColor = SystemColors.MenuHighlight;
            btnAnswer.Dock = DockStyle.Fill;
            btnAnswer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnswer.ForeColor = SystemColors.ButtonHighlight;
            btnAnswer.Location = new Point(3, 3);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(159, 52);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "Answer";
            btnAnswer.UseVisualStyleBackColor = false;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BackColor = Color.FromArgb(192, 255, 255);
            lblAnswer.Dock = DockStyle.Fill;
            lblAnswer.Location = new Point(208, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(190, 58);
            lblAnswer.TabIndex = 1;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFeedback.ForeColor = Color.FromArgb(128, 255, 255);
            lblFeedback.Location = new Point(427, 527);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(355, 30);
            lblFeedback.TabIndex = 11;
            lblFeedback.Text = " Great Job!! Your answer is correct.";
            // 
            // WordScramble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(851, 594);
            Controls.Add(tblMain);
            Name = "WordScramble";
            Text = "WordScramble";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRadioButtons.ResumeLayout(false);
            tblRadioButtons.PerformLayout();
            tblStart.ResumeLayout(false);
            tblScore.ResumeLayout(false);
            tblScore.PerformLayout();
            tblAnswer.ResumeLayout(false);
            tblAnswer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblScrambledWord1;
        private Label lblScrambledWord2;
        private Panel panel1;
        private TableLayoutPanel tblRadioButtons;
        private RadioButton rdbEasy;
        private RadioButton rdbMedium;
        private RadioButton rdbHard;
        private TableLayoutPanel tblStart;
        private Button btnStart;
        private TableLayoutPanel tblScore;
        private Label lblScore1;
        private Label lblScore2;
        private Label lblGuessTheWord;
        private TextBox txtGuessTheWord;
        private TableLayoutPanel tblAnswer;
        private Button btnAnswer;
        private Label lblAnswer;
        private Label lblFeedback;
    }
}
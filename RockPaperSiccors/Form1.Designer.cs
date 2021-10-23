
namespace RockPaperScissors
{
    partial class Form1
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
            this.ChooseRock = new System.Windows.Forms.Button();
            this.WinLoseOrTieText = new System.Windows.Forms.TextBox();
            this.PaperButton = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.PlayerChoiceLabel = new System.Windows.Forms.Label();
            this.ComputerChoiceLabel = new System.Windows.Forms.Label();
            this.PlayerChoiceText = new System.Windows.Forms.TextBox();
            this.ComputerChoiceText = new System.Windows.Forms.TextBox();
            this.RecentGames = new System.Windows.Forms.TextBox();
            this.ComputerScoreHeading = new System.Windows.Forms.Label();
            this.PlayerScoreHeading = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseRock
            // 
            this.ChooseRock.Location = new System.Drawing.Point(260, 146);
            this.ChooseRock.Name = "ChooseRock";
            this.ChooseRock.Size = new System.Drawing.Size(75, 23);
            this.ChooseRock.TabIndex = 0;
            this.ChooseRock.Text = "Rock";
            this.ChooseRock.UseVisualStyleBackColor = true;
            this.ChooseRock.Click += new System.EventHandler(this.Choose_Click);
            // 
            // WinLoseOrTieText
            // 
            this.WinLoseOrTieText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinLoseOrTieText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.WinLoseOrTieText.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinLoseOrTieText.Location = new System.Drawing.Point(222, 69);
            this.WinLoseOrTieText.Name = "WinLoseOrTieText";
            this.WinLoseOrTieText.ReadOnly = true;
            this.WinLoseOrTieText.Size = new System.Drawing.Size(150, 71);
            this.WinLoseOrTieText.TabIndex = 1;
            this.WinLoseOrTieText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(260, 175);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(260, 204);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(75, 23);
            this.Scissors.TabIndex = 3;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Choose_Click);
            // 
            // PlayerChoiceLabel
            // 
            this.PlayerChoiceLabel.AutoSize = true;
            this.PlayerChoiceLabel.Location = new System.Drawing.Point(66, 63);
            this.PlayerChoiceLabel.Name = "PlayerChoiceLabel";
            this.PlayerChoiceLabel.Size = new System.Drawing.Size(39, 15);
            this.PlayerChoiceLabel.TabIndex = 4;
            this.PlayerChoiceLabel.Text = "Player";
            // 
            // ComputerChoiceLabel
            // 
            this.ComputerChoiceLabel.AutoSize = true;
            this.ComputerChoiceLabel.Location = new System.Drawing.Point(66, 107);
            this.ComputerChoiceLabel.Name = "ComputerChoiceLabel";
            this.ComputerChoiceLabel.Size = new System.Drawing.Size(61, 15);
            this.ComputerChoiceLabel.TabIndex = 5;
            this.ComputerChoiceLabel.Text = "Computer";
            // 
            // PlayerChoiceText
            // 
            this.PlayerChoiceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerChoiceText.Location = new System.Drawing.Point(66, 81);
            this.PlayerChoiceText.Name = "PlayerChoiceText";
            this.PlayerChoiceText.ReadOnly = true;
            this.PlayerChoiceText.Size = new System.Drawing.Size(100, 16);
            this.PlayerChoiceText.TabIndex = 6;
            // 
            // ComputerChoiceText
            // 
            this.ComputerChoiceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComputerChoiceText.Location = new System.Drawing.Point(66, 125);
            this.ComputerChoiceText.Name = "ComputerChoiceText";
            this.ComputerChoiceText.ReadOnly = true;
            this.ComputerChoiceText.Size = new System.Drawing.Size(100, 16);
            this.ComputerChoiceText.TabIndex = 7;
            // 
            // RecentGames
            // 
            this.RecentGames.Location = new System.Drawing.Point(402, 164);
            this.RecentGames.Multiline = true;
            this.RecentGames.Name = "RecentGames";
            this.RecentGames.ReadOnly = true;
            this.RecentGames.Size = new System.Drawing.Size(118, 274);
            this.RecentGames.TabIndex = 10;
            this.RecentGames.TabStop = false;
            this.RecentGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RecentGames.WordWrap = false;
            // 
            // ComputerScoreHeading
            // 
            this.ComputerScoreHeading.AutoSize = true;
            this.ComputerScoreHeading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerScoreHeading.Location = new System.Drawing.Point(482, 69);
            this.ComputerScoreHeading.Name = "ComputerScoreHeading";
            this.ComputerScoreHeading.Size = new System.Drawing.Size(38, 20);
            this.ComputerScoreHeading.TabIndex = 9;
            this.ComputerScoreHeading.Text = "CPU";
            this.ComputerScoreHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerScoreHeading
            // 
            this.PlayerScoreHeading.AutoSize = true;
            this.PlayerScoreHeading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerScoreHeading.Location = new System.Drawing.Point(402, 69);
            this.PlayerScoreHeading.Name = "PlayerScoreHeading";
            this.PlayerScoreHeading.Size = new System.Drawing.Size(52, 20);
            this.PlayerScoreHeading.TabIndex = 8;
            this.PlayerScoreHeading.Text = "Player";
            this.PlayerScoreHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerScore.Location = new System.Drawing.Point(402, 105);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(33, 37);
            this.PlayerScore.TabIndex = 11;
            this.PlayerScore.Text = "0";
            // 
            // ComputerScore
            // 
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerScore.Location = new System.Drawing.Point(487, 105);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(33, 37);
            this.ComputerScore.TabIndex = 12;
            this.ComputerScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.ComputerScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.RecentGames);
            this.Controls.Add(this.ComputerScoreHeading);
            this.Controls.Add(this.PlayerScoreHeading);
            this.Controls.Add(this.ComputerChoiceText);
            this.Controls.Add(this.PlayerChoiceText);
            this.Controls.Add(this.ComputerChoiceLabel);
            this.Controls.Add(this.PlayerChoiceLabel);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.WinLoseOrTieText);
            this.Controls.Add(this.ChooseRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseRock;
        private System.Windows.Forms.TextBox WinLoseOrTieText;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Label PlayerChoiceLabel;
        private System.Windows.Forms.Label ComputerChoiceLabel;
        private System.Windows.Forms.TextBox PlayerChoiceText;
        private System.Windows.Forms.TextBox ComputerChoiceText;
        private System.Windows.Forms.TextBox RecentGames;
        private System.Windows.Forms.Label ComputerScoreHeading;
        private System.Windows.Forms.Label PlayerScoreHeading;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label ComputerScore;
    }
}


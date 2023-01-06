
namespace MilestoneMinesweeperConsole
{
    partial class Form1
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
            this.rdr_groupBox = new System.Windows.Forms.GroupBox();
            this.rdr_hard = new System.Windows.Forms.RadioButton();
            this.rdr_medium = new System.Windows.Forms.RadioButton();
            this.rdr_easy = new System.Windows.Forms.RadioButton();
            this.btn_gameplay = new System.Windows.Forms.Button();
            this.btn_highScore = new System.Windows.Forms.Button();
            this.rdr_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdr_groupBox
            // 
            this.rdr_groupBox.Controls.Add(this.rdr_hard);
            this.rdr_groupBox.Controls.Add(this.rdr_medium);
            this.rdr_groupBox.Controls.Add(this.rdr_easy);
            this.rdr_groupBox.Location = new System.Drawing.Point(36, 21);
            this.rdr_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_groupBox.Name = "rdr_groupBox";
            this.rdr_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rdr_groupBox.Size = new System.Drawing.Size(142, 152);
            this.rdr_groupBox.TabIndex = 0;
            this.rdr_groupBox.TabStop = false;
            this.rdr_groupBox.Text = "Select Difficulty";
            // 
            // rdr_hard
            // 
            this.rdr_hard.AutoSize = true;
            this.rdr_hard.Location = new System.Drawing.Point(16, 115);
            this.rdr_hard.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_hard.Name = "rdr_hard";
            this.rdr_hard.Size = new System.Drawing.Size(48, 17);
            this.rdr_hard.TabIndex = 2;
            this.rdr_hard.TabStop = true;
            this.rdr_hard.Text = "Hard";
            this.rdr_hard.UseVisualStyleBackColor = true;
            // 
            // rdr_medium
            // 
            this.rdr_medium.AutoSize = true;
            this.rdr_medium.Location = new System.Drawing.Point(16, 71);
            this.rdr_medium.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_medium.Name = "rdr_medium";
            this.rdr_medium.Size = new System.Drawing.Size(62, 17);
            this.rdr_medium.TabIndex = 1;
            this.rdr_medium.TabStop = true;
            this.rdr_medium.Text = "Medium";
            this.rdr_medium.UseVisualStyleBackColor = true;
            // 
            // rdr_easy
            // 
            this.rdr_easy.AutoSize = true;
            this.rdr_easy.Location = new System.Drawing.Point(16, 31);
            this.rdr_easy.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_easy.Name = "rdr_easy";
            this.rdr_easy.Size = new System.Drawing.Size(48, 17);
            this.rdr_easy.TabIndex = 0;
            this.rdr_easy.TabStop = true;
            this.rdr_easy.Text = "Easy";
            this.rdr_easy.UseVisualStyleBackColor = true;
            // 
            // btn_gameplay
            // 
            this.btn_gameplay.Location = new System.Drawing.Point(184, 182);
            this.btn_gameplay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gameplay.Name = "btn_gameplay";
            this.btn_gameplay.Size = new System.Drawing.Size(157, 23);
            this.btn_gameplay.TabIndex = 1;
            this.btn_gameplay.Text = "Play Game";
            this.btn_gameplay.UseVisualStyleBackColor = true;
            this.btn_gameplay.Click += new System.EventHandler(this.btn_gameplay_Click);
            // 
            // btn_highScore
            // 
            this.btn_highScore.Location = new System.Drawing.Point(184, 209);
            this.btn_highScore.Margin = new System.Windows.Forms.Padding(2);
            this.btn_highScore.Name = "btn_highScore";
            this.btn_highScore.Size = new System.Drawing.Size(157, 23);
            this.btn_highScore.TabIndex = 2;
            this.btn_highScore.Text = "See High Scores";
            this.btn_highScore.UseVisualStyleBackColor = true;
            this.btn_highScore.Click += new System.EventHandler(this.btn_highScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.btn_highScore);
            this.Controls.Add(this.btn_gameplay);
            this.Controls.Add(this.rdr_groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rdr_groupBox.ResumeLayout(false);
            this.rdr_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdr_groupBox;
        private System.Windows.Forms.RadioButton rdr_hard;
        private System.Windows.Forms.RadioButton rdr_medium;
        private System.Windows.Forms.RadioButton rdr_easy;
        private System.Windows.Forms.Button btn_gameplay;
        private System.Windows.Forms.Button btn_highScore;
    }
}


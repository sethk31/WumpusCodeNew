namespace HighScore
{
    partial class TestForm
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
            this.Constructor = new System.Windows.Forms.Button();
            this.turnBtn = new System.Windows.Forms.Button();
            this.finalScoreBtn = new System.Windows.Forms.Button();
            this.toStringBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.finalLable = new System.Windows.Forms.Label();
            this.toStringLabel = new System.Windows.Forms.Label();
            this.highScoresLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Constructor
            // 
            this.Constructor.Location = new System.Drawing.Point(12, 47);
            this.Constructor.Name = "Constructor";
            this.Constructor.Size = new System.Drawing.Size(255, 23);
            this.Constructor.TabIndex = 0;
            this.Constructor.Text = "HighScore";
            this.Constructor.UseVisualStyleBackColor = true;
            this.Constructor.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnBtn
            // 
            this.turnBtn.Location = new System.Drawing.Point(21, 90);
            this.turnBtn.Name = "turnBtn";
            this.turnBtn.Size = new System.Drawing.Size(234, 23);
            this.turnBtn.TabIndex = 1;
            this.turnBtn.Text = "Get Score After Turn";
            this.turnBtn.UseVisualStyleBackColor = true;
            this.turnBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // finalScoreBtn
            // 
            this.finalScoreBtn.Location = new System.Drawing.Point(51, 135);
            this.finalScoreBtn.Name = "finalScoreBtn";
            this.finalScoreBtn.Size = new System.Drawing.Size(180, 23);
            this.finalScoreBtn.TabIndex = 2;
            this.finalScoreBtn.Text = "Get Final Score";
            this.finalScoreBtn.UseVisualStyleBackColor = true;
            this.finalScoreBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // toStringBtn
            // 
            this.toStringBtn.Location = new System.Drawing.Point(40, 179);
            this.toStringBtn.Name = "toStringBtn";
            this.toStringBtn.Size = new System.Drawing.Size(200, 22);
            this.toStringBtn.TabIndex = 3;
            this.toStringBtn.Text = "toString";
            this.toStringBtn.UseVisualStyleBackColor = true;
            this.toStringBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.Location = new System.Drawing.Point(21, 219);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(246, 23);
            this.highScoresBtn.TabIndex = 4;
            this.highScoresBtn.Text = "Show High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = true;
            this.highScoresBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(316, 100);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(35, 13);
            this.turnLabel.TabIndex = 5;
            this.turnLabel.Text = "label1";
            // 
            // finalLable
            // 
            this.finalLable.AutoSize = true;
            this.finalLable.Location = new System.Drawing.Point(319, 135);
            this.finalLable.Name = "finalLable";
            this.finalLable.Size = new System.Drawing.Size(35, 13);
            this.finalLable.TabIndex = 6;
            this.finalLable.Text = "label2";
            // 
            // toStringLabel
            // 
            this.toStringLabel.AutoSize = true;
            this.toStringLabel.Location = new System.Drawing.Point(322, 179);
            this.toStringLabel.Name = "toStringLabel";
            this.toStringLabel.Size = new System.Drawing.Size(35, 13);
            this.toStringLabel.TabIndex = 7;
            this.toStringLabel.Text = "label3";
            // 
            // highScoresLabel
            // 
            this.highScoresLabel.AutoSize = true;
            this.highScoresLabel.Location = new System.Drawing.Point(325, 228);
            this.highScoresLabel.Name = "highScoresLabel";
            this.highScoresLabel.Size = new System.Drawing.Size(35, 13);
            this.highScoresLabel.TabIndex = 8;
            this.highScoresLabel.Text = "label4";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highScoresLabel);
            this.Controls.Add(this.toStringLabel);
            this.Controls.Add(this.finalLable);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.toStringBtn);
            this.Controls.Add(this.finalScoreBtn);
            this.Controls.Add(this.turnBtn);
            this.Controls.Add(this.Constructor);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Constructor;
        private System.Windows.Forms.Button turnBtn;
        private System.Windows.Forms.Button finalScoreBtn;
        private System.Windows.Forms.Button toStringBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label finalLable;
        private System.Windows.Forms.Label toStringLabel;
        private System.Windows.Forms.Label highScoresLabel;
    }
}


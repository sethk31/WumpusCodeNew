using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HighScore
{
    public partial class TestForm : Form
    {
        private HighScore myHS;

        private int turns = 0;

        public TestForm()
        {
            InitializeComponent();
            turnBtn.Enabled = false;
            finalScoreBtn.Enabled = false;
            toStringBtn.Enabled = false;
            highScoresBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myHS = new HighScore(10000);
            myHS.setStartingScore(5000);
            Constructor.Text = "Score created!";
            turnBtn.Enabled = true;
            finalScoreBtn.Enabled = true;
            toStringBtn.Enabled = true;
            highScoresBtn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turns++;
            int score = myHS.getScoreAfterTurn(true);
            String str = "" + score;
            turnLabel.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = myHS.getFinalScore(true, 1, 1);
            String str = "" + score;
            finalLable.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = myHS.toString();
            toStringLabel.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String str = myHS.showHighScores();
            highScoresLabel.Text = str;
        }
    }
}

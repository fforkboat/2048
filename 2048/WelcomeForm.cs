using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace _2048
{
    public enum GameMode
    {
        General,
        Wild,
        Items
    }

    public partial class WelcomeForm : MaterialForm
    {
        public static bool isFirstWelcomeForm = true;
        public static bool isToTerminateProcess = true;
        
        public WelcomeForm()
        {
            InitializeComponent();

            initScores();
            isToTerminateProcess = true;
        }

        private void initScores()
        {
            labelGeneralScore.Text = Properties.Settings.Default.HighestScoreGeneral.ToString();
            labelWildScore.Text = Properties.Settings.Default.HighestScoreWild.ToString();
            labelItemsScore.Text = Properties.Settings.Default.HighestScoreItems.ToString();
        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            GameForm.gameMode = GameMode.General;

            if (isFirstWelcomeForm)
            {
                this.Visible = false;
                isFirstWelcomeForm = false;
            }
            else
            {
                isToTerminateProcess = false;
                this.Close();
            }

            var gameForm = new GameForm();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }

        private void buttonWild_Click(object sender, EventArgs e)
        {
            GameForm.gameMode = GameMode.Wild;

            if (isFirstWelcomeForm)
            {
                this.Visible = false;
                isFirstWelcomeForm = false;
            }
            else
            {
                isToTerminateProcess = false;
                this.Close();
            }

            var gameForm = new GameForm();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            GameForm.gameMode = GameMode.Items;

            if (isFirstWelcomeForm)
            {
                this.Visible = false;
                isFirstWelcomeForm = false;
            }
            else
            {
                isToTerminateProcess = false;
                this.Close();
            }

            var gameForm = new GameForm();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }

        private void buttonHighestScores_Click(object sender, EventArgs e)
        {
            if (buttonMode == 0)
            {
                tableLayoutPanelScores.Visible = true;
                buttonHighestScores.Text = "Return";
                buttonMode = 1;
            }
            else if (buttonMode == 1)
            {
                tableLayoutPanelScores.Visible = false;
                buttonHighestScores.Text = "Highest Scores";
                buttonMode = 0;
            }
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isToTerminateProcess)
            {
                System.Environment.Exit(0);
            }
        }

        private int buttonMode = 0;

    }

}

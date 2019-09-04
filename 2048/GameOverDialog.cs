using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace _2048
{
    public partial class GameOverDialog : MaterialForm
    {
        public GameOverDialog(Form form)
        {
            this.form = form;

            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            GameForm.isToTerminateProcess = false;
            form.Close();
            this.Close();

            var welcomeForm = new WelcomeForm();
            welcomeForm.StartPosition = FormStartPosition.CenterScreen;
            welcomeForm.Show();

        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            GameForm.isToTerminateProcess = false;
            form.Close();
            this.Close();

            var gameForm = new GameForm();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }

        private Form form;
    }
}

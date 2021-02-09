using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameStart
{
    public partial class gameWindow : Form
    {
        public gameWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            Refresh();
            Thread.Sleep(500);

            SoundPlayer cymbolPlay = new SoundPlayer(Properties.Resources.cymbol);
            cymbolPlay.Play();
            countdown.Visible = true;

            Refresh();
            Thread.Sleep(1000);

            cymbolPlay.Play();
            countdown.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            cymbolPlay.Play();
            countdown.Text = "1";

            Refresh();
            Thread.Sleep(1000);

            cymbolPlay.Play();
            SoundPlayer introSound = new SoundPlayer(Properties.Resources.intro);
            introSound.Play();
            countdown.Text = "GO";
            this.BackColor = Color.Black;
            countdown.BackColor = Color.White;
            countdown.ForeColor = Color.Black;

            Refresh();
            Thread.Sleep(500);
        }
        
    }
}

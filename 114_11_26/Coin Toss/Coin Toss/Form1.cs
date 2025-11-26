using System;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        private int headsCount = 0;
        private int tailsCount = 0;
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUP = random.Next(2); // 0 = heads, 1 = tails

            if (sideUP == 0)
            {
                // Display heads.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                // Update heads count and UI
                headsCount++;
                headsCountValueLabel.Text = headsCount.ToString();
            }
            else
            {
                // Display tails.
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;

                // Update tails count and UI
                tailsCount++;
                tailsCountValueLabel.Text = tailsCount.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

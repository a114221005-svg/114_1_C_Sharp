using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
       private decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0;
            total = total + 5;
            totalLabel.Text = total.ToString( );
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
           //decimal total = 0;
            total = total + 10;
            totalLabel.Text = total.ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
          //decimal total = 0;
            total = total + 25;
            totalLabel.Text = total.ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
          //decimal total = 0;
            total = total + 50;
            totalLabel.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

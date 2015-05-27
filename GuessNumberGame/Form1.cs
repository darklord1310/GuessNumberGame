using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        int NumberToWin, numberoftrying = 0;            //declare here to make variable able to use in other method

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            NumberToWin = rnd.Next(1, 101); // creates a number between 1 and 100
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGuessNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            numberoftrying++;
            int anInteger;
            anInteger = Convert.ToInt32(txtGuessNumber.Text);
            if (anInteger == NumberToWin)
                txtMsg.Text = "Bingo! You Win! You used " + numberoftrying + " times";
            else if (anInteger < NumberToWin)
                txtMsg.Text = "The value entered is too low!";
            else
                txtMsg.Text = "The value entered is too high";
        }

        private void gbxMsg_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

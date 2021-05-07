/*
 * Gurvir Upppal
 * Guessing Game
 * May 6, 2021
 * Mr. T
 * ICS3U
 * */





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guesssingGame
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int randNumb;
        public Form1()
        {
            InitializeComponent();
            randNumb = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {

            int guess = Convert.ToInt32(inputBox.Text);

            if (randNumb < guess)
            {
                outputLabel.Text = "Too High";
            }
            else if (randNumb == guess)
            {
                outputLabel.Text = "You Got It !!!";
            }
            else 
            {
                outputLabel.Text = "Too Low";
            }






        }
    }
}

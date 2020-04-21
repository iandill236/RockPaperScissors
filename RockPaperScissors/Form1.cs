using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int rockVariable = 0;
        int paperVariable = 0;
        int scissorVariable = 0;
        int computerChoice;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ComputerChoice()
        {
            Random randGen = new Random();

            computerChoice = randGen.Next(1,4);

            if (computerChoice == 1)
            {
                computerchoiceLabel.Text = "ROCK";
            }
            
            if (computerChoice == 2)
            {
                computerchoiceLabel.Text = "PAPER";
            }
            
            if (computerChoice == 3)
            {
                computerchoiceLabel.Text = "SCISSORS";
            }

        }

        private void DetermineWinner()
        {
            if (rockVariable > 0 && computerChoice == 1)
            {
                winnerLabel.Text = "TIE";
            }
            else if (rockVariable > 0 && computerChoice == 2)
            {
                winnerLabel.Text = "LOSER";
            }
            else if (rockVariable > 0 && computerChoice == 3)
            {
                winnerLabel.Text = "WINNER";
            }
            else if (paperVariable > 0 && computerChoice == 1)
            {
                winnerLabel.Text = "WINNER";
            }
            else if (paperVariable > 0 && computerChoice == 2)
            {
                winnerLabel.Text = "TIE";
            }
            else if (paperVariable > 0 && computerChoice == 3)
            {
                winnerLabel.Text = "LOSER";
            }
            else if (scissorVariable > 0 && computerChoice == 1)
            {
                winnerLabel.Text = "LOSER";
            }
            else if (scissorVariable > 0 && computerChoice == 2)
            {
                winnerLabel.Text = "WINNER";
            }
            else if (scissorVariable > 0 && computerChoice == 3)
            {
                winnerLabel.Text = "TIE";
            }
            
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            rockVariable = 1;
            paperVariable = 0;
            scissorVariable = 0;
            playerchoiceLabel.Text = "ROCK";
            ComputerChoice();
            DetermineWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            paperVariable = 1;
            rockVariable = 0;
            scissorVariable = 0;
            playerchoiceLabel.Text = "PAPER";
            ComputerChoice();
            DetermineWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            scissorVariable = 1;
            paperVariable = 0;
            rockVariable = 0;
            playerchoiceLabel.Text = "SCISSORS";
            ComputerChoice();
            DetermineWinner();
        }
    }
}

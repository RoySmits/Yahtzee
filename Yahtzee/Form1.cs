using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {

        Image[] diceImages;
        int[] dice;
        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_blank;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            rand = new Random();

        }

        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i] = rand.Next(1, 6 + 1);

            lbl_Die1.Image = diceImages[dice[0]];
            lbl_Die2.Image = diceImages[dice[1]];
            lbl_Die3.Image = diceImages[dice[2]];
            lbl_Die4.Image = diceImages[dice[3]];
            lbl_Die5.Image = diceImages[dice[4]];

        }

    }
}

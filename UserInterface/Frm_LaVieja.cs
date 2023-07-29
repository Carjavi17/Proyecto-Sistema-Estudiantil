using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Frm_LaVieja : Form
    {
        int counter;
        private bool isPlayer1Turn = true;
        private string player1Name;
        private string player2Name;

        public Frm_LaVieja()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LaVieja_Load(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void DisableButtons()
        {
            EnableDisableButtons(false);
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(true);
            EnableDeseablePanel(false);
            GetPlayerNames();
        }

        private void GetPlayerNames()
        {
            player1Name = textBox1.Text;
            player2Name = textBox2.Text;
        }

        private void EnableDisableButtons(bool value)
        {
            button1.Enabled = value;
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
        }

        private void EnableDeseablePanel(bool value)
        {

            groupBox1.Enabled = value;
            groupBox2.Enabled = value;
        }

        private void resetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void ResetGame()
        {
            EnableDisableButtons(false);
            EnableDeseablePanel(true);
            counter = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (isPlayer1Turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            b.Enabled = false;
            counter++;

            if (CheckWinner(b.Text))
            {
                ShowWinner(b.Text);
                ResetGame();
            }
            else if (counter == 9)
            {
                MessageBox.Show("Estan empatados. Vuelvan a Jugar.", "Empate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBoard();
                ResetGame();
            }
            else
            {
                TogglePlayerTurn();
            }
        }

        private bool CheckWinner(string symbol)
        {
            if ((button1.Text == symbol && button2.Text == symbol && button3.Text == symbol) ||
                (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol) ||
                (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol))
            {
                return true;
            }

            if ((button1.Text == symbol && button4.Text == symbol && button7.Text == symbol) ||
                (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) ||
                (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol))
            {
                return true;
            }

            if ((button1.Text == symbol && button5.Text == symbol && button9.Text == symbol) ||
                (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol))
            {
                return true;
            }

            return false;
        }

        private void ShowWinner(string symbol)
        {
            string winner = (symbol == "X") ? player1Name : player2Name;
            MessageBox.Show($"{winner} Gano!", "Termino el Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBoard();
        }

        private void ClearBoard()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                }
            }
        }

        private void TogglePlayerTurn()
        {
            isPlayer1Turn = !isPlayer1Turn;
            if (isPlayer1Turn)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
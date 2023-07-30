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
        // Variables para el juego
        int counter;// Contador de movimientos realizados en el juego
        private bool isPlayer1Turn = true;// Variable que indica el turno del jugador 1
        private string player1Name;// Nombre del jugador 1
        private string player2Name;// Nombre del jugador 2

        // Constructor del formulario
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

        // Evento Click del menú Iniciar Juego
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(true);// Habilita los botones del tablero para comenzar el juego
            EnableDeseablePanel(false);// Deshabilita el panel para ingresar los nombres de los jugadores
            GetPlayerNames();// Obtiene los nombres de los jugadores ingresados en los cuadros de texto
        }
        // Método para obtener los nombres de los jugadores ingresados en los cuadros de texto
        private void GetPlayerNames()
        {
            player1Name = textBox1.Text;
            player2Name = textBox2.Text;
        }
        // Método para habilitar o deshabilitar los botones del tablero
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
        // Método para habilitar o deshabilitar el panel para ingresar los nombres de los jugadores
        private void EnableDeseablePanel(bool value)
        {

            groupBox1.Enabled = value;
            groupBox2.Enabled = value;
        }
        // Evento Click del menú Reiniciar Juego
        private void resetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResetGame();
        }
        // Método para reiniciar el juego
        private void ResetGame()
        {
            EnableDisableButtons(false);
            EnableDeseablePanel(true);
            counter = 0;
        }
        // Evento Click de los botones del tablero
        private void button_Click(object sender, EventArgs e)
        {
            // Lógica del juego al hacer clic en un botón del tablero

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
            // Lógica para verificar si un jugador ha ganado el juego
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
        // Método para verificar si hay un ganador del juego
        private bool CheckWinner(string symbol)
        {
            // Lógica para verificar si un jugador ha ganado el juego
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

        // Método para mostrar al ganador del juego
        private void ShowWinner(string symbol)
        {
            // Muestra un mensaje indicando al ganador del juego
            string winner = (symbol == "X") ? player1Name : player2Name;
            MessageBox.Show($"{winner} Gano!", "Termino el Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBoard();
        }
        // Método para limpiar el tablero después de un juego terminado (empate o victoria)
        private void ClearBoard()
        {
            // Limpia el tablero, reiniciando los botones del mismo
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                }
            }
        }
        // Método para alternar el turno entre los jugadores
        private void TogglePlayerTurn()
        {
            // Cambia el turno entre el jugador 1 y el jugador 2
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
        // Evento Click del menú Salir
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();// Cierra el formulario
        }
    }
}
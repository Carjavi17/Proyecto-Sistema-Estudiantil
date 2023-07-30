using AppSistemaEstudiantil.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Frm_LaCulebrita : Form

    {
        // Lista que almacena los segmentos del cuerpo de la serpiente
        private List<Circle> Snake = new List<Circle>();
        // Objeto que representa la comida para la serpiente
        private Circle food = new Circle();
        // Variables para el ancho y alto máximo del área de juego
        int maxWidth;
        int maxHeight;
        // Variables para el puntaje actual y el puntaje máximo (high score)
        int score;
        int highScore;
        // Objeto Random para generar posiciones aleatorias para la comida
        Random rand = new Random();
        // Variables para controlar las direcciones de movimiento de la serpiente
        bool goLeft, goRight, goDown, goUp;

        // Constructor del formulario
        public Frm_LaCulebrita()
        {
            InitializeComponent();
            new Setting(); // Crea una nueva instancia de la clase Setting
        }
        // Evento que se activa cuando se presiona una tecla
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            // Asigna las direcciones de movimiento de la serpiente según la tecla presionada
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.Down:
                    goDown = true;
                    break;
            }
        }

        // Evento que se activa cuando se suelta una tecla
        private void KeyisUP(object sender, KeyEventArgs e)
        {
            // Desactiva las direcciones de movimiento de la serpiente cuando se suelta la tecla
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.Down:
                    goDown = false;
                    break;
            }
        }
        // Evento Click del botón Iniciar Juego
        private void IniciarJuego(object sender, EventArgs e)
        {
            RestartGame();// Reinicia el juego
        }
        // Evento del temporizador que controla el movimiento de la serpiente
        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Setting.directions = "left";
            }
            if (goRight)
            {
                Setting.directions = "right";
            }
            if (goDown)
            {
                Setting.directions = "down";
            }
            if (goUp)
            {
                Setting.directions = "up";
            }
            // Lógica del movimiento de la serpiente y detección de colisiones

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Setting.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            // Vuelve a dibujar el área de juego
            pictureBox1.Invalidate();

        }
        // Evento Paint del PictureBox donde se dibuja el juego
        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            // Lógica para dibujar el juego en el PictureBox
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Setting.Width,
                    Snake[i].Y * Setting.Height,
                    Setting.Width, Setting.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Setting.Width,
            food.Y * Setting.Height,
            Setting.Width, Setting.Height
            ));

        }
        // Método para reiniciar el juego
        private void RestartGame()
        {
            // Lógica para reiniciar el juego (posiciones iniciales, puntajes, etc.)
            maxWidth = pictureBox1.Width / Setting.Width - 1;
            maxHeight = pictureBox1.Height / Setting.Height - 1;

            Snake.Clear();

            button1.Enabled = false;
            score = 0;
            label1.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            timer1.Start();
        }
        // Método para gestionar la acción cuando la serpiente come la comida
        private void EatFood()
        {
            // Lógica para aumentar el puntaje y generar una nueva posición para la comida
            score += 1;

            label1.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        // Método para gestionar el final del juego (Game Over)
        private void GameOver()
        {
            // Lógica para detener el juego, actualizar el puntaje máximo y mostrar mensaje de Game Over
            timer1.Stop();
            button1.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                label2.Text = "High Score: " + highScore;
                label2.ForeColor = Color.Maroon;
            }
        }
    }
}

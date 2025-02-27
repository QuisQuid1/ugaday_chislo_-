using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ugaday_chislo__
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101); // Случайное число от 1 до 100
            attempts = 0;
            label_rez.Text = "Попробуйте угадать число от 1 до 100!";
            label_pop.Text = "Попытки: 0";
            textBox_chisl.Text = "";
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_chisl.Text, out int userGuess))
            {
                attempts++;
                label_pop.Text = $"Попытки: {attempts}";

                if (userGuess < targetNumber)
                {
                    label_rez.Text = "Слишком мало! Попробуйте еще раз.";
                    textBox_chisl.Text = "";
                }
                else if (userGuess > targetNumber)
                {
                    label_rez.Text = "Слишком много! Попробуйте еще раз.";
                    textBox_chisl.Text = "";
                }
                else
                {
                    label_rez.Text = $"Поздравляю! Вы угадали число за {attempts} попыток.";
                    button_check.Enabled = false;
                }
            }
            else
            {
                label_rez.Text = "Пожалуйста, введите корректное число.";
            }
        }

        private void button_povtor_Click(object sender, EventArgs e)
        {
            StartNewGame();
            button_check.Enabled = true;
        }
    }
}

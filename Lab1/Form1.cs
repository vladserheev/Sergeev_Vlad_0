using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void makeRandomButtonColor(Button button)
        {
            Random rand = new Random();

            switch (rand.Next(0, 8))
            {
                case 0: button.BackColor = Color.Yellow; break;
                case 1: button.BackColor = Color.Blue; break;
                case 2: button.BackColor = Color.Green; break;
                case 3: button.BackColor = Color.Red; break;
                case 4: button.BackColor = Color.White; break;
                case 5: button.BackColor = Color.Cyan; break;
                case 6: button.BackColor = Color.DarkBlue; break;
                case 7: button.BackColor = Color.DarkCyan; break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeRandomButtonColor(button2);
            
            if (button2.BackColor == Color.Cyan)
            {
                string firstInputVal = textBox1.Text;

                if (textBox1.Text.Length == 0)
                {
                    label5.Text = "Помилка! Пусте значення х";
                    return;
                }

                bool isNumericX = int.TryParse(firstInputVal, out _);
                if (!isNumericX)
                {
                    label5.Text = "Помилка! Потрібно вводити тільки цифри";
                    return;
                }

                int x = Int32.Parse(firstInputVal);

                // ОДЗ
                if(x > -2.236 && x < 2.236)
                {
                    label5.Text = "Помилка! Недопустиме значення х";
                    return;
                }

                double y = Math.Sqrt(Math.Log(((x ^ 2) - 4), Math.E));
                label5.Text = y.ToString("0.000");
            }
            


        }


        private void button2_Click(object sender, EventArgs e)
        {
            makeRandomButtonColor(button1);
            if (button1.BackColor == Color.DarkBlue)
            {
                string firstInputVal = textBox1.Text;
                string secondInputVal = textBox2.Text;

                if (textBox1.Text.Length == 0)
                {
                    label6.Text = "Помилка! Пусте значення х";
                    return;
                    
                }else if (textBox2.Text.Length == 0)
                {
                    label6.Text = "Помилка! Пусте значення z";
                    return;
                }

                bool isNumericX = int.TryParse(firstInputVal, out _);
                bool isNumericZ = int.TryParse(secondInputVal, out _);
                if (!isNumericX || !isNumericZ)
                {
                    label6.Text = "Помилка! Потрібно вводити тільки цифри";
                    return;
                }

                int x = Int32.Parse(firstInputVal);
                int z = Int32.Parse(secondInputVal);

                // ОДЗ
                if(z == 2)
                {
                    label6.Text = "Помилка! Недопустиме значення z";
                    return;
                }

                double y = x * Math.Atan(z) + Math.Pow(Math.E, (-x - 3) / (z - 2));
                label6.Text = y.ToString("0.000");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Завершити виконання??");
            Application.Exit();
        }
    }
}

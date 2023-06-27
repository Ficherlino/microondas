using System;
using System.Windows.Forms;

namespace Windows_Forms_App_Benner
{
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private System.Windows.Forms.Timer timer;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 1;
            AtualizarTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 2;
            AtualizarTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 3;
            AtualizarTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 4;
            AtualizarTextBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 5;
            AtualizarTextBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 6;
            AtualizarTextBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 7;
            AtualizarTextBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 8;
            AtualizarTextBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10 + 9;
            AtualizarTextBox();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            segundos = segundos * 10;
            AtualizarTextBox();
        }

        private void AtualizarTextBox()
        {
            int minutos = segundos / 60;
            int segundosExibicao = segundos % 60;

            textBox1.Text = $"{minutos:00}:{segundosExibicao:00}";
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            int tempo = Convert.ToInt32(textBox1.Text);

            if (tempo < 1 || tempo > 120)
            {
                MessageBox.Show("Informe o tempo entre 1 segundo e 2 minutos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tempo > 120)
            {
                MessageBox.Show("O tempo máximo permitido é de 2 minutos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inicializar o Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                segundos--;
                AtualizarTextBox();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Contagem regressiva concluída!", "Microondas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            segundos = 0;
            AtualizarTextBox();
        }

        private void botaoClear(object sender, EventArgs e)
        {
            segundos = 0;
            AtualizarTextBox();
        }
    }
}

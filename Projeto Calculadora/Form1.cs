using System;
using System.Windows.Forms;

namespace Projeto_Calculadora
{
    public partial class Form1 : Form
    {
        private Label lblMensagem;

        public Form1(Label lblMensagem)
        {
            this.lblMensagem = lblMensagem;
        }

        public Form1()
        {
            InitializeComponent();
            lblMensagem = new Label();
            Controls.Add(lblMensagem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblMensagem.Top = button1.Bottom + 10;
            lblMensagem.Text = "Primeiro Aplicativo em C#";
            lblMensagem.ForeColor = System.Drawing.Color.Black;
            lblMensagem.AutoSize = false;
            lblMensagem.Width = 200;
            lblMensagem.Height = 50;
            lblMensagem.Visible = true; // Altere de 'Enabled' para 'Visible'
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
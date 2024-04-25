using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_de_pt.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário
            Produtos form = new Produtos();

            // Defina TopLevel como false para permitir a incorporação no painel
            form.TopLevel = false;

            // Adicione o formulário ao painel
            painel.Controls.Add(form);

            // Atualize o tamanho do formulário quando o tamanho do painel mudar
            painel.SizeChanged += (s,ev) =>
            {
                form.Size = painel.Size;
            };

            // Exiba o formulário
            form.Show();


        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void painel_MouseHover(object sender, EventArgs e)
        {

        }
    }
}

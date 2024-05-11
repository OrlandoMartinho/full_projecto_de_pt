using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projecto_de_pt.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string caminhoImagem = Path.GetFullPath(Path.Combine(Application.StartupPath, @"assets\img\orlando.png"));

            foto.Image = Image.FromFile(caminhoImagem);

            // Ajusta o tamanho da PictureBox à imagem
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
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

            removerForm();
            foreach (Control control in painel.Controls)
            {
                control.Visible = true;
            }
        }
        public void removerForm()
        {

            Form formulario = painel.Controls.OfType<Form>().FirstOrDefault();

            // Se o formulário existe dentro do painel
            if (formulario != null)
            {
                // Remove o formulário dos controles do painel
                painel.Controls.Remove(formulario);
                // Libera os recursos do formulário
                formulario.Dispose();
            }

            

        }

        public void removerControl()
        {

            foreach (Control control in painel.Controls)
            {
                control.Visible = false;
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            removerForm();
            removerControl();
          
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
            this.SetVisibleCore(false);
            new Login().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            new Login().Show();
        }

        private void painel_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Notificacoes notificacao = new Notificacoes();

            // Define a posição do formulário de notificações à esquerda do formulário principal
            notificacao.StartPosition = FormStartPosition.Manual;
            notificacao.Location = new Point(this.Right - notificacao.Width-8, this.Top+8); // Ajusta para a posição à esquerda do formulário principal

            notificacao.ShowDialog();



        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            removerForm();
            removerControl();
            // Crie uma instância do formulário
            Fornecedores form = new Fornecedores();

            // Defina TopLevel como false para permitir a incorporação no painel
            form.TopLevel = false;

            // Adicione o formulário ao painel
            painel.Controls.Add(form);

            // Atualize o tamanho do formulário quando o tamanho do painel mudar
            painel.SizeChanged += (s, ev) =>
            {
                form.Size = painel.Size;
            };

            // Exiba o formulário
            form.Show();


        }

        private void label5_Click(object sender, EventArgs e)
        {

            removerForm();
            removerControl();
            // Crie uma instância do formulário
            Perfil form = new Perfil();

            // Defina TopLevel como false para permitir a incorporação no painel
            form.TopLevel = false;

            // Adicione o formulário ao painel
            painel.Controls.Add(form);

            // Atualize o tamanho do formulário quando o tamanho do painel mudar
            painel.SizeChanged += (s, ev) =>
            {
                form.Size = painel.Size;
            };

            // Exiba o formulário
            form.Show();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            removerForm();
            removerControl();
            // Crie uma instância do formulário
            Perfil form = new Perfil();

            // Defina TopLevel como false para permitir a incorporação no painel
            form.TopLevel = false;

            // Adicione o formulário ao painel
            painel.Controls.Add(form);

            // Atualize o tamanho do formulário quando o tamanho do painel mudar
            painel.SizeChanged += (s, ev) =>
            {
                form.Size = painel.Size;
            };

            // Exiba o formulário
            form.Show();
        }
    }
}

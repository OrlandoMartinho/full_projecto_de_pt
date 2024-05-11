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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();

            string caminhoImagem = Path.GetFullPath(Path.Combine(Application.StartupPath, @"assets\img\user3.png"));
            foto.Image = Image.FromFile(caminhoImagem);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             Notificacoes notificacao = new Notificacoes();

            // Define a posição do formulário de notificações à esquerda do formulário principal
            notificacao.StartPosition = FormStartPosition.Manual;
            notificacao.Location = new Point(this.Right, this.Top + 120); // Ajusta para a posição à esquerda do formulário principal

            notificacao.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
 
           
        
        }

        private void foto_Click(object sender, EventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            // Cria uma instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define o título da janela
            openFileDialog.Title = "Selecionar Arquivo";

            // Define o filtro de tipos de arquivo
            openFileDialog.Filter = "Imagens JPG (*.jpg;*.jpeg)|*.jpg;*.jpeg|Imagens PNG (*.png)|*.png";


            // Define o diretório inicial
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Exibe o diálogo para o usuário selecionar o arquivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verifica se o usuário selecionou um arquivo
            if (result == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado
                string filePath = openFileDialog.FileName;



                // Carrega a imagem no PictureBox
                foto.Image = Image.FromFile(filePath);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            EditarPerfil edit = new EditarPerfil();

            edit.ShowDialog();
        }
        }
    }


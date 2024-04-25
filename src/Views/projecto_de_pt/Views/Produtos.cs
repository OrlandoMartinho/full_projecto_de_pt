using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projecto_de_pt.Views
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            PreencherTabela();
 
        }


        private void PreencherTabela()
        {
            // Objeto JSON
            string json = @"{
                ""Data"":""20/3/2003"",
                ""Descricao"":""Entrada"",
                ""Quantidade"":""12"",
                ""Fornecedor"":""Orlando"",
                ""Nome"":""exemplo"",
                ""Preco"":""20000""
            }";

            // Desserializa o JSON manualmente
            Dictionary<string, string> dados = Deserialize(json);

            string caminhoImagem = Path.GetFullPath(Path.Combine(Application.StartupPath, @"assets\icons\teste.png"));

            try
            {
                // Carregar a imagem
                Image imagem = Image.FromFile(caminhoImagem);

                // Criar uma célula com imagem
                DataGridViewImageCell cell = new DataGridViewImageCell();
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom; // Definir o layout da imagem

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(caminhoImagem);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                cell.Value = pictureBox.Image;


                // Adicionar os dados à tabela
                Tabela.Rows.Add(dados["Data"], dados["Descricao"], dados["Quantidade"], dados["Fornecedor"], dados["Nome"], dados["Preco"], pictureBox.Image);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Erro: Arquivo de imagem não encontrado. Verifique o caminho da imagem.\n" + ex.Message);
            }
            

        }


       
        private Dictionary<string, string> Deserialize(string json)
        {
            Dictionary<string, string> dados = new Dictionary<string, string>();

            // Remove os caracteres de inicio e fim
            json = json.Trim('{', '}');

            // Divide o JSON em pares chave-valor
            string[] keyValuePairs = json.Split(',');

            foreach (string pair in keyValuePairs)
            {
                // Divide o par chave-valor
                string[] keyValue = pair.Trim().Split(':');

                // Remove aspas dos valores
                string key = keyValue[0].Trim('"');
                string value = keyValue[1].Trim('"');

                // Adiciona à lista
                dados.Add(key, value);
            }

            return dados;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

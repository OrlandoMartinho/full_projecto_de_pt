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
using Newtonsoft.Json;

namespace projecto_de_pt.Views
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Notificacoes notificacao = new Notificacoes();

            // Define a posição do formulário de notificações à esquerda do formulário principal
            notificacao.StartPosition = FormStartPosition.Manual;
            notificacao.Location = new Point(this.Right, this.Top + 120); // Ajusta para a posição à esquerda do formulário principal

            notificacao.ShowDialog();

        }


        private void InitializeDataView()
        {
            // Adiciona uma linha à tabela
            string json = @"
                        [
                            {
                                ""nome"": ""Orlando Martinho Pedro Saiombo"",
                                ""email"": ""srsaiombo@gmail.com"",
                                ""numero_de_telefone"": ""941139558"",
                                ""produto"": ""massa, arroz e etc...""
                            },

                            {
                                ""nome"": ""Orlando Martinho Pedro Saiombo"",
                                ""email"": ""srsaiombo@gmail.com"",
                                ""numero_de_telefone"": ""941139558"",
                                ""produto"": ""massa, arroz e etc...""
                            }


                        ]";

            List<Item> itens = JsonConvert.DeserializeObject<List<Item>>(json);

            Tabela1.Columns.Clear();
            Tabela1.Columns.Add("tb_nome", "Nome");
            Tabela1.Columns.Add("tb_numero", "Telefone");
            Tabela1.Columns.Add("tb_email", "Email");
            Tabela1.Columns.Add("tb_produto", "Produto");

            // Adiciona as colunas de imagem para editar e eliminar
            DataGridViewImageColumn editarColumn = new DataGridViewImageColumn();
            editarColumn.Name = "editar";
            editarColumn.HeaderText = "Editar";
            editarColumn.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"assets\icons\editar.png"));
            editarColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Tabela1.Columns.Add(editarColumn);

            DataGridViewImageColumn eliminarColumn = new DataGridViewImageColumn();
            eliminarColumn.Name = "eliminar";
            eliminarColumn.HeaderText = "Eliminar";
            eliminarColumn.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"assets\icons\eliminar.png"));
            eliminarColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Tabela1.Columns.Add(eliminarColumn);

            Tabela1.AllowUserToResizeColumns = false;
            Tabela1.AllowUserToResizeRows = false;

            // Adiciona os dados à tabela
            foreach (var item in itens)
            {
                Tabela1.Rows.Add(item.nome, item.data_de_nascimento, item.numero, item.genero,item.localizacao);
            }

            Tabela1.Columns["tb_nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.CellMouseLeave += Tabela1_CellMouseLeave;
            Tabela1.CellMouseEnter += Tabela1_CellMouseEnter;
            Tabela1.CellMouseLeave += Tabela1_CellMouseLeave;
            Tabela1.CellContentClick += Tabela1_CellContentClick;

            // Configurações de alinhamento
            foreach (DataGridViewColumn coluna in Tabela1.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            Tabela1.DefaultCellStyle.Font = new Font("Arial", 9);
        }
        private void Tabela1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o cursor está sobre uma célula de imagem para editar ou eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                (Tabela1.Columns[e.ColumnIndex].Name == "editar" || Tabela1.Columns[e.ColumnIndex].Name == "eliminar"))
            {
                // Muda o cursor para Hand quando passa sobre a célula de imagem
                Tabela1.Cursor = Cursors.Hand;



            }
        }

        private void Tabela1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Restaura o cursor quando sai da célula de imagem
            Tabela1.Cursor = Cursors.Default;
        }

        private void Tabela1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique ocorreu em uma célula de imagem de editar ou eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                (Tabela1.Columns[e.ColumnIndex].Name == "editar" || Tabela1.Columns[e.ColumnIndex].Name == "eliminar"))
            {
                // Você pode implementar aqui a lógica para edição ou eliminação
                // Por exemplo, você pode exibir uma mensagem ou abrir um formulário de edição
                string cellName = Tabela1.Columns[e.ColumnIndex].Name;
                MessageBox.Show("Célula clicada: " + cellName);
            }
        }


        public class Item
        {
            public string nome { get; set; }
            public string data_de_nascimento { get; set; }
            public string genero { get; set; }
            public string numero { get; set; }
            public string localizacao { get; set; }
            public string ultima_sessao { get; set; }
        }
    }
}

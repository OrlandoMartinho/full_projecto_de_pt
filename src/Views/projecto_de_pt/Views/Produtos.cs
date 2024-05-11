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
using Newtonsoft.Json;
using projecto_de_pt.Views;
using projecto_de_pt.Models;


namespace projecto_de_pt.Views
{
    public partial class Produtos : Form
    {

        ProdutosModel produtos = new ProdutosModel();
        public Produtos()
        {
            InitializeComponent();
            InitializeDataView();

            string caminhoImagem = Path.GetFullPath(Path.Combine(Application.StartupPath, @"assets\img\orlando.png"));

            foto.Image = Image.FromFile(caminhoImagem);

            // Ajusta o tamanho da PictureBox à imagem
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
 
        }


      
        private void InitializeDataView()
        {
            // Adiciona uma linha à tabela
                        string json = @"
            [
                {
                    ""Data"": ""01/04/2024"",
                    ""Descricao"": ""Saída"",
                    ""Quantidade"": 5,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo"",
                    ""Nome"": ""Nome do item"",
                    ""Preco"": 10099
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                },
                {
                    ""Data"": ""10/04/2024"",
                    ""Descricao"": ""Entrada"",
                    ""Quantidade"": 2,
                    ""Fornecedor"": ""Orlando Martinho Pedro Saiombo Y"",
                    ""Nome"": ""Outro item"",
                    ""Preco"": 15500
                }
            ]";

            List<Item> itens = JsonConvert.DeserializeObject<List<Item>>(json);

                 
            
            Tabela1.Columns.Clear();
            Tabela1.Columns.Add("tb_data","Data" );
            Tabela1.Columns.Add("tb_descricao","Descrição");
            Tabela1.Columns.Add("tb_quantidade","Quantidade");
            Tabela1.Columns.Add("tb_fornecedor", "Fornecedor");
            Tabela1.Columns.Add("tb_nome", "Nome");
            Tabela1.Columns.Add("tb_preco","Preço");
            DataGridViewImageColumn imagemColumn = new DataGridViewImageColumn();
            imagemColumn.HeaderText = "Editar";
            imagemColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; 
            Tabela1.Columns.Add(imagemColumn);

            string caminhoImagem = Path.GetFullPath(Path.Combine(Application.StartupPath, @"assets\icons\editar.png"));
            Image imagem = Image.FromFile(caminhoImagem);
            Tabela1.AllowUserToResizeColumns = false;
            Tabela1.AllowUserToResizeRows = false;
            // Adiciona os dados à tabela

            foreach (var item in itens)
            {
                object[] rowData = { item.Data, item.Descricao,item.Quantidade, item.Fornecedor, item.Nome,item.Preco , imagem };

                Tabela1.Rows.Add(rowData);
            }


            Tabela1.Columns["tb_data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_fornecedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tabela1.Columns["tb_preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            
            // AutoResizeColumns para forçar o ajuste automático do tamanho das colunas
            Tabela1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            Tabela1.CellContentClick += Tabela1_CellContentClick;
            Tabela1.CellMouseLeave += Tabela1_CellMouseLeave;
            Tabela1.CellMouseEnter += Tabela1_CellMouseEnter;
            Tabela1.CellMouseLeave += Tabela1_CellMouseLeave;


            // Configura o alinhamento das outras células para a esquerda e centraliza apenas as células da coluna "Quantidade"
            foreach (DataGridViewRow linha in Tabela1.Rows)
            {
                linha.Cells["tb_quantidade"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewCell cell in linha.Cells)
                {
                    if (cell.ColumnIndex != Tabela1.Columns["tb_quantidade"].Index && cell.ColumnIndex != Tabela1.Columns["tb_data"].Index)
                    {
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                }
            }

            // Configura o alinhamento centralizado para todas as colunas, exceto a coluna "Data"
            foreach (DataGridViewColumn coluna in Tabela1.Columns)
            {
                if (coluna.Name != "tb_data")
                {
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

           
    

            Tabela1.DefaultCellStyle.Font = new Font("Arial", 9); 
            imagemColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            imagemColumn.DefaultCellStyle.NullValue = null; 
           }


        private void Tabela1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o cursor está sobre uma célula de imagem                                                             
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && Tabela1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
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
            // Verifica se o clique ocorreu em uma célula de imagem
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && Tabela1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                // Recupera a imagem da célula clicada
                Image imagemClicada = (Image)Tabela1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Exibe uma mensagem com a imagem clicada
                produtos.editarProduto();
            }
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


         public class Item
        {

        public string Data { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

     
       }

         private void guna2Button1_Click(object sender, EventArgs e)
         {
             CadastrarProduto cadastrarProduto = new CadastrarProduto();

             cadastrarProduto.ShowDialog();

         }

         private void pictureBox1_Click(object sender, EventArgs e)
         {
             Notificacoes notificacao = new Notificacoes();

             // Define a posição do formulário de notificações à esquerda do formulário principal
             notificacao.StartPosition = FormStartPosition.Manual;
             notificacao.Location = new Point(this.Right, this.Top + 120); // Ajusta para a posição à esquerda do formulário principal

             notificacao.ShowDialog();
         }

         private void foto_Click(object sender, EventArgs e)
         {

         }
         
    



    }
}

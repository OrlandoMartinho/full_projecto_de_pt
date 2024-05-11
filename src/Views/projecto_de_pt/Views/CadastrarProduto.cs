using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projecto_de_pt.Models;

namespace projecto_de_pt.Views
{
    public partial class CadastrarProduto : Form
    {
        ProdutosModel produtos = new ProdutosModel();
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            produtos.Nome = nome.Text;
            produtos.Preco = preco.Text;
            produtos.Quantidade = quantidade.Text;
            produtos.Fornecedor = fornecedor.Text;
            produtos.Descricao = descricao.Text;
            produtos.Categoria = categoria.Text;


            produtos.cadastrarProduto();



        }
    }
}

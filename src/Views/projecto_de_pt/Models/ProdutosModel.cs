using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_de_pt.Models
{
   public class ProdutosModel
{
        private string nome;
        private string descricao;
        private string quantidade;
        private string fornecedor;
        private string preco;
        private string categoria;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    
       public void cadastrarProduto(){


           MessageBox.Show("Produto Cadastrado");
       }

       public void editarProduto()
       {


           MessageBox.Show("Produto Editado");
       }
   
   }



    }


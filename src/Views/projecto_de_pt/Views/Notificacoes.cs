using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace projecto_de_pt.Views
{
    public partial class Notificacoes : Form
    {
        public Notificacoes()
        {
            InitializeComponent();

            this.Location = new Point(100, 100);


            string json = "[{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo1\",\"data\":\"12/03/2003\"},{\"descricao\":\"exemplo2\",\"data\":\"25/05/2005\"},{\"descricao\":\"exemplo3\",\"data\":\"05/08/2008\"},{\"descricao\":\"exemplo4\",\"data\":\"10/10/2010\"},{\"descricao\":\"exemplo5\",\"data\":\"15/12/2012\"}]";

            // Convertendo o JSON para um array de objetos JSON
            JArray jsonArray = JArray.Parse(json);

            list_notificacoes.BackColor = Color.White;

            // Adicionando itens ao ListBox
            // Adicionando itens ao ListBox
            foreach (JObject item in jsonArray)
            {
                string descricao = item["descricao"].ToString();
                string data = item["data"].ToString();

                // Adiciona a descrição
                list_notificacoes.Items.Add(new ColorListBoxItem(descricao, Color.Black));

                // Adiciona a data
                list_notificacoes.Items.Add(new ColorListBoxItem(data, Color.Yellow));

                // Adiciona a linha de separação
                list_notificacoes.Items.Add(new ColorListBoxItem("--------------------------------------------------------------------------------", Color.Black));
            }



           
        
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ColorListBoxItem
    {
        public string Text { get; set; }
        public Color ForeColor { get; set; }

        public ColorListBoxItem(string text, Color foreColor)
        {
            Text = text;
            ForeColor = foreColor;
        }

        public override string ToString()
        {
            return Text;
        }
    }

}

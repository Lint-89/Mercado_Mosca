using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado_mosca
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void AdicionarProdutoNaListBox(string nomeProduto, int quantidade, decimal precoUnitario)
        {
            try
            {
                string produto = $"{nomeProduto} - {quantidade}x - Total: R$ {quantidade * precoUnitario:F2}";

                bool produtoExistente = false;
                for (int i = 0; i < listBoxProdutos.Items.Count; i++)
                {
                    string item = listBoxProdutos.Items[i].ToString();
                    if (item.Contains(nomeProduto))
                    {
                        string[] partes = item.Split('-');
                        int quantidadeAtual = int.Parse(partes[1].Trim().Split('x')[0]);

                        int novaQuantidade = quantidadeAtual + quantidade;
                        decimal precoTotal = novaQuantidade * precoUnitario;

                        listBoxProdutos.Items[i] = $"{nomeProduto} - {novaQuantidade}x - Total: R$ {precoTotal:F2}";
                        produtoExistente = true;
                        break;
                    }
                }
                if (!produtoExistente)
                {
                    listBoxProdutos.Items.Add(produto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }
    }
}
    

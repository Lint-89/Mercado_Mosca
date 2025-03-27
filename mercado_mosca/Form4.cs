using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mercado_mosca.Form5;

namespace mercado_mosca
{
    public partial class Form4 : Form
    {
        public static List<Produto> Carrinho = new List<Produto>();
        public Form4()
        {
            InitializeComponent();
            btnProduto1.Tag = new Produto { Nome = "Produto 1", PrecoUnitario = 10.00m };
            btnProduto2.Tag = new Produto { Nome = "Produto 2", PrecoUnitario = 20.00m };
            btnProduto3.Tag = new Produto { Nome = "Produto 3", PrecoUnitario = 30.00m };

            btnProduto1.Click += btnAdicionarAoCarrinho_Click;
            btnProduto2.Click += btnAdicionarAoCarrinho_Click;
            btnProduto3.Click += btnAdicionarAoCarrinho_Click;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

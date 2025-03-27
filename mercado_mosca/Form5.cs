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

        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }

            public decimal PrecoTotal => Quantidade * PrecoUnitario;
        }
    }
    }


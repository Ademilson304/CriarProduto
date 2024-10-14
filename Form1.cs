using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App10._10WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            CriarProdutoForm2 fcp = new CriarProdutoForm2();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK) 
            {
                string textoProduto = $"{fcp.nomeProduto}({fcp.nomeFabricante}) preço de compra [R$ {fcp.precoCompra}] preço de venda [R$ {fcp.precoVenda}]";
                listBox1.Items.Add(textoProduto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}

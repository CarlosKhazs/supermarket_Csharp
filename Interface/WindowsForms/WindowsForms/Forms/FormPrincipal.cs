using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias formCategoria = new FormCategorias();

            formCategoria.MdiParent = this;
            formCategoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();

            formProdutos.MdiParent = this;
            formProdutos.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();

            formVendas.MdiParent = this;
            formVendas.Show();
        }

        private void itemVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemVenda formItemVenda = new FormItemVenda();

            formItemVenda.MdiParent = this;
            formItemVenda.Show();
        }

        private void promocaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromocao formPromocao = new FormPromocao();

            formPromocao.MdiParent = this;
            formPromocao.Show();
        }
    }
}

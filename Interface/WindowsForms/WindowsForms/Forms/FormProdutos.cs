using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Data.Entity;

namespace WindowsForms.Forms
{
    public partial class FormProdutos : Form
    {
        projetoCNETEntities db = new projetoCNETEntities();
        private Produto produto;
        private String messageBox;

        public FormProdutos()
        {
            InitializeComponent();
        }

        public void LoadGrid()
        {
            this.produtoTableAdapter.Fill(this.projetoCNETDataSet1.Produto);

            comboBoxCategoria.DataSource = db.Categoria.ToList();
            comboBoxCategoria.DisplayMember = "Descricao";
            comboBoxCategoria.ValueMember = "id";

            comboBoxPromocao.DataSource = db.Promocao.ToList();
            comboBoxPromocao.DisplayMember = "ValorDesconto";
            comboBoxPromocao.ValueMember = "id";
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            LoadGrid();

            dataGridProduto.MultiSelect = false;
            dataGridProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProduto.EditMode = DataGridViewEditMode.EditProgrammatically;

            LimparCampos();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (inputNomeProduto.Text != "")
            {
                if (produto == null)
                {
                    produto = new Produto();
                }

                int idProduto = produto.id > 0 ? produto.id : 0;

                produto.Nome = inputNomeProduto.Text;
                produto.idCategoria = (int)comboBoxCategoria.SelectedValue;
                produto.idPromocao = (int)comboBoxPromocao.SelectedValue;

                if (idProduto == 0)
                {
                    db.Produto.Add(produto);
                    messageBox = "Produto registrado com sucesso!";
                }
                else
                {
                    var obj = db.Entry(produto);
                    obj.Property(prop => prop.Nome).IsModified = true;
                    obj.Property(prop => prop.idCategoria).IsModified = true;
                    obj.Property(prop => prop.idPromocao).IsModified = true;

                    messageBox = "Produto alterado com sucesso!";
                }

                db.SaveChanges();

                LoadGrid();
                LimparCampos();
            }
            else
            {
                messageBox = "Por favor, digite um nome para o novo produto!";
            }

            MessageBox.Show(messageBox);
        }

        private void EditarProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridProduto.CurrentRow;
            int idProduto = (int)row.Cells[0].Value;

            produto = db.Produto.Where(column => column.id == idProduto).FirstOrDefault();
            inputNomeProduto.Text = produto.Nome;
            comboBoxCategoria.SelectedValue = produto.idCategoria;
            comboBoxPromocao.SelectedValue = produto.idPromocao;
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dataGridProduto.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmar remoção",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridProduto.CurrentRow;
                    int idProduto = (int)row.Cells[0].Value;

                    produto = db.Produto.Where(column => column.id == idProduto).FirstOrDefault();

                    Item_Venda item_Venda = new Item_Venda();
                    item_Venda = db.Item_Venda.Where(column => column.idProduto == produto.id).FirstOrDefault();

                    if (item_Venda != null)
                    {
                        messageBox = "Item não pode ser removido, pois já possui um registro referenciado a algum Item de venda!";
                    }
                    else
                    {
                        db.Produto.Remove(produto);
                        db.SaveChanges();

                        LoadGrid();
                        LimparCampos();
                        messageBox = "Item removido com sucesso!";
                    }

                    MessageBox.Show(messageBox);
                }
            }
            else
            {
                messageBox = "Por favor, selecione um item para excluir!";

                MessageBox.Show(messageBox);
            }
        }

        public void LimparCampos()
        {
            inputNomeProduto.Clear();
            comboBoxCategoria.SelectedItem = null;
            comboBoxPromocao.SelectedItem = null;
            produto = null;
        }
    }
}

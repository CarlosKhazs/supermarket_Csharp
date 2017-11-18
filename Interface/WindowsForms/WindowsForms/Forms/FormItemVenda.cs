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
    public partial class FormItemVenda : Form
    {
        projetoCNETEntities db = new projetoCNETEntities();
        private Item_Venda itemVenda;
        private String messageBox;

        public FormItemVenda()
        {
            InitializeComponent();
        }

        public void LoadGrid()
        {
            this.item_VendaTableAdapter.Fill(this.projetoCNETDataSet3.Item_Venda);

            comboBoxIdProduto.DataSource = db.Produto.ToList();
            comboBoxIdProduto.DisplayMember = "Nome";
            comboBoxIdProduto.ValueMember = "id";

            comboBoxIdVenda.DataSource = db.Venda.ToList();
            comboBoxIdVenda.DisplayMember = "Data";
            comboBoxIdVenda.ValueMember = "id";
        }

        private void Item_Venda_Load(object sender, EventArgs e)
        {
            LoadGrid();

            dataGridItemVenda.MultiSelect = false;
            dataGridItemVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridItemVenda.EditMode = DataGridViewEditMode.EditProgrammatically;

            LimparCampos();
        }

        private void btnSalvarItemVenda_Click(object sender, EventArgs e)
        {
            if (inputQuantidadeItemVenda.Text != "" || inputValorUnitarioItemVenda.Text != "")
            {
                if (itemVenda == null)
                {
                    itemVenda = new Item_Venda();
                }

                int idItem_VendaIdProduto = itemVenda.idProduto > 0 ? itemVenda.idProduto : 0;
                int idItem_VendaIdVenda = itemVenda.idVenda > 0 ? itemVenda.idVenda : 0;

                itemVenda.idProduto = (int)comboBoxIdProduto.SelectedValue;
                itemVenda.idVenda = (int)comboBoxIdVenda.SelectedValue;
                itemVenda.Quantidade = int.Parse(inputQuantidadeItemVenda.Text);
                itemVenda.ValorUnitario = Convert.ToDouble(inputValorUnitarioItemVenda.Text);

                if (idItem_VendaIdProduto == 0 && idItem_VendaIdVenda == 0)
                {
                    if (VerificarItemRegistrado(itemVenda.idProduto, itemVenda.idVenda))
                    {
                        messageBox = "Item de venda já registrado!";
                    }
                    else
                    {
                        db.Item_Venda.Add(itemVenda);
                        messageBox = "Item de venda registrado com sucesso!";

                        db.SaveChanges();
                    }
                }
                else
                {
                    if (VerificarItemRegistrado(itemVenda.idProduto, itemVenda.idVenda))
                    {
                        messageBox = "Você não pode alterar este item. Item de venda já registrado! ";
                    }
                    else
                    {
                        var obj = db.Entry(itemVenda);
                        obj.Property(prop => prop.idProduto).IsModified = true;
                        obj.Property(prop => prop.idVenda).IsModified = true;
                        obj.Property(prop => prop.Quantidade).IsModified = true;
                        obj.Property(prop => prop.ValorUnitario).IsModified = true;

                        messageBox = "Item de venda alterado com sucesso!";

                        db.SaveChanges();
                    }
                }

                LoadGrid();
                LimparCampos();
            }
            else
            {
                messageBox = "Por favor, digite a quantidade ou o valor unitário do item!";
            }

            MessageBox.Show(messageBox);
        }

        private void EditarItemVenda_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridItemVenda.CurrentRow;
            int idProduto = (int)row.Cells[0].Value;
            int idVenda = (int)row.Cells[1].Value;

            itemVenda = db.Item_Venda.Where(column => column.idProduto == idProduto && column.idVenda == idVenda).FirstOrDefault();
            comboBoxIdProduto.SelectedValue = itemVenda.idProduto;
            comboBoxIdVenda.SelectedValue = itemVenda.idVenda;
            inputQuantidadeItemVenda.Text = itemVenda.Quantidade.ToString();
            inputValorUnitarioItemVenda.Text = itemVenda.ValorUnitario.ToString();
        }

        private void btnExcluirItemVenda_Click(object sender, EventArgs e)
        {
            if (dataGridItemVenda.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmar remoção",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridItemVenda.CurrentRow;
                    int idProduto = (int)row.Cells[0].Value;
                    int idVenda = (int)row.Cells[1].Value;

                    itemVenda = db.Item_Venda.Where(column => column.idProduto == idProduto && column.idVenda == idVenda).FirstOrDefault();
                    db.Item_Venda.Remove(itemVenda);
                    db.SaveChanges();

                    LoadGrid();
                    LimparCampos();
                    messageBox = "Item removido com sucesso!";

                    MessageBox.Show(messageBox);
                }
            }
            else
            {
                messageBox = "Por favor, selecione um item para excluir!";

                MessageBox.Show(messageBox);
            }
        }

        private bool VerificarItemRegistrado(int idProduto, int idVenda)
        {
            var query = db.Item_Venda.Where(column => column.idProduto == idProduto &&
               column.idVenda == idVenda).Count();

            if (query > 0)
            {
                return true;
            }

            return false;
        }

        public void LimparCampos()
        {
            comboBoxIdProduto.SelectedItem = null;
            comboBoxIdVenda.SelectedItem = null;
            inputQuantidadeItemVenda.Clear();
            inputValorUnitarioItemVenda.Clear();
            itemVenda = null;
        }
    }
}

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
    public partial class FormPromocao : Form
    {
        projetoCNETEntities db = new projetoCNETEntities();
        private Promocao promocao;
        private String messageBox;

        public FormPromocao()
        {
            InitializeComponent();
        }

        public void LoadGrid()
        {
            this.promocaoTableAdapter.Fill(this.projetoCNETDataSet4.Promocao);
        }

        private void Promocao_Load(object sender, EventArgs e)
        {
            LoadGrid();

            dataGridPromocao.MultiSelect = false;
            dataGridPromocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPromocao.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void salvarPromocao_Click(object sender, EventArgs e)
        {
            if (inputValorDescontoPromocao.Text != "")
            {
                if (promocao == null)
                {
                    promocao = new Promocao();
                }

                int idPromocao = promocao.id > 0 ? promocao.id : 0;

                promocao.ValorDesconto = Convert.ToDouble(inputValorDescontoPromocao.Text);

                if (idPromocao == 0)
                {
                    db.Promocao.Add(promocao);
                    messageBox = "Promocao registrado com sucesso!";
                }
                else
                {
                    var obj = db.Entry(promocao);
                    obj.Property(prop => prop.ValorDesconto).IsModified = true;

                    messageBox = "Promocao alterado com sucesso!";
                }

                db.SaveChanges();

                LoadGrid();
                LimparCampos();
            }
            else
            {
                messageBox = "Por favor, digite um nome para o novo promocao!";
            }

            MessageBox.Show(messageBox);
        }

        private void EditarPromocao_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridPromocao.CurrentRow;
            int id = (int)row.Cells[0].Value;

            promocao = db.Promocao.Where(column => column.id == id).FirstOrDefault();
            inputValorDescontoPromocao.Text = promocao.ValorDesconto.ToString();
        }

        private void excluirPromocao_Click(object sender, EventArgs e)
        {
            if (dataGridPromocao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmar remoção",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridPromocao.CurrentRow;
                    int id = (int)row.Cells[0].Value;

                    promocao = db.Promocao.Where(column => column.id == id).FirstOrDefault();

                    Produto produto = new Produto();
                    produto = db.Produto.Where(column => column.idPromocao == promocao.id).FirstOrDefault();

                    if (produto != null)
                    {
                        messageBox = "Item não pode ser removido, pois já possui um registro referenciado a algum Produto!";
                    }
                    else
                    {
                        db.Promocao.Remove(promocao);
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
            inputValorDescontoPromocao.Clear();
            promocao = null;
        }
    }
}

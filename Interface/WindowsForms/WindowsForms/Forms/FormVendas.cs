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
    public partial class FormVendas : Form
    {
        projetoCNETEntities db = new projetoCNETEntities();
        private Venda venda;
        private String messageBox;

        public FormVendas()
        {
            InitializeComponent();
        }

        public void LoadGrid()
        {
            this.vendaTableAdapter.Fill(this.projetoCNETDataSet2.Venda);

            comboBoxIdPessoa.DataSource = db.Cliente.ToList();
            comboBoxIdPessoa.DisplayMember = "CPF";
            comboBoxIdPessoa.ValueMember = "idPessoa";
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            LoadGrid();

            dataGridVenda.MultiSelect = false;
            dataGridVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVenda.EditMode = DataGridViewEditMode.EditProgrammatically;

            LimparCampos();
        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            if (venda == null)
            {
                venda = new Venda();
            }

            int idVenda = venda.id > 0 ? venda.id : 0;

            venda.Data = DateTime.Now;
            venda.idPessoa = (int)comboBoxIdPessoa.SelectedValue;

            if (idVenda == 0)
            {
                db.Venda.Add(venda);
                messageBox = "Venda registrada com sucesso!";
            }
            else
            {
                var obj = db.Entry(venda);
                obj.Property(prop => prop.idPessoa).IsModified = true;

                messageBox = "Venda alterada com sucesso!";
            }

            db.SaveChanges();

            LoadGrid();
            LimparCampos();

            MessageBox.Show(messageBox);
        }

        private void EditarVenda_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridVenda.CurrentRow;
            int id = (int)row.Cells[0].Value;

            venda = db.Venda.Where(column => column.id == id).FirstOrDefault();
            comboBoxIdPessoa.SelectedValue = venda.idPessoa;
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            if (dataGridVenda.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmar remoção",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridVenda.CurrentRow;
                    int id = (int)row.Cells[0].Value;

                    venda = db.Venda.Where(column => column.id == id).FirstOrDefault();

                    Item_Venda item_Venda = new Item_Venda();
                    item_Venda = db.Item_Venda.Where(column => column.idVenda == venda.id).FirstOrDefault();

                    if (item_Venda != null)
                    {
                        messageBox = "Item não pode ser removido, pois já possui um registro referenciado a algum Item de venda!";
                    }
                    else
                    {
                        db.Venda.Remove(venda);
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
            comboBoxIdPessoa.SelectedItem = null;
            venda = null;
        }
    }
}

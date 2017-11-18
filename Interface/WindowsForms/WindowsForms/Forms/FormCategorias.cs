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
    public partial class FormCategorias : Form
    {
        projetoCNETEntities db = new projetoCNETEntities();
        private Categoria categoria;
        private String messageBox;

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            LoadGrid();

            dataGridCategoria.MultiSelect = false;
            dataGridCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategoria.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void LoadGrid()
        {
            this.categoriaTableAdapter.Fill(this.projetoCNETDataSet.Categoria);
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            if(inputDescricaoCategoria.Text != "")
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                int idCategoria = categoria.id > 0 ? categoria.id : 0;
                categoria.Descricao = inputDescricaoCategoria.Text;

                if (categoria.id == 0)
                {
                    db.Categoria.Add(categoria);
                    messageBox = "Categoria registrada com sucesso!";
                }
                else
                {
                    var obj = db.Entry(categoria);
                    obj.Property(prop => prop.Descricao).IsModified = true;

                    messageBox = "Categoria alterada com sucesso!";
                }

                db.SaveChanges();

                LoadGrid();
                LimparCampos();
            }
            else
            {
                messageBox = "Por favor, digite um nome para a nova categoria!";
            }
            
            MessageBox.Show(messageBox);
        }    

        private void EditarCategoria_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridCategoria.SelectedRows[0];
            int idCategoria = (int)row.Cells["id"].Value;

            categoria = db.Categoria.Where(column => column.id == idCategoria).FirstOrDefault();
            inputDescricaoCategoria.Text = categoria.Descricao;
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            if(dataGridCategoria.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmar remoção",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridCategoria.SelectedRows[0];
                    int idCategoria = (int)row.Cells["id"].Value;

                    categoria = db.Categoria.Where(column => column.id == idCategoria).FirstOrDefault();

                    Produto produto = new Produto();
                    produto = db.Produto.Where(column => column.idCategoria == categoria.id).FirstOrDefault();

                    if (produto != null)
                    {
                        messageBox = "Item não pode ser removido, pois já possui um registro referenciado a algum Produto!";
                    }
                    else
                    {
                        db.Categoria.Remove(categoria);
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
            inputDescricaoCategoria.Clear();
            categoria = null;
        }
    }
}

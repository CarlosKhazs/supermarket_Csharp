namespace WindowsForms.Forms
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NomeProduto = new System.Windows.Forms.Label();
            this.inputNomeProduto = new System.Windows.Forms.TextBox();
            this.CategoriaProduto = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.PromocaoProduto = new System.Windows.Forms.Label();
            this.comboBoxPromocao = new System.Windows.Forms.ComboBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoCNETDataSet1 = new WindowsForms.projetoCNETDataSet1();
            this.produtoTableAdapter = new WindowsForms.projetoCNETDataSet1TableAdapters.ProdutoTableAdapter();
            this.PromocaoDesconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSize = true;
            this.NomeProduto.Location = new System.Drawing.Point(13, 28);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(35, 13);
            this.NomeProduto.TabIndex = 0;
            this.NomeProduto.Text = "Nome";
            // 
            // inputNomeProduto
            // 
            this.inputNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNomeProduto.Location = new System.Drawing.Point(74, 25);
            this.inputNomeProduto.Name = "inputNomeProduto";
            this.inputNomeProduto.Size = new System.Drawing.Size(470, 20);
            this.inputNomeProduto.TabIndex = 1;
            // 
            // CategoriaProduto
            // 
            this.CategoriaProduto.AutoSize = true;
            this.CategoriaProduto.Location = new System.Drawing.Point(13, 66);
            this.CategoriaProduto.Name = "CategoriaProduto";
            this.CategoriaProduto.Size = new System.Drawing.Size(52, 13);
            this.CategoriaProduto.TabIndex = 2;
            this.CategoriaProduto.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(74, 63);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(470, 21);
            this.comboBoxCategoria.TabIndex = 3;
            // 
            // PromocaoProduto
            // 
            this.PromocaoProduto.AutoSize = true;
            this.PromocaoProduto.Location = new System.Drawing.Point(13, 106);
            this.PromocaoProduto.Name = "PromocaoProduto";
            this.PromocaoProduto.Size = new System.Drawing.Size(55, 13);
            this.PromocaoProduto.TabIndex = 4;
            this.PromocaoProduto.Text = "Promoção";
            // 
            // comboBoxPromocao
            // 
            this.comboBoxPromocao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPromocao.FormattingEnabled = true;
            this.comboBoxPromocao.Location = new System.Drawing.Point(74, 106);
            this.comboBoxPromocao.Name = "comboBoxPromocao";
            this.comboBoxPromocao.Size = new System.Drawing.Size(470, 21);
            this.comboBoxPromocao.TabIndex = 5;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(74, 153);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProduto.TabIndex = 6;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(464, 153);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(80, 23);
            this.btnExcluirProduto.TabIndex = 7;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToOrderColumns = true;
            this.dataGridProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProduto.AutoGenerateColumns = false;
            this.dataGridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idPromocaoDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn});
            this.dataGridProduto.DataSource = this.produtoBindingSource;
            this.dataGridProduto.Location = new System.Drawing.Point(12, 197);
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.Size = new System.Drawing.Size(560, 182);
            this.dataGridProduto.TabIndex = 8;
            this.dataGridProduto.Click += new System.EventHandler(this.EditarProduto_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // idPromocaoDataGridViewTextBoxColumn
            // 
            this.idPromocaoDataGridViewTextBoxColumn.DataPropertyName = "idPromocao";
            this.idPromocaoDataGridViewTextBoxColumn.HeaderText = "idPromocao";
            this.idPromocaoDataGridViewTextBoxColumn.Name = "idPromocaoDataGridViewTextBoxColumn";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.projetoCNETDataSet1;
            // 
            // projetoCNETDataSet1
            // 
            this.projetoCNETDataSet1.DataSetName = "projetoCNETDataSet1";
            this.projetoCNETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // PromocaoDesconto
            // 
            this.PromocaoDesconto.AutoSize = true;
            this.PromocaoDesconto.Location = new System.Drawing.Point(9, 119);
            this.PromocaoDesconto.Name = "PromocaoDesconto";
            this.PromocaoDesconto.Size = new System.Drawing.Size(59, 13);
            this.PromocaoDesconto.TabIndex = 9;
            this.PromocaoDesconto.Text = "(Desconto)";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.PromocaoDesconto);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.comboBoxPromocao);
            this.Controls.Add(this.PromocaoProduto);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.CategoriaProduto);
            this.Controls.Add(this.inputNomeProduto);
            this.Controls.Add(this.NomeProduto);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeProduto;
        private System.Windows.Forms.TextBox inputNomeProduto;
        private System.Windows.Forms.Label CategoriaProduto;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label PromocaoProduto;
        private System.Windows.Forms.ComboBox comboBoxPromocao;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private projetoCNETDataSet1 projetoCNETDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private projetoCNETDataSet1TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label PromocaoDesconto;
    }
}
namespace WindowsForms.Forms
{
    partial class FormCategorias
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
            this.Descrição = new System.Windows.Forms.Label();
            this.inputDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.dataGridCategoria = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoCNETDataSet = new WindowsForms.projetoCNETDataSet();
            this.categoriaTableAdapter = new WindowsForms.projetoCNETDataSetTableAdapters.CategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(12, 41);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(55, 13);
            this.Descrição.TabIndex = 0;
            this.Descrição.Text = "Descrição";
            // 
            // inputDescricaoCategoria
            // 
            this.inputDescricaoCategoria.Location = new System.Drawing.Point(80, 38);
            this.inputDescricaoCategoria.Name = "inputDescricaoCategoria";
            this.inputDescricaoCategoria.Size = new System.Drawing.Size(470, 20);
            this.inputDescricaoCategoria.TabIndex = 1;
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.Location = new System.Drawing.Point(120, 97);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCategoria.TabIndex = 2;
            this.btnSalvarCategoria.Text = "Salvar";
            this.btnSalvarCategoria.UseVisualStyleBackColor = true;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Location = new System.Drawing.Point(432, 97);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCategoria.TabIndex = 4;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.AllowUserToAddRows = false;
            this.dataGridCategoria.AllowUserToOrderColumns = true;
            this.dataGridCategoria.AutoGenerateColumns = false;
            this.dataGridCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridCategoria.DataSource = this.categoriaBindingSource;
            this.dataGridCategoria.Location = new System.Drawing.Point(12, 166);
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.Size = new System.Drawing.Size(538, 150);
            this.dataGridCategoria.TabIndex = 5;
            this.dataGridCategoria.Click += new System.EventHandler(this.EditarCategoria_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.projetoCNETDataSet;
            // 
            // projetoCNETDataSet
            // 
            this.projetoCNETDataSet.DataSetName = "projetoCNETDataSet";
            this.projetoCNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 328);
            this.Controls.Add(this.dataGridCategoria);
            this.Controls.Add(this.btnExcluirCategoria);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.inputDescricaoCategoria);
            this.Controls.Add(this.Descrição);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.TextBox inputDescricaoCategoria;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private projetoCNETDataSet projetoCNETDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private projetoCNETDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}
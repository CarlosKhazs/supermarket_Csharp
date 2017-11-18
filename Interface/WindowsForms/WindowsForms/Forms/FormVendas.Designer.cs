namespace WindowsForms.Forms
{
    partial class FormVendas
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
            this.comboBoxIdPessoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridVenda = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoCNETDataSet2 = new WindowsForms.projetoCNETDataSet2();
            this.vendaTableAdapter = new WindowsForms.projetoCNETDataSet2TableAdapters.VendaTableAdapter();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdPessoa
            // 
            this.comboBoxIdPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIdPessoa.FormattingEnabled = true;
            this.comboBoxIdPessoa.Location = new System.Drawing.Point(59, 12);
            this.comboBoxIdPessoa.Name = "comboBoxIdPessoa";
            this.comboBoxIdPessoa.Size = new System.Drawing.Size(380, 21);
            this.comboBoxIdPessoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pessoa";
            // 
            // dataGridVenda
            // 
            this.dataGridVenda.AllowUserToAddRows = false;
            this.dataGridVenda.AllowUserToOrderColumns = true;
            this.dataGridVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVenda.AutoGenerateColumns = false;
            this.dataGridVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idPessoaDataGridViewTextBoxColumn});
            this.dataGridVenda.DataSource = this.vendaBindingSource;
            this.dataGridVenda.Location = new System.Drawing.Point(12, 101);
            this.dataGridVenda.Name = "dataGridVenda";
            this.dataGridVenda.Size = new System.Drawing.Size(427, 136);
            this.dataGridVenda.TabIndex = 3;
            this.dataGridVenda.Click += new System.EventHandler(this.EditarVenda_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "idPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "idPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.projetoCNETDataSet2;
            // 
            // projetoCNETDataSet2
            // 
            this.projetoCNETDataSet2.DataSetName = "projetoCNETDataSet2";
            this.projetoCNETDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.Location = new System.Drawing.Point(59, 55);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarVenda.TabIndex = 5;
            this.btnSalvarVenda.Text = "Salvar";
            this.btnSalvarVenda.UseVisualStyleBackColor = true;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarVenda_Click);
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirVenda.Location = new System.Drawing.Point(359, 55);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(80, 23);
            this.btnExcluirVenda.TabIndex = 6;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 249);
            this.Controls.Add(this.btnExcluirVenda);
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.dataGridVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIdPessoa);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxIdPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridVenda;
        private projetoCNETDataSet2 projetoCNETDataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private projetoCNETDataSet2TableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.Button btnExcluirVenda;
    }
}
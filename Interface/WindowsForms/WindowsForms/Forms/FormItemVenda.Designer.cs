namespace WindowsForms.Forms
{
    partial class FormItemVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIdProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxIdVenda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputQuantidadeItemVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputValorUnitarioItemVenda = new System.Windows.Forms.TextBox();
            this.dataGridItemVenda = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoCNETDataSet3 = new WindowsForms.projetoCNETDataSet3();
            this.btnSalvarItemVenda = new System.Windows.Forms.Button();
            this.btnExcluirItemVenda = new System.Windows.Forms.Button();
            this.item_VendaTableAdapter = new WindowsForms.projetoCNETDataSet3TableAdapters.Item_VendaTableAdapter();
            this.DataVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venda";
            // 
            // comboBoxIdProduto
            // 
            this.comboBoxIdProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIdProduto.FormattingEnabled = true;
            this.comboBoxIdProduto.Location = new System.Drawing.Point(80, 20);
            this.comboBoxIdProduto.Name = "comboBoxIdProduto";
            this.comboBoxIdProduto.Size = new System.Drawing.Size(434, 21);
            this.comboBoxIdProduto.TabIndex = 2;
            // 
            // comboBoxIdVenda
            // 
            this.comboBoxIdVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIdVenda.FormattingEnabled = true;
            this.comboBoxIdVenda.Location = new System.Drawing.Point(80, 63);
            this.comboBoxIdVenda.Name = "comboBoxIdVenda";
            this.comboBoxIdVenda.Size = new System.Drawing.Size(434, 21);
            this.comboBoxIdVenda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // inputQuantidadeItemVenda
            // 
            this.inputQuantidadeItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputQuantidadeItemVenda.Location = new System.Drawing.Point(80, 109);
            this.inputQuantidadeItemVenda.Name = "inputQuantidadeItemVenda";
            this.inputQuantidadeItemVenda.Size = new System.Drawing.Size(157, 20);
            this.inputQuantidadeItemVenda.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Unitário";
            // 
            // inputValorUnitarioItemVenda
            // 
            this.inputValorUnitarioItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputValorUnitarioItemVenda.Location = new System.Drawing.Point(355, 109);
            this.inputValorUnitarioItemVenda.Name = "inputValorUnitarioItemVenda";
            this.inputValorUnitarioItemVenda.Size = new System.Drawing.Size(159, 20);
            this.inputValorUnitarioItemVenda.TabIndex = 7;
            // 
            // dataGridItemVenda
            // 
            this.dataGridItemVenda.AllowUserToAddRows = false;
            this.dataGridItemVenda.AllowUserToOrderColumns = true;
            this.dataGridItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridItemVenda.AutoGenerateColumns = false;
            this.dataGridItemVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItemVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.idVendaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn});
            this.dataGridItemVenda.DataSource = this.itemVendaBindingSource;
            this.dataGridItemVenda.Location = new System.Drawing.Point(12, 203);
            this.dataGridItemVenda.Name = "dataGridItemVenda";
            this.dataGridItemVenda.Size = new System.Drawing.Size(502, 183);
            this.dataGridItemVenda.TabIndex = 8;
            this.dataGridItemVenda.Click += new System.EventHandler(this.EditarItemVenda_Click);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataMember = "Item_Venda";
            this.itemVendaBindingSource.DataSource = this.projetoCNETDataSet3;
            // 
            // projetoCNETDataSet3
            // 
            this.projetoCNETDataSet3.DataSetName = "projetoCNETDataSet3";
            this.projetoCNETDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalvarItemVenda
            // 
            this.btnSalvarItemVenda.Location = new System.Drawing.Point(80, 158);
            this.btnSalvarItemVenda.Name = "btnSalvarItemVenda";
            this.btnSalvarItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarItemVenda.TabIndex = 9;
            this.btnSalvarItemVenda.Text = "Salvar";
            this.btnSalvarItemVenda.UseVisualStyleBackColor = true;
            this.btnSalvarItemVenda.Click += new System.EventHandler(this.btnSalvarItemVenda_Click);
            // 
            // btnExcluirItemVenda
            // 
            this.btnExcluirItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirItemVenda.Location = new System.Drawing.Point(439, 158);
            this.btnExcluirItemVenda.Name = "btnExcluirItemVenda";
            this.btnExcluirItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItemVenda.TabIndex = 10;
            this.btnExcluirItemVenda.Text = "Excluir";
            this.btnExcluirItemVenda.UseVisualStyleBackColor = true;
            this.btnExcluirItemVenda.Click += new System.EventHandler(this.btnExcluirItemVenda_Click);
            // 
            // item_VendaTableAdapter
            // 
            this.item_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // DataVenda
            // 
            this.DataVenda.AutoSize = true;
            this.DataVenda.Location = new System.Drawing.Point(15, 80);
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.Size = new System.Drawing.Size(36, 13);
            this.DataVenda.TabIndex = 11;
            this.DataVenda.Text = "(Data)";
            // 
            // FormItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 398);
            this.Controls.Add(this.DataVenda);
            this.Controls.Add(this.btnExcluirItemVenda);
            this.Controls.Add(this.btnSalvarItemVenda);
            this.Controls.Add(this.dataGridItemVenda);
            this.Controls.Add(this.inputValorUnitarioItemVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputQuantidadeItemVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdVenda);
            this.Controls.Add(this.comboBoxIdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormItemVenda";
            this.Text = "Item de venda";
            this.Load += new System.EventHandler(this.Item_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdProduto;
        private System.Windows.Forms.ComboBox comboBoxIdVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputQuantidadeItemVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputValorUnitarioItemVenda;
        private System.Windows.Forms.DataGridView dataGridItemVenda;
        private System.Windows.Forms.Button btnSalvarItemVenda;
        private System.Windows.Forms.Button btnExcluirItemVenda;
        private projetoCNETDataSet3 projetoCNETDataSet3;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private projetoCNETDataSet3TableAdapters.Item_VendaTableAdapter item_VendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label DataVenda;
    }
}
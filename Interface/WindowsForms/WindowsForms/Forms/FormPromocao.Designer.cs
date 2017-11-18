namespace WindowsForms.Forms
{
    partial class FormPromocao
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
            this.valorDesconto = new System.Windows.Forms.Label();
            this.inputValorDescontoPromocao = new System.Windows.Forms.TextBox();
            this.dataGridPromocao = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promocaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoCNETDataSet4 = new WindowsForms.projetoCNETDataSet4();
            this.promocaoTableAdapter = new WindowsForms.projetoCNETDataSet4TableAdapters.PromocaoTableAdapter();
            this.salvarPromocao = new System.Windows.Forms.Button();
            this.excluirPromocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // valorDesconto
            // 
            this.valorDesconto.AutoSize = true;
            this.valorDesconto.Location = new System.Drawing.Point(13, 13);
            this.valorDesconto.Name = "valorDesconto";
            this.valorDesconto.Size = new System.Drawing.Size(80, 13);
            this.valorDesconto.TabIndex = 0;
            this.valorDesconto.Text = "Valor Desconto";
            // 
            // inputValorDescontoPromocao
            // 
            this.inputValorDescontoPromocao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputValorDescontoPromocao.Location = new System.Drawing.Point(99, 10);
            this.inputValorDescontoPromocao.Name = "inputValorDescontoPromocao";
            this.inputValorDescontoPromocao.Size = new System.Drawing.Size(247, 20);
            this.inputValorDescontoPromocao.TabIndex = 1;
            // 
            // dataGridPromocao
            // 
            this.dataGridPromocao.AllowUserToAddRows = false;
            this.dataGridPromocao.AllowUserToOrderColumns = true;
            this.dataGridPromocao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPromocao.AutoGenerateColumns = false;
            this.dataGridPromocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPromocao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valorDescontoDataGridViewTextBoxColumn});
            this.dataGridPromocao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridPromocao.DataSource = this.promocaoBindingSource;
            this.dataGridPromocao.Location = new System.Drawing.Point(11, 96);
            this.dataGridPromocao.Name = "dataGridPromocao";
            this.dataGridPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPromocao.Size = new System.Drawing.Size(335, 179);
            this.dataGridPromocao.TabIndex = 2;
            this.dataGridPromocao.Click += new System.EventHandler(this.EditarPromocao_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDescontoDataGridViewTextBoxColumn
            // 
            this.valorDescontoDataGridViewTextBoxColumn.DataPropertyName = "ValorDesconto";
            this.valorDescontoDataGridViewTextBoxColumn.HeaderText = "ValorDesconto";
            this.valorDescontoDataGridViewTextBoxColumn.Name = "valorDescontoDataGridViewTextBoxColumn";
            // 
            // promocaoBindingSource
            // 
            this.promocaoBindingSource.DataMember = "Promocao";
            this.promocaoBindingSource.DataSource = this.projetoCNETDataSet4;
            // 
            // projetoCNETDataSet4
            // 
            this.projetoCNETDataSet4.DataSetName = "projetoCNETDataSet4";
            this.projetoCNETDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promocaoTableAdapter
            // 
            this.promocaoTableAdapter.ClearBeforeFill = true;
            // 
            // salvarPromocao
            // 
            this.salvarPromocao.Location = new System.Drawing.Point(16, 53);
            this.salvarPromocao.Name = "salvarPromocao";
            this.salvarPromocao.Size = new System.Drawing.Size(75, 23);
            this.salvarPromocao.TabIndex = 3;
            this.salvarPromocao.Text = "Salvar";
            this.salvarPromocao.UseVisualStyleBackColor = true;
            this.salvarPromocao.Click += new System.EventHandler(this.salvarPromocao_Click);
            // 
            // excluirPromocao
            // 
            this.excluirPromocao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirPromocao.Location = new System.Drawing.Point(272, 52);
            this.excluirPromocao.Name = "excluirPromocao";
            this.excluirPromocao.Size = new System.Drawing.Size(75, 25);
            this.excluirPromocao.TabIndex = 4;
            this.excluirPromocao.Text = "Excluir";
            this.excluirPromocao.UseVisualStyleBackColor = true;
            this.excluirPromocao.Click += new System.EventHandler(this.excluirPromocao_Click);
            // 
            // FormPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 287);
            this.Controls.Add(this.excluirPromocao);
            this.Controls.Add(this.salvarPromocao);
            this.Controls.Add(this.dataGridPromocao);
            this.Controls.Add(this.inputValorDescontoPromocao);
            this.Controls.Add(this.valorDesconto);
            this.Name = "FormPromocao";
            this.Text = "Promoções";
            this.Load += new System.EventHandler(this.Promocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoCNETDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valorDesconto;
        private System.Windows.Forms.TextBox inputValorDescontoPromocao;
        private System.Windows.Forms.DataGridView dataGridPromocao;
        private projetoCNETDataSet4 projetoCNETDataSet4;
        private System.Windows.Forms.BindingSource promocaoBindingSource;
        private projetoCNETDataSet4TableAdapters.PromocaoTableAdapter promocaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salvarPromocao;
        private System.Windows.Forms.Button excluirPromocao;
    }
}
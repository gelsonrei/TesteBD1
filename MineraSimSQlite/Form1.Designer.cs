namespace MineraSimSQlite
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label descSetorLabel;
            System.Windows.Forms.Label descFuncaoLabel;
            System.Windows.Forms.Label dtAdmLabel;
            this.tableAdapterManager = new MineraSimSQlite.MineraSimDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mineraSimDataSet1 = new MineraSimSQlite.MineraSimDataSet();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.descSetorTextBox = new System.Windows.Forms.TextBox();
            this.descFuncaoTextBox = new System.Windows.Forms.TextBox();
            this.dtAdmTextBox = new System.Windows.Forms.TextBox();
            this.tabPageCadastros = new System.Windows.Forms.TabPage();
            this.groupBoxCadPessoa = new System.Windows.Forms.GroupBox();
            this.BtRemoverPessoa = new System.Windows.Forms.Button();
            this.pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvarPessoa = new System.Windows.Forms.Button();
            this.tabPageRelatorios = new System.Windows.Forms.TabPage();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new MineraSimSQlite.MineraSimDataSetTableAdapters.SetorTableAdapter();
            this.funcaoTableAdapter = new MineraSimSQlite.MineraSimDataSetTableAdapters.FuncaoTableAdapter();
            this.pessoaTableAdapter = new MineraSimSQlite.MineraSimDataSetTableAdapters.PessoaTableAdapter();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            descSetorLabel = new System.Windows.Forms.Label();
            descFuncaoLabel = new System.Windows.Forms.Label();
            dtAdmLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineraSimDataSet1)).BeginInit();
            this.tabPageCadastros.SuspendLayout();
            this.groupBoxCadPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(29, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Cód:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(27, 59);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(27, 85);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(37, 13);
            idadeLabel.TabIndex = 4;
            idadeLabel.Text = "Idade:";
            // 
            // descSetorLabel
            // 
            descSetorLabel.AutoSize = true;
            descSetorLabel.Location = new System.Drawing.Point(255, 33);
            descSetorLabel.Name = "descSetorLabel";
            descSetorLabel.Size = new System.Drawing.Size(32, 13);
            descSetorLabel.TabIndex = 8;
            descSetorLabel.Text = "Setor";
            // 
            // descFuncaoLabel
            // 
            descFuncaoLabel.AutoSize = true;
            descFuncaoLabel.Location = new System.Drawing.Point(255, 85);
            descFuncaoLabel.Name = "descFuncaoLabel";
            descFuncaoLabel.Size = new System.Drawing.Size(46, 13);
            descFuncaoLabel.TabIndex = 12;
            descFuncaoLabel.Text = "Funcão:";
            // 
            // dtAdmLabel
            // 
            dtAdmLabel.AutoSize = true;
            dtAdmLabel.Location = new System.Drawing.Point(27, 111);
            dtAdmLabel.Name = "dtAdmLabel";
            dtAdmLabel.Size = new System.Drawing.Size(55, 13);
            dtAdmLabel.TabIndex = 14;
            dtAdmLabel.Text = "Admissão:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.PessoaTableAdapter = null;
            this.tableAdapterManager.SetorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MineraSimSQlite.MineraSimDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInicio);
            this.tabControl1.Controls.Add(this.tabPageCadastros);
            this.tabControl1.Controls.Add(this.tabPageRelatorios);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.Controls.Add(idLabel);
            this.tabPageInicio.Controls.Add(this.idTextBox);
            this.tabPageInicio.Controls.Add(nomeLabel);
            this.tabPageInicio.Controls.Add(this.nomeTextBox);
            this.tabPageInicio.Controls.Add(idadeLabel);
            this.tabPageInicio.Controls.Add(this.idadeTextBox);
            this.tabPageInicio.Controls.Add(descSetorLabel);
            this.tabPageInicio.Controls.Add(this.descSetorTextBox);
            this.tabPageInicio.Controls.Add(descFuncaoLabel);
            this.tabPageInicio.Controls.Add(this.descFuncaoTextBox);
            this.tabPageInicio.Controls.Add(dtAdmLabel);
            this.tabPageInicio.Controls.Add(this.dtAdmTextBox);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 22);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(986, 537);
            this.tabPageInicio.TabIndex = 1;
            this.tabPageInicio.Text = "Início";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(105, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.mineraSimDataSet1;
            // 
            // mineraSimDataSet1
            // 
            this.mineraSimDataSet1.DataSetName = "MineraSimDataSet";
            this.mineraSimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(105, 56);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(328, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "idade", true));
            this.idadeTextBox.Enabled = false;
            this.idadeTextBox.Location = new System.Drawing.Point(105, 82);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeTextBox.TabIndex = 5;
            // 
            // descSetorTextBox
            // 
            this.descSetorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "descSetor", true));
            this.descSetorTextBox.Enabled = false;
            this.descSetorTextBox.Location = new System.Drawing.Point(333, 30);
            this.descSetorTextBox.Name = "descSetorTextBox";
            this.descSetorTextBox.Size = new System.Drawing.Size(100, 20);
            this.descSetorTextBox.TabIndex = 9;
            // 
            // descFuncaoTextBox
            // 
            this.descFuncaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "descFuncao", true));
            this.descFuncaoTextBox.Enabled = false;
            this.descFuncaoTextBox.Location = new System.Drawing.Point(333, 82);
            this.descFuncaoTextBox.Name = "descFuncaoTextBox";
            this.descFuncaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descFuncaoTextBox.TabIndex = 13;
            // 
            // dtAdmTextBox
            // 
            this.dtAdmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "dtAdm", true));
            this.dtAdmTextBox.Enabled = false;
            this.dtAdmTextBox.Location = new System.Drawing.Point(105, 108);
            this.dtAdmTextBox.Name = "dtAdmTextBox";
            this.dtAdmTextBox.Size = new System.Drawing.Size(100, 20);
            this.dtAdmTextBox.TabIndex = 15;
            // 
            // tabPageCadastros
            // 
            this.tabPageCadastros.AutoScroll = true;
            this.tabPageCadastros.Controls.Add(this.groupBoxCadPessoa);
            this.tabPageCadastros.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastros.Name = "tabPageCadastros";
            this.tabPageCadastros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastros.Size = new System.Drawing.Size(986, 537);
            this.tabPageCadastros.TabIndex = 0;
            this.tabPageCadastros.Text = "Cadastros";
            this.tabPageCadastros.UseVisualStyleBackColor = true;
            // 
            // groupBoxCadPessoa
            // 
            this.groupBoxCadPessoa.AutoSize = true;
            this.groupBoxCadPessoa.Controls.Add(this.BtRemoverPessoa);
            this.groupBoxCadPessoa.Controls.Add(this.pessoaDataGridView);
            this.groupBoxCadPessoa.Controls.Add(this.btEditar);
            this.groupBoxCadPessoa.Controls.Add(this.btSalvarPessoa);
            this.groupBoxCadPessoa.Location = new System.Drawing.Point(8, 6);
            this.groupBoxCadPessoa.Name = "groupBoxCadPessoa";
            this.groupBoxCadPessoa.Size = new System.Drawing.Size(989, 380);
            this.groupBoxCadPessoa.TabIndex = 1;
            this.groupBoxCadPessoa.TabStop = false;
            this.groupBoxCadPessoa.Text = "Colaboradores";
            // 
            // BtRemoverPessoa
            // 
            this.BtRemoverPessoa.Location = new System.Drawing.Point(456, 264);
            this.BtRemoverPessoa.Name = "BtRemoverPessoa";
            this.BtRemoverPessoa.Size = new System.Drawing.Size(75, 23);
            this.BtRemoverPessoa.TabIndex = 4;
            this.BtRemoverPessoa.Text = "Remover";
            this.BtRemoverPessoa.UseVisualStyleBackColor = true;
            this.BtRemoverPessoa.Click += new System.EventHandler(this.BtRemoverPessoa_Click);
            // 
            // pessoaDataGridView
            // 
            this.pessoaDataGridView.AutoGenerateColumns = false;
            this.pessoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pessoaDataGridView.DataSource = this.pessoaBindingSource;
            this.pessoaDataGridView.Location = new System.Drawing.Point(11, 19);
            this.pessoaDataGridView.Name = "pessoaDataGridView";
            this.pessoaDataGridView.ReadOnly = true;
            this.pessoaDataGridView.Size = new System.Drawing.Size(958, 220);
            this.pessoaDataGridView.TabIndex = 3;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(7, 264);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSalvarPessoa
            // 
            this.btSalvarPessoa.Location = new System.Drawing.Point(894, 265);
            this.btSalvarPessoa.Name = "btSalvarPessoa";
            this.btSalvarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btSalvarPessoa.TabIndex = 2;
            this.btSalvarPessoa.Text = "Salvar";
            this.btSalvarPessoa.UseVisualStyleBackColor = true;
            this.btSalvarPessoa.Click += new System.EventHandler(this.btSalvarPessoa_Click);
            // 
            // tabPageRelatorios
            // 
            this.tabPageRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelatorios.Name = "tabPageRelatorios";
            this.tabPageRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelatorios.Size = new System.Drawing.Size(986, 537);
            this.tabPageRelatorios.TabIndex = 2;
            this.tabPageRelatorios.Text = "Relatórios";
            this.tabPageRelatorios.UseVisualStyleBackColor = true;
            // 
            // setorTableAdapter
            // 
            this.setorTableAdapter.ClearBeforeFill = true;
            // 
            // funcaoTableAdapter
            // 
            this.funcaoTableAdapter.ClearBeforeFill = true;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descSetor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Setor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "descFuncao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Função";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dtAdm";
            this.dataGridViewTextBoxColumn8.HeaderText = "Admissão";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MineraSimSQLite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPageInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineraSimDataSet1)).EndInit();
            this.tabPageCadastros.ResumeLayout(false);
            this.tabPageCadastros.PerformLayout();
            this.groupBoxCadPessoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MineraSimDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCadastros;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageRelatorios;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private MineraSimDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private MineraSimDataSetTableAdapters.FuncaoTableAdapter funcaoTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCadPessoa;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvarPessoa;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private MineraSimDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private MineraSimDataSet mineraSimDataSet1;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private System.Windows.Forms.Button BtRemoverPessoa;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox descSetorTextBox;
        private System.Windows.Forms.TextBox descFuncaoTextBox;
        private System.Windows.Forms.TextBox dtAdmTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}


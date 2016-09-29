using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineraSimSQlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mineraSimDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mineraSimDataSet1.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.mineraSimDataSet1.Pessoa);
            // TODO: This line of code loads data into the 'mineraSimDataSet.Funcao' table. You can move, or remove it, as needed.
            this.funcaoTableAdapter.Fill(this.mineraSimDataSet1.Funcao);
            // TODO: This line of code loads data into the 'mineraSimDataSet.Setor' table. You can move, or remove it, as needed.
            this.setorTableAdapter.Fill(this.mineraSimDataSet1.Setor);
            // TODO: This line of code loads data into the 'mineraSimDataSet.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.mineraSimDataSet1.Pessoa);

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (btEditar.Text == "Cancelar")
                this.pessoaTableAdapter.Fill(this.mineraSimDataSet1.Pessoa);


            pessoaDataGridView.ReadOnly = !pessoaDataGridView.ReadOnly;

            if (pessoaDataGridView.ReadOnly)
            {
                btEditar.Text = "Editar";
            }
            else
            {
                btEditar.Text = "Cancelar";
            }
        }

        private void btSalvarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pessoaBindingSource.EndEdit();
                this.pessoaTableAdapter.Update(this.mineraSimDataSet1.Pessoa);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void BtRemoverPessoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remover");
        }
    }
}

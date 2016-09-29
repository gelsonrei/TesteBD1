using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBD1
{
    public partial class MineraSimForm : Form
    {
        public MineraSimForm()
        {
            InitializeComponent();
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.database1DataSet.Empresa);
            // TODO: This line of code loads data into the 'database1DataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.database1DataSet.Area);
            // TODO: This line of code loads data into the 'database1DataSet.Funcao' table. You can move, or remove it, as needed.
            this.funcaoTableAdapter.Fill(this.database1DataSet.Funcao);
            // TODO: This line of code loads data into the 'database1DataSet.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.database1DataSet.Pessoa);


        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

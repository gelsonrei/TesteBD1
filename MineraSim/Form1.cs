using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineraSim
{
    public partial class MineraSimForm : Form
    {
        public MineraSimForm()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        private void MineraSimForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mineraSimDataSet.Setor' table. You can move, or remove it, as needed.
            this.setorTableAdapter.Fill(this.mineraSimDataSet.Setor);
            // TODO: This line of code loads data into the 'mineraSimDataSet.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.mineraSimDataSet.Pessoa);


        }

    }
}

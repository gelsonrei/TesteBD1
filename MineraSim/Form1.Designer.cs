using System;

namespace MineraSim
{
    partial class MineraSimForm
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPageSim = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSair = new System.Windows.Forms.Button();
            this.btAvancar = new System.Windows.Forms.Button();
            this.tabPageCad = new System.Windows.Forms.TabPage();
            this.setorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mineraSimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageRel = new System.Windows.Forms.TabPage();
            this.tab1.SuspendLayout();
            this.tabPageSim.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineraSimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPageSim);
            this.tab1.Controls.Add(this.tabPageCad);
            this.tab1.Controls.Add(this.tabPageRel);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Font = new System.Drawing.Font("Intro Light Alt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.ItemSize = new System.Drawing.Size(100, 18);
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Drawing.Point(8, 3);
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(725, 530);
            this.tab1.TabIndex = 1;
            // 
            // tabPageSim
            // 
            this.tabPageSim.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSim.Font = new System.Drawing.Font("Intro ", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSim.ForeColor = System.Drawing.Color.CadetBlue;
            this.tabPageSim.Location = new System.Drawing.Point(4, 22);
            this.tabPageSim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSim.Name = "tabPageSim";
            this.tabPageSim.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageSim.Size = new System.Drawing.Size(717, 504);
            this.tabPageSim.TabIndex = 0;
            this.tabPageSim.Text = "Simulação";
            this.tabPageSim.ToolTipText = "Simulação";
            this.tabPageSim.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::MineraSim.Properties.Resources.Telas1;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75034F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.94573F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.527816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45862F));
            this.tableLayoutPanel1.Controls.Add(this.btSair, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btAvancar, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.58333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.958333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.BackgroundImage = global::MineraSim.Properties.Resources.btSairImg;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.CadetBlue;
            this.btSair.Location = new System.Drawing.Point(229, 401);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(133, 46);
            this.btSair.TabIndex = 0;
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btAvancar.BackgroundImage = global::MineraSim.Properties.Resources.btAvancarImg;
            this.btAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAvancar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.ForeColor = System.Drawing.Color.CadetBlue;
            this.btAvancar.Location = new System.Drawing.Point(395, 401);
            this.btAvancar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(121, 46);
            this.btAvancar.TabIndex = 1;
            this.btAvancar.UseVisualStyleBackColor = false;
            // 
            // tabPageCad
            // 
            this.tabPageCad.AutoScroll = true;
            this.tabPageCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCad.Location = new System.Drawing.Point(4, 22);
            this.tabPageCad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCad.Name = "tabPageCad";
            this.tabPageCad.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCad.Size = new System.Drawing.Size(717, 504);
            this.tabPageCad.TabIndex = 1;
            this.tabPageCad.Text = "Cadastros";
            this.tabPageCad.UseVisualStyleBackColor = true;
            // 
            // setorBindingSource1
            // 
            this.setorBindingSource1.DataMember = "Setor";
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataMember = "Setor";
            this.setorBindingSource.DataSource = this.mineraSimDataSetBindingSource;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            // 
            // tabPageRel
            // 
            this.tabPageRel.BackgroundImage = global::MineraSim.Properties.Resources.Telas__Medium_;
            this.tabPageRel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageRel.Location = new System.Drawing.Point(4, 22);
            this.tabPageRel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRel.Name = "tabPageRel";
            this.tabPageRel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRel.Size = new System.Drawing.Size(717, 504);
            this.tabPageRel.TabIndex = 2;
            this.tabPageRel.Text = "Relatórios";
            this.tabPageRel.UseVisualStyleBackColor = true;
            // 
            // MineraSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 530);
            this.Controls.Add(this.tab1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Intro Light Alt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MineraSimForm";
            this.ShowIcon = false;
            this.Text = "MineraSIm";
            this.Load += new System.EventHandler(this.MineraSimForm_Load);
            this.tab1.ResumeLayout(false);
            this.tabPageSim.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineraSimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPageSim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.TabPage tabPageCad;
        private System.Windows.Forms.TabPage tabPageRel;
        private MineraSimDataSet mineraSimDataSet;
        private System.Windows.Forms.BindingSource mineraSimDataSetBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private MineraSimDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private MineraSimDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MineraSimDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource setorBindingSource1;
    }
}


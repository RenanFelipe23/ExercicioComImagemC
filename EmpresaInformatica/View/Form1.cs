using EmpresaInformatica.Controller.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaInformatica
{
    public partial class Form1 : Form
    {
        private int IdGeral{get;set;}
        private IItenscontroller controller;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                controller.InserirRegistro(TxtDescricao.Text);
                LimpaCampos();
            }
        }

        private void CarregaDados()
        {
            dataGridView1.DataSource = controller.RetornaLista();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdGeral = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            TxtDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void LimpaCampos()
        {
            TxtDescricao.Text = "";
        }
        private bool ValidaCampos()
        {
            if (TxtDescricao.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv_CastGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            listCadastro.Items.Add(txtNome.Text +" | "+ txtSobrenome.Text +" | "+ txtCPF.Text +" | "+ txtEmail.Text);
            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            listCadastro.Items.RemoveAt(listCadastro.SelectedIndex);
        }
    }
}

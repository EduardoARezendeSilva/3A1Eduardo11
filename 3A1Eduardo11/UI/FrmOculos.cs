using _3A1Eduardo11.CODE.BLL;
using _3A1Eduardo11.CODE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1Eduardo11.UI
{
    public partial class FrmOculos : Form
    {
        OculosBLL oculosBLL = new OculosBLL();
        OculosDTO oculosDTO = new OculosDTO(); 

        public FrmOculos()
        {
            InitializeComponent();
            Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtCategoria.Text != "" || txtValor.Text != "" || txtLancamento.Text != "")
            {
                txtValor.Text = txtValor.Text.Replace(",", ".");
                oculosDTO.nome = txtNome.Text;
                oculosDTO.categoria = txtCategoria.Text;
                oculosDTO.valor = txtValor.Text;
                oculosDTO.lancamento = txtLancamento.Text;
                oculosBLL.Inserir(oculosDTO);
                Listar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtCategoria.Text != "" || txtValor.Text != "" || txtLancamento.Text != "")
            {
                txtValor.Text = txtValor.Text.Replace(",", ".");
                oculosDTO.id = int.Parse(txtNome.Tag.ToString());
                oculosDTO.nome = txtNome.Text;
                oculosDTO.categoria = txtCategoria.Text;
                oculosDTO.valor = txtValor.Text;
                oculosDTO.lancamento = txtLancamento.Text;
                oculosBLL.Alterar(oculosDTO);
                Listar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            oculosDTO.id = int.Parse(txtNome.Tag.ToString());
            oculosBLL.Deletar(oculosDTO);
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtNome.Tag = "";
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtValor.Text = "";
            txtLancamento.Text = "";
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        public void Listar()
        {
            Limpar();
            dtgOculos.DataSource = oculosBLL.Listar();
        }

        private void dtgOculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgOculos.Rows[e.RowIndex].Cells[0].Value.ToString() != ""
            && dtgOculos.Rows[e.RowIndex].Cells[1].Value.ToString() != ""
            && dtgOculos.Rows[e.RowIndex].Cells[2].Value.ToString() != ""
            && dtgOculos.Rows[e.RowIndex].Cells[3].Value.ToString() != ""
            && dtgOculos.Rows[e.RowIndex].Cells[4].Value.ToString() != "")
            {
                txtNome.Tag = dtgOculos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgOculos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCategoria.Text = dtgOculos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dtgOculos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLancamento.Text = dtgOculos.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnAlterar.Enabled = true;
                btnDeletar.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

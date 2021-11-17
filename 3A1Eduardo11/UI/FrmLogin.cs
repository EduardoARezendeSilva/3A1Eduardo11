using _3A1Eduardo11.CODE.BLL;
using _3A1Eduardo11.CODE.DTO;
using _3A1Eduardo11.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1Eduardo11
{
    public partial class FrmLogin : Form
    {
        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        FrmOculos frmOculos = new FrmOculos();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" || txtSenha.Text != "")
            {
                loginDTO.email = txtEmail.Text;
                loginDTO.senha = txtSenha.Text;

                DataTable dt = loginBLL.Login(loginDTO);

                if (dt.Rows.Count > 0)
                {
                    frmOculos.Show();
                    frmOculos.Text = $"Oculos - {dt.Rows[0].ItemArray[1].ToString()}";
                }
                else
                {
                    MessageBox.Show("Dados Para login invalido!!!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!");
            }
        }
    }
}

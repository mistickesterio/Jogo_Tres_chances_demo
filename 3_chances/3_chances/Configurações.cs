using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_chances
{
    public partial class frmConfiguracoes : Form
    {
        Form corfundo;
        public frmConfiguracoes(Form corFundo)
        {
            InitializeComponent();
            corfundo = corFundo;
        }

        private void btn_claro_Click(object sender, EventArgs e)
        {
            corfundo.BackColor = Color.Orange;
            this.BackColor = Color.Orange;
        }

        private void btn_escuro_Click(object sender, EventArgs e)
        {
            corfundo.BackColor = Color.DarkCyan;
            this.BackColor = Color.DarkCyan;
        }

        private void btn_Padrão_Click(object sender, EventArgs e)
        {
            corfundo.BackColor = Color.MediumSlateBlue;
            this.BackColor = Color.MediumSlateBlue;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            if (txt_senha.Text == "#")
            {
                btn_zerar.Visible = true;
                MessageBox.Show("Adiministrador você tem certeza em realizar essa ação?");
            }
            else
            {
                btn_zerar.Visible = false;
                txt_senha.Text = "";
            }
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            try
            {
                Jogador usu = new Jogador();

                object retorno = usu.deletar();

                MessageBox.Show("DADOS EXCLUIDOS");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

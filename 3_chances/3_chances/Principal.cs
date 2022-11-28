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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            string nome = txt_Jogador.Text;

            //processamento

            string cliente = nome.Length > 10
                      ? nome.Substring(0, 10)
                      : nome;

            if (cliente == "")
            {
                MessageBox.Show("Digite o jogador");
            }
            else
            {
                try
                {
                    Jogador usu = new Jogador();
                    usu.Jogador_usu1 = cliente;

                    object retorno = usu.Inserir();

                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Jogador salvo");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                frmSelecaodejogo frmselecaodejogo = new frmSelecaodejogo(this);
                frmselecaodejogo.ShowDialog();
            }
            
        }

        private void btn_configuracaos_Click(object sender, EventArgs e)
        {
            frmConfiguracoes frmconfiguracoes = new frmConfiguracoes(this);
            frmconfiguracoes.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btn_Regras_Click(object sender, EventArgs e)
        {
            frmRegras frm_regras = new frmRegras(this);
            frm_regras.ShowDialog();
        }
    }
}

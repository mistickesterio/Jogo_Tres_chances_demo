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
    public partial class frmSelecaodejogo : Form
    {
        public frmSelecaodejogo(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
        }

        private void btn_comidas_Click(object sender, EventArgs e)
        {
            frm_Comidas_seleção frm_comidas_seleção = new frm_Comidas_seleção(this);
            frm_comidas_seleção.ShowDialog();
        }

        private void btn_cores_Click(object sender, EventArgs e)
        {
            frm_Cores_seleção frm_cores_seleção = new frm_Cores_seleção(this);
            frm_cores_seleção.ShowDialog();
        }

        private void btn_lugares_Click(object sender, EventArgs e)
        {
            frm_Lugares_seleção frm_lugares_seleção = new frm_Lugares_seleção(this);
            frm_lugares_seleção.ShowDialog();
        }

        private void btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_desenhos_Click(object sender, EventArgs e)
        {
            frm_Desenhos_selecao frm_Desenhos_Selecao = new frm_Desenhos_selecao();
            frm_Desenhos_Selecao.ShowDialog();
        }

        private void btn_monstros_Click(object sender, EventArgs e)
        {
            frm_Monstros_selecao frm_Monstros_Selecao = new frm_Monstros_selecao();
            frm_Monstros_Selecao.ShowDialog();
        }

        private void btn_filmes_Click(object sender, EventArgs e)
        {
            frm_Fimes_selecao frm_Fimes_Selecao = new frm_Fimes_selecao();
            frm_Fimes_Selecao.ShowDialog();
        }

        private void btn_profissoes_Click(object sender, EventArgs e)
        {
            frm_Profissoes_selecao frm_Profissoes_Selecao = new frm_Profissoes_selecao();
            frm_Profissoes_Selecao.ShowDialog();
        }

        private void btn_esportes_Click(object sender, EventArgs e)
        {
            frm_Esportes_selecao frm_Esportes_Selecao = new frm_Esportes_selecao();
            frm_Esportes_Selecao.ShowDialog();
        }

        private void btn_jogos_Click(object sender, EventArgs e)
        {
            frm_Jogos_selecao frm_Jogos_Selecao = new frm_Jogos_selecao();
            frm_Jogos_Selecao.ShowDialog();
        }
    }
}

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
    public partial class frm_Profissoes_selecao : Form
    {
        public frm_Profissoes_selecao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_profissoes_facil_Click(object sender, EventArgs e)
        {
            frm_Profissoes_facil frm_Profissoes_Facil = new frm_Profissoes_facil();
            frm_Profissoes_Facil.ShowDialog();
        }

        private void btn_profissoes_medio_Click(object sender, EventArgs e)
        {
            frm_Profissoes_Medio frm_Profissoes_Medio = new frm_Profissoes_Medio();
            frm_Profissoes_Medio.ShowDialog();
        }

        private void btn_profissoes_dificil_Click(object sender, EventArgs e)
        {
            frm_Profissoes_dificil frm_Profissoes_Dificil = new frm_Profissoes_dificil();
            frm_Profissoes_Dificil.ShowDialog();
        }
    }
}

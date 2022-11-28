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
    public partial class frm_Jogos_selecao : Form
    {
        public frm_Jogos_selecao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Jogos_facil_Click(object sender, EventArgs e)
        {
            frm_Jogos_facil frm_Jogos_Facil = new frm_Jogos_facil();
            frm_Jogos_Facil.ShowDialog();
        }

        private void btn_Jogos_medio_Click(object sender, EventArgs e)
        {
            frm_Jogos_Medio frm_Jogos_Medio = new frm_Jogos_Medio();
            frm_Jogos_Medio.ShowDialog();
        }

        private void btn_Jogos_dificil_Click(object sender, EventArgs e)
        {
            frm_Jogos_dificil frm_Jogos_Dificil = new frm_Jogos_dificil();
            frm_Jogos_Dificil.ShowDialog();
        }
    }
}

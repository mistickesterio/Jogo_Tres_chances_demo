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
    public partial class frm_Fimes_selecao : Form
    {
        public frm_Fimes_selecao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filmes_facil_Click(object sender, EventArgs e)
        {
            frm_Filmes_facil frm_Filmes_Facil = new frm_Filmes_facil();
            frm_Filmes_Facil.ShowDialog();
        }

        private void btn_filmess_medio_Click(object sender, EventArgs e)
        {
            frm_Filmes_Medio frm_Filmes_Medio = new frm_Filmes_Medio();
            frm_Filmes_Medio.ShowDialog();
        }

        private void btn_filmes_dificil_Click(object sender, EventArgs e)
        {
            frm_Filmes_Dificil frm_Filmes_Dificil = new frm_Filmes_Dificil();
            frm_Filmes_Dificil.ShowDialog();
        }
    }
}

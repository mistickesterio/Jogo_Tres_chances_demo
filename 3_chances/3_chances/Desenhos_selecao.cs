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
    public partial class frm_Desenhos_selecao : Form
    {
        public frm_Desenhos_selecao()
        {
            InitializeComponent();
        }

        private void btn_desenhos_facil_Click(object sender, EventArgs e)
        {
            frm_Desenhos_facil frm_Desenhos_Facil = new frm_Desenhos_facil();
            frm_Desenhos_Facil.ShowDialog();
        }

        private void btn_desenhos_medio_Click(object sender, EventArgs e)
        {
            frm_Desenhos_Medio frm_Desenhos_Medio = new frm_Desenhos_Medio();
            frm_Desenhos_Medio.ShowDialog();
        }

        private void btn_desenhos_dificil_Click(object sender, EventArgs e)
        {
            frm_Desenhos_Dificil frm_Desenhos_Dificil = new frm_Desenhos_Dificil();
            frm_Desenhos_Dificil.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

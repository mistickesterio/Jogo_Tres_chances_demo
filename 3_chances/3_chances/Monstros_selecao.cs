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
    public partial class frm_Monstros_selecao : Form
    {
        public frm_Monstros_selecao()
        {
            InitializeComponent();
        }

        private void btn_desenhos_facil_Click(object sender, EventArgs e)
        {
            frm_Monstros_facil frm_Monstros_Facil = new frm_Monstros_facil();
            frm_Monstros_Facil.ShowDialog();
        }

        private void btn_desenhos_medio_Click(object sender, EventArgs e)
        {
            frm_Monstros_Medio frm_Monstros_Medio = new frm_Monstros_Medio();
            frm_Monstros_Medio.ShowDialog();
        }

        private void btn_desenhos_dificil_Click(object sender, EventArgs e)
        {
            frm_Monstros_Dificil frm_Monstros_Dificil = new frm_Monstros_Dificil();
            frm_Monstros_Dificil.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frm_Cores_seleção : Form
    {
        public frm_Cores_seleção(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cores_facil_Click(object sender, EventArgs e)
        {
            frm_Cores_facil frm_cores_facil = new frm_Cores_facil(this);
            frm_cores_facil.ShowDialog();
        }

        private void btn_cores_medio_Click(object sender, EventArgs e)
        {
            frm_Cores_Medio frm_cores_Medio = new frm_Cores_Medio(this);
            frm_cores_Medio.ShowDialog();
        }

        private void btn_cores_dificil_Click(object sender, EventArgs e)
        {
            frm_Cores_Dificil frm_cores_Dificil = new frm_Cores_Dificil(this);
            frm_cores_Dificil.ShowDialog();
        }
    }
}

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
    public partial class frm_Comidas_seleção : Form
    {
        public frm_Comidas_seleção(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
            //lbl_Jogador_1_Comida.Text = VariaveisGlobais.JFcomidas.ToString();
            //lbl_Jogador_2_Comida.Text = VariaveisGlobais.JFcomidas.ToString();
            //lbl_Jogador_3_Comida.Text = VariaveisGlobais.JFcomidas.ToString();

        }

        private void btn_Comidas_Facil_Click(object sender, EventArgs e)
        {
            frm_Comidas_facil frm_comidas_facil = new frm_Comidas_facil(this);
            frm_comidas_facil.ShowDialog();
        }

        private void btn_Comidas_Medio_Click(object sender, EventArgs e)
        {
            frm_Comidas_Medio frm_comidas_Medio = new frm_Comidas_Medio(this);
            frm_comidas_Medio.ShowDialog();
        }

        private void btn_Comidas_Dificil_Click(object sender, EventArgs e)
        {
            frm_Comidas_Dificil frm_comidas_Dificil = new frm_Comidas_Dificil(this);
            frm_comidas_Dificil.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    namespace create_global_variable
    {
        public static class Global
        {
            public static string PontoJogador1;
        }
        class Program
        {
            static void Main(int[] args)
            {
                Global.PontoJogador1 = "0";
                Console.WriteLine(Global.PontoJogador1);
            }
        }
    }
}

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
    public partial class frm_Comidas_facil : Form
    {
        public frm_Comidas_facil(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
            txt1.MaxLength = 1;
            txt2.MaxLength = 1;
            txt3.MaxLength = 1;
            txt4.MaxLength = 1;
            txt5.MaxLength = 1;
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Normalmente redonda";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if (txt1.Enabled == true)
            {
                txt1.Text = "";
                txt1.BackColor = Color.Empty;
            }
            if (txt2.Enabled == true)
            {
                txt2.Text = "";
                txt2.BackColor = Color.Empty;
            }
            if (txt3.Enabled == true)
            {
                txt3.Text = "";
                txt3.BackColor = Color.Empty;
            }
            if (txt4.Enabled == true)
            {
                txt4.Text = "";
                txt4.BackColor = Color.Empty;
            }
            if (txt5.Enabled == true)
            {
                txt5.Text = "";
                txt5.BackColor = Color.Empty;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);

            if (l1 == "T")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else
            {
                txt1.BackColor = Color.Red;
                txt1.Text = "";
                if (l1 =="T" || l1 == "O" || l1 == "R" || l1 == "A")
                {
                }
                else
                {
                    txt_erros.Text += l1 + " ";
                }
            }

            if (l2 == "O")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else
            {
                txt2.BackColor = Color.Red;
                txt2.Text = "";
                if (l2 == "T" || l2 == "O" || l2 == "R" || l2 == "A")
                {
                }
                else
                {
                    txt_erros.Text += l2 + " ";
                }
            }

            if (l3 == "R")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else
            {
                txt3.BackColor = Color.Red;
                txt3.Text = "";
                if (l3 == "T" || l3 == "O" || l3 == "R" || l3 == "A")
                {
                }
                else
                {
                    txt_erros.Text += l3 + " ";
                }
            }

            if (l4 == "T")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else
            {
                txt4.BackColor = Color.Red;
                txt4.Text = "";
                if (l4 == "T" || l4 == "O" || l4 == "R" || l4 == "A")
                {
                }
                else
                {
                    txt_erros.Text += l4 + " ";
                }
            }

            if (l5 == "A")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else
            {
                txt5.BackColor = Color.Red;
                txt5.Text = "";
                if (l5 == "T" || l5 == "O" || l5 == "R" || l5 == "A")
                {
                }
                else
                {
                    txt_erros.Text += l5 + " ";
                }
            }

            if (l1 == "T" && l2 == "O" && l3 == "R" && l4 == "T" && l5 == "A")
            {
                btn_Avancar.Visible = true;
            }

            else if (pic_coracao5.Visible == true)
            {
                pic_coracao5.Visible = false;
                pic_tubarao5.Visible = true;
            }

            else if (pic_coracao4.Visible == true)
            {
                pic_coracao4.Visible = false;
                pic_tubarao4.Visible = true;
            }

            else if (pic_coracao3.Visible == true)
            {
                pic_coracao3.Visible = false;
                pic_tubarao3.Visible = true;
            }

            else if (pic_coracao2.Visible == true)
            {
                pic_coracao2.Visible = false;
                pic_tubarao2.Visible = true;
            }

            else if (pic_coracao1.Visible == true)
            {
                pic_coracao1.Visible = false;
                pic_tubarao1.Visible = true;
            }

            else
            {
                this.Close();
            }
        }

        private void Btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Avancar_Click(object sender, EventArgs e)
        {
            frm_Comidas_Medio frm_comidas_Medio = new frm_Comidas_Medio(this);
            frm_comidas_Medio.ShowDialog();
            this.Close();
        }

        private void Frm_Comidas_facil_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frm_Lugares_Facil : Form
    {
        public frm_Lugares_Facil(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6, l7, l8;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);
            l7 = Convert.ToString(txt7.Text);
            l8 = Convert.ToString(txt8.Text);

            if (l1 == "C")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else
            {
                txt1.BackColor = Color.Red;
                txt1.Text = "";
                txt_erros.Text += l1 + " ";
            }

            if (l2 == "U")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else
            {
                txt2.BackColor = Color.Red;
                txt2.Text = "";
                txt_erros.Text += l2 + " ";

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
                txt_erros.Text += l3 + " ";

            }

            if (l4 == "I")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else
            {
                txt4.BackColor = Color.Red;
                txt4.Text = "";
                txt_erros.Text += l4 + " ";

            }

            if (l5 == "T")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else
            {
                txt5.BackColor = Color.Red;
                txt5.Text = "";
                txt_erros.Text += l5 + " ";

            }

            if (l6 == "I")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else
            {
                txt6.BackColor = Color.Red;
                txt6.Text = "";
                txt_erros.Text += l6 + " ";

            }

            if (l7 == "B")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else
            {
                txt7.BackColor = Color.Red;
                txt7.Text = "";
                txt_erros.Text += l7 + " ";

            }

            if (l8 == "A")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else
            {
                txt8.BackColor = Color.Red;
                txt8.Text = "";
                txt_erros.Text += l8 + " ";

            }

            if (l1 == "C" && l2 == "U" && l3 == "R" && l4 == "I" && l5 == "T" && l6 == "I" && l7 == "B" && l8 == "A")
            {

            }

            else
            {
                if (pic_coracao5.Visible == true)
                {
                    pic_coracao5.Visible = false;
                    pic_tubarao5.Visible = true;
                }

                else
                {
                    if (pic_coracao4.Visible == true)
                    {
                        pic_coracao4.Visible = false;
                        pic_tubarao4.Visible = true;
                    }

                    else
                    {
                        if (pic_coracao3.Visible == true)
                        {
                            pic_coracao3.Visible = false;
                            pic_tubarao3.Visible = true;
                        }

                        else
                        {
                            if (pic_coracao2.Visible == true)
                            {
                                pic_coracao2.Visible = false;
                                pic_tubarao2.Visible = true;
                            }

                            else
                            {
                                if (pic_coracao1.Visible == true)
                                {
                                    pic_coracao1.Visible = false;
                                    pic_tubarao1.Visible = true;
                                }

                                else
                                {
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt1.BackColor = Color.Empty;
            txt1.Enabled = true;
            txt2.Text = "";
            txt2.BackColor = Color.Empty;
            txt2.Enabled = true;
            txt3.Text = "";
            txt3.BackColor = Color.Empty;
            txt3.Enabled = true;
            txt4.Text = "";
            txt4.BackColor = Color.Empty;
            txt4.Enabled = true;
            txt5.Text = "";
            txt5.BackColor = Color.Empty;
            txt5.Enabled = true;
            txt6.Text = "";
            txt6.BackColor = Color.Empty;
            txt6.Enabled = true;
            txt7.Text = "";
            txt7.BackColor = Color.Empty;
            txt7.Enabled = true;
            txt8.Text = "";
            txt8.BackColor = Color.Empty;
            txt8.Enabled = true;
            lbl_dicas.Text = "Dica:???";
            lbl_dicas.BackColor = Color.Empty;
            txt_erros.Text = string.Empty;
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Jardim Botânico";
        }

        private void btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

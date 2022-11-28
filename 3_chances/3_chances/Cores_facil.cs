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
    public partial class frm_Cores_facil : Form
    {
        public frm_Cores_facil(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);

            if (l1 == "P")
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

            if (l2 == "R")
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

            if (l3 == "E")
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

            if (l4 == "T")
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

            if (l5 == "O")
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

            if (l1 == "P" && l2 == "R" && l3 == "E" && l4 == "T" && l5 == "O")
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
            txt3.Enabled = true;
            txt3.BackColor = Color.Empty;
            txt4.Text = "";
            txt4.Enabled = true;
            txt4.BackColor = Color.Empty;
            txt5.Text = "";
            txt5.BackColor = Color.Empty;
            txt5.Enabled = true;
            lbl_dicas.Text = "Dica:???";
            lbl_dicas.BackColor = Color.Empty;
            txt_erros.Text = string.Empty;
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Combina com tudo";
        }

        private void btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frm_Lugares_Medio : Form
    {
        public frm_Lugares_Medio(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);
            l7 = Convert.ToString(txt7.Text);
            l8 = Convert.ToString(txt8.Text);
            l9 = Convert.ToString(txt9.Text);
            l10 = Convert.ToString(txt10.Text);
            l11 = Convert.ToString(txt11.Text);
            l12 = Convert.ToString(txt12.Text);

            if (l1 == "R")
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

            if (l2 == "I")
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

            if (l3 == "O")
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

            if (l4 == "D")
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

            if (l5 == "E")
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

            if (l6 == "J")
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

            if (l7 == "A")
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

            if (l8 == "N")
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

            if (l9 == "E")
            {
                txt9.BackColor = Color.Green;
                txt9.Enabled = false;
            }

            else
            {
                txt9.BackColor = Color.Red;
                txt9.Text = "";
                txt_erros.Text += l9 + " ";

            }

            if (l10 == "I")
            {
                txt10.BackColor = Color.Green;
                txt10.Enabled = false;
            }

            else
            {
                txt10.BackColor = Color.Red;
                txt10.Text = "";
                txt_erros.Text += l10 + " ";

            }

            if (l11 == "R")
            {
                txt11.BackColor = Color.Green;
                txt11.Enabled = false;
            }

            else
            {
                txt11.BackColor = Color.Red;
                txt11.Text = "";
                txt_erros.Text += l11 + " ";

            }

            if (l12 == "O")
            {
                txt12.BackColor = Color.Green;
                txt12.Enabled = false;
            }

            else
            {
                txt12.BackColor = Color.Red;
                txt12.Text = "";
                txt_erros.Text += l12 + " ";

            }

            if (l1 == "R" && l2 == "I" && l3 == "O" && l4 == "D" && l5 == "E" && l6 == "J" && l7 == "A" && l8 == "N" && l9 == "E" && l10 == "I" && l11 == "R" && l12 == "O")
            {

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
            txt9.Text = "";
            txt9.BackColor = Color.Empty;
            txt9.Enabled = true;
            txt10.Text = "";
            txt10.BackColor = Color.Empty;
            txt10.Enabled = true;
            txt11.Text = "";
            txt11.BackColor = Color.Empty;
            txt11.Enabled = true;
            txt12.Text = "";
            txt12.BackColor = Color.Empty;
            txt12.Enabled = true;
            lbl_dicas.Text = "Dica:???";
            lbl_dicas.BackColor = Color.Empty;
            txt_erros.Text = string.Empty;
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Biblia";
        }

        private void btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

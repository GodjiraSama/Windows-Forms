using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Jogo_Futebol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Casa
        private void goloc_minus_Click(object sender, EventArgs e)
        {
            int x = int.Parse(GolosC.Text);
            if (x > 0)
            {
                x--;
            }
            GolosC.Text = x.ToString();

            
        }

        private void goloc_plus_Click(object sender, EventArgs e)
        {
            int x = int.Parse(GolosC.Text);
            x++;
            GolosC.Text = x.ToString();
        }

        /*private void NomeC_Click(object sender, EventArgs e)
        {

        }*/

        //Fora
        private void golof_plus_Click(object sender, EventArgs e)
        {
            int y = int.Parse(GolosF.Text);
            y++;
            GolosF.Text = y.ToString();
        }

        private void golof_minus_Click(object sender, EventArgs e)
        {
            int y = int.Parse(GolosF.Text);
            if(y > 0)
            {
                y--;
            }
            GolosF.Text = y.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
       
        }

        int min =0;
        int seg = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
                if(min < 90)
                {
                    if(seg < 59)
                    {
                        seg++;
                    }
                    else if (seg == 59)
                    {
                        seg = 0;
                        min++;
                    }
                }
            TempoJogo.Text = min + ":" + seg;

            if(min==90)
            {
                goloc_minus.Enabled = false;
                goloc_plus.Enabled = false;
                golof_minus.Enabled = false;
                golof_plus.Enabled = false;
            }

            if(min >= 45 )
            {
                ParteJogo.Text = "2ª Parte";
            }

            if (min > 0 || seg > 0)
            {
                ComeçarJ.Visible = false;
            }

            if (min == 45 && seg == 00)
            {
                ComeçarJ.Visible = true;
                timer1.Enabled = false;
                goloc_minus.Enabled = false;
                golof_minus.Enabled = false;
                goloc_plus.Enabled = false;
                golof_plus.Enabled = false;
                ComeçarJ.Text = "Começar a 2ª Parte";
            }

            if (min >=45 && seg > 0)
            {
                ComeçarJ.Visible = false;
                goloc_minus.Enabled = true;
                golof_minus.Enabled = true;
                goloc_plus.Enabled = true;
                goloc_plus.Enabled = true;
            }

            if (min == 90 && seg == 0)
            {
                ComeçarJ.Visible = true;
                timer1.Enabled = false;
                ComeçarJ.Text = "Gravar e Recomeçar";
            }

        }
        private void ComeçarJ_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            goloc_plus.Enabled = true;
            goloc_minus.Enabled = true;

            golof_plus.Enabled = true;
            golof_minus.Enabled = true;

            if (min == 0 && seg == 0)
            {
                ComeçarJ.Visible = true;
                goloc_minus.Enabled = false;

            }

            if (min == 45 && seg == 00)
            {
                ComeçarJ.Visible = true;
                timer1.Enabled = true;
            }

            if (min == 90)
            {
                min = 0;
                seg = 0;
                TempoJogo.Text = "00:00";
                ParteJogo.Text = "1ª Parte";
                GolosC.Text = "0";
                GolosF.Text = "0";
                goloc_minus.Enabled = true;
                goloc_plus.Enabled = true;
                golof_minus.Enabled = true;
                golof_plus.Enabled = true;
            }
        }

        /*private void GolosF_Click(object sender, EventArgs e)
        {

        }

        private void NomeF_Click(object sender, EventArgs e)
        {

        }

        private void TempoJogo_Click(object sender, EventArgs e)
        {

        }*/
    }
}

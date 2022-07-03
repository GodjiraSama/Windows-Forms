using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estação_Meterológica
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        int min = 59;
        int seg = 0;
        int hour = 23;

        int dia = 27;
        int mes = 2;
        int ano = 2022;

        public void Relógio1_Tick(object sender, EventArgs e)
        {
            if (hour < 24)
            {
               if(seg < 59)
                {
                    seg++;
                }
               else if (seg == 59 && min < 60)
                {
                    seg = 00;
                    min++;
                }
               if (min == 60 && hour < 24)
                {
                    hour++;
                    min = 00;
                    seg = 00;
                }
               if (hour == 24 && min == 0 && seg == 0)
                {
                    hour = 00;
                    min = 00;
                    seg = 00;
                    dia++;
                     
                }

               if (dia < 31 && hour == 24 && min == 0 && seg == 0)
                {
                    dia++;
                }

                if (dia > 31)
                {
                    dia = 1;
                    mes++;
                }
                if ( dia > 28 && mes == 2)
                {
                    dia = 1;
                    mes++;
                }        
            }
                Relógio.Text = hour + ":" + min + ":" + seg;
                Data.Text = dia + "/" + mes + "/" + ano;
        }


        private void Data_Click(object sender, EventArgs e)
        {

        }
    }
}

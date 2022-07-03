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

        int dia = 31;
        int mes = 5;
        int ano = 2022;

        private void tempo_Tick(object sender, EventArgs e)
        {
            {
                if (hour < 24)
                {
                    if (seg < 59)
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

                    if (dia > 31 && mes ==1 || dia > 31 && mes == 3 || dia > 31 && mes == 5 || dia > 31 && mes == 7 || dia > 31 && mes == 8 || dia > 31 && mes == 10 || dia > 31 && mes == 12 )
                    {
                        dia = 1;
                        mes++;
                    }
                    else if (dia > 30 && mes == 4 || dia > 31 && mes == 6 || dia > 31 && mes == 9 || dia > 31 && mes == 11)
                    {
                        dia = 1;
                        mes++;
                    }
                    
                        if (dia > 28 && mes == 2)
                    {
                        dia = 1;
                        mes++;
                    }
                    if (mes > 12)
                    {
                        mes = 1;
                        ano++;
                    }
                }
                relogio.Text = hour + ":" + min + ":" + seg;
                data.Text = dia + "/" + mes + "/" + ano;
            }
        }
    }
    }

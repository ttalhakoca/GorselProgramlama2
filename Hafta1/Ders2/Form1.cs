namespace Ders2
{
    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0, salise = 0;
        bool ileriMi = true;
        TimeSpan hedefZaman;
        public Form1()
        {
            InitializeComponent();
            btnBasla.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                if(ileriMi)
                {
                    hedefZaman = DateTime.Now.TimeOfDay;
                    timer1.Start();
                    btnBasla.BackColor = Color.Red;
                    btnBasla.Enabled = false;
                }
                else
                {
                    timer1.Start();
                    btnBasla.BackColor= Color.Red;
                    btnBasla.Enabled = false;
                }
            else
            {
                timer1.Stop();
                ileriMi = !ileriMi;
                btnBasla.BackColor = Color.Green;
                btnBasla.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ileriMi)
            {
                salise++;
                if(salise == 100)
                {
                    salise = 0; saniye++;
                }
                if (saniye == 60) 
                { 
                    saniye = 0; dakika++;
                }
                if (dakika == 60) 
                { 
                    dakika = 0; saat++; 
                }
                label1.Text = saat.ToString("00");
                label2.Text = dakika.ToString("00");
                label3.Text = saniye.ToString("00");
                label4.Text = salise.ToString("00");

                TimeSpan sayacTS = new TimeSpan(saat, dakika, saniye) + TimeSpan.FromMilliseconds(salise * 10);

                if(sayacTS >= hedefZaman)
                {
                    timer1.Stop();
                    btnBasla.BackColor= Color.Green;
                    btnBasla.Enabled = true;
                    ileriMi = false;
                }
            }
            else
            {
                if (saat == 0 && dakika == 0 && saniye == 0 && salise == 0)
                {
                    timer1.Stop();
                    btnBasla.BackColor = Color.Green;
                    btnBasla.Enabled = true;
                    ileriMi = true;
                    return;
                }

                salise--;
                if (salise < 0) { salise = 99; saniye--; }
                if (saniye < 0) { saniye = 59; dakika--; }
                if (dakika < 0) { dakika = 59; saat--; }

                label5.Text = saat.ToString("00");
                label6.Text = dakika.ToString("00");
                label7.Text = saniye.ToString("00");
                label8.Text = salise.ToString("00");
            }
        }

    }
}

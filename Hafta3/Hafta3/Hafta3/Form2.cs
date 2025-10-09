using System;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form2 : Form
    {
        MaskedTextBox[,] notlar = new MaskedTextBox[8, 3];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Not Giriş Paneli";
            groupBox1.Width = 500;
            groupBox1.Height = 350;

            for (int i = 0; i < 8; i++)
            {
                Label lblDers = new Label();
                lblDers.Text = $"{i + 1}. Ders:";
                lblDers.SetBounds(20, 30 + i * 35, 80, 25);
                groupBox1.Controls.Add(lblDers);

                for (int j = 0; j < 3; j++)
                {
                    MaskedTextBox mtxt = new MaskedTextBox();
                    mtxt.Mask = "00.00"; 
                    mtxt.SetBounds(100 + j * 70, 30 + i * 35, 60, 25);
                    groupBox1.Controls.Add(mtxt);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

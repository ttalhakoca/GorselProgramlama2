using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form3 : Form
    {
        int sayac = 0;
        List<TextBox> textboxlar = new List<TextBox>();
        public Form3()
        {
            InitializeComponent();
        }
        ListBox list = new ListBox();
        private void Form3_Load(object sender, EventArgs e)
        {
            list.SetBounds(325,50,100,125);
            this.Controls.Add(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox yenitext = new TextBox();
            sayac++;
            yenitext.Location = new System.Drawing.Point(12,50*sayac);
            yenitext.Size = new System.Drawing.Size(125,25);
            this.Controls.Add(yenitext);
            textboxlar.Add(yenitext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox veriler in textboxlar)
                list.Items.Add(veriler.Text);
        }
    }
}

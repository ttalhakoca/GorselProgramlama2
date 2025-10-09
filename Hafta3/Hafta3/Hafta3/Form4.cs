﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Hafta3
{
    public partial class Form4 : Form
    {
        Button b1, b2, b3, b4;
        Timer timer;
        int offset;
        int direction = 1;
        int step = 3;
        int maxOffset = 120;
        int minOffset = 30;
        Point center;

        public Form4()
        {
            InitializeComponent();

            this.Text = "Çapraz Hareketli Butonlar";
            this.BackColor = Color.Black;
            this.ClientSize = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            offset = minOffset;

            b1 = YeniButon("B1", Color.Red);
            b2 = YeniButon("B2", Color.Blue);
            b3 = YeniButon("B3", Color.Lime);
            b4 = YeniButon("B4", Color.Orange);

            this.Controls.AddRange(new Control[] { b1, b2, b3, b4 });

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private Button YeniButon(string text, Color c)
        {
            return new Button
            {
                Text = text,
                BackColor = c,
                Size = new Size(60, 60),
                FlatStyle = FlatStyle.Flat
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            offset += direction * step;

            if (offset >= maxOffset)
                direction = -1;
            else if (offset <= minOffset)
                direction = 1;

            b1.Location = new Point(center.X - b1.Width / 2 - offset, center.Y - b1.Height / 2 - offset);
            b2.Location = new Point(center.X - b2.Width / 2 + offset, center.Y - b2.Height / 2 - offset);
            b3.Location = new Point(center.X - b3.Width / 2 - offset, center.Y - b3.Height / 2 + offset);
            b4.Location = new Point(center.X - b4.Width / 2 + offset, center.Y - b4.Height / 2 + offset);
        }
    }
}

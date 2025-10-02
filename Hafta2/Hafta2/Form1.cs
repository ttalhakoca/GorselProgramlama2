namespace Hafta2
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            button1.MouseDown += Button1_MouseDown;
            button1.MouseMove += Button1_MouseMove;
            button1.MouseUp += Button1_MouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = e.Location;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                button1.Left += e.X - startPoint.X;
                button1.Top += e.Y - startPoint.Y;
            }
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

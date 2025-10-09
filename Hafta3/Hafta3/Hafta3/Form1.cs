namespace Hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnTikla = new Button();
            btnTikla.Text = "Týkla";
            btnTikla.SetBounds(20, 35, 100, 150);
            this.Controls.Add(btnTikla);

            Label lblYazi = new Label();
            lblYazi.SetBounds(20, 200, 125, 20);
            lblYazi.ForeColor = Color.Blue;
            lblYazi.BackColor = Color.Black;
            lblYazi.Text = "TALHA KOCA";
            this.Controls.Add(lblYazi);

            ListBox listListele = new ListBox();
            listListele.SetBounds(150, 35, 100, 150);
            listListele.Items.Add("Ankara");
            listListele.Items.Add("Ýstanbul");
            listListele.Items.Add("Ýzmir");
            this.Controls.Add(listListele);

            ComboBox comboSehir = new ComboBox();
            comboSehir.SetBounds(150, 200, 100, 20);
            comboSehir.Items.Add("Ankara");
            comboSehir.Items.Add("Ýstanbul");
            comboSehir.Items.Add("Ýzmir");
            this.Controls.Add(comboSehir);

            CheckedListBox checkedListSecim = new CheckedListBox();
            checkedListSecim.SetBounds(280, 35, 100, 150);
            checkedListSecim.Items.Add("Ankara");
            checkedListSecim.Items.Add("Ýstanbul");
            checkedListSecim.Items.Add("Ýzmir");
            this.Controls.Add(checkedListSecim);

            DataGridView dataGridViewTablo = new DataGridView();
            dataGridViewTablo.SetBounds(280, 200, 300, 150);
            this.Controls.Add(dataGridViewTablo);
            dataGridViewTablo.ColumnCount = 3;
            dataGridViewTablo.Columns[0].Name = "ID";
            dataGridViewTablo.Columns[1].Name = "AD";
            dataGridViewTablo.Columns[2].Name = "SOYAD";
            string[] row1 = new string[] { "1", "Mehmet", "Hoca" };
            string[] row2 = new string[] { "2", "Ali", "Demir" };
            string[] row3 = new string[] { "3", "Salim", "Uðurlu" };
            dataGridViewTablo.Rows.Add(row1);
            dataGridViewTablo.Rows.Add(row2);
            dataGridViewTablo.Rows.Add(row3);
            dataGridViewTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RadioButton rdoEvet = new RadioButton();
            rdoEvet.SetBounds(400, 35, 100, 20);
            rdoEvet.Text = "Evet";
            this.Controls.Add(rdoEvet);
            RadioButton rdoHayir = new RadioButton();
            rdoHayir.SetBounds(500, 35, 100, 20);
            rdoHayir.Text = "Hayýr";
            this.Controls.Add(rdoHayir);

            CheckBox chkIstanbul = new CheckBox();
            chkIstanbul.SetBounds(400, 80, 100, 20);
            chkIstanbul.Text = "Ýstanbul";
            CheckBox chkAnkara = new CheckBox();
            chkAnkara.SetBounds(400, 110, 100, 20);
            chkAnkara.Text = "Ankara";
            CheckBox chkIzmir = new CheckBox();
            chkIzmir.SetBounds(400, 140, 100, 20);
            chkIzmir.Text = "Ýzmir";
            this.Controls.Add(chkIstanbul);
            this.Controls.Add(chkAnkara);
            this.Controls.Add(chkIzmir);

            //masked textbox


        }
    }
}

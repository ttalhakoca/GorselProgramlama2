namespace Hafta4_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlOyunAlani = new Panel();
            lblSure = new Label();
            lbxCiftSayilar = new ListBox();
            btnOyunuBitir = new Button();
            btnOyunaBasla = new Button();
            timerHareket = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pnlOyunAlani
            // 
            pnlOyunAlani.Location = new Point(157, 69);
            pnlOyunAlani.Name = "pnlOyunAlani";
            pnlOyunAlani.Size = new Size(492, 346);
            pnlOyunAlani.TabIndex = 0;
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(809, 167);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(0, 15);
            lblSure.TabIndex = 3;
            // 
            // lbxCiftSayilar
            // 
            lbxCiftSayilar.FormattingEnabled = true;
            lbxCiftSayilar.ItemHeight = 15;
            lbxCiftSayilar.Location = new Point(679, 28);
            lbxCiftSayilar.Name = "lbxCiftSayilar";
            lbxCiftSayilar.Size = new Size(114, 439);
            lbxCiftSayilar.TabIndex = 2;
            // 
            // btnOyunuBitir
            // 
            btnOyunuBitir.Location = new Point(799, 108);
            btnOyunuBitir.Name = "btnOyunuBitir";
            btnOyunuBitir.Size = new Size(75, 47);
            btnOyunuBitir.TabIndex = 1;
            btnOyunuBitir.Text = "OYUNU BİTİR";
            btnOyunuBitir.UseVisualStyleBackColor = true;
            btnOyunuBitir.Click += btnOyunuBitir_Click;
            // 
            // btnOyunaBasla
            // 
            btnOyunaBasla.Location = new Point(54, 119);
            btnOyunaBasla.Name = "btnOyunaBasla";
            btnOyunaBasla.Size = new Size(75, 47);
            btnOyunaBasla.TabIndex = 0;
            btnOyunaBasla.Text = "OYUNA BAŞLA";
            btnOyunaBasla.UseVisualStyleBackColor = true;
            btnOyunaBasla.Click += btnOyunaBasla_Click;
            // 
            // timerHareket
            // 
            timerHareket.Interval = 1000;
            timerHareket.Tick += timerHareket_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 511);
            Controls.Add(lblSure);
            Controls.Add(pnlOyunAlani);
            Controls.Add(btnOyunuBitir);
            Controls.Add(lbxCiftSayilar);
            Controls.Add(btnOyunaBasla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlOyunAlani;
        private Label lblSure;
        private ListBox lbxCiftSayilar;
        private Button btnOyunuBitir;
        private Button btnOyunaBasla;
        private System.Windows.Forms.Timer timerHareket;
    }
}

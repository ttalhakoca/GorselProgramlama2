namespace Ders2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBasla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Saat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Dakika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 59);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Saniye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 59);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Salise";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 106);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "Saat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 106);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Dakika";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 106);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 6;
            label7.Text = "Saniye";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(216, 106);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 7;
            label8.Text = "Salise";
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(299, 81);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(94, 29);
            btnBasla.TabIndex = 8;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBasla);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnBasla;
        private System.Windows.Forms.Timer timer1;
    }
}

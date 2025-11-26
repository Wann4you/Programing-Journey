namespace projet_akhir_semester_xpplg_2_ridwan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnhitung = new Button();
            btnbatal = new Button();
            cmbjenis = new ComboBox();
            cmbminuman = new ComboBox();
            txtjumlah = new TextBox();
            lblharga = new Label();
            IbIBayar = new Label();
            IbIDiskon = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(84, 238);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 12;
            label3.Text = "Harga :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(-1, 185);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 13;
            label4.Text = "Nama Minuman :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(10, 134);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 14;
            label5.Text = "Jenis Minuman :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(76, 295);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 15;
            label6.Text = "Jumlah :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(493, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 309);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 23;
            label7.Text = "Total Harga :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 358);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 25;
            label8.Text = "Potongan :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 9);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(231, -3);
            label11.Name = "label11";
            label11.Size = new Size(400, 67);
            label11.TabIndex = 30;
            label11.Text = "COFFE TIME";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 538);
            label12.Name = "label12";
            label12.Size = new Size(375, 20);
            label12.TabIndex = 31;
            label12.Text = "Potongan 50 ribu untuk total pembelian di atas 100.000";
            // 
            // btnhitung
            // 
            btnhitung.Location = new Point(66, 394);
            btnhitung.Name = "btnhitung";
            btnhitung.Size = new Size(94, 40);
            btnhitung.TabIndex = 32;
            btnhitung.Text = "Hitung";
            btnhitung.UseVisualStyleBackColor = true;
            btnhitung.Click += btnhitung_Click;
            // 
            // btnbatal
            // 
            btnbatal.Location = new Point(231, 394);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(94, 40);
            btnbatal.TabIndex = 33;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            // 
            // cmbjenis
            // 
            cmbjenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbjenis.FormattingEnabled = true;
            cmbjenis.Location = new Point(166, 138);
            cmbjenis.Name = "cmbjenis";
            cmbjenis.Size = new Size(151, 28);
            cmbjenis.TabIndex = 34;
            cmbjenis.SelectedIndexChanged += cmbjenis_SelectedIndexChanged;
            // 
            // cmbminuman
            // 
            cmbminuman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbminuman.FormattingEnabled = true;
            cmbminuman.Location = new Point(166, 189);
            cmbminuman.Name = "cmbminuman";
            cmbminuman.Size = new Size(151, 28);
            cmbminuman.TabIndex = 37;
            cmbminuman.SelectedIndexChanged += cmbminuman_SelectedIndexChanged;
            // 
            // txtjumlah
            // 
            txtjumlah.Location = new Point(164, 295);
            txtjumlah.Name = "txtjumlah";
            txtjumlah.Size = new Size(153, 27);
            txtjumlah.TabIndex = 39;
            txtjumlah.TextChanged += textBox2_TextChanged;
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.BackColor = SystemColors.Control;
            lblharga.Location = new Point(166, 246);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(17, 20);
            lblharga.TabIndex = 43;
            lblharga.Text = "0";
            // 
            // IbIBayar
            // 
            IbIBayar.AutoSize = true;
            IbIBayar.BackColor = Color.White;
            IbIBayar.Location = new Point(620, 309);
            IbIBayar.Name = "IbIBayar";
            IbIBayar.Size = new Size(17, 20);
            IbIBayar.TabIndex = 44;
            IbIBayar.Text = "0";
            // 
            // IbIDiskon
            // 
            IbIDiskon.AutoSize = true;
            IbIDiskon.BackColor = Color.White;
            IbIDiskon.Location = new Point(620, 358);
            IbIDiskon.Name = "IbIDiskon";
            IbIDiskon.Size = new Size(17, 20);
            IbIDiskon.TabIndex = 45;
            IbIDiskon.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(852, 567);
            Controls.Add(IbIDiskon);
            Controls.Add(IbIBayar);
            Controls.Add(lblharga);
            Controls.Add(txtjumlah);
            Controls.Add(cmbminuman);
            Controls.Add(cmbjenis);
            Controls.Add(btnbatal);
            Controls.Add(btnhitung);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnhitung;
        private Button btnbatal;
        private ComboBox cmbjenis;
        private ComboBox cmbminuman;
        private TextBox txtjumlah;
        private Label lblharga;
        private Label IbIBayar;
        private Label IbIDiskon;
    }
}

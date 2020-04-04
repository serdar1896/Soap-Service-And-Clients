namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sikl = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check_satilamaz = new System.Windows.Forms.CheckBox();
            this.txt_bf = new System.Windows.Forms.TextBox();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_kat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(725, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btn_sikl
            // 
            this.btn_sikl.Location = new System.Drawing.Point(749, 332);
            this.btn_sikl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sikl.Name = "btn_sikl";
            this.btn_sikl.Size = new System.Drawing.Size(115, 28);
            this.btn_sikl.TabIndex = 2;
            this.btn_sikl.Text = "Sil";
            this.btn_sikl.UseVisualStyleBackColor = true;
            this.btn_sikl.Click += new System.EventHandler(this.btn_sikl_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(835, 71);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(93, 22);
            this.txt_id.TabIndex = 3;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(835, 117);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(93, 22);
            this.txt_ad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birim Fiy";
            // 
            // check_satilamaz
            // 
            this.check_satilamaz.AutoSize = true;
            this.check_satilamaz.Enabled = false;
            this.check_satilamaz.Location = new System.Drawing.Point(749, 231);
            this.check_satilamaz.Margin = new System.Windows.Forms.Padding(4);
            this.check_satilamaz.Name = "check_satilamaz";
            this.check_satilamaz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_satilamaz.Size = new System.Drawing.Size(111, 21);
            this.check_satilamaz.TabIndex = 9;
            this.check_satilamaz.Text = "     Satılamaz";
            this.check_satilamaz.UseVisualStyleBackColor = true;
            // 
            // txt_bf
            // 
            this.txt_bf.Location = new System.Drawing.Point(835, 154);
            this.txt_bf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bf.Name = "txt_bf";
            this.txt_bf.Size = new System.Drawing.Size(93, 22);
            this.txt_bf.TabIndex = 10;
            // 
            // btn_guncel
            // 
            this.btn_guncel.Location = new System.Drawing.Point(749, 296);
            this.btn_guncel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(115, 28);
            this.btn_guncel.TabIndex = 11;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = true;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(749, 260);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(115, 28);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = " Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kategori Ad";
            // 
            // cmb_kat
            // 
            this.cmb_kat.FormattingEnabled = true;
            this.cmb_kat.Location = new System.Drawing.Point(835, 194);
            this.cmb_kat.Name = "cmb_kat";
            this.cmb_kat.Size = new System.Drawing.Size(93, 24);
            this.cmb_kat.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 410);
            this.Controls.Add(this.cmb_kat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.txt_bf);
            this.Controls.Add(this.check_satilamaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_sikl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sikl;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_satilamaz;
        private System.Windows.Forms.TextBox txt_bf;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_kat;
    }
}


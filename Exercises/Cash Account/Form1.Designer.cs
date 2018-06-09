namespace _1.CashAccount
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
            this.gbProdukti = new System.Windows.Forms.GroupBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiNov = new System.Windows.Forms.Button();
            this.btnDodadiVoSmetka = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.gbSmetka = new System.Windows.Forms.GroupBox();
            this.nudDanok = new System.Windows.Forms.NumericUpDown();
            this.tbZaPlakanje = new System.Windows.Forms.TextBox();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.lbSmetka = new System.Windows.Forms.ListBox();
            this.btnIzbrisiStavka = new System.Windows.Forms.Button();
            this.lblPlakanje = new System.Windows.Forms.Label();
            this.lblDanok = new System.Windows.Forms.Label();
            this.lblVkupno = new System.Windows.Forms.Label();
            this.gbProdukti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gbSmetka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanok)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProdukti
            // 
            this.gbProdukti.Controls.Add(this.nudQuantity);
            this.gbProdukti.Controls.Add(this.btnDodadiNov);
            this.gbProdukti.Controls.Add(this.btnDodadiVoSmetka);
            this.gbProdukti.Controls.Add(this.lbProducts);
            this.gbProdukti.Controls.Add(this.lblKolicina);
            this.gbProdukti.Location = new System.Drawing.Point(12, 12);
            this.gbProdukti.Name = "gbProdukti";
            this.gbProdukti.Size = new System.Drawing.Size(237, 288);
            this.gbProdukti.TabIndex = 0;
            this.gbProdukti.TabStop = false;
            this.gbProdukti.Text = "Продукти";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(107, 200);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 4;
            // 
            // btnDodadiNov
            // 
            this.btnDodadiNov.Location = new System.Drawing.Point(6, 256);
            this.btnDodadiNov.Name = "btnDodadiNov";
            this.btnDodadiNov.Size = new System.Drawing.Size(221, 23);
            this.btnDodadiNov.TabIndex = 3;
            this.btnDodadiNov.Text = "Додади нов";
            this.btnDodadiNov.UseVisualStyleBackColor = true;
            this.btnDodadiNov.Click += new System.EventHandler(this.btnDodadiNov_Click);
            // 
            // btnDodadiVoSmetka
            // 
            this.btnDodadiVoSmetka.Location = new System.Drawing.Point(6, 229);
            this.btnDodadiVoSmetka.Name = "btnDodadiVoSmetka";
            this.btnDodadiVoSmetka.Size = new System.Drawing.Size(221, 23);
            this.btnDodadiVoSmetka.TabIndex = 2;
            this.btnDodadiVoSmetka.Text = "Додади во сметка";
            this.btnDodadiVoSmetka.UseVisualStyleBackColor = true;
            this.btnDodadiVoSmetka.Click += new System.EventHandler(this.btnDodadiVoSmetka_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(10, 18);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(217, 173);
            this.lbProducts.TabIndex = 1;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(11, 204);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(58, 13);
            this.lblKolicina.TabIndex = 0;
            this.lblKolicina.Text = "Количина:";
            // 
            // gbSmetka
            // 
            this.gbSmetka.Controls.Add(this.nudDanok);
            this.gbSmetka.Controls.Add(this.tbZaPlakanje);
            this.gbSmetka.Controls.Add(this.tbVkupno);
            this.gbSmetka.Controls.Add(this.lbSmetka);
            this.gbSmetka.Controls.Add(this.btnIzbrisiStavka);
            this.gbSmetka.Controls.Add(this.lblPlakanje);
            this.gbSmetka.Controls.Add(this.lblDanok);
            this.gbSmetka.Controls.Add(this.lblVkupno);
            this.gbSmetka.Location = new System.Drawing.Point(255, 12);
            this.gbSmetka.Name = "gbSmetka";
            this.gbSmetka.Size = new System.Drawing.Size(300, 288);
            this.gbSmetka.TabIndex = 1;
            this.gbSmetka.TabStop = false;
            this.gbSmetka.Text = "Сметка";
            // 
            // nudDanok
            // 
            this.nudDanok.Location = new System.Drawing.Point(114, 222);
            this.nudDanok.Name = "nudDanok";
            this.nudDanok.Size = new System.Drawing.Size(178, 20);
            this.nudDanok.TabIndex = 8;
            this.nudDanok.ValueChanged += new System.EventHandler(this.nudDanok_ValueChanged);
            // 
            // tbZaPlakanje
            // 
            this.tbZaPlakanje.Location = new System.Drawing.Point(114, 255);
            this.tbZaPlakanje.Name = "tbZaPlakanje";
            this.tbZaPlakanje.ReadOnly = true;
            this.tbZaPlakanje.Size = new System.Drawing.Size(178, 20);
            this.tbZaPlakanje.TabIndex = 7;
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(114, 195);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.ReadOnly = true;
            this.tbVkupno.Size = new System.Drawing.Size(178, 20);
            this.tbVkupno.TabIndex = 5;
            // 
            // lbSmetka
            // 
            this.lbSmetka.FormattingEnabled = true;
            this.lbSmetka.Location = new System.Drawing.Point(6, 19);
            this.lbSmetka.Name = "lbSmetka";
            this.lbSmetka.Size = new System.Drawing.Size(286, 134);
            this.lbSmetka.TabIndex = 4;
            this.lbSmetka.SelectedIndexChanged += new System.EventHandler(this.lbSmetka_SelectedIndexChanged);
            // 
            // btnIzbrisiStavka
            // 
            this.btnIzbrisiStavka.Location = new System.Drawing.Point(6, 165);
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Size = new System.Drawing.Size(288, 23);
            this.btnIzbrisiStavka.TabIndex = 4;
            this.btnIzbrisiStavka.Text = "Избриши ставка";
            this.btnIzbrisiStavka.UseVisualStyleBackColor = true;
            this.btnIzbrisiStavka.Click += new System.EventHandler(this.btnIzbrisiStavka_Click);
            // 
            // lblPlakanje
            // 
            this.lblPlakanje.AutoSize = true;
            this.lblPlakanje.Location = new System.Drawing.Point(21, 258);
            this.lblPlakanje.Name = "lblPlakanje";
            this.lblPlakanje.Size = new System.Drawing.Size(69, 13);
            this.lblPlakanje.TabIndex = 3;
            this.lblPlakanje.Text = "За плаќање";
            // 
            // lblDanok
            // 
            this.lblDanok.AutoSize = true;
            this.lblDanok.Location = new System.Drawing.Point(21, 230);
            this.lblDanok.Name = "lblDanok";
            this.lblDanok.Size = new System.Drawing.Size(60, 13);
            this.lblDanok.TabIndex = 2;
            this.lblDanok.Text = "Данок (%):";
            // 
            // lblVkupno
            // 
            this.lblVkupno.AutoSize = true;
            this.lblVkupno.Location = new System.Drawing.Point(21, 202);
            this.lblVkupno.Name = "lblVkupno";
            this.lblVkupno.Size = new System.Drawing.Size(46, 13);
            this.lblVkupno.TabIndex = 1;
            this.lblVkupno.Text = "Вкупно:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 312);
            this.Controls.Add(this.gbSmetka);
            this.Controls.Add(this.gbProdukti);
            this.Name = "Form1";
            this.Text = "Каса";
            this.gbProdukti.ResumeLayout(false);
            this.gbProdukti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gbSmetka.ResumeLayout(false);
            this.gbSmetka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProdukti;
        private System.Windows.Forms.GroupBox gbSmetka;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblDanok;
        private System.Windows.Forms.Label lblVkupno;
        private System.Windows.Forms.Label lblPlakanje;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnDodadiNov;
        private System.Windows.Forms.Button btnDodadiVoSmetka;
        private System.Windows.Forms.ListBox lbSmetka;
        private System.Windows.Forms.Button btnIzbrisiStavka;
        private System.Windows.Forms.TextBox tbZaPlakanje;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudDanok;
    }
}


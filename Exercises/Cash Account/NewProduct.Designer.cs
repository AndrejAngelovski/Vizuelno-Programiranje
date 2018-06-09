namespace _1.CashAccount
{
    partial class NewProduct
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
            this.components = new System.ComponentModel.Container();
            this.gbPodatoci = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPodatoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPodatoci
            // 
            this.gbPodatoci.Controls.Add(this.tbName);
            this.gbPodatoci.Controls.Add(this.nudPrice);
            this.gbPodatoci.Controls.Add(this.nudCode);
            this.gbPodatoci.Controls.Add(this.lblCena);
            this.gbPodatoci.Controls.Add(this.lblIme);
            this.gbPodatoci.Controls.Add(this.lblKod);
            this.gbPodatoci.Location = new System.Drawing.Point(12, 12);
            this.gbPodatoci.Name = "gbPodatoci";
            this.gbPodatoci.Size = new System.Drawing.Size(461, 158);
            this.gbPodatoci.TabIndex = 0;
            this.gbPodatoci.TabStop = false;
            this.gbPodatoci.Text = "Податоци за продуктот";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(19, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(417, 20);
            this.tbName.TabIndex = 5;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(19, 123);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 4;
            // 
            // nudCode
            // 
            this.nudCode.Location = new System.Drawing.Point(19, 44);
            this.nudCode.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCode.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(120, 20);
            this.nudCode.TabIndex = 3;
            this.nudCode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(16, 107);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(36, 13);
            this.lblCena.TabIndex = 2;
            this.lblCena.Text = "Цена:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(16, 67);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Име:";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(16, 27);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(29, 13);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "Код:";
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(298, 177);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(75, 23);
            this.btnVnesi.TabIndex = 1;
            this.btnVnesi.Text = "Внеси";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(398, 177);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 215);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.gbPodatoci);
            this.Name = "NewProduct";
            this.Text = "Нов продукт";
            this.gbPodatoci.ResumeLayout(false);
            this.gbPodatoci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPodatoci;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudCode;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
namespace Airports
{
    partial class NewAirport
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
            this.gbAddAirport = new System.Windows.Forms.GroupBox();
            this.tbAirportShortcut = new System.Windows.Forms.TextBox();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbAirportCity = new System.Windows.Forms.TextBox();
            this.btnAirportCancel = new System.Windows.Forms.Button();
            this.btnAirportSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddAirport
            // 
            this.gbAddAirport.Controls.Add(this.tbAirportShortcut);
            this.gbAddAirport.Controls.Add(this.tbAirportName);
            this.gbAddAirport.Controls.Add(this.tbAirportCity);
            this.gbAddAirport.Controls.Add(this.btnAirportCancel);
            this.gbAddAirport.Controls.Add(this.btnAirportSave);
            this.gbAddAirport.Controls.Add(this.label3);
            this.gbAddAirport.Controls.Add(this.label2);
            this.gbAddAirport.Controls.Add(this.label1);
            this.gbAddAirport.Location = new System.Drawing.Point(13, 13);
            this.gbAddAirport.Name = "gbAddAirport";
            this.gbAddAirport.Size = new System.Drawing.Size(259, 185);
            this.gbAddAirport.TabIndex = 0;
            this.gbAddAirport.TabStop = false;
            this.gbAddAirport.Text = "Додади аеродром";
            // 
            // tbAirportShortcut
            // 
            this.tbAirportShortcut.Location = new System.Drawing.Point(7, 117);
            this.tbAirportShortcut.Name = "tbAirportShortcut";
            this.tbAirportShortcut.Size = new System.Drawing.Size(100, 20);
            this.tbAirportShortcut.TabIndex = 7;
            this.tbAirportShortcut.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportShortcut_Validating);
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(10, 77);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(229, 20);
            this.tbAirportName.TabIndex = 6;
            this.tbAirportName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportName_Validating);
            // 
            // tbAirportCity
            // 
            this.tbAirportCity.Location = new System.Drawing.Point(10, 37);
            this.tbAirportCity.Name = "tbAirportCity";
            this.tbAirportCity.Size = new System.Drawing.Size(229, 20);
            this.tbAirportCity.TabIndex = 5;
            this.tbAirportCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportCity_Validating);
            // 
            // btnAirportCancel
            // 
            this.btnAirportCancel.Location = new System.Drawing.Point(149, 153);
            this.btnAirportCancel.Name = "btnAirportCancel";
            this.btnAirportCancel.Size = new System.Drawing.Size(104, 23);
            this.btnAirportCancel.TabIndex = 4;
            this.btnAirportCancel.Text = "Откажи";
            this.btnAirportCancel.UseVisualStyleBackColor = true;
            this.btnAirportCancel.Click += new System.EventHandler(this.btnAirportCancel_Click);
            // 
            // btnAirportSave
            // 
            this.btnAirportSave.Location = new System.Drawing.Point(10, 153);
            this.btnAirportSave.Name = "btnAirportSave";
            this.btnAirportSave.Size = new System.Drawing.Size(103, 23);
            this.btnAirportSave.TabIndex = 3;
            this.btnAirportSave.Text = "Зачувај";
            this.btnAirportSave.UseVisualStyleBackColor = true;
            this.btnAirportSave.Click += new System.EventHandler(this.btnAirportSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кратенка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Град";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.gbAddAirport);
            this.Name = "NewAirport";
            this.Text = "Нов аеродром";
            this.gbAddAirport.ResumeLayout(false);
            this.gbAddAirport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddAirport;
        private System.Windows.Forms.TextBox tbAirportShortcut;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbAirportCity;
        private System.Windows.Forms.Button btnAirportCancel;
        private System.Windows.Forms.Button btnAirportSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
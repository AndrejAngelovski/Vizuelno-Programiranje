namespace Airports
{
    partial class AddDestination
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDestAdd = new System.Windows.Forms.Button();
            this.btnDestCancel = new System.Windows.Forms.Button();
            this.nudDestDistance = new System.Windows.Forms.NumericUpDown();
            this.nudDestPrice = new System.Windows.Forms.NumericUpDown();
            this.tbDestName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudDestPrice);
            this.groupBox1.Controls.Add(this.nudDestDistance);
            this.groupBox1.Controls.Add(this.tbDestName);
            this.groupBox1.Controls.Add(this.btnDestCancel);
            this.groupBox1.Controls.Add(this.btnDestAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади дестинација";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // btnDestAdd
            // 
            this.btnDestAdd.Location = new System.Drawing.Point(10, 147);
            this.btnDestAdd.Name = "btnDestAdd";
            this.btnDestAdd.Size = new System.Drawing.Size(105, 23);
            this.btnDestAdd.TabIndex = 3;
            this.btnDestAdd.Text = "Додади";
            this.btnDestAdd.UseVisualStyleBackColor = true;
            this.btnDestAdd.Click += new System.EventHandler(this.btnDestAdd_Click);
            // 
            // btnDestCancel
            // 
            this.btnDestCancel.Location = new System.Drawing.Point(148, 147);
            this.btnDestCancel.Name = "btnDestCancel";
            this.btnDestCancel.Size = new System.Drawing.Size(105, 23);
            this.btnDestCancel.TabIndex = 4;
            this.btnDestCancel.Text = "Откажи";
            this.btnDestCancel.UseVisualStyleBackColor = true;
            // 
            // nudDestDistance
            // 
            this.nudDestDistance.Location = new System.Drawing.Point(10, 77);
            this.nudDestDistance.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudDestDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDestDistance.Name = "nudDestDistance";
            this.nudDestDistance.Size = new System.Drawing.Size(120, 20);
            this.nudDestDistance.TabIndex = 6;
            this.nudDestDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDestPrice
            // 
            this.nudDestPrice.Location = new System.Drawing.Point(10, 114);
            this.nudDestPrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudDestPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDestPrice.Name = "nudDestPrice";
            this.nudDestPrice.Size = new System.Drawing.Size(120, 20);
            this.nudDestPrice.TabIndex = 7;
            this.nudDestPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbDestName
            // 
            this.tbDestName.Location = new System.Drawing.Point(10, 33);
            this.tbDestName.Name = "tbDestName";
            this.tbDestName.Size = new System.Drawing.Size(232, 20);
            this.tbDestName.TabIndex = 5;
            this.tbDestName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDestination";
            this.Text = "Нова дестинација";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDestCancel;
        private System.Windows.Forms.Button btnDestAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDestPrice;
        private System.Windows.Forms.NumericUpDown nudDestDistance;
        private System.Windows.Forms.TextBox tbDestName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
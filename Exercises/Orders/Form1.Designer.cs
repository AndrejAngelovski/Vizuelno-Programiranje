namespace Narachki
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
            this.components = new System.ComponentModel.Container();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBills = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbOrder.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrder
            // 
            this.gbOrder.BackColor = System.Drawing.SystemColors.Control;
            this.gbOrder.Controls.Add(this.btnBill);
            this.gbOrder.Controls.Add(this.lbOrders);
            this.gbOrder.Controls.Add(this.btnAddOrder);
            this.gbOrder.Location = new System.Drawing.Point(28, 13);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(254, 310);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Нарачај";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(6, 277);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(242, 23);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Сметка";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(6, 56);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(242, 212);
            this.lbOrders.TabIndex = 1;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(6, 20);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(242, 23);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Внеси нарачка";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // gbAccount
            // 
            this.gbAccount.BackColor = System.Drawing.SystemColors.Control;
            this.gbAccount.Controls.Add(this.tbTotal);
            this.gbAccount.Controls.Add(this.label4);
            this.gbAccount.Controls.Add(this.lblTime);
            this.gbAccount.Controls.Add(this.lblDate);
            this.gbAccount.Controls.Add(this.label1);
            this.gbAccount.Controls.Add(this.lbBills);
            this.gbAccount.Location = new System.Drawing.Point(325, 13);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(283, 310);
            this.gbAccount.TabIndex = 1;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Сметки";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(59, 280);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(204, 20);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вкупно";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(188, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(103, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Време";
            // 
            // lbBills
            // 
            this.lbBills.FormattingEnabled = true;
            this.lbBills.Location = new System.Drawing.Point(6, 56);
            this.lbBills.Name = "lbBills";
            this.lbBills.Size = new System.Drawing.Size(257, 212);
            this.lbBills.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(620, 335);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.gbOrder);
            this.Name = "Form1";
            this.Text = "Нарачки";
            this.gbOrder.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.ListBox lbBills;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}


namespace GUI_KIEU
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnChangePass = new System.Windows.Forms.Panel();
            this.pnBill = new System.Windows.Forms.Panel();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.pnCategory = new System.Windows.Forms.Panel();
            this.pnReport = new System.Windows.Forms.Panel();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnChangePass, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnBill, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnCustomer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnCategory, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnReport, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnProduct, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnAccount, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnChangePass
            // 
            this.pnChangePass.BackgroundImage = global::GUI_KIEU.Properties.Resources.changePass;
            this.pnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChangePass.Location = new System.Drawing.Point(278, 26);
            this.pnChangePass.Name = "pnChangePass";
            this.pnChangePass.Size = new System.Drawing.Size(194, 94);
            this.pnChangePass.TabIndex = 10;
            this.pnChangePass.Click += new System.EventHandler(this.pnChangePass_Click);
            // 
            // pnBill
            // 
            this.pnBill.BackgroundImage = global::GUI_KIEU.Properties.Resources.bill11;
            this.pnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBill.Location = new System.Drawing.Point(78, 26);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(194, 94);
            this.pnBill.TabIndex = 11;
            this.pnBill.Click += new System.EventHandler(this.pnBill_Click);
            // 
            // pnCustomer
            // 
            this.pnCustomer.BackgroundImage = global::GUI_KIEU.Properties.Resources.customer;
            this.pnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCustomer.Location = new System.Drawing.Point(78, 126);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(194, 94);
            this.pnCustomer.TabIndex = 15;
            this.pnCustomer.Click += new System.EventHandler(this.pnCustomer_Click_1);
            // 
            // pnCategory
            // 
            this.pnCategory.BackgroundImage = global::GUI_KIEU.Properties.Resources.fdg;
            this.pnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCategory.Location = new System.Drawing.Point(278, 126);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(194, 94);
            this.pnCategory.TabIndex = 16;
            this.pnCategory.Click += new System.EventHandler(this.pnCategory_Click);
            // 
            // pnReport
            // 
            this.pnReport.BackgroundImage = global::GUI_KIEU.Properties.Resources.report;
            this.pnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnReport.Location = new System.Drawing.Point(278, 226);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(194, 94);
            this.pnReport.TabIndex = 17;
            this.pnReport.Click += new System.EventHandler(this.pnReport_Click);
            // 
            // pnProduct
            // 
            this.pnProduct.BackgroundImage = global::GUI_KIEU.Properties.Resources.product;
            this.pnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnProduct.Location = new System.Drawing.Point(78, 226);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(194, 94);
            this.pnProduct.TabIndex = 18;
            this.pnProduct.Click += new System.EventHandler(this.pnProduct_Click);
            // 
            // pnAccount
            // 
            this.pnAccount.BackgroundImage = global::GUI_KIEU.Properties.Resources.account2;
            this.pnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAccount.Location = new System.Drawing.Point(78, 326);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(194, 94);
            this.pnAccount.TabIndex = 19;
            this.pnAccount.Click += new System.EventHandler(this.pnAccount_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnChangePass;
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Panel pnCategory;
        private System.Windows.Forms.Panel pnReport;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Panel pnAccount;
    }
}


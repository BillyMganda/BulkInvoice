namespace BulkInvoice.Forms
{
    partial class AuditTrail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Invoice_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAuditTrail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice_Number,
            this.Invoice_Date,
            this.Account,
            this.Invoice_Amount,
            this.Invoice_Description});
            this.dataGridView1.Location = new System.Drawing.Point(11, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(738, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // Invoice_Number
            // 
            this.Invoice_Number.DataPropertyName = "Invoice_Number";
            this.Invoice_Number.HeaderText = "Invoice Number";
            this.Invoice_Number.Name = "Invoice_Number";
            this.Invoice_Number.ReadOnly = true;
            this.Invoice_Number.Width = 120;
            // 
            // Invoice_Date
            // 
            this.Invoice_Date.DataPropertyName = "Invoice_Date";
            this.Invoice_Date.HeaderText = "Invoice Date";
            this.Invoice_Date.Name = "Invoice_Date";
            this.Invoice_Date.ReadOnly = true;
            this.Invoice_Date.Width = 120;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 120;
            // 
            // Invoice_Amount
            // 
            this.Invoice_Amount.DataPropertyName = "Invoice_Amount";
            this.Invoice_Amount.HeaderText = "Invoice Amount";
            this.Invoice_Amount.Name = "Invoice_Amount";
            this.Invoice_Amount.ReadOnly = true;
            this.Invoice_Amount.Width = 120;
            // 
            // Invoice_Description
            // 
            this.Invoice_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Invoice_Description.DataPropertyName = "Invoice_Description";
            this.Invoice_Description.HeaderText = "Description";
            this.Invoice_Description.Name = "Invoice_Description";
            this.Invoice_Description.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 561);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processed Invoices";
            // 
            // btnAuditTrail
            // 
            this.btnAuditTrail.BackColor = System.Drawing.SystemColors.Control;
            this.btnAuditTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuditTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditTrail.Location = new System.Drawing.Point(686, 579);
            this.btnAuditTrail.Name = "btnAuditTrail";
            this.btnAuditTrail.Size = new System.Drawing.Size(75, 32);
            this.btnAuditTrail.TabIndex = 42;
            this.btnAuditTrail.Text = "&Cancel";
            this.btnAuditTrail.UseVisualStyleBackColor = false;
            this.btnAuditTrail.Click += new System.EventHandler(this.btnAuditTrail_Click);
            // 
            // AuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 622);
            this.Controls.Add(this.btnAuditTrail);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuditTrail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sent Invoices";
            this.Load += new System.EventHandler(this.AuditTrail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAuditTrail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Description;
    }
}
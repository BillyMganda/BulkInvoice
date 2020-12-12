namespace BulkInvoice.Forms
{
    partial class BulkInvoicing
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.comboCustomerGroup = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvTotExclDEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvTotTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvTotInclDEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSinglePrint = new System.Windows.Forms.Button();
            this.btnMultiPrint = new System.Windows.Forms.Button();
            this.comboBoxPrinter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_InvoiceNumber = new System.Windows.Forms.Label();
            this.btnAuditTrail = new System.Windows.Forms.Button();
            this.label_EmailFrom = new System.Windows.Forms.Label();
            this.label_EmailPassword = new System.Windows.Forms.Label();
            this.label_EmailMessage = new System.Windows.Forms.Label();
            this.label_EmailSubject = new System.Windows.Forms.Label();
            this.label_SMTP_CC = new System.Windows.Forms.Label();
            this.label_SMTPClient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_SMTPSSL = new System.Windows.Forms.Label();
            this.label_Path = new System.Windows.Forms.Label();
            this.label_InvNumumber = new System.Windows.Forms.Label();
            this.label_InvDate = new System.Windows.Forms.Label();
            this.label_InvAccount = new System.Windows.Forms.Label();
            this.label_InvAmount = new System.Windows.Forms.Label();
            this.label_InvDescription = new System.Windows.Forms.Label();
            this.btnChangeMessage = new System.Windows.Forms.Button();
            this.label_InvoiceEmail = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel2.Controls.Add(this.btnLoadData);
            this.Panel2.Controls.Add(this.dateEnd);
            this.Panel2.Controls.Add(this.dateFrom);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Location = new System.Drawing.Point(12, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(557, 119);
            this.Panel2.TabIndex = 21;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Location = new System.Drawing.Point(447, 73);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 32);
            this.btnLoadData.TabIndex = 24;
            this.btnLoadData.Text = "&Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(353, 39);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(169, 20);
            this.dateEnd.TabIndex = 16;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(84, 39);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(169, 20);
            this.dateFrom.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(308, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(31, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(185, 19);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Select Invoice Date Range";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel3.Controls.Add(this.comboCustomerGroup);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Location = new System.Drawing.Point(591, 12);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(481, 119);
            this.Panel3.TabIndex = 22;
            // 
            // comboCustomerGroup
            // 
            this.comboCustomerGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCustomerGroup.FormattingEnabled = true;
            this.comboCustomerGroup.Location = new System.Drawing.Point(42, 37);
            this.comboCustomerGroup.Name = "comboCustomerGroup";
            this.comboCustomerGroup.Size = new System.Drawing.Size(404, 21);
            this.comboCustomerGroup.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(38, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(166, 19);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Select Customer Group";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 2);
            this.panel1.TabIndex = 23;
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
            this.InvNumber,
            this.Account,
            this.Description,
            this.InvDate,
            this.InvTotExclDEx,
            this.InvTotTax,
            this.InvTotInclDEx});
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 238);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // InvNumber
            // 
            this.InvNumber.DataPropertyName = "InvNumber";
            this.InvNumber.HeaderText = "Invoice Number";
            this.InvNumber.Name = "InvNumber";
            this.InvNumber.ReadOnly = true;
            this.InvNumber.Width = 120;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 120;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // InvDate
            // 
            this.InvDate.DataPropertyName = "InvDate";
            this.InvDate.HeaderText = "Invoice Date";
            this.InvDate.Name = "InvDate";
            this.InvDate.ReadOnly = true;
            this.InvDate.Width = 120;
            // 
            // InvTotExclDEx
            // 
            this.InvTotExclDEx.DataPropertyName = "InvTotExclDEx";
            this.InvTotExclDEx.HeaderText = "InvTotExclDEx";
            this.InvTotExclDEx.Name = "InvTotExclDEx";
            this.InvTotExclDEx.ReadOnly = true;
            // 
            // InvTotTax
            // 
            this.InvTotTax.DataPropertyName = "InvTotTax";
            this.InvTotTax.HeaderText = "InvTotTax";
            this.InvTotTax.Name = "InvTotTax";
            this.InvTotTax.ReadOnly = true;
            // 
            // InvTotInclDEx
            // 
            this.InvTotInclDEx.DataPropertyName = "InvTotInclDEx";
            this.InvTotInclDEx.HeaderText = "InvTotInclDEx";
            this.InvTotInclDEx.Name = "InvTotInclDEx";
            this.InvTotInclDEx.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(12, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1060, 2);
            this.panel4.TabIndex = 25;
            // 
            // btnSinglePrint
            // 
            this.btnSinglePrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnSinglePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePrint.Location = new System.Drawing.Point(897, 414);
            this.btnSinglePrint.Name = "btnSinglePrint";
            this.btnSinglePrint.Size = new System.Drawing.Size(75, 42);
            this.btnSinglePrint.TabIndex = 26;
            this.btnSinglePrint.Text = "&Print";
            this.btnSinglePrint.UseVisualStyleBackColor = false;
            this.btnSinglePrint.Click += new System.EventHandler(this.btnSinglePrint_Click);
            // 
            // btnMultiPrint
            // 
            this.btnMultiPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiPrint.Location = new System.Drawing.Point(994, 414);
            this.btnMultiPrint.Name = "btnMultiPrint";
            this.btnMultiPrint.Size = new System.Drawing.Size(75, 42);
            this.btnMultiPrint.TabIndex = 27;
            this.btnMultiPrint.Text = "&Multi Print";
            this.btnMultiPrint.UseVisualStyleBackColor = false;
            this.btnMultiPrint.Click += new System.EventHandler(this.btnMultiPrint_Click);
            // 
            // comboBoxPrinter
            // 
            this.comboBoxPrinter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrinter.FormattingEnabled = true;
            this.comboBoxPrinter.Location = new System.Drawing.Point(692, 421);
            this.comboBoxPrinter.Name = "comboBoxPrinter";
            this.comboBoxPrinter.Size = new System.Drawing.Size(181, 21);
            this.comboBoxPrinter.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(581, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select Printer";
            // 
            // label_InvoiceNumber
            // 
            this.label_InvoiceNumber.AutoSize = true;
            this.label_InvoiceNumber.Location = new System.Drawing.Point(734, 450);
            this.label_InvoiceNumber.Name = "label_InvoiceNumber";
            this.label_InvoiceNumber.Size = new System.Drawing.Size(82, 13);
            this.label_InvoiceNumber.TabIndex = 40;
            this.label_InvoiceNumber.Text = "invoice_number";
            this.label_InvoiceNumber.Visible = false;
            // 
            // btnAuditTrail
            // 
            this.btnAuditTrail.BackColor = System.Drawing.SystemColors.Control;
            this.btnAuditTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuditTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditTrail.Location = new System.Drawing.Point(12, 414);
            this.btnAuditTrail.Name = "btnAuditTrail";
            this.btnAuditTrail.Size = new System.Drawing.Size(92, 42);
            this.btnAuditTrail.TabIndex = 41;
            this.btnAuditTrail.Text = "&Sent \r\nInvoices";
            this.btnAuditTrail.UseVisualStyleBackColor = false;
            this.btnAuditTrail.Click += new System.EventHandler(this.btnAuditTrail_Click);
            // 
            // label_EmailFrom
            // 
            this.label_EmailFrom.AutoSize = true;
            this.label_EmailFrom.Location = new System.Drawing.Point(221, 417);
            this.label_EmailFrom.Name = "label_EmailFrom";
            this.label_EmailFrom.Size = new System.Drawing.Size(61, 13);
            this.label_EmailFrom.TabIndex = 43;
            this.label_EmailFrom.Text = "Email_From";
            this.label_EmailFrom.Visible = false;
            // 
            // label_EmailPassword
            // 
            this.label_EmailPassword.AutoSize = true;
            this.label_EmailPassword.Location = new System.Drawing.Point(220, 435);
            this.label_EmailPassword.Name = "label_EmailPassword";
            this.label_EmailPassword.Size = new System.Drawing.Size(84, 13);
            this.label_EmailPassword.TabIndex = 44;
            this.label_EmailPassword.Text = "Email_Password";
            this.label_EmailPassword.Visible = false;
            // 
            // label_EmailMessage
            // 
            this.label_EmailMessage.AutoSize = true;
            this.label_EmailMessage.Location = new System.Drawing.Point(311, 417);
            this.label_EmailMessage.Name = "label_EmailMessage";
            this.label_EmailMessage.Size = new System.Drawing.Size(81, 13);
            this.label_EmailMessage.TabIndex = 43;
            this.label_EmailMessage.Text = "Email_Message";
            this.label_EmailMessage.Visible = false;
            // 
            // label_EmailSubject
            // 
            this.label_EmailSubject.AutoSize = true;
            this.label_EmailSubject.Location = new System.Drawing.Point(310, 435);
            this.label_EmailSubject.Name = "label_EmailSubject";
            this.label_EmailSubject.Size = new System.Drawing.Size(74, 13);
            this.label_EmailSubject.TabIndex = 44;
            this.label_EmailSubject.Text = "Email_Subject";
            this.label_EmailSubject.Visible = false;
            // 
            // label_SMTP_CC
            // 
            this.label_SMTP_CC.AutoSize = true;
            this.label_SMTP_CC.Location = new System.Drawing.Point(406, 417);
            this.label_SMTP_CC.Name = "label_SMTP_CC";
            this.label_SMTP_CC.Size = new System.Drawing.Size(52, 13);
            this.label_SMTP_CC.TabIndex = 43;
            this.label_SMTP_CC.Text = "Email_CC";
            this.label_SMTP_CC.Visible = false;
            // 
            // label_SMTPClient
            // 
            this.label_SMTPClient.AutoSize = true;
            this.label_SMTPClient.Location = new System.Drawing.Point(405, 435);
            this.label_SMTPClient.Name = "label_SMTPClient";
            this.label_SMTPClient.Size = new System.Drawing.Size(69, 13);
            this.label_SMTPClient.TabIndex = 44;
            this.label_SMTPClient.Text = "SMTP_Client";
            this.label_SMTPClient.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Email_Port";
            this.label7.Visible = false;
            // 
            // label_SMTPSSL
            // 
            this.label_SMTPSSL.AutoSize = true;
            this.label_SMTPSSL.Location = new System.Drawing.Point(489, 434);
            this.label_SMTPSSL.Name = "label_SMTPSSL";
            this.label_SMTPSSL.Size = new System.Drawing.Size(63, 13);
            this.label_SMTPSSL.TabIndex = 44;
            this.label_SMTPSSL.Text = "SMTP_SSL";
            this.label_SMTPSSL.Visible = false;
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(582, 443);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(83, 13);
            this.label_Path.TabIndex = 45;
            this.label_Path.Text = "AttachmentPath";
            this.label_Path.Visible = false;
            // 
            // label_InvNumumber
            // 
            this.label_InvNumumber.AutoSize = true;
            this.label_InvNumumber.Location = new System.Drawing.Point(223, 463);
            this.label_InvNumumber.Name = "label_InvNumumber";
            this.label_InvNumumber.Size = new System.Drawing.Size(67, 13);
            this.label_InvNumumber.TabIndex = 46;
            this.label_InvNumumber.Text = "invoice_num";
            this.label_InvNumumber.Visible = false;
            // 
            // label_InvDate
            // 
            this.label_InvDate.AutoSize = true;
            this.label_InvDate.Location = new System.Drawing.Point(297, 463);
            this.label_InvDate.Name = "label_InvDate";
            this.label_InvDate.Size = new System.Drawing.Size(68, 13);
            this.label_InvDate.TabIndex = 47;
            this.label_InvDate.Text = "invoice_date";
            this.label_InvDate.Visible = false;
            // 
            // label_InvAccount
            // 
            this.label_InvAccount.AutoSize = true;
            this.label_InvAccount.Location = new System.Drawing.Point(382, 463);
            this.label_InvAccount.Name = "label_InvAccount";
            this.label_InvAccount.Size = new System.Drawing.Size(87, 13);
            this.label_InvAccount.TabIndex = 48;
            this.label_InvAccount.Text = "invoice_Account";
            this.label_InvAccount.Visible = false;
            // 
            // label_InvAmount
            // 
            this.label_InvAmount.AutoSize = true;
            this.label_InvAmount.Location = new System.Drawing.Point(502, 463);
            this.label_InvAmount.Name = "label_InvAmount";
            this.label_InvAmount.Size = new System.Drawing.Size(83, 13);
            this.label_InvAmount.TabIndex = 49;
            this.label_InvAmount.Text = "invoice_Amount";
            this.label_InvAmount.Visible = false;
            // 
            // label_InvDescription
            // 
            this.label_InvDescription.AutoSize = true;
            this.label_InvDescription.Location = new System.Drawing.Point(600, 463);
            this.label_InvDescription.Name = "label_InvDescription";
            this.label_InvDescription.Size = new System.Drawing.Size(100, 13);
            this.label_InvDescription.TabIndex = 50;
            this.label_InvDescription.Text = "invoice_Description";
            this.label_InvDescription.Visible = false;
            // 
            // btnChangeMessage
            // 
            this.btnChangeMessage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMessage.Location = new System.Drawing.Point(110, 414);
            this.btnChangeMessage.Name = "btnChangeMessage";
            this.btnChangeMessage.Size = new System.Drawing.Size(92, 42);
            this.btnChangeMessage.TabIndex = 51;
            this.btnChangeMessage.Text = "&Change\r\nMessage";
            this.btnChangeMessage.UseVisualStyleBackColor = false;
            this.btnChangeMessage.Click += new System.EventHandler(this.btnChangeMessage_Click);
            // 
            // label_InvoiceEmail
            // 
            this.label_InvoiceEmail.AutoSize = true;
            this.label_InvoiceEmail.Location = new System.Drawing.Point(734, 469);
            this.label_InvoiceEmail.Name = "label_InvoiceEmail";
            this.label_InvoiceEmail.Size = new System.Drawing.Size(72, 13);
            this.label_InvoiceEmail.TabIndex = 52;
            this.label_InvoiceEmail.Text = "invoice_Email";
            this.label_InvoiceEmail.Visible = false;
            // 
            // BulkInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 491);
            this.Controls.Add(this.label_InvoiceEmail);
            this.Controls.Add(this.btnChangeMessage);
            this.Controls.Add(this.label_InvDescription);
            this.Controls.Add(this.label_InvAmount);
            this.Controls.Add(this.label_InvAccount);
            this.Controls.Add(this.label_InvDate);
            this.Controls.Add(this.label_InvNumumber);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.label_SMTPSSL);
            this.Controls.Add(this.label_SMTPClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_EmailSubject);
            this.Controls.Add(this.label_SMTP_CC);
            this.Controls.Add(this.label_EmailMessage);
            this.Controls.Add(this.label_EmailPassword);
            this.Controls.Add(this.btnAuditTrail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPrinter);
            this.Controls.Add(this.btnMultiPrint);
            this.Controls.Add(this.btnSinglePrint);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.label_InvoiceNumber);
            this.Controls.Add(this.label_EmailFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BulkInvoicing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk Invoicing";
            this.Load += new System.EventHandler(this.BulkInvoicing_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.ComboBox comboCustomerGroup;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSinglePrint;
        private System.Windows.Forms.Button btnMultiPrint;
        private System.Windows.Forms.ComboBox comboBoxPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_InvoiceNumber;
        private System.Windows.Forms.Button btnAuditTrail;
        private System.Windows.Forms.Label label_EmailFrom;
        private System.Windows.Forms.Label label_EmailPassword;
        private System.Windows.Forms.Label label_EmailMessage;
        private System.Windows.Forms.Label label_EmailSubject;
        private System.Windows.Forms.Label label_SMTP_CC;
        private System.Windows.Forms.Label label_SMTPClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_SMTPSSL;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvTotExclDEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvTotTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvTotInclDEx;
        private System.Windows.Forms.Label label_InvNumumber;
        private System.Windows.Forms.Label label_InvDate;
        private System.Windows.Forms.Label label_InvAccount;
        private System.Windows.Forms.Label label_InvAmount;
        private System.Windows.Forms.Label label_InvDescription;
        private System.Windows.Forms.Button btnChangeMessage;
        private System.Windows.Forms.Label label_InvoiceEmail;
    }
}
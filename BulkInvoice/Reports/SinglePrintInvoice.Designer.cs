namespace BulkInvoice.Reports
{
    partial class SinglePrintInvoice
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
            this.label_InvoiceNumber = new System.Windows.Forms.Label();
            this.label_PrinterName = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label_EmailFrom = new System.Windows.Forms.Label();
            this.label_EmailPassword = new System.Windows.Forms.Label();
            this.label_EmailSubject = new System.Windows.Forms.Label();
            this.label_EmailMessage = new System.Windows.Forms.Label();
            this.label_EmailCC = new System.Windows.Forms.Label();
            this.label_SMTPClient = new System.Windows.Forms.Label();
            this.label_SMTPPort = new System.Windows.Forms.Label();
            this.label_SMTPSSL = new System.Windows.Forms.Label();
            this.label_EmailTo = new System.Windows.Forms.Label();
            this.label_attachmentPath = new System.Windows.Forms.Label();
            this.label_EmailSecondSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_InvoiceNumber
            // 
            this.label_InvoiceNumber.AutoSize = true;
            this.label_InvoiceNumber.Location = new System.Drawing.Point(120, 247);
            this.label_InvoiceNumber.Name = "label_InvoiceNumber";
            this.label_InvoiceNumber.Size = new System.Drawing.Size(79, 13);
            this.label_InvoiceNumber.TabIndex = 0;
            this.label_InvoiceNumber.Text = "InvoiceNumber";
            // 
            // label_PrinterName
            // 
            this.label_PrinterName.AutoSize = true;
            this.label_PrinterName.Location = new System.Drawing.Point(123, 287);
            this.label_PrinterName.Name = "label_PrinterName";
            this.label_PrinterName.Size = new System.Drawing.Size(65, 13);
            this.label_PrinterName.TabIndex = 1;
            this.label_PrinterName.Text = "PrinterName";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(944, 640);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label_EmailFrom
            // 
            this.label_EmailFrom.AutoSize = true;
            this.label_EmailFrom.Location = new System.Drawing.Point(454, 53);
            this.label_EmailFrom.Name = "label_EmailFrom";
            this.label_EmailFrom.Size = new System.Drawing.Size(58, 13);
            this.label_EmailFrom.TabIndex = 3;
            this.label_EmailFrom.Text = "Email From";
            // 
            // label_EmailPassword
            // 
            this.label_EmailPassword.AutoSize = true;
            this.label_EmailPassword.Location = new System.Drawing.Point(454, 85);
            this.label_EmailPassword.Name = "label_EmailPassword";
            this.label_EmailPassword.Size = new System.Drawing.Size(81, 13);
            this.label_EmailPassword.TabIndex = 4;
            this.label_EmailPassword.Text = "Email Password";
            // 
            // label_EmailSubject
            // 
            this.label_EmailSubject.AutoSize = true;
            this.label_EmailSubject.Location = new System.Drawing.Point(454, 147);
            this.label_EmailSubject.Name = "label_EmailSubject";
            this.label_EmailSubject.Size = new System.Drawing.Size(71, 13);
            this.label_EmailSubject.TabIndex = 5;
            this.label_EmailSubject.Text = "Email Subject";
            // 
            // label_EmailMessage
            // 
            this.label_EmailMessage.AutoSize = true;
            this.label_EmailMessage.Location = new System.Drawing.Point(454, 180);
            this.label_EmailMessage.Name = "label_EmailMessage";
            this.label_EmailMessage.Size = new System.Drawing.Size(78, 13);
            this.label_EmailMessage.TabIndex = 6;
            this.label_EmailMessage.Text = "Email Message";
            // 
            // label_EmailCC
            // 
            this.label_EmailCC.AutoSize = true;
            this.label_EmailCC.Location = new System.Drawing.Point(454, 113);
            this.label_EmailCC.Name = "label_EmailCC";
            this.label_EmailCC.Size = new System.Drawing.Size(49, 13);
            this.label_EmailCC.TabIndex = 7;
            this.label_EmailCC.Text = "Email CC";
            // 
            // label_SMTPClient
            // 
            this.label_SMTPClient.AutoSize = true;
            this.label_SMTPClient.Location = new System.Drawing.Point(454, 215);
            this.label_SMTPClient.Name = "label_SMTPClient";
            this.label_SMTPClient.Size = new System.Drawing.Size(66, 13);
            this.label_SMTPClient.TabIndex = 8;
            this.label_SMTPClient.Text = "SMTP Client";
            // 
            // label_SMTPPort
            // 
            this.label_SMTPPort.AutoSize = true;
            this.label_SMTPPort.Location = new System.Drawing.Point(454, 252);
            this.label_SMTPPort.Name = "label_SMTPPort";
            this.label_SMTPPort.Size = new System.Drawing.Size(59, 13);
            this.label_SMTPPort.TabIndex = 9;
            this.label_SMTPPort.Text = "SMTP Port";
            // 
            // label_SMTPSSL
            // 
            this.label_SMTPSSL.AutoSize = true;
            this.label_SMTPSSL.Location = new System.Drawing.Point(454, 293);
            this.label_SMTPSSL.Name = "label_SMTPSSL";
            this.label_SMTPSSL.Size = new System.Drawing.Size(60, 13);
            this.label_SMTPSSL.TabIndex = 10;
            this.label_SMTPSSL.Text = "SMTP SSL";
            // 
            // label_EmailTo
            // 
            this.label_EmailTo.AutoSize = true;
            this.label_EmailTo.Location = new System.Drawing.Point(457, 345);
            this.label_EmailTo.Name = "label_EmailTo";
            this.label_EmailTo.Size = new System.Drawing.Size(48, 13);
            this.label_EmailTo.TabIndex = 11;
            this.label_EmailTo.Text = "Email To";
            // 
            // label_attachmentPath
            // 
            this.label_attachmentPath.AutoSize = true;
            this.label_attachmentPath.Location = new System.Drawing.Point(460, 382);
            this.label_attachmentPath.Name = "label_attachmentPath";
            this.label_attachmentPath.Size = new System.Drawing.Size(85, 13);
            this.label_attachmentPath.TabIndex = 12;
            this.label_attachmentPath.Text = "Attachment path";
            // 
            // label_EmailSecondSend
            // 
            this.label_EmailSecondSend.AutoSize = true;
            this.label_EmailSecondSend.Location = new System.Drawing.Point(467, 415);
            this.label_EmailSecondSend.Name = "label_EmailSecondSend";
            this.label_EmailSecondSend.Size = new System.Drawing.Size(65, 13);
            this.label_EmailSecondSend.TabIndex = 13;
            this.label_EmailSecondSend.Text = "Email To CC";
            // 
            // SinglePrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 640);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label_PrinterName);
            this.Controls.Add(this.label_InvoiceNumber);
            this.Controls.Add(this.label_EmailFrom);
            this.Controls.Add(this.label_EmailPassword);
            this.Controls.Add(this.label_EmailCC);
            this.Controls.Add(this.label_EmailSubject);
            this.Controls.Add(this.label_EmailMessage);
            this.Controls.Add(this.label_SMTPClient);
            this.Controls.Add(this.label_SMTPPort);
            this.Controls.Add(this.label_SMTPSSL);
            this.Controls.Add(this.label_EmailTo);
            this.Controls.Add(this.label_attachmentPath);
            this.Controls.Add(this.label_EmailSecondSend);
            this.Name = "SinglePrintInvoice";
            this.Text = "SinglePrintInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.SinglePrintInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InvoiceNumber;
        private System.Windows.Forms.Label label_PrinterName;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label_EmailFrom;
        private System.Windows.Forms.Label label_EmailPassword;
        private System.Windows.Forms.Label label_EmailSubject;
        private System.Windows.Forms.Label label_EmailMessage;
        private System.Windows.Forms.Label label_EmailCC;
        private System.Windows.Forms.Label label_SMTPClient;
        private System.Windows.Forms.Label label_SMTPPort;
        private System.Windows.Forms.Label label_SMTPSSL;
        private System.Windows.Forms.Label label_EmailTo;
        private System.Windows.Forms.Label label_attachmentPath;
        private System.Windows.Forms.Label label_EmailSecondSend;
    }
}
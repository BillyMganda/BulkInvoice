using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using BulkInvoice.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net.Mail;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace BulkInvoice.Forms
{
    public partial class BulkInvoicing : Form
    {
        public BulkInvoicing()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString;


        //LOAD CUSTOMER GROUP
        public void loadCustomerGroup()
        {
            string query = "SELECT DISTINCT NAME FROM Client";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            SqlDataReader sqlreader;
            try
            {
                sqlcon.Open();
                sqlreader = sqlcmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    string client_name = sqlreader.GetString(0);
                    comboCustomerGroup.Items.Add(client_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LOAD PRINTERS
        public void loadPrinters()
        {
            PrintDocument prtdoc = new PrintDocument();
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                comboBoxPrinter.Items.Add(strPrinter);
                if (strPrinter == strDefaultPrinter)
                {
                    comboBoxPrinter.SelectedIndex = comboBoxPrinter.Items.IndexOf(strPrinter);
                }
            }
        }
        //LOAD EMAIL DETAILS
        public void loadEmailSettings()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                DataTable dt = new DataTable();
                sqlcon.Open();
                SqlDataReader myReader = null;
                string query = "SELECT * FROM WIZ_BulkInvoice_Settings";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                myReader = sqlcmd.ExecuteReader();
                while (myReader.Read())
                {
                    label_EmailFrom.Text = (myReader["EmailFrom"].ToString());
                    label_EmailPassword.Text = (myReader["EmailPassword"].ToString());
                    label_EmailMessage.Text = (myReader["EmailMessage"].ToString());
                    label_EmailSubject.Text = (myReader["EmailSubject"].ToString());
                    label_SMTP_CC.Text = (myReader["EmailCC"].ToString());
                    label_SMTPClient.Text = (myReader["SMTP_ServerName"].ToString());
                    label7.Text = (myReader["SMTP_Port"].ToString());
                    label_SMTPSSL.Text = (myReader["SMTP_Enable_SSL"].ToString());
                    label_Path.Text = (myReader["File_Path"].ToString());
                }
            }
        }
        //FORM LOAD
        private void BulkInvoicing_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            loadEmailSettings();
            loadCustomerGroup();
            loadPrinters();

            if (dataGridView1.Rows.Count == 0)
            {
                btnSinglePrint.Enabled = false;
                btnMultiPrint.Enabled = false;
            }
        }
        //LOAD DATA
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT DISTINCT InvNumber, Account, Description, InvDate, InvTotExclDEx, InvTotTax, InvTotInclDEx, EMail FROM WIZ_BulkInvoice_Report WHERE InvDate BETWEEN '" +Convert.ToDateTime(dateFrom.Value) + "' AND '" +Convert.ToDateTime(dateEnd.Value) + "' AND InvNumber <> '' AND InvNumber LIKE 'IN%' ", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (dataGridView1.Rows.Count >= 1)
                {
                    btnSinglePrint.Enabled = true;
                    btnMultiPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                string filepath = @"C:\BulkInvoice\Documents-Final\Errors.txt";  // file
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine("==========There was an error Loading database data to datagrid==========");
                    writer.WriteLine("Date: " + DateTime.Now.ToString());
                    writer.WriteLine();
                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);
                        ex = ex.InnerException;
                    }
                }
            }
        }
        //SELCT A ROW
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_InvoiceNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();      //invoice number
            label_InvoiceEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();       //email

            label_InvNumumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label_InvDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label_InvAccount.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label_InvAmount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label_InvDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        //AUDIT TRAIL
        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            try
            {
                AuditTrail at = new AuditTrail();
                at.ShowDialog();
            }
            catch(Exception ex)
            {
                string filepath = @"C:\BulkInvoice\Documents-Final\Errors.txt";  // file
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine("==========There was an error loading processed invoices to window==========");
                    writer.WriteLine("Date: " + DateTime.Now.ToString());
                    writer.WriteLine();
                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);
                        ex = ex.InnerException;
                    }
                }
            }
        }
        //SINGLE PRINT
        public static string SetInvoiceNumberValue = "";
        public static string selected_Email = "";
        public static string SelectedPrinter = "";
        public static string attachment_path = "";
        private void btnSinglePrint_Click(object sender, EventArgs e)
        {
            if (label_InvoiceNumber.Text == "invoice_number" || label_InvoiceNumber.Text == "" || label_InvoiceEmail.Text == "invoice_Email" || label_InvoiceEmail.Text =="")
            {
                MessageBox.Show("You have not selected an invoice to print or email is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
            else
            {
                try
                {
                    //insert into audit trail table                    
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "INSERT INTO WIZ_BulkInvoice_Audit_Trail(Invoice_Number,Invoice_Date,Account,Invoice_Amount,Invoice_Description)VALUES(@Invoice_Number, @Invoice_Date, @Account, @Invoice_Amount, @Invoice_Description)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Invoice_Number", label_InvNumumber.Text);
                        cmd.Parameters.AddWithValue("@Invoice_Date", label_InvDate.Text);
                        cmd.Parameters.AddWithValue("@Account", label_InvAccount.Text);
                        cmd.Parameters.AddWithValue("@Invoice_Amount", Convert.ToDouble(label_InvAmount.Text));
                        cmd.Parameters.AddWithValue("@Invoice_Description", label_InvDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                    //open report window
                    SetInvoiceNumberValue = label_InvoiceNumber.Text;
                    selected_Email = label_InvoiceEmail.Text;
                    SelectedPrinter = comboBoxPrinter.Text;
                    attachment_path = label_Path.Text;
                    SinglePrintInvoice singlePrintInvoice = new SinglePrintInvoice();
                    singlePrintInvoice.Show();
                }
                catch(Exception ex)
                {
                    string filepath = @"C:\BulkInvoice\Documents-Final\Errors.txt";  // file
                    using (StreamWriter writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine("==========There was an error in your operation: Invoice already processed==========");
                        writer.WriteLine("Date: " + DateTime.Now.ToString());
                        writer.WriteLine();
                        while (ex != null)
                        {
                            writer.WriteLine(ex.GetType().FullName);
                            writer.WriteLine("Message : " + ex.Message);
                            writer.WriteLine("StackTrace : " + ex.StackTrace);
                            ex = ex.InnerException;
                        }
                    }
                }
            }            
        }
   
        //MULTI PRINT
        string email;
        string attachment;
        ArrayList emailList = new ArrayList();
        ArrayList attachList = new ArrayList();       
        private void btnMultiPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("You can not print an empty invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                try
                {
                    //saving bulk to db code       
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string query = @"INSERT INTO WIZ_BulkInvoice_Audit_Trail (Invoice_Number, Invoice_Date, Account, Invoice_Amount, Invoice_Description) VALUES (@Invoice_Number, @Invoice_Date, @Account, @Invoice_Amount, @Invoice_Description)  ";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@Invoice_Number", row.Cells["InvNumber"].Value);
                            cmd.Parameters.AddWithValue("@Invoice_Date", row.Cells["InvDate"].Value);
                            cmd.Parameters.AddWithValue("@Account", row.Cells["Account"].Value);
                            cmd.Parameters.AddWithValue("@Invoice_Amount", row.Cells["InvTotInclDEx"].Value);
                            cmd.Parameters.AddWithValue("@Invoice_Description", row.Cells["Description"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                     
                    //print bulk report
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        using (SqlConnection con = new SqlConnection(connectionstring))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM WIZ_BulkInvoice_Invoices WHERE InvNumber = '" + dataGridView1.Rows[i].Cells[0].Value + "' ORDER BY iLineID ", con);
                            ReportDocument report = new ReportDocument();
                            report.Load(@"C:\\BulkInvoice\\CrystalReport\\Invoice.rpt");
                            DataSet datatablesource = new DataSet();
                            sda.Fill(datatablesource, "WIZ_BulkInvoice_Invoices");
                            report.SetDataSource(datatablesource);
                            report.SummaryInfo.ReportTitle = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            report.PrintToPrinter(1, false, 0, 0);
                            report.PrintOptions.PrinterName = comboBoxPrinter.Text;
                            report.Dispose();
                        }

                    }

                    //save bulk pdf to folder
                    //using (SqlConnection con = new SqlConnection(connectionstring))
                    //{
                    //    foreach (DataGridViewRow row in dataGridView1.Rows)
                    //    {
                    //        for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    //        {
                    //            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM WIZ_BulkInvoice_Report WHERE InvNumber = '" + dataGridView1.Rows[k].Cells[0].Value + "' ", con);
                    //            ReportDocument rpt = new ReportDocument();
                    //            rpt.Load(@"C:\\BulkInvoice\\CrystalReport\\Invoice.rpt");
                    //            DataSet datatablesource = new DataSet();
                    //            sda.Fill(datatablesource, "WIZ_BulkInvoice_Report");
                    //            rpt.SetDataSource(datatablesource);
                    //            ExportOptions rptExportOption;
                    //            DiskFileDestinationOptions rptFileDestOption = new DiskFileDestinationOptions();
                    //            PdfRtfWordFormatOptions rptFormatOption = new PdfRtfWordFormatOptions();
                    //            string reportFileName = @"C:\BulkInvoice\Documents\" + dataGridView1.Rows[k].Cells[0].Value + ".pdf";  //save path
                    //            rptFileDestOption.DiskFileName = reportFileName;
                    //            rptExportOption = rpt.ExportOptions;
                    //            {
                    //                rptExportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                    //                rptExportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                    //                rptExportOption.ExportDestinationOptions = rptFileDestOption;
                    //                rptExportOption.ExportFormatOptions = rptFormatOption;
                    //            }
                    //            rpt.Export();
                    //            rpt.Dispose();
                    //        }
                    //    }
                    //}

                    //send bulk mail
                    for (int t = 0; t < dataGridView1.Rows.Count; t++)
                    {                        
                        email = dataGridView1.Rows[t].Cells[7].Value.ToString();
                        attachment = label_Path.Text + dataGridView1.Rows[t].Cells[0].Value.ToString() + ".pdf";          //path and file
                        sendMail(email, attachment);
                    }                   
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\BulkInvoice\Documents-Final\Errors.txt";  // file
                    using (StreamWriter writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine("==========There was an error in bulk invoices: Either invoice has already been processed, software could not print or email could not be sent==========");
                        writer.WriteLine("Date: " + DateTime.Now.ToString());
                        writer.WriteLine();
                        while (ex != null)
                        {
                            writer.WriteLine(ex.GetType().FullName);
                            writer.WriteLine("Message : " + ex.Message);
                            writer.WriteLine("StackTrace : " + ex.StackTrace);
                            ex = ex.InnerException;
                        }
                    }
                }
                finally
                {                   
                    moveFiles();
                }
            }

        }
        //SEND EMAIL      
        public void sendMail(string sendTo, string sendAttachments)
        {
            using (MailMessage mail = new MailMessage())
            {
                string from = label_EmailFrom.Text;

                for (int t = 0; t < dataGridView1.Rows.Count; t++)
                {
                    foreach (var address in dataGridView1.Rows[t].Cells[7].Value.ToString().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        mail.To.Add(address);
                    }
                }  
                //mail.To.Add(sendTo);
                mail.From = new MailAddress(from, "Securex Mail", Encoding.UTF8);
                //mail.Bcc.Add(label_SMTP_CC.Text);
                //mail.CC.Add(label_SMTP_CC.Text);
                mail.Subject = label_EmailSubject.Text;
                mail.Body = label_EmailMessage.Text;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                mail.Attachments.Add(new Attachment(sendAttachments));
                SmtpClient client = new SmtpClient(label_SMTPClient.Text);
                client.Credentials = new System.Net.NetworkCredential(label_EmailFrom.Text, label_EmailPassword.Text);
                client.EnableSsl = Convert.ToBoolean(label_SMTPSSL.Text);
                try
                {
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //cut files
        public void moveFiles()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@"\\192.168.0.32\Invoice\");                       //path and file
                foreach (var fullName in filePaths)
                {
                    string fileName = Path.GetFileName(fullName);
                    string destination = String.Format(@"C:\BulkInvoice\Documents-Final\{0}", fileName);
                    File.Move(fullName, destination);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CHANGE MESSAGE
        private void btnChangeMessage_Click(object sender, EventArgs e)
        {
            Change_Message cm = new Change_Message();
            cm.ShowDialog();
        }
    }
}

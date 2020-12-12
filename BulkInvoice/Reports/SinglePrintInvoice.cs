using BulkInvoice.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using CrystalDecisions.Shared;
using System.IO;
using System.Net.Mail;
using MimeKit;
using System.Net.Mime;
using System.Security.Principal;
using System.Web;
using System.Drawing.Text;
using System.IO.Compression;
using Microsoft.SqlServer.Management.Smo;


namespace BulkInvoice.Reports
{
    public partial class SinglePrintInvoice : Form
    {
        ReportDocument crystal = new ReportDocument();
        
        public SinglePrintInvoice()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString;
       
        //LOAD

        private void SinglePrintInvoice_Load(object sender, EventArgs e)
        {
            label_InvoiceNumber.Text = BulkInvoicing.SetInvoiceNumberValue;
            label_EmailTo.Text = BulkInvoicing.selected_Email;
            label_PrinterName.Text = BulkInvoicing.SelectedPrinter;
            label_attachmentPath.Text = BulkInvoicing.attachment_path;

            //loadEmailSettings();
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
                    label_EmailCC.Text = (myReader["EmailCC"].ToString());
                    label_SMTPClient.Text = (myReader["SMTP_ServerName"].ToString());
                    label_SMTPPort.Text = (myReader["SMTP_Port"].ToString());
                    label_SMTPSSL.Text = (myReader["SMTP_Enable_SSL"].ToString());
                }
            }
            //load email CC
            using(SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                DataTable dt = new DataTable();
                sqlcon.Open();
                SqlDataReader myReader = null;
                string query = "SELECT Email FROM WIZ_BulkInvoice_CrystalReport WHERE InvNumber = '"+label_InvoiceNumber.Text+"' ";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                myReader = sqlcmd.ExecuteReader();
                while (myReader.Read())
                {
                    label_EmailSecondSend.Text = (myReader["Email"].ToString());                    
                }
            }

            try
            {
                //print invoice
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM WIZ_BulkInvoice_Invoices WHERE InvNumber = '" + label_InvoiceNumber.Text + "' ORDER BY iLineID ", con);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "WIZ_BulkInvoice_Invoices");
                    crystal.Load(@"C:\BulkInvoice\CrystalReport\Invoice.rpt");
                    crystal.SetDataSource(dst);
                    crystalReportViewer1.ReportSource = crystal;
                    crystal.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                    crystal.SummaryInfo.ReportTitle = label_InvoiceNumber.Text;
                    crystal.PrintOptions.PaperSize = PaperSize.PaperA4Small;
                    crystal.PrintToPrinter(1, false, 0, 0);
                    crystal.PrintOptions.PrinterName = label_PrinterName.Text;

                }

                //delay to send sendEmail  
                Task.Delay(10000).ContinueWith(t => sendEmail()); 
                

            }
            catch (Exception ex)
            {
                string filepath = @"C:\BulkInvoice\Documents-Final\Errors.txt";  // file
                using(StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine("==========There was an error Printing or send an email==========");
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
                //move files to a different folder
                //string[] filePaths = Directory.GetFiles(@"\\192.168.0.104\c\Users\usrstl\Downloads\Invoicetest\");           //move to a path
                //foreach (var fullName in filePaths)
                //{
                //    string fileName = Path.GetFileName(fullName);
                //    string destination = String.Format(@"C:\BulkInvoice\Documents-Final\{0}", fileName);
                //    File.Move(fullName, destination);
                //}
            }
        }        
        
        //SEND MAIL
        public void sendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                SmtpClient smtp = new SmtpClient(label_SMTPClient.Text);
                mail.From = new MailAddress(label_EmailFrom.Text);

                foreach(var address in label_EmailSecondSend.Text.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    mail.To.Add(address);
                }

                //mail.To.Add(label_EmailTo.Text);
                //mail.Bcc.Add(label_EmailCC.Text);
                mail.Subject = label_EmailSubject.Text;
                mail.Body = label_EmailMessage.Text;

                FileStream fStream;
                string filePath = @"\\192.168.0.32\Invoice\";
                DirectoryInfo dir = new DirectoryInfo(filePath);
                foreach (FileInfo files in dir.GetFiles("*.*"))
                {
                    fStream = File.OpenRead(filePath + @"\" + files.Name);
                    mail.Attachments.Add(new Attachment(fStream, files.Name));
                }

                smtp.Port = Convert.ToInt32(label_SMTPPort.Text);
                smtp.Credentials = new System.Net.NetworkCredential(label_EmailFrom.Text, label_EmailPassword.Text);
                smtp.EnableSsl = Convert.ToBoolean(label_SMTPSSL.Text);
                smtp.Send(mail);

                // delay to move files
                Task.Delay(5000).ContinueWith(t => moveFilesToFolder());
            }

        }
        //MOVE FILES
        public void moveFilesToFolder()
        {
            //move files to a different folder
            string[] filePaths = Directory.GetFiles(@"\\192.168.0.32\Invoice");           //move to a path
            foreach (var fullName in filePaths)
            {
                string fileName = Path.GetFileName(fullName);
                string destination = String.Format(@"C:\BulkInvoice\Documents-Final\{0}", fileName);
                File.Move(fullName, destination);
            }
        }


        //SAVE PDF TO FILE              - method not used
        public void savePDF()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM WIZ_BulkInvoice_CrystalReport WHERE InvNumber = '" + label_InvoiceNumber.Text+ "' ", con);
                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"C:\\BulkInvoice\\CrystalReport\\Invoice.rpt");
                DataSet datatablesource = new DataSet();
                sda.Fill(datatablesource, "WIZ_BulkInvoice_Report");
                rpt.SetDataSource(datatablesource);
                ExportOptions rptExportOption;
                DiskFileDestinationOptions rptFileDestOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions rptFormatOption = new PdfRtfWordFormatOptions();
                string reportFileName = @"C:\BulkInvoice\Documents\" + label_InvoiceNumber.Text + ".pdf";  //save path
                rptFileDestOption.DiskFileName = reportFileName;
                rptExportOption = rpt.ExportOptions;
                {
                    rptExportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                    rptExportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                    rptExportOption.ExportDestinationOptions = rptFileDestOption;
                    rptExportOption.ExportFormatOptions = rptFormatOption;
                }
                rpt.Export();
                rpt.Dispose();
            }
        }

       
    }
}

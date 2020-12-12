using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Drawing.Printing;
using System.IO;
using System.Security.Cryptography;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace BulkInvoice.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();            
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString;
        //LOAD DB
        public void loadDatabase()
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        txtDatabaseName.Text = ServerName + "\\" + instanceName;
                    }
                }
            }
        }
        //FORM LOAD      
        private void Settings_Load(object sender, EventArgs e)
        {            
            loadAllDataToForm();
            if (txtEmailFrom.Text == "")
            {
                //do nothing
            }
            else
            {
                //licence here
                DateTime today = DateTime.Now;
                DateTime start_date = DateTime.Parse("09/28/2020");
                if ((today.Date - start_date.Date).TotalDays > 30)
                {
                    MessageBox.Show("Your licence has expired, update your licence to continue using the application","Licence Expired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    BulkInvoicing bi = new BulkInvoicing();
                    bi.ShowDialog();
                    this.Hide();
                    this.ShowInTaskbar = false;
                }                
            }
            loadDatabase();
            loadPrinters();
        }
        //TEST DB 1
        private void btnTestSageDB_Click(object sender, EventArgs e)
        {
            string onnectionString = string.Format("Data Source={0};  User ID={1}; Password={2};", txtDatabaseName.Text, txtUserName.Text, txtPassword.Text);
            try
            {
                SQLHelper helper = new SQLHelper(onnectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //populate dropdown with all databases                
                if (txtDatabaseName.Text != null && txtDatabaseName.Text != "")
                {
                    ServerConnection srvcon = new ServerConnection(txtDatabaseName.Text);
                    srvcon.LoginSecure = false;                    
                    srvcon.Login = txtUserName.Text;
                    srvcon.Password = txtPassword.Text;
                    Server srv = new Server(srvcon);
                    foreach (Database db in srv.Databases)
                    {                        
                        comboSageDB.Items.Add(db.Name);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CHECK BOX TO COPY SETTINGS
        private void checkBoxCopySettings_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDatabaseName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || comboSageDB.Text == "")
            {
                MessageBox.Show("Fill all text boxes above to copy", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCommonServer.Text = txtDatabaseName.Text;
                txtCommonUser.Text = txtUserName.Text;
                txtCommonPassword.Text = txtPassword.Text;
                comboCommonDB.Items.Add(comboSageDB.Text);                
            }
        }
        //TEST DB 2
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCommonServer.Text == "" || txtCommonUser.Text == "" || txtCommonPassword.Text == "" || comboCommonDB.Text == "")
            {
                MessageBox.Show("Fill all text boxes to proceed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string onnectionString = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", txtCommonServer.Text, comboCommonDB.Text, txtCommonUser.Text, txtCommonPassword.Text);
                try
                {
                    SQLHelper helper = new SQLHelper(onnectionString);
                    if (helper.IsConnection)
                        MessageBox.Show("Test connection successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
        //CLOSE BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();            
        }
        //LOAD PRINTERS
        public void loadPrinters()
        {
            PrintDocument prtdoc = new PrintDocument();
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                comboPrinter.Items.Add(strPrinter);
                if (strPrinter == strDefaultPrinter)
                {
                    comboPrinter.SelectedIndex = comboPrinter.Items.IndexOf(strPrinter);
                }
            }
        }
        //LOAD ALL DATA TO FORM
        public void loadAllDataToForm()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                DataTable dt = new DataTable();
                sqlcon.Open();
                SqlDataReader myReader = null;
                string query = "SELECT EmailFrom FROM WIZ_BulkInvoice_Settings";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                myReader = sqlcmd.ExecuteReader();
                while (myReader.Read())
                {
                    txtEmailFrom.Text = (myReader["EmailFrom"].ToString());
                }
                sqlcon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Application first time use. Connection to the database has to be established. Press OK", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CHECK SSL
        string SSL_yes;
        private void checkBoxSSL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSSL.CheckState == CheckState.Checked)
            {
                SSL_yes = "true";
            }
            else
            {
                SSL_yes = "false";
            }
        }
        //ENCORDING & WRITE TO FILE
        string cypherData;
        byte[] cypherByte;
        byte[] plainByte;
        byte[] plainKey;
        SymmetricAlgorithm alg;
        private void WriteToFilE()
        {
            //ENCRYPT
            cypherData = comboCommonDB.Text;
            plainByte = Encoding.ASCII.GetBytes(cypherData);
            plainKey = Encoding.ASCII.GetBytes("65f02fab40f56c8e409b121965fa1d657a80d237fabacab95f9c59f8f967becb");
            alg = new AesManaged();
            alg.Key = plainKey;
            alg.Mode = CipherMode.CBC;
            alg.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(plainByte, 0, plainByte.Length);
            cs.Close();
            cypherByte = ms.ToArray();
            ms.Close();
            comboCommonDB.Text = Encoding.ASCII.GetString(cypherByte);
            txtCommonServer.Text = Encoding.ASCII.GetString(cypherByte);
            txtCommonUser.Text = Encoding.ASCII.GetString(cypherByte);
            txtCommonPassword.Text = Encoding.ASCII.GetString(cypherByte);
            //SAVE FILE
            string folder = @"C:\BulkInvoice\File\";
            string fileName = "ConnectToDB.txt";
            string fullPath = folder + fileName;
            string[] content = { comboCommonDB.Text, txtCommonServer.Text, txtCommonUser.Text, txtCommonPassword.Text };
            File.WriteAllLines(fullPath, content);
        }
        //CREATE DIRECTORIES
        public void createDirectories()
        {
            //CREATE DIRECTORY
            string bulkinvoice = @"C:\BulkInvoice";
            string file = @"C:\BulkInvoice\File";
            string document = @"C:\BulkInvoice\Documents";
            string documents_final = @"C:\BulkInvoice\Documents-Final";
            string reports = @"C:\BulkInvoice\CrystalReport";
            if (!Directory.Exists(bulkinvoice))
            {
                Directory.CreateDirectory(bulkinvoice);
            }
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            if (!Directory.Exists(document))
            {
                Directory.CreateDirectory(document);
            }
            if (!Directory.Exists(documents_final))
            {
                Directory.CreateDirectory(documents_final);
            }
            if (!Directory.Exists(reports))
            {
                Directory.CreateDirectory(reports);
            }
        }
        //SAVE SETTINGS
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmailFrom.Text == "" || txtEmailPassword.Text == "" || txtEmailSMTPUser.Text == "" )
            {
                MessageBox.Show("Settings can not be saved, fill all fields to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("WIZ_BulkInvoice_Settings_Proc", sqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SageServerName", txtCommonServer.Text);           
                        cmd.Parameters.AddWithValue("@SageDatabaseName", comboCommonDB.Text);
                        cmd.Parameters.AddWithValue("@SageUsername", txtCommonUser.Text);
                        cmd.Parameters.AddWithValue("@SagePassword", txtCommonPassword.Text);
                        cmd.Parameters.AddWithValue("@EmailFrom", txtEmailFrom.Text);
                        cmd.Parameters.AddWithValue("@EmailPassword", txtEmailPassword.Text);
                        cmd.Parameters.AddWithValue("@EmailCC", txtEmailCC.Text);
                        cmd.Parameters.AddWithValue("@EmailSubject", txtEmailSubject.Text);
                        cmd.Parameters.AddWithValue("@EmailMessage", txtEmailMessage.Text);
                        cmd.Parameters.AddWithValue("@SMTP_ServerName", txtEmailSMTPServer.Text);
                        cmd.Parameters.AddWithValue("@SMTP_UserName", txtEmailSMTPUser.Text);
                        cmd.Parameters.AddWithValue("@SMTP_Password", txtEmailSMTPPassword.Text);
                        cmd.Parameters.AddWithValue("@SMTP_Port", txtEmailSMTPPort.Text);
                        cmd.Parameters.AddWithValue("@PrinterName", comboPrinter.Text);
                        cmd.Parameters.AddWithValue("@SMTP_Enable_SSL", SSL_yes);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Settings saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        createDirectories();
                        Hide();   
                        BulkInvoicing fb = new BulkInvoicing();
                        fb.ShowDialog();
                        WriteToFilE();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        
        //SAVE CONNECTION
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCommonServer.Text==""|| txtCommonUser.Text == "" || txtCommonPassword.Text == "" || comboCommonDB.Text == "")
                MessageBox.Show("Fill all common DB entries to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings"); 
                connectionStringsSection.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString = "Data Source='" + txtCommonServer.Text + "'; Initial Catalog='" + comboCommonDB.Text + "'; Persist Security Info=True; UID='" + txtCommonUser.Text + "'; password='" + txtCommonPassword.Text + "'";
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Connection successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}

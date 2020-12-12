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

namespace BulkInvoice.Forms
{
    public partial class AuditTrail : Form
    {
        public AuditTrail()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString;
        //LOAD FORM
        private void AuditTrail_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Invoice_Number, Invoice_Date, Account, Invoice_Amount, Invoice_Description FROM WIZ_BulkInvoice_Audit_Trail ", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CLOSE
        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

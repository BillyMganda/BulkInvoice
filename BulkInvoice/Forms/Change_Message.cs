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
    public partial class Change_Message : Form
    {
        public Change_Message()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["BulkInvoice.Properties.Settings.cn"].ConnectionString;
        //UPDATE MESSAGE
        private void btnUpdateMessage_Click(object sender, EventArgs e)
        {
            if (txtEmailMessageUpdate.Text == "")
                MessageBox.Show("You can not save an empty message!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "UPDATE WIZ_BulkInvoice_Settings SET EmailMessage = '" + txtEmailMessageUpdate.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Email Message Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }            
        }
    }    
}

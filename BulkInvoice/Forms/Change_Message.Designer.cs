namespace BulkInvoice.Forms
{
    partial class Change_Message
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailMessageUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateMessage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailMessageUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Email Message";
            // 
            // txtEmailMessageUpdate
            // 
            this.txtEmailMessageUpdate.Location = new System.Drawing.Point(6, 19);
            this.txtEmailMessageUpdate.MaxLength = 1500;
            this.txtEmailMessageUpdate.Multiline = true;
            this.txtEmailMessageUpdate.Name = "txtEmailMessageUpdate";
            this.txtEmailMessageUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailMessageUpdate.Size = new System.Drawing.Size(318, 228);
            this.txtEmailMessageUpdate.TabIndex = 6;
            // 
            // btnUpdateMessage
            // 
            this.btnUpdateMessage.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMessage.Location = new System.Drawing.Point(244, 280);
            this.btnUpdateMessage.Name = "btnUpdateMessage";
            this.btnUpdateMessage.Size = new System.Drawing.Size(92, 42);
            this.btnUpdateMessage.TabIndex = 42;
            this.btnUpdateMessage.Text = "&Update \r\nMessage";
            this.btnUpdateMessage.UseVisualStyleBackColor = false;
            this.btnUpdateMessage.Click += new System.EventHandler(this.btnUpdateMessage_Click);
            // 
            // Change_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 333);
            this.Controls.Add(this.btnUpdateMessage);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Change_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailMessageUpdate;
        private System.Windows.Forms.Button btnUpdateMessage;
    }
}
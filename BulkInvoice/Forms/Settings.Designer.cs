namespace BulkInvoice.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestSageDB = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboSageDB = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCommonDB = new System.Windows.Forms.ComboBox();
            this.txtCommonPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCommonUser = new System.Windows.Forms.TextBox();
            this.txtCommonServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCopySettings = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEmailSMTPPort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmailSMTPPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmailSMTPUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmailSMTPServer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmailMessage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboPrinter = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestSageDB);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.comboSageDB);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtDatabaseName);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SAGE DB";
            // 
            // btnTestSageDB
            // 
            this.btnTestSageDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestSageDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestSageDB.Location = new System.Drawing.Point(205, 87);
            this.btnTestSageDB.Name = "btnTestSageDB";
            this.btnTestSageDB.Size = new System.Drawing.Size(75, 25);
            this.btnTestSageDB.TabIndex = 4;
            this.btnTestSageDB.Text = "&Test";
            this.btnTestSageDB.UseVisualStyleBackColor = true;
            this.btnTestSageDB.Click += new System.EventHandler(this.btnTestSageDB_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(36, 127);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 13);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "SAGE DB";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Server Name";
            // 
            // comboSageDB
            // 
            this.comboSageDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSageDB.FormattingEnabled = true;
            this.comboSageDB.Location = new System.Drawing.Point(106, 124);
            this.comboSageDB.Name = "comboSageDB";
            this.comboSageDB.Size = new System.Drawing.Size(174, 21);
            this.comboSageDB.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(92, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(30, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(92, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(106, 25);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(174, 20);
            this.txtDatabaseName.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(37, 92);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.checkBoxCopySettings);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(222, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboCommonDB);
            this.groupBox3.Controls.Add(this.txtCommonPassword);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCommonUser);
            this.groupBox3.Controls.Add(this.txtCommonServer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(17, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COMMON DB";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(205, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "SAGE DB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Server Name";
            // 
            // comboCommonDB
            // 
            this.comboCommonDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCommonDB.FormattingEnabled = true;
            this.comboCommonDB.Location = new System.Drawing.Point(106, 124);
            this.comboCommonDB.Name = "comboCommonDB";
            this.comboCommonDB.Size = new System.Drawing.Size(174, 21);
            this.comboCommonDB.TabIndex = 5;
            // 
            // txtCommonPassword
            // 
            this.txtCommonPassword.Location = new System.Drawing.Point(106, 89);
            this.txtCommonPassword.Name = "txtCommonPassword";
            this.txtCommonPassword.PasswordChar = '*';
            this.txtCommonPassword.ReadOnly = true;
            this.txtCommonPassword.Size = new System.Drawing.Size(92, 20);
            this.txtCommonPassword.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "User Name";
            // 
            // txtCommonUser
            // 
            this.txtCommonUser.Location = new System.Drawing.Point(106, 57);
            this.txtCommonUser.Name = "txtCommonUser";
            this.txtCommonUser.ReadOnly = true;
            this.txtCommonUser.Size = new System.Drawing.Size(92, 20);
            this.txtCommonUser.TabIndex = 2;
            // 
            // txtCommonServer
            // 
            this.txtCommonServer.Location = new System.Drawing.Point(106, 25);
            this.txtCommonServer.Name = "txtCommonServer";
            this.txtCommonServer.ReadOnly = true;
            this.txtCommonServer.Size = new System.Drawing.Size(174, 20);
            this.txtCommonServer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Password";
            // 
            // checkBoxCopySettings
            // 
            this.checkBoxCopySettings.AutoSize = true;
            this.checkBoxCopySettings.Location = new System.Drawing.Point(107, 217);
            this.checkBoxCopySettings.Name = "checkBoxCopySettings";
            this.checkBoxCopySettings.Size = new System.Drawing.Size(125, 17);
            this.checkBoxCopySettings.TabIndex = 2;
            this.checkBoxCopySettings.Text = "Copy Above Settings";
            this.checkBoxCopySettings.UseVisualStyleBackColor = true;
            this.checkBoxCopySettings.CheckedChanged += new System.EventHandler(this.checkBoxCopySettings_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEmailSMTPPort);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.checkBoxSSL);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtEmailSMTPPassword);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtEmailSMTPUser);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtEmailSMTPServer);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtEmailMessage);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtEmailSubject);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtEmailCC);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtEmailPassword);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtEmailFrom);
            this.groupBox4.Location = new System.Drawing.Point(355, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 467);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Email Settings";
            // 
            // txtEmailSMTPPort
            // 
            this.txtEmailSMTPPort.Location = new System.Drawing.Point(226, 433);
            this.txtEmailSMTPPort.Name = "txtEmailSMTPPort";
            this.txtEmailSMTPPort.Size = new System.Drawing.Size(61, 20);
            this.txtEmailSMTPPort.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(191, 437);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Port";
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(82, 435);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSSL.TabIndex = 5;
            this.checkBoxSSL.Text = "Enable SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            this.checkBoxSSL.CheckedChanged += new System.EventHandler(this.checkBoxSSL_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "SMTP Pass";
            // 
            // txtEmailSMTPPassword
            // 
            this.txtEmailSMTPPassword.Location = new System.Drawing.Point(82, 403);
            this.txtEmailSMTPPassword.Name = "txtEmailSMTPPassword";
            this.txtEmailSMTPPassword.PasswordChar = '*';
            this.txtEmailSMTPPassword.Size = new System.Drawing.Size(205, 20);
            this.txtEmailSMTPPassword.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "SMTP User";
            // 
            // txtEmailSMTPUser
            // 
            this.txtEmailSMTPUser.Location = new System.Drawing.Point(82, 373);
            this.txtEmailSMTPUser.Name = "txtEmailSMTPUser";
            this.txtEmailSMTPUser.Size = new System.Drawing.Size(205, 20);
            this.txtEmailSMTPUser.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "SMTP Server";
            // 
            // txtEmailSMTPServer
            // 
            this.txtEmailSMTPServer.Location = new System.Drawing.Point(82, 344);
            this.txtEmailSMTPServer.Name = "txtEmailSMTPServer";
            this.txtEmailSMTPServer.Size = new System.Drawing.Size(205, 20);
            this.txtEmailSMTPServer.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Message";
            // 
            // txtEmailMessage
            // 
            this.txtEmailMessage.Location = new System.Drawing.Point(82, 144);
            this.txtEmailMessage.Multiline = true;
            this.txtEmailMessage.Name = "txtEmailMessage";
            this.txtEmailMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailMessage.Size = new System.Drawing.Size(205, 190);
            this.txtEmailMessage.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Subject";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(82, 113);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(205, 20);
            this.txtEmailSubject.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "BCC";
            // 
            // txtEmailCC
            // 
            this.txtEmailCC.Location = new System.Drawing.Point(82, 85);
            this.txtEmailCC.Name = "txtEmailCC";
            this.txtEmailCC.Size = new System.Drawing.Size(205, 20);
            this.txtEmailCC.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Password";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(82, 56);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(205, 20);
            this.txtEmailPassword.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "From";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(82, 28);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(205, 20);
            this.txtEmailFrom.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(347, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 460);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(660, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 460);
            this.panel2.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(667, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 467);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Other Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(41, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(148, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboPrinter);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(16, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(233, 73);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Printer Settings";
            // 
            // comboPrinter
            // 
            this.comboPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboPrinter.FormattingEnabled = true;
            this.comboPrinter.Location = new System.Drawing.Point(50, 30);
            this.comboPrinter.Name = "comboPrinter";
            this.comboPrinter.Size = new System.Drawing.Size(174, 21);
            this.comboPrinter.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Name";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestSageDB;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox comboSageDB;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.TextBox txtDatabaseName;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox comboCommonDB;
        internal System.Windows.Forms.TextBox txtCommonPassword;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtCommonUser;
        internal System.Windows.Forms.TextBox txtCommonServer;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxCopySettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtEmailFrom;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtEmailPassword;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtEmailCC;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtEmailSubject;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmailMessage;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtEmailSMTPServer;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtEmailSMTPUser;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtEmailSMTPPassword;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.ComboBox comboPrinter;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtEmailSMTPPort;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
    }
}
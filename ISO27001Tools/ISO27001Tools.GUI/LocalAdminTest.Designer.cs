namespace ISO27001Tools.GUI
{
    partial class LocalAdminTest
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.maskedTextBoxDHCPServer = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxIp = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.radioButtonDHCPScope = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleIp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewComputers = new System.Windows.Forms.DataGridView();
            this.listBoxLocalAdmins = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBarScanScope = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.ıpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelScanningIp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelScanningIp);
            this.groupBox1.Controls.Add(this.labelProgress);
            this.groupBox1.Controls.Add(this.progressBarScanScope);
            this.groupBox1.Controls.Add(this.buttonScan);
            this.groupBox1.Controls.Add(this.maskedTextBoxDHCPServer);
            this.groupBox1.Controls.Add(this.maskedTextBoxIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.radioButtonDHCPScope);
            this.groupBox1.Controls.Add(this.radioButtonSingleIp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 700);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgu Şartları";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(12, 220);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(212, 23);
            this.buttonScan.TabIndex = 3;
            this.buttonScan.Text = "Taramayı Başlat";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // maskedTextBoxDHCPServer
            // 
            this.maskedTextBoxDHCPServer.Location = new System.Drawing.Point(9, 112);
            this.maskedTextBoxDHCPServer.Name = "maskedTextBoxDHCPServer";
            this.maskedTextBoxDHCPServer.Size = new System.Drawing.Size(215, 20);
            this.maskedTextBoxDHCPServer.TabIndex = 2;
            // 
            // maskedTextBoxIp
            // 
            this.maskedTextBoxIp.Location = new System.Drawing.Point(12, 173);
            this.maskedTextBoxIp.Name = "maskedTextBoxIp";
            this.maskedTextBoxIp.Size = new System.Drawing.Size(215, 20);
            this.maskedTextBoxIp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DHCP Server";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(9, 157);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(86, 13);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Sorgulanacak IP";
            // 
            // radioButtonDHCPScope
            // 
            this.radioButtonDHCPScope.AutoSize = true;
            this.radioButtonDHCPScope.Location = new System.Drawing.Point(12, 51);
            this.radioButtonDHCPScope.Name = "radioButtonDHCPScope";
            this.radioButtonDHCPScope.Size = new System.Drawing.Size(89, 17);
            this.radioButtonDHCPScope.TabIndex = 0;
            this.radioButtonDHCPScope.Text = "DHCP Scope";
            this.radioButtonDHCPScope.UseVisualStyleBackColor = true;
            this.radioButtonDHCPScope.CheckedChanged += new System.EventHandler(this.radioButtonSingleIp_CheckedChanged);
            // 
            // radioButtonSingleIp
            // 
            this.radioButtonSingleIp.AutoSize = true;
            this.radioButtonSingleIp.Checked = true;
            this.radioButtonSingleIp.Location = new System.Drawing.Point(12, 28);
            this.radioButtonSingleIp.Name = "radioButtonSingleIp";
            this.radioButtonSingleIp.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSingleIp.TabIndex = 0;
            this.radioButtonSingleIp.TabStop = true;
            this.radioButtonSingleIp.Text = "Tek IP";
            this.radioButtonSingleIp.UseVisualStyleBackColor = true;
            this.radioButtonSingleIp.CheckedChanged += new System.EventHandler(this.radioButtonSingleIp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 45);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewComputers
            // 
            this.dataGridViewComputers.AllowUserToAddRows = false;
            this.dataGridViewComputers.AllowUserToDeleteRows = false;
            this.dataGridViewComputers.AutoGenerateColumns = false;
            this.dataGridViewComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıpDataGridViewTextBoxColumn,
            this.hostNameDataGridViewTextBoxColumn});
            this.dataGridViewComputers.DataSource = this.localAdminBindingSource;
            this.dataGridViewComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewComputers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewComputers.Name = "dataGridViewComputers";
            this.dataGridViewComputers.ReadOnly = true;
            this.dataGridViewComputers.Size = new System.Drawing.Size(351, 636);
            this.dataGridViewComputers.TabIndex = 2;
            // 
            // listBoxLocalAdmins
            // 
            this.listBoxLocalAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLocalAdmins.FormattingEnabled = true;
            this.listBoxLocalAdmins.Location = new System.Drawing.Point(3, 16);
            this.listBoxLocalAdmins.Name = "listBoxLocalAdmins";
            this.listBoxLocalAdmins.Size = new System.Drawing.Size(499, 258);
            this.listBoxLocalAdmins.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewComputers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(233, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 655);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taranan Bilgisayarlar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxLocalAdmins);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(590, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 277);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgisayardaki Local Yöneticiler";
            // 
            // progressBarScanScope
            // 
            this.progressBarScanScope.Location = new System.Drawing.Point(12, 249);
            this.progressBarScanScope.Name = "progressBarScanScope";
            this.progressBarScanScope.Size = new System.Drawing.Size(212, 23);
            this.progressBarScanScope.TabIndex = 4;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(92, 275);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(24, 13);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "0/0";
            // 
            // ıpDataGridViewTextBoxColumn
            // 
            this.ıpDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            this.ıpDataGridViewTextBoxColumn.HeaderText = "Ip";
            this.ıpDataGridViewTextBoxColumn.Name = "ıpDataGridViewTextBoxColumn";
            this.ıpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostNameDataGridViewTextBoxColumn
            // 
            this.hostNameDataGridViewTextBoxColumn.DataPropertyName = "HostName";
            this.hostNameDataGridViewTextBoxColumn.HeaderText = "HostName";
            this.hostNameDataGridViewTextBoxColumn.Name = "hostNameDataGridViewTextBoxColumn";
            this.hostNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localAdminBindingSource
            // 
            this.localAdminBindingSource.DataSource = typeof(ISO27001Tools.Entities.LocalAdmin);
            this.localAdminBindingSource.CurrentChanged += new System.EventHandler(this.localAdminBindingSource_CurrentChanged);
            // 
            // labelScanningIp
            // 
            this.labelScanningIp.AutoSize = true;
            this.labelScanningIp.Location = new System.Drawing.Point(81, 295);
            this.labelScanningIp.Name = "labelScanningIp";
            this.labelScanningIp.Size = new System.Drawing.Size(35, 13);
            this.labelScanningIp.TabIndex = 6;
            this.labelScanningIp.Text = "label2";
            // 
            // LocalAdminTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LocalAdminTest";
            this.Text = "Local Admin Test";
            this.Load += new System.EventHandler(this.LocalAdminTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localAdminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIp;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.RadioButton radioButtonDHCPScope;
        private System.Windows.Forms.RadioButton radioButtonSingleIp;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDHCPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewComputers;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource localAdminBindingSource;
        private System.Windows.Forms.ListBox listBoxLocalAdmins;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBarScanScope;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelScanningIp;
    }
}
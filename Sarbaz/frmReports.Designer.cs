namespace Sarbaz
{
    partial class frmReports
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
            this.dgvReports = new ADGV.AdvancedDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabListKoli = new System.Windows.Forms.TabPage();
            this.tabAmarTafkiki = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Majority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.tabList.SuspendLayout();
            this.tabListKoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AutoGenerateContextFilters = true;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.familyname,
            this.fathername,
            this.nationalcode,
            this.BirthDate,
            this.Education,
            this.PersonnelID,
            this.FileNumber,
            this.Majority,
            this.MobileNumber});
            this.dgvReports.DateWithTime = false;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(3, 3);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(1043, 621);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.TimeFilter = false;
            // 
            // name
            // 
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 22;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // familyname
            // 
            this.familyname.HeaderText = "نام خانوادگی";
            this.familyname.MinimumWidth = 22;
            this.familyname.Name = "familyname";
            this.familyname.ReadOnly = true;
            this.familyname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fathername
            // 
            this.fathername.HeaderText = "نام پدر";
            this.fathername.MinimumWidth = 22;
            this.fathername.Name = "fathername";
            this.fathername.ReadOnly = true;
            this.fathername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nationalcode
            // 
            this.nationalcode.HeaderText = "کد ملی";
            this.nationalcode.MinimumWidth = 22;
            this.nationalcode.Name = "nationalcode";
            this.nationalcode.ReadOnly = true;
            this.nationalcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tabList
            // 
            this.tabList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabList.Controls.Add(this.tabListKoli);
            this.tabList.Controls.Add(this.tabAmarTafkiki);
            this.tabList.Location = new System.Drawing.Point(3, 12);
            this.tabList.Name = "tabList";
            this.tabList.RightToLeftLayout = true;
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(1057, 657);
            this.tabList.TabIndex = 1;
            // 
            // tabListKoli
            // 
            this.tabListKoli.Controls.Add(this.dgvReports);
            this.tabListKoli.Location = new System.Drawing.Point(4, 26);
            this.tabListKoli.Name = "tabListKoli";
            this.tabListKoli.Padding = new System.Windows.Forms.Padding(3);
            this.tabListKoli.Size = new System.Drawing.Size(1049, 627);
            this.tabListKoli.TabIndex = 0;
            this.tabListKoli.Text = "لیست کلی";
            this.tabListKoli.UseVisualStyleBackColor = true;
            // 
            // tabAmarTafkiki
            // 
            this.tabAmarTafkiki.Location = new System.Drawing.Point(4, 26);
            this.tabAmarTafkiki.Name = "tabAmarTafkiki";
            this.tabAmarTafkiki.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmarTafkiki.Size = new System.Drawing.Size(1049, 627);
            this.tabAmarTafkiki.TabIndex = 1;
            this.tabAmarTafkiki.Text = "آمار تفکیکی";
            this.tabAmarTafkiki.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Image = global::Sarbaz.Properties.Resources.check;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(112, 675);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(94, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ثبت";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::Sarbaz.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(12, 675);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "بستن";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "تاریخ تولد";
            this.BirthDate.MinimumWidth = 22;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Education
            // 
            this.Education.HeaderText = "تحصیلات";
            this.Education.MinimumWidth = 22;
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PersonnelID
            // 
            this.PersonnelID.HeaderText = "شناسه پاسداری";
            this.PersonnelID.MinimumWidth = 22;
            this.PersonnelID.Name = "PersonnelID";
            this.PersonnelID.ReadOnly = true;
            this.PersonnelID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FileNumber
            // 
            this.FileNumber.HeaderText = "شماره پرونده";
            this.FileNumber.MinimumWidth = 22;
            this.FileNumber.Name = "FileNumber";
            this.FileNumber.ReadOnly = true;
            this.FileNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Majority
            // 
            this.Majority.HeaderText = "رشته ";
            this.Majority.MinimumWidth = 22;
            this.Majority.Name = "Majority";
            this.Majority.ReadOnly = true;
            this.Majority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MobileNumber
            // 
            this.MobileNumber.HeaderText = "شماره تلفن";
            this.MobileNumber.MinimumWidth = 22;
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            this.MobileNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 720);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.tabList.ResumeLayout(false);
            this.tabListKoli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalcode;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabListKoli;
        private System.Windows.Forms.TabPage tabAmarTafkiki;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Majority;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
    }
}
namespace Sarbaz
{
    partial class frmSearch
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSearchUnit = new System.Windows.Forms.ComboBox();
            this.tbSearchPersonnelId = new System.Windows.Forms.TextBox();
            this.tbSearchNationalCode = new System.Windows.Forms.TextBox();
            this.picSearchPersonnel = new System.Windows.Forms.PictureBox();
            this.tbSearchFileNumber = new System.Windows.Forms.TextBox();
            this.tbSearchFather = new System.Windows.Forms.TextBox();
            this.tbSearchLast = new System.Windows.Forms.TextBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSoldier = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Location = new System.Drawing.Point(608, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(94, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(608, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام خانوادگی:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(608, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام پدر:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(318, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "کد ملی:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(288, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "شناسه پاسداری:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbSearchUnit);
            this.groupBox1.Controls.Add(this.tbSearchPersonnelId);
            this.groupBox1.Controls.Add(this.tbSearchNationalCode);
            this.groupBox1.Controls.Add(this.picSearchPersonnel);
            this.groupBox1.Controls.Add(this.tbSearchFileNumber);
            this.groupBox1.Controls.Add(this.tbSearchFather);
            this.groupBox1.Controls.Add(this.tbSearchLast);
            this.groupBox1.Controls.Add(this.tbSearchName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(708, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس:";
            // 
            // cbSearchUnit
            // 
            this.cbSearchUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchUnit.FormattingEnabled = true;
            this.cbSearchUnit.Items.AddRange(new object[] {
            "آموزش",
            "گردان یکم فجر",
            "گردان دوم کمیل",
            "گردان سوم حضرت ابوالفضل(ع)",
            "گردان چهارم حنین",
            "نیروی انسانی",
            "قرارگاه",
            "آماد و پشتیبانی"});
            this.cbSearchUnit.Location = new System.Drawing.Point(105, 94);
            this.cbSearchUnit.Name = "cbSearchUnit";
            this.cbSearchUnit.Size = new System.Drawing.Size(172, 25);
            this.cbSearchUnit.TabIndex = 7;
            this.cbSearchUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbSearchPersonnelId
            // 
            this.tbSearchPersonnelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchPersonnelId.Location = new System.Drawing.Point(105, 60);
            this.tbSearchPersonnelId.Name = "tbSearchPersonnelId";
            this.tbSearchPersonnelId.Size = new System.Drawing.Size(172, 24);
            this.tbSearchPersonnelId.TabIndex = 6;
            this.tbSearchPersonnelId.TextChanged += new System.EventHandler(this.tbSearchPersonnelId_TextChanged);
            // 
            // tbSearchNationalCode
            // 
            this.tbSearchNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchNationalCode.Location = new System.Drawing.Point(105, 26);
            this.tbSearchNationalCode.Name = "tbSearchNationalCode";
            this.tbSearchNationalCode.Size = new System.Drawing.Size(172, 24);
            this.tbSearchNationalCode.TabIndex = 5;
            this.tbSearchNationalCode.TextChanged += new System.EventHandler(this.tbSearchNationalCode_TextChanged);
            // 
            // picSearchPersonnel
            // 
            this.picSearchPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearchPersonnel.Location = new System.Drawing.Point(6, 28);
            this.picSearchPersonnel.Name = "picSearchPersonnel";
            this.picSearchPersonnel.Size = new System.Drawing.Size(93, 114);
            this.picSearchPersonnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchPersonnel.TabIndex = 2;
            this.picSearchPersonnel.TabStop = false;
            // 
            // tbSearchFileNumber
            // 
            this.tbSearchFileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchFileNumber.Location = new System.Drawing.Point(423, 124);
            this.tbSearchFileNumber.Name = "tbSearchFileNumber";
            this.tbSearchFileNumber.Size = new System.Drawing.Size(165, 24);
            this.tbSearchFileNumber.TabIndex = 4;
            this.tbSearchFileNumber.TextChanged += new System.EventHandler(this.tbSearchNationalCode_TextChanged);
            // 
            // tbSearchFather
            // 
            this.tbSearchFather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchFather.Location = new System.Drawing.Point(423, 94);
            this.tbSearchFather.Name = "tbSearchFather";
            this.tbSearchFather.Size = new System.Drawing.Size(165, 24);
            this.tbSearchFather.TabIndex = 3;
            this.tbSearchFather.TextChanged += new System.EventHandler(this.tbSearchFather_TextChanged);
            // 
            // tbSearchLast
            // 
            this.tbSearchLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchLast.Location = new System.Drawing.Point(423, 60);
            this.tbSearchLast.Name = "tbSearchLast";
            this.tbSearchLast.Size = new System.Drawing.Size(165, 24);
            this.tbSearchLast.TabIndex = 2;
            this.tbSearchLast.TextChanged += new System.EventHandler(this.tbSearchLast_TextChanged);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchName.Location = new System.Drawing.Point(423, 26);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(165, 24);
            this.tbSearchName.TabIndex = 1;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(288, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "گد/واحد:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(608, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "شماره پرونده:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSoldier
            // 
            this.dgvSoldier.AllowUserToAddRows = false;
            this.dgvSoldier.AllowUserToDeleteRows = false;
            this.dgvSoldier.AllowUserToOrderColumns = true;
            this.dgvSoldier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoldier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSoldier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FileNumber,
            this.name,
            this.FamilyName,
            this.FatherName,
            this.NationalCode,
            this.PersonnelID,
            this.Unit});
            this.dgvSoldier.Location = new System.Drawing.Point(12, 186);
            this.dgvSoldier.Name = "dgvSoldier";
            this.dgvSoldier.ReadOnly = true;
            this.dgvSoldier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSoldier.RowTemplate.Height = 24;
            this.dgvSoldier.Size = new System.Drawing.Size(708, 309);
            this.dgvSoldier.TabIndex = 3;
            this.dgvSoldier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldier_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FileNumber
            // 
            this.FileNumber.DataPropertyName = "FileNumber";
            this.FileNumber.HeaderText = "شماره پرونده";
            this.FileNumber.Name = "FileNumber";
            this.FileNumber.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // FamilyName
            // 
            this.FamilyName.DataPropertyName = "FamilyName";
            this.FamilyName.HeaderText = "نام خانوادگی";
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.ReadOnly = true;
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "نام پدر";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "کد ملی";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            // 
            // PersonnelID
            // 
            this.PersonnelID.DataPropertyName = "PersonnelID";
            this.PersonnelID.HeaderText = "شناسه پاسداری";
            this.PersonnelID.Name = "PersonnelID";
            this.PersonnelID.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "گد/واحد";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = global::Sarbaz.Properties.Resources.trash2;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(626, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChoose.Image = global::Sarbaz.Properties.Resources.check;
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.Location = new System.Drawing.Point(112, 9);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(94, 31);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "انتخاب";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::Sarbaz.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(12, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "بستن";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSoldier);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جستجوی سرباز";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearchPersonnelId;
        private System.Windows.Forms.TextBox tbSearchNationalCode;
        private System.Windows.Forms.TextBox tbSearchFather;
        private System.Windows.Forms.TextBox tbSearchLast;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picSearchPersonnel;
        private System.Windows.Forms.DataGridView dgvSoldier;
        private System.Windows.Forms.ComboBox cbSearchUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchFileNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}
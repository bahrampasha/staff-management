namespace Sarbaz
{
    partial class frmLetters
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSearchLetter = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbLetters = new System.Windows.Forms.ToolStripComboBox();
            this.tbfrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLetterText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbLetterClass = new System.Windows.Forms.ComboBox();
            this.cbLetterPriority = new System.Windows.Forms.ComboBox();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnSearchLetter,
            this.toolStripLabel1,
            this.cbLetters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 94);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Sarbaz.Properties.Resources.printer;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 91);
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearchLetter
            // 
            this.btnSearchLetter.Image = global::Sarbaz.Properties.Resources.SearchLetter;
            this.btnSearchLetter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearchLetter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchLetter.Name = "btnSearchLetter";
            this.btnSearchLetter.Size = new System.Drawing.Size(96, 91);
            this.btnSearchLetter.Text = "جستجوی نامه";
            this.btnSearchLetter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(128, 91);
            this.toolStripLabel1.Text = "نامه های پیش فرض:";
            // 
            // cbLetters
            // 
            this.cbLetters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLetters.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbLetters.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cbLetters.Items.AddRange(new object[] {
            "--انتخاب نامه--",
            "گواهی عضویت",
            "گواهی خدمت"});
            this.cbLetters.Name = "cbLetters";
            this.cbLetters.Size = new System.Drawing.Size(121, 94);
            this.cbLetters.ToolTipText = "جستجو";
            this.cbLetters.SelectedIndexChanged += new System.EventHandler(this.cbLetters_SelectedIndexChanged);
            // 
            // tbfrom
            // 
            this.tbfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbfrom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbfrom.Location = new System.Drawing.Point(299, 105);
            this.tbfrom.Name = "tbfrom";
            this.tbfrom.Size = new System.Drawing.Size(186, 24);
            this.tbfrom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(491, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "از:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(489, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "به:";
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbTo.Location = new System.Drawing.Point(299, 137);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(186, 24);
            this.tbTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(489, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "موضوع:";
            // 
            // tbsubject
            // 
            this.tbsubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsubject.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbsubject.Location = new System.Drawing.Point(23, 242);
            this.tbsubject.Name = "tbsubject";
            this.tbsubject.Size = new System.Drawing.Size(462, 24);
            this.tbsubject.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(216, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "شماره:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(216, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "تاریخ:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(494, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "پیوست:";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbNumber.Location = new System.Drawing.Point(22, 105);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(186, 24);
            this.tbNumber.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbDate.Location = new System.Drawing.Point(22, 140);
            this.tbDate.Name = "tbDate";
            this.tbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDate.Size = new System.Drawing.Size(186, 24);
            this.tbDate.TabIndex = 3;
            // 
            // tbAttachment
            // 
            this.tbAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAttachment.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbAttachment.Location = new System.Drawing.Point(300, 174);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.Size = new System.Drawing.Size(186, 24);
            this.tbAttachment.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(217, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "طبقه بندی:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(217, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "ارجحیت:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(489, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "فرستنده:";
            // 
            // tbSender
            // 
            this.tbSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSender.Location = new System.Drawing.Point(299, 208);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(186, 24);
            this.tbSender.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(494, 276);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "متن نامه:";
            // 
            // tbLetterText
            // 
            this.tbLetterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLetterText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbLetterText.Location = new System.Drawing.Point(19, 308);
            this.tbLetterText.Multiline = true;
            this.tbLetterText.Name = "tbLetterText";
            this.tbLetterText.Size = new System.Drawing.Size(547, 169);
            this.tbLetterText.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(491, 491);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 11, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "توضیحات:";
            // 
            // tbComments
            // 
            this.tbComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComments.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbComments.Location = new System.Drawing.Point(19, 523);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(547, 94);
            this.tbComments.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Sarbaz.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(12, 623);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "بستن";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbLetterClass
            // 
            this.cbLetterClass.FormattingEnabled = true;
            this.cbLetterClass.Items.AddRange(new object[] {
            "--انتخاب کنید--",
            "عادی",
            "محرمانه",
            "خیلی محرمانه"});
            this.cbLetterClass.Location = new System.Drawing.Point(23, 171);
            this.cbLetterClass.Name = "cbLetterClass";
            this.cbLetterClass.Size = new System.Drawing.Size(186, 25);
            this.cbLetterClass.TabIndex = 5;
            // 
            // cbLetterPriority
            // 
            this.cbLetterPriority.FormattingEnabled = true;
            this.cbLetterPriority.Items.AddRange(new object[] {
            "--انتخاب کنید--",
            "عادی",
            "فوری",
            "خیلی فوری"});
            this.cbLetterPriority.Location = new System.Drawing.Point(23, 205);
            this.cbLetterPriority.Name = "cbLetterPriority";
            this.cbLetterPriority.Size = new System.Drawing.Size(186, 25);
            this.cbLetterPriority.TabIndex = 5;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.Key = "ccc15bfbc5604f55a465d7e20216007b";
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "a4dde496b21f43d69ae20d27c053cca4";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.StoreImagesInResources = true;
            this.stiPrint.UseProgressInThread = false;
            // 
            // frmLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 664);
            this.Controls.Add(this.cbLetterPriority);
            this.Controls.Add(this.cbLetterClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbAttachment);
            this.Controls.Add(this.tbLetterText);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.tbsubject);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbfrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLetters";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نوشتن نامه";
            this.Load += new System.EventHandler(this.frmLetters_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnSearchLetter;
        private System.Windows.Forms.TextBox tbfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLetterText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbLetterClass;
        private System.Windows.Forms.ComboBox cbLetterPriority;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbLetters;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}
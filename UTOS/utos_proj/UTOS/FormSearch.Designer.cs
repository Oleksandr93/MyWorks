namespace UTOS
{
    partial class FormSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSpeciality = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEducation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDisabilityGroup = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPensionCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbIdCode = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicketNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.cbPhone = new System.Windows.Forms.ComboBox();
            this.cbIdCode = new System.Windows.Forms.ComboBox();
            this.cbPassportNumber = new System.Windows.Forms.ComboBox();
            this.cbPensionCardNumber = new System.Windows.Forms.ComboBox();
            this.cbDisabilityGroup = new System.Windows.Forms.ComboBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 344);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 44);
            this.panel2.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(509, 10);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Відміна";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(403, 10);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Шукати";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Controls.Add(this.cbSpeciality);
            this.groupBox1.Controls.Add(this.cbEducation);
            this.groupBox1.Controls.Add(this.cbDisabilityGroup);
            this.groupBox1.Controls.Add(this.cbPensionCardNumber);
            this.groupBox1.Controls.Add(this.cbPassportNumber);
            this.groupBox1.Controls.Add(this.cbIdCode);
            this.groupBox1.Controls.Add(this.cbPhone);
            this.groupBox1.Controls.Add(this.cbAddress);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbSpeciality);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbEducation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbDisabilityGroup);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbPensionCardNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPassportNumber);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.tbIdCode);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTicketNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 342);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть частину даних для пошука картки:";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(271, 291);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(327, 20);
            this.tbPosition.TabIndex = 127;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 13);
            this.label16.TabIndex = 126;
            this.label16.Text = "Посада чи виконувана робота:";
            // 
            // tbSpeciality
            // 
            this.tbSpeciality.Location = new System.Drawing.Point(271, 265);
            this.tbSpeciality.Name = "tbSpeciality";
            this.tbSpeciality.Size = new System.Drawing.Size(327, 20);
            this.tbSpeciality.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Спеціальність:";
            // 
            // tbEducation
            // 
            this.tbEducation.Location = new System.Drawing.Point(271, 239);
            this.tbEducation.Name = "tbEducation";
            this.tbEducation.Size = new System.Drawing.Size(327, 20);
            this.tbEducation.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "Освіта:";
            // 
            // tbDisabilityGroup
            // 
            this.tbDisabilityGroup.Location = new System.Drawing.Point(271, 213);
            this.tbDisabilityGroup.Name = "tbDisabilityGroup";
            this.tbDisabilityGroup.Size = new System.Drawing.Size(327, 20);
            this.tbDisabilityGroup.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Група інвалідності по зору:";
            // 
            // tbPensionCardNumber
            // 
            this.tbPensionCardNumber.Location = new System.Drawing.Point(271, 187);
            this.tbPensionCardNumber.Name = "tbPensionCardNumber";
            this.tbPensionCardNumber.Size = new System.Drawing.Size(327, 20);
            this.tbPensionCardNumber.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Номер пенс. посвідчення:";
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Location = new System.Drawing.Point(271, 161);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(327, 20);
            this.tbPassportNumber.TabIndex = 117;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(171, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 116;
            this.label20.Text = "Номер паспорту:";
            // 
            // tbIdCode
            // 
            this.tbIdCode.Location = new System.Drawing.Point(271, 135);
            this.tbIdCode.Name = "tbIdCode";
            this.tbIdCode.Size = new System.Drawing.Size(327, 20);
            this.tbIdCode.TabIndex = 115;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(133, 138);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(131, 13);
            this.label36.TabIndex = 114;
            this.label36.Text = "Ідентифікаційний номер:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(271, 109);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(327, 20);
            this.tbPhone.TabIndex = 113;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(193, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 13);
            this.label26.TabIndex = 112;
            this.label26.Text = "№ телефону:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(271, 83);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(327, 20);
            this.tbAddress.TabIndex = 111;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(167, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 110;
            this.label27.Text = "Домашня адреса:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(271, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(327, 20);
            this.tbName.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Прізвище/Ім\'я/По-батькові:";
            // 
            // tbTicketNumber
            // 
            this.tbTicketNumber.Location = new System.Drawing.Point(271, 31);
            this.tbTicketNumber.Name = "tbTicketNumber";
            this.tbTicketNumber.Size = new System.Drawing.Size(327, 20);
            this.tbTicketNumber.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "№ членського квитка:";
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbName.Location = new System.Drawing.Point(17, 56);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(86, 21);
            this.cbName.TabIndex = 129;
            // 
            // cbAddress
            // 
            this.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbAddress.Location = new System.Drawing.Point(17, 82);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(86, 21);
            this.cbAddress.TabIndex = 130;
            // 
            // cbPhone
            // 
            this.cbPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhone.FormattingEnabled = true;
            this.cbPhone.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbPhone.Location = new System.Drawing.Point(17, 108);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(86, 21);
            this.cbPhone.TabIndex = 131;
            // 
            // cbIdCode
            // 
            this.cbIdCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdCode.FormattingEnabled = true;
            this.cbIdCode.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbIdCode.Location = new System.Drawing.Point(17, 134);
            this.cbIdCode.Name = "cbIdCode";
            this.cbIdCode.Size = new System.Drawing.Size(86, 21);
            this.cbIdCode.TabIndex = 132;
            // 
            // cbPassportNumber
            // 
            this.cbPassportNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPassportNumber.FormattingEnabled = true;
            this.cbPassportNumber.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbPassportNumber.Location = new System.Drawing.Point(17, 160);
            this.cbPassportNumber.Name = "cbPassportNumber";
            this.cbPassportNumber.Size = new System.Drawing.Size(86, 21);
            this.cbPassportNumber.TabIndex = 133;
            // 
            // cbPensionCardNumber
            // 
            this.cbPensionCardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPensionCardNumber.FormattingEnabled = true;
            this.cbPensionCardNumber.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbPensionCardNumber.Location = new System.Drawing.Point(17, 186);
            this.cbPensionCardNumber.Name = "cbPensionCardNumber";
            this.cbPensionCardNumber.Size = new System.Drawing.Size(86, 21);
            this.cbPensionCardNumber.TabIndex = 134;
            // 
            // cbDisabilityGroup
            // 
            this.cbDisabilityGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisabilityGroup.FormattingEnabled = true;
            this.cbDisabilityGroup.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbDisabilityGroup.Location = new System.Drawing.Point(17, 212);
            this.cbDisabilityGroup.Name = "cbDisabilityGroup";
            this.cbDisabilityGroup.Size = new System.Drawing.Size(86, 21);
            this.cbDisabilityGroup.TabIndex = 135;
            // 
            // cbEducation
            // 
            this.cbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbEducation.Location = new System.Drawing.Point(17, 238);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(86, 21);
            this.cbEducation.TabIndex = 136;
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbSpeciality.Location = new System.Drawing.Point(17, 264);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(86, 21);
            this.cbSpeciality.TabIndex = 137;
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "OR (або)",
            "AND (і)"});
            this.cbPosition.Location = new System.Drawing.Point(17, 290);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(86, 21);
            this.cbPosition.TabIndex = 138;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пошук карток";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSpeciality;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEducation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDisabilityGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPensionCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbIdCode;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicketNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.ComboBox cbDisabilityGroup;
        private System.Windows.Forms.ComboBox cbPensionCardNumber;
        private System.Windows.Forms.ComboBox cbPassportNumber;
        private System.Windows.Forms.ComboBox cbIdCode;
        private System.Windows.Forms.ComboBox cbPhone;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.ComboBox cbName;
    }
}
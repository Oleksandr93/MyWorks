namespace UTOS
{
    partial class FormMembers
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
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.AllowUserToDeleteRows = false;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ticket_number,
            this.reg_date,
            this.full_name,
            this.org_name});
            this.dgMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMembers.Location = new System.Drawing.Point(0, 0);
            this.dgMembers.MultiSelect = false;
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.ReadOnly = true;
            this.dgMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembers.Size = new System.Drawing.Size(849, 524);
            this.dgMembers.TabIndex = 0;
            this.dgMembers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMembers_RowEnter);
            this.dgMembers.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMembers_RowLeave);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ticket_number
            // 
            this.ticket_number.DataPropertyName = "ticket_number";
            this.ticket_number.FillWeight = 80F;
            this.ticket_number.HeaderText = "№ членського квитка";
            this.ticket_number.Name = "ticket_number";
            this.ticket_number.ReadOnly = true;
            this.ticket_number.Width = 80;
            // 
            // reg_date
            // 
            this.reg_date.DataPropertyName = "reg_date";
            this.reg_date.FillWeight = 80F;
            this.reg_date.HeaderText = "Дата вступу";
            this.reg_date.Name = "reg_date";
            this.reg_date.ReadOnly = true;
            this.reg_date.Width = 80;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.DataPropertyName = "full_name";
            this.full_name.FillWeight = 200F;
            this.full_name.HeaderText = "Ім\'я";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // org_name
            // 
            this.org_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.org_name.DataPropertyName = "org_name";
            this.org_name.FillWeight = 200F;
            this.org_name.HeaderText = "Первинна організація";
            this.org_name.Name = "org_name";
            this.org_name.ReadOnly = true;
            // 
            // FormMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 524);
            this.ControlBox = false;
            this.Controls.Add(this.dgMembers);
            this.Name = "FormMembers";
            this.Text = "Члени УТОС";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMembers_FormClosed);
            this.Load += new System.EventHandler(this.FormMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_name;

    }
}
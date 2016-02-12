namespace UTOS
{
    partial class FormOrganizations
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
            this.dgOrganizations = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chief_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretary_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrganizations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrganizations
            // 
            this.dgOrganizations.AllowUserToAddRows = false;
            this.dgOrganizations.AllowUserToDeleteRows = false;
            this.dgOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.chief_name,
            this.secretary_name});
            this.dgOrganizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrganizations.Location = new System.Drawing.Point(0, 0);
            this.dgOrganizations.MultiSelect = false;
            this.dgOrganizations.Name = "dgOrganizations";
            this.dgOrganizations.ReadOnly = true;
            this.dgOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrganizations.Size = new System.Drawing.Size(841, 554);
            this.dgOrganizations.TabIndex = 1;
            this.dgOrganizations.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrganizations_RowEnter);
            this.dgOrganizations.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrganizations_RowLeave);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // chief_name
            // 
            this.chief_name.DataPropertyName = "chief_name";
            this.chief_name.FillWeight = 200F;
            this.chief_name.HeaderText = "Голова бюро";
            this.chief_name.Name = "chief_name";
            this.chief_name.ReadOnly = true;
            this.chief_name.Width = 200;
            // 
            // secretary_name
            // 
            this.secretary_name.DataPropertyName = "secretary_name";
            this.secretary_name.FillWeight = 200F;
            this.secretary_name.HeaderText = "Секретар";
            this.secretary_name.Name = "secretary_name";
            this.secretary_name.ReadOnly = true;
            this.secretary_name.Width = 200;
            // 
            // FormOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 554);
            this.ControlBox = false;
            this.Controls.Add(this.dgOrganizations);
            this.Name = "FormOrganizations";
            this.Text = "Первинні організації";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrganizations_FormClosed);
            this.Load += new System.EventHandler(this.FormOrganizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrganizations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrganizations;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chief_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretary_name;

    }
}
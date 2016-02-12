namespace UTOS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.miCards = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewCard = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditCard = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteCard = new System.Windows.Forms.ToolStripMenuItem();
            this.miOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewOrgs = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.miPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btMembers = new System.Windows.Forms.ToolStripButton();
            this.btOrganizations = new System.Windows.Forms.ToolStripButton();
            this.btPayments = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.btExport = new System.Windows.Forms.ToolStripButton();
            this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miMembers,
            this.miOrganizations,
            this.miPayments,
            this.проПрограмуToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1008, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(102, 22);
            this.miExit.Text = "Вихід";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miMembers
            // 
            this.miMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCards,
            this.miNewCard,
            this.miEditCard,
            this.miDeleteCard,
            this.miSearch,
            this.miExport});
            this.miMembers.Name = "miMembers";
            this.miMembers.Size = new System.Drawing.Size(88, 20);
            this.miMembers.Text = "Члени УТОС";
            // 
            // miCards
            // 
            this.miCards.Name = "miCards";
            this.miCards.Size = new System.Drawing.Size(194, 22);
            this.miCards.Text = "Облікові картки";
            this.miCards.Click += new System.EventHandler(this.miCards_Click);
            // 
            // miNewCard
            // 
            this.miNewCard.Name = "miNewCard";
            this.miNewCard.Size = new System.Drawing.Size(194, 22);
            this.miNewCard.Text = "Створити нову картку";
            this.miNewCard.Click += new System.EventHandler(this.miNewCard_Click);
            // 
            // miEditCard
            // 
            this.miEditCard.Enabled = false;
            this.miEditCard.Name = "miEditCard";
            this.miEditCard.Size = new System.Drawing.Size(194, 22);
            this.miEditCard.Text = "Редагувати картку";
            this.miEditCard.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // miDeleteCard
            // 
            this.miDeleteCard.Enabled = false;
            this.miDeleteCard.Name = "miDeleteCard";
            this.miDeleteCard.Size = new System.Drawing.Size(194, 22);
            this.miDeleteCard.Text = "Видалити картку";
            this.miDeleteCard.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // miOrganizations
            // 
            this.miOrganizations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewOrgs,
            this.miAddOrg,
            this.miEditOrg,
            this.miDeleteOrg});
            this.miOrganizations.Name = "miOrganizations";
            this.miOrganizations.Size = new System.Drawing.Size(133, 20);
            this.miOrganizations.Text = "Первинні організації";
            // 
            // miViewOrgs
            // 
            this.miViewOrgs.Name = "miViewOrgs";
            this.miViewOrgs.Size = new System.Drawing.Size(203, 22);
            this.miViewOrgs.Text = "Переглянути";
            this.miViewOrgs.Click += new System.EventHandler(this.miViewOrgs_Click);
            // 
            // miAddOrg
            // 
            this.miAddOrg.Name = "miAddOrg";
            this.miAddOrg.Size = new System.Drawing.Size(203, 22);
            this.miAddOrg.Text = "Додати організацію";
            this.miAddOrg.Click += new System.EventHandler(this.miAddOrg_Click);
            // 
            // miEditOrg
            // 
            this.miEditOrg.Enabled = false;
            this.miEditOrg.Name = "miEditOrg";
            this.miEditOrg.Size = new System.Drawing.Size(203, 22);
            this.miEditOrg.Text = "Редагувати організацію";
            this.miEditOrg.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // miDeleteOrg
            // 
            this.miDeleteOrg.Enabled = false;
            this.miDeleteOrg.Name = "miDeleteOrg";
            this.miDeleteOrg.Size = new System.Drawing.Size(203, 22);
            this.miDeleteOrg.Text = "Видалити організацію";
            this.miDeleteOrg.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // miPayments
            // 
            this.miPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewPayments});
            this.miPayments.Name = "miPayments";
            this.miPayments.Size = new System.Drawing.Size(109, 20);
            this.miPayments.Text = "Членські внески";
            this.miPayments.Visible = false;
            // 
            // miViewPayments
            // 
            this.miViewPayments.Name = "miViewPayments";
            this.miViewPayments.Size = new System.Drawing.Size(145, 22);
            this.miViewPayments.Text = "Переглянути";
            this.miViewPayments.Click += new System.EventHandler(this.miViewPayments_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAbout});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.проПрограмуToolStripMenuItem.Text = "?";
            // 
            // msiAbout
            // 
            this.msiAbout.Name = "msiAbout";
            this.msiAbout.Size = new System.Drawing.Size(154, 22);
            this.msiAbout.Text = "Про програму";
            this.msiAbout.Click += new System.EventHandler(this.msiAbout_Click);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMembers,
            this.btOrganizations,
            this.btPayments,
            this.toolStripSeparator1,
            this.btAdd,
            this.btEdit,
            this.btDelete,
            this.btSearch,
            this.btRefresh,
            this.btExport});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1008, 25);
            this.tsMain.TabIndex = 1;
            // 
            // btMembers
            // 
            this.btMembers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMembers.Image = ((System.Drawing.Image)(resources.GetObject("btMembers.Image")));
            this.btMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMembers.Name = "btMembers";
            this.btMembers.Size = new System.Drawing.Size(23, 22);
            this.btMembers.Tag = "frmMembers";
            this.btMembers.Text = "Члени УТОС";
            this.btMembers.Click += new System.EventHandler(this.btMembers_Click);
            // 
            // btOrganizations
            // 
            this.btOrganizations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOrganizations.Image = ((System.Drawing.Image)(resources.GetObject("btOrganizations.Image")));
            this.btOrganizations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOrganizations.Name = "btOrganizations";
            this.btOrganizations.Size = new System.Drawing.Size(23, 22);
            this.btOrganizations.Text = "Первинні організації";
            this.btOrganizations.Click += new System.EventHandler(this.btOrganizations_Click);
            // 
            // btPayments
            // 
            this.btPayments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPayments.Image = ((System.Drawing.Image)(resources.GetObject("btPayments.Image")));
            this.btPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPayments.Name = "btPayments";
            this.btPayments.Size = new System.Drawing.Size(23, 22);
            this.btPayments.Text = "Членські внески";
            this.btPayments.Visible = false;
            this.btPayments.Click += new System.EventHandler(this.btPayments_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Enabled = false;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 22);
            this.btAdd.Text = "Створити";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEdit.Enabled = false;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(23, 22);
            this.btEdit.Text = "Редагувати";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDelete.Enabled = false;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(23, 22);
            this.btDelete.Text = "Видалити";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSearch
            // 
            this.btSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearch.Enabled = false;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(23, 22);
            this.btSearch.Text = "Пошук";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRefresh.Enabled = false;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRefresh.Size = new System.Drawing.Size(30, 22);
            this.btRefresh.Text = "Обновити";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btExport
            // 
            this.btExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExport.Enabled = false;
            this.btExport.Image = ((System.Drawing.Image)(resources.GetObject("btExport.Image")));
            this.btExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExport.Name = "btExport";
            this.btExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btExport.Size = new System.Drawing.Size(30, 22);
            this.btExport.Text = "Експорт в Word";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // miSearch
            // 
            this.miSearch.Enabled = false;
            this.miSearch.Name = "miSearch";
            this.miSearch.Size = new System.Drawing.Size(194, 22);
            this.miSearch.Text = "Пошук карток";
            this.miSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // miExport
            // 
            this.miExport.Enabled = false;
            this.miExport.Name = "miExport";
            this.miExport.Size = new System.Drawing.Size(194, 22);
            this.miExport.Text = "Експорт в Word";
            this.miExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УТОС Рівненської області";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miMembers;
        private System.Windows.Forms.ToolStripMenuItem miCards;
        private System.Windows.Forms.ToolStripMenuItem miNewCard;
        private System.Windows.Forms.ToolStripMenuItem miEditCard;
        private System.Windows.Forms.ToolStripMenuItem miDeleteCard;
        private System.Windows.Forms.ToolStripMenuItem miOrganizations;
        private System.Windows.Forms.ToolStripMenuItem miViewOrgs;
        private System.Windows.Forms.ToolStripMenuItem miAddOrg;
        private System.Windows.Forms.ToolStripMenuItem miEditOrg;
        private System.Windows.Forms.ToolStripMenuItem miDeleteOrg;
        private System.Windows.Forms.ToolStripMenuItem miPayments;
        private System.Windows.Forms.ToolStripMenuItem miViewPayments;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btMembers;
        private System.Windows.Forms.ToolStripButton btOrganizations;
        private System.Windows.Forms.ToolStripButton btPayments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripButton btSearch;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAbout;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.ToolStripButton btExport;
        private System.Windows.Forms.ToolStripMenuItem miSearch;
        private System.Windows.Forms.ToolStripMenuItem miExport;

    }
}


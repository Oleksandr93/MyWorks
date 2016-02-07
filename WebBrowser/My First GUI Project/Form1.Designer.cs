namespace My_First_GUI_Project
{
    partial class Form1
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
            this.goButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домашняяСтраницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.далееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протопитТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прототипТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(142, 58);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "goButton";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переходToolStripMenuItem,
            this.прототипТекстаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.домашняяСтраницаToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.далееToolStripMenuItem,
            this.протопитТекстаToolStripMenuItem});
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            // 
            // домашняяСтраницаToolStripMenuItem
            // 
            this.домашняяСтраницаToolStripMenuItem.Name = "домашняяСтраницаToolStripMenuItem";
            this.домашняяСтраницаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.домашняяСтраницаToolStripMenuItem.Text = "Домашняя страница";
            this.домашняяСтраницаToolStripMenuItem.Click += new System.EventHandler(this.домашняяСтраницаToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // далееToolStripMenuItem
            // 
            this.далееToolStripMenuItem.Name = "далееToolStripMenuItem";
            this.далееToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.далееToolStripMenuItem.Text = "Далее";
            this.далееToolStripMenuItem.Click += new System.EventHandler(this.далееToolStripMenuItem_Click);
            // 
            // протопитТекстаToolStripMenuItem
            // 
            this.протопитТекстаToolStripMenuItem.Name = "протопитТекстаToolStripMenuItem";
            this.протопитТекстаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.протопитТекстаToolStripMenuItem.Text = "Прототип текста";
            // 
            // прототипТекстаToolStripMenuItem
            // 
            this.прототипТекстаToolStripMenuItem.Name = "прототипТекстаToolStripMenuItem";
            this.прототипТекстаToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.прототипТекстаToolStripMenuItem.Text = "Прототип текста";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http://google.com.ua",
            "http://vk.com",
            "http://facebook.com",
            "http://habrahabr.ru"});
            this.comboBox1.Location = new System.Drawing.Point(0, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(277, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(895, 426);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 640);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Web-browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem домашняяСтраницаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem далееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протопитТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прототипТекстаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


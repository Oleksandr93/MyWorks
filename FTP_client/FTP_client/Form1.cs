using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using FTP_client; 


namespace FTP_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FtpClient ftp = new FtpClient();

        string serverDir = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Сохранить файл");
            menu.Items[0].Click += new EventHandler(Download_File);
            menu.Items.Add("Загрузить файл на сервер");
            menu.Items[1].Click += new EventHandler(Upload_File);
            menu.Items.Add("Удалить каталог");
            menu.Items[2].Click += new EventHandler(Remove_Directory);
            menu.Items.Add("Удалить файл");
            menu.Items[3].Click += new EventHandler(Delete_File);
            listView2.ContextMenuStrip = menu;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == null)
            {
                MessageBox.Show("Имя сервера не может быть пустым");
                return;
            }


            ftp.Host = textBox6.Text;
            ftp.UserName = textBox4.Text;
            ftp.Password = textBox5.Text;
            FileStruct[] FileList = DirectoryList("");
            try
            {
                this.Text = "Подключение к ftp-серверу....";

                foreach (FileStruct s in FileList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = s.Name;
                    lvi.SubItems.Add(s.CreateTime);
                    listView2.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }
            this.Text = "FTP-client";
        }

        private FileStruct[] DirectoryList(string v)
        {
            throw new NotImplementedException();
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Выделите папку для просмотра");
            }
            try
            {
                this.Text = "Подключение к ftp-серверу....";
                string directory = listView2.SelectedItems[0].SubItems[0].Text.Trim();

                listView2.Items.Clear();

                FileStruct[] FileList = ftp.ListDirectory("/" + directory);

                this.Text = "Подключение к ftp-серверу....";

                foreach (FileStruct s in FileList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = s.Name;
                    lvi.SubItems.Add(s.CreateTime);
                    listView2.Items.Add(lvi);
                }

                textBox6.Text += ("/" + directory);
                serverDir += ("/" + directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Text = "FTP-client";
        }

        private void Delete_File(object sender, EventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Выделите файл для удаления");
            }
            try
            {
                string directory = listView2.SelectedItems[0].SubItems[0].Text.Trim();
                ftp.DeleteFile(serverDir + "/" + directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void Remove_Directory(object sender, EventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Выделите файл для удаления");
            }
            try
            {
                string directory = listView2.SelectedItems[0].SubItems[0].Text.Trim();
                ftp.RemoveDirectory(serverDir + "/" + directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void Download_File(object sender, EventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Выделите файл для загрузки на локальный компьютер");
            }
            try
            {
                string directory = listView2.SelectedItems[0].SubItems[0].Text.Trim();
                ftp.DownloadFile(serverDir, directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void Upload_File(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string file = openFileDialog1.FileName;
            try
            {
                ftp.UploadFile(serverDir, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            {
                
            }
        } 
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace MacroTextEditor
{
    public partial class Form1 : Form
    {

        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

        // Коллекция для загружаемых сборок
        private List<string> accemblyList; 



        public Form1()
        {
            InitializeComponent();

            // Устанавливаем типы файлов для диалоговых окон
            OpenFileDialog1.Filter = "Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf|CSharp Files(*.cs)|*.cs|All files(*.*)|*.*";
            SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf|CSharp Files(*.cs)|*.cs|All files(*.*)|*.*";

            // инициализируем список сборок
            accemblyList = new List<string>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Открытие файла
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = OpenFileDialog1.FileName;

            if (filename.EndsWith("txt")|| filename.EndsWith("cs"))
            {
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
            else if(filename.EndsWith("rtf"))
            {
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = SaveFileDialog1.FileName;

            if (filename.EndsWith("txt") || filename.EndsWith("cs"))
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
            else if (filename.EndsWith("rtf"))
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
        }

        // Пункт меню Add Accembl - добавляем сборку
        private void addAccemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = OpenFileDialog1.FileName;

            // Добавляем в список имя сборки
            accemblyList.Add(filename.Remove(0, filename.LastIndexOf(@"\") + 1));
        }


        // Пункт меню Run Macros - запуск макроса
        private void runMacrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string filename = OpenFileDialog1.FileName;
                if (filename!="")
                {
                    Run_Macro(filename);
                }
            }
        }


        // Основная работа по запуске макроса
        private void Run_Macro(string filename)
        {
            if (!filename.EndsWith("cs"))
            {
                MessageBox.Show("Макрос должен быть написан на c# и иметь расширение cs");
                return;
            }
            try
            {
                // Читает как текст код из файла
                string macroCode = new StreamReader(filename, Encoding.Default).ReadToEnd();

                // Создает экземпляр компилятора c#
                CSharpCodeProvider csProv = new CSharpCodeProvider();

                // Создает набор параметров для передачи их компилятору.
                CompilerParameters csParams = new CompilerParameters();

                // Добавляет нужные сборки
                foreach (string accembly in accemblyList)
                {
                    csParams.ReferencedAssemblies.Add(accembly);
                }
                accemblyList.Clear();

                // Добавляет по умолчанию найболее используемые сборки
                csParams.ReferencedAssemblies.Add("mscorlib.dll");
                csParams.ReferencedAssemblies.Add("System.dll");
                csParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");

                // Не будем создавать из кода исполняемый файл
                csParams.GenerateExecutable = false;
                
                // Код будет откомпилирован только в памяти без записи на диск
                csParams.GenerateInMemory = true;
                
                // Компилируем код и получаем результаты компиляции
                CompilerResults compResults = csProv.CompileAssemblyFromSource(csParams, macroCode);

                // Проверяем на наличие ошибок
                if (compResults.Errors.Count > 0)
                {
                    // Отображаем сообщение об ошибке
                    foreach (var er in compResults.Errors)
                    {
                        MessageBox.Show(er.ToString());
                    }
                }
                else
                {
                    // Создаем экземпляр временно созданного при компиляции класса
                    object obj = compResults.CompiledAssembly.CreateInstance("Program");

                    // В качестве аргумента программы возьмем наше текстовое поле, над которым можна производить манипуляции
                    object[] args = new object[] {this.richTextBox1};
                    
                    // Вызываем код и передаем ему в качестве параметров наш обьект - класс Program и массив аргументов
                    Type t = (Type) obj.GetType().InvokeMember("Main", BindingFlags.InvokeMethod, null, obj, args);
                }
            }
            
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

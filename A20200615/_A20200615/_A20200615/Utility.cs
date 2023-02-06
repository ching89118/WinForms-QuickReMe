using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace _A20200615
{
    class Utility
    {


        public static void InitAutoCompleteTextBox(string configPath, TextBox textBox)
        {
            AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();//自動完成輸入
            bool folderName = Directory.Exists(configPath);
            if (!folderName)//如果此路徑不存在
            {
                //新創此路徑
                Directory.CreateDirectory($@"C:\Users\ching\source\repos\A20200615\Vocabulary");

            }

            string[] directories = Directory.GetDirectories(configPath);//得到此路徑下面的所有目錄=>單字資料夾


            foreach (var directory in directories)
            {
                DirectoryInfo folder = new DirectoryInfo(directory);
                Console.WriteLine(folder.Name);
                autoData.Add(folder.Name);//把資料夾名稱一一存入"自動完成輸入集合"
            }



            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteCustomSource = autoData;
        }

        public static void GetExplanation(string configPath, Label explanation, string selectedV)
        {
            string path = $@"{configPath}\{selectedV}\Explanation\{selectedV}.csv";

            bool file = File.Exists(path);
            if (file)
            {
                string[] explainArr = File.ReadAllLines(path, System.Text.Encoding.Default);
                foreach (var item in explainArr)
                {
                    explanation.Text += item;
                }
            }
            else
            {
                MessageBox.Show("CSV File is not existed.");
            }

        }

        public static void GetExplanation(string configPath, RichTextBox meaning, string importNewWord)
        {
            string path = $@"{configPath}\{importNewWord}\Explanation\{importNewWord}.csv";

            bool file = File.Exists(path);
            if (file)
            {
              
                string[] explainArr = File.ReadAllLines(path, System.Text.Encoding.Default);
                foreach (var item in explainArr)
                {
                    meaning.Text += item;
                }
            }
            else
            {
                MessageBox.Show("CSV File is not existed.");
            }

        }



        public static void ExportCSV(string configPath, string importNewWord, RichTextBox richTextBox, Label label)
        {
            TextWriter textWriter = new StreamWriter($@"C:\Users\ching\source\repos\A20200615\Vocabulary\{importNewWord}\Explanation\{importNewWord}.csv", false, System.Text.Encoding.Default);
            Console.WriteLine($@"C:\Users\ching\source\repos\A20200615\Vocabulary\{importNewWord}\Explanation\{importNewWord}.csv");
            textWriter.Write(richTextBox.Text);
            textWriter.Close();
            label.Text = "CSV file saves successfully.";
        }

       
    }

}   


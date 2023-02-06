using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _A20200615
{
    public partial class Add : Form//在專案下新增Form表單
    {
        String path = "";//完整路徑        
        private string configPath;//取代部分字串的路徑


        public Add()
        {
            InitializeComponent();
            configPath = ConfigurationManager.AppSettings["directoryPath"];
            Console.WriteLine(configPath);
            Utility.InitAutoCompleteTextBox(configPath, textBox_importNewWord);
            button_saveIMG.Enabled = false;
        }




        private void exportCSV_Clicked(object sender, EventArgs e)
        {
            path = $@"{configPath}\{textBox_importNewWord.Text}\Explanation\{textBox_importNewWord.Text}.csv";

            //先判斷資料夾目錄路徑是否存在
            bool file = File.Exists(path);//需要完整路徑
            if (file)//存在，是否覆蓋
            {
                DialogResult Result = MessageBox.Show("CSV file has existed, Do you want to override?", "Override", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    Utility.ExportCSV(configPath, textBox_importNewWord.Text, richTextBox_meaning, CSV_label);
                }
                else
                {
                    return;
                }
            }
            else//不存在，先建立路徑再輸出CSV
            {
                Directory.CreateDirectory($@"{configPath}\{textBox_importNewWord.Text}\Explanation");
                Utility.ExportCSV(configPath, textBox_importNewWord.Text, richTextBox_meaning, CSV_label);
            }


        }



        private void saveIMG_Clicked(object sender, EventArgs e)
        {
            path = $@"{configPath}\{textBox_importNewWord.Text}\image\{textBox_importNewWord.Text}.jpg";

            //先判斷資料夾目錄路徑是否存在
            bool file = File.Exists(path);//需要完整路徑
            if (file)//存在，是否覆蓋
            {
                DialogResult Result = MessageBox.Show("Image file has existed, Do you want to override?", "Override", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    File.Copy(showImagePath.Text, Path.Combine($@"{configPath}\{textBox_importNewWord.Text}\image", Path.GetFileName(showImagePath.Text)));//需要完整路徑
                    Image_label.Text = "Image file saves successfully.";
                }
                else
                {
                    return;
                }
            }
            else//不存在，建立路徑與檔案
            {
                File.Copy(showImagePath.Text, Path.Combine($@"{configPath}\{textBox_importNewWord.Text}\image", Path.GetFileName(showImagePath.Text)));//需要完整路徑
                Image_label.Text = "Image file saves successfully.";
            }


        }



        private void Add_Click(object sender, EventArgs e)
        {
            richTextBox_meaning.Text = textBox_importNewWord.Text;
        }




        private void Add_Load(object sender, EventArgs e)
        {
           drawImage.AllowDrop = true;
        }

        private void drawImage_DragDrop(object sender, DragEventArgs e)
        {

            Directory.CreateDirectory($@"{configPath}\{textBox_importNewWord.Text}\image");
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                Console.WriteLine(fileNames[0]);
                if (fileNames.Length > 0)
                {
                    showImagePath.Text = fileNames[0];
                    drawImage.Image = Image.FromFile(showImagePath.Text);
                }

            }
            button_saveIMG.Enabled = true;
        }

        private void drawImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBox_importNewWord_KeyDown(object sender, KeyEventArgs e)//輸入時點擊TexBox觸發
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox_importNewWord.Text = textBox_importNewWord.SelectedText;
            }
            richTextBox_meaning.Text = "";


            if (!string.IsNullOrEmpty(textBox_importNewWord.SelectedText))//判斷正在新增的單字是否已存在在路徑裡
            {  //解釋是否存在

                Utility.GetExplanation(configPath, richTextBox_meaning, textBox_importNewWord.Text);

                //圖片是否存在
                path = $@"{configPath}\{textBox_importNewWord.Text}\image\{textBox_importNewWord.Text}.jpg";
                bool file = File.Exists(path);//需要完整路徑   
                if (file)
                {
                    Bitmap bitmap = new Bitmap(path);
                    drawImage.Image = bitmap;
                }
                else
                {
                    MessageBox.Show("IMG File is not existed.");
                }

            }
        }

        private void pictureBox_UploadIMG_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($@"{configPath}\{textBox_importNewWord.Text}\image");
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                showImagePath.Text = openFile.FileName;
                drawImage.Image = new Bitmap(openFile.FileName);
            }
            button_saveIMG.Enabled = true;
        }


    }
}

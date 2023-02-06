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
using System.Speech.Synthesis;

namespace _A20200615
{
    public partial class QuickReMe : Form
    {
        string selectedV = "";
        string path = "";//完整路徑
        private string configPath;//取代部分字串的路徑

        public QuickReMe()
        {
            InitializeComponent();
            button_flip.Enabled = false;
            configPath = ConfigurationManager.AppSettings["directoryPath"];
            Console.WriteLine(configPath);
            Utility.InitAutoCompleteTextBox(configPath, textBox_Search);
            QuickReMe.SetAutoCompleteComboBox(configPath, comboBox_Search);
      
        }





        public static void SetAutoCompleteComboBox(string configPath, ComboBox comboBox)
        {

            List<string> beforeSelected = new List<string>();
            List<string> afterSelected = new List<string>();
            string[] directories = Directory.GetDirectories(configPath);//得到此路徑下面的所有目錄=>單字資料夾

            foreach (var directory in directories)
            {
                DirectoryInfo folder = new DirectoryInfo(directory);
                beforeSelected.Add(folder.Name.ToLower());//把資料夾名稱一一存入"自動完成輸入集合"                    
            }

            if (comboBox.Items.Count != 0)
            {
                comboBox.Items.Clear();
            }
            //輸入的字元
            var input = comboBox.Text.ToLower();

            if (string.IsNullOrEmpty(input))
            {

                comboBox.Items.AddRange(beforeSelected.ToArray());

            }
            else
            {

                foreach (var item in beforeSelected)
                {
                    if (item.IndexOf(input) >= 0)
                    {
                        afterSelected.Add(item);
                    }
                }

                comboBox.Items.AddRange(afterSelected.ToArray());

                //這個Select方法解決了輸入游標不斷置回起始位置的問題
                comboBox.Select(comboBox.Text.Length, 0);
                comboBox.DroppedDown = true;
                //使用DroppedDown之後，鼠標箭頭消失在comboBox上，設定取得預設游標(箭號游標)
                comboBox.Cursor = Cursors.Default;



            }

        }



        private void comboBox_Search_TextUpdate(object sender, EventArgs e)
        {
            QuickReMe.SetAutoCompleteComboBox(configPath, comboBox_Search);
        }



        private void button_flip_Clicked(object sender, EventArgs e)
        {//按下翻面，顯示解釋：先判斷檔案是否存在才能取得

            label_explanation.Text = string.Empty;
            Utility.GetExplanation(configPath, label_explanation, selectedV);

            button_flip.Enabled = false;
        }

        private void menu_Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void menu_startQuiz_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            button_flip.Enabled = true;
            string res = strMatchesCtl1.SelectedText;
           
            selectedV = res.Substring(0,1).ToUpper()+ res.Substring(1,res.Length-1);
            path = $@"{configPath}\{selectedV}\image\{selectedV}.jpg";
                     


            //按下搜尋，顯示圖片：先判斷檔案是否存在才能取得
            bool file = File.Exists(path);//需要完整路徑   
            if (file)
            {
                Bitmap bitmap = new Bitmap(path);
                pictureBox_ShowIMG.Image = bitmap;
            }
            else
            {
                MessageBox.Show("IMG File is not existed.");
            }
        }

        private void menu_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_speaker_Click(object sender, EventArgs e)
        {
            string speechText1 = selectedV;
            
            SpeechSynthesizer voice = new SpeechSynthesizer();
            //美語 男聲
            voice.SelectVoice("Microsoft David Desktop");
            voice.Speak(speechText1);
            //美語 女聲
            voice.SelectVoice("Microsoft Zira Desktop");
            voice.Speak(speechText1);

        }

        private void pictureBox_speaker2_Click(object sender, EventArgs e)
        {
            string speechText2 = label_explanation.Text;

            SpeechSynthesizer voice = new SpeechSynthesizer();
           
            //國語
            var pb = new PromptBuilder();
            pb.StartVoice("Microsoft Hanhan Desktop");
            pb.AppendText(speechText2);
            //https://msdn.microsoft.com/zh-tw/library/hh378418(v=office.14).aspx
            //pb.AppendSsmlMarkup("<voice name=\"Microsoft David Desktop\">darkthread</voice>");
            pb.EndVoice();
            voice.Speak(pb);
        }

        private void QuickReMe_Load(object sender, EventArgs e)
        {
            List<string> vocabularies = new List<string>();
            
            string[] directories = Directory.GetDirectories(configPath);//得到此路徑下面的所有目錄=>單字資料夾

            foreach (var directory in directories)
            {
                DirectoryInfo folder = new DirectoryInfo(directory);
                vocabularies.Add(folder.Name.ToLower());//把資料夾名稱一一存入"自動完成輸入集合"                    
            }

            strMatchesCtl1.DataSource = vocabularies;
        }



       




    }
}

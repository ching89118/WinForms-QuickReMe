using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using System.Configuration;
using Timer =System.Timers.Timer;
using System.Threading.Tasks;
using System.Threading;
using System.Speech.Synthesis;

namespace _A20200615
{
    public partial class Quiz : Form//在專案下新增Form表單
    {
     
        List<string> files;
        Timer timer;
        Timer timer2;
        private string configPath;
        string singleFile;//ChangePicture()裡
        string[] folderName;
        DirectoryInfo directoryInfo;
        bool isCorrectAnswer = false;        
        int score = 0;
        private int timeLeft;
        int index = 0;
       

        public Quiz()
        {
            InitializeComponent();
            configPath = ConfigurationManager.AppSettings["directoryPath"];
        }

        private void Quiz_Load(object sender, EventArgs e)
        {           
            pictureBox_correct.Visible = false;
            pictureBox_incorrect.Visible = false;
            pictureBox_timeUp.Visible = false;
            pictureBox_timeUp.Visible = false;
            label_setTimer.Visible = false;
            pictureBox_next.Visible = false;
        }

        private List<string> GetRandomImages()
        {


            string test = "ching89118@gmail.com";
            bool result = test.IsEmail();
            Console.WriteLine(result);

            //先用一個泛型集合來儲存所有圖片的路徑
            //再使用Linq的Orderby方法(指的是我們要以Random隨機得到GUID的HashCode來當亂數種子)，
            //以這個亂數排序法，來一一排序files集合裡的元素，x就是迭代器

            files = Directory.GetFiles($@"C:\Users\ching\source\repos\A20200615\Vocabulary", "*.jpg", 
                                       SearchOption.AllDirectories).OrderBy
                                       (d => new Random(Guid.NewGuid().GetHashCode()).Next()).ToList();

            //既然集合裡的元素，已經做了亂數排序，因此每次讀取集合裡的第一個元素都不是同一個
            using (FileStream fs = new FileStream(files[index],
                             FileMode.Open, FileAccess.Read))
            {
                myPictureBox.Image = Image.FromStream(fs);
            }

            // Create timer to call timer_Elapsed every 16 secs.
            timer = new Timer();
            timer.Interval = 16000; //16 secs.   
            timer.Elapsed += Timer_Elapsed;//每過16秒就觸發方法事件
            timer.Start();

           


            // Show first picture so we dont need wait 16 secs.
             ChangePicture();

            return files;
        }



        private void ChangePicture()
        {
            if (files.Count > 0)
            {
                //OK lets grab first one
               singleFile = files[++index];////////從這裡取得當前圖片路徑/////////    
               // Load it
                myPictureBox.Load(singleFile);

                directoryInfo = new DirectoryInfo(singleFile);//檔名
                Console.WriteLine(directoryInfo.Name);//.jpg
            }
            else
            {                
                //Out of pictures, stopping timer
                 //and wait god todo someting.
                timer.Stop();
                timer2.Stop();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
           
            //得到當前加載圖片的檔名            
            folderName = directoryInfo.Name.Split('.');

            //folderName[0]檔名不含.jpg
            if (textBox_answer.Text.ToLower() == folderName[0].ToLower())
            {//答案正確
                isCorrectAnswer = true;
                score++;
                pictureBox_correct.Visible = true;
                pictureBox_incorrect.Visible = false;
                //Console.WriteLine(folderName[0].ToLower());
                label_score.Text = score.ToString();
            }
            else
            {//答案錯誤
                pictureBox_incorrect.Visible = true;
                pictureBox_correct.Visible = false;
                textBox_answer.ForeColor = Color.Red;
                textBox_answer.Text = folderName[0];
            }

        }

        private void Timer2_Elapsed(object sender, ElapsedEventArgs e)
        {            
            folderName = directoryInfo.Name.Split('.');
            button_submit.setCtrlsEnable(true);//Extention


            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                string showSec = timeLeft + " seconds";
                label_setTimer.ShowCtrlsText(showSec);//Extention
                


                if (timeLeft==5)
                {
                    pictureBox_timeUp.SetCtrlsVisible(true);//Extention
                }
                else if (timeLeft==1)//時間剩1秒
                {
                    
                    if (string.IsNullOrEmpty(textBox_answer.Text) && isCorrectAnswer == false)
                    {
                        button_submit.setCtrlsEnable(false);//Extention
                        //答案錯誤
                        pictureBox_incorrect.SetCtrlsVisible(true);//Extention
                        pictureBox_correct.SetCtrlsVisible(false);//Extention
                        textBox_answer.setCtrlsForeCr(Color.Red);//Extention
                        textBox_answer.ShowCtrlsText(folderName[0]);//Extention
                        Thread.Sleep(1000);

                    }
                    else if (textBox_answer.Text.ToLower() != folderName[0].ToLower() && isCorrectAnswer == false)
                    {
                        button_submit.setCtrlsEnable(false);//Extention
                        //答案錯誤
                        pictureBox_incorrect.SetCtrlsVisible(true);//Extention
                        pictureBox_correct.SetCtrlsVisible(false);//Extention
                        textBox_answer.setCtrlsForeCr(Color.Red);//Extention
                        textBox_answer.ShowCtrlsText(folderName[0]);//Extention
                        Thread.Sleep(1000);
                    }
                    else if (textBox_answer.Text.ToLower() == folderName[0].ToLower() && isCorrectAnswer == false)
                    {
                        button_submit.setCtrlsEnable(false);//Extention
                        //答案正確                        
                        score++;
                        pictureBox_correct.SetCtrlsVisible(true);//Extention
                        pictureBox_incorrect.SetCtrlsVisible(false);//Extention
                        //Console.WriteLine(folderName[0].ToLower());
                        label_score.ShowCtrlsText(score.ToString());//Extention
                    }
                    isCorrectAnswer = false;
                }
            }
            else
            {
                /* 倒數時間到執行 */

                timeLeft = 15;
                label_setTimer.ShowCtrlsText("15 seconds");//Extention
                pictureBox_timeUp.SetCtrlsVisible(false);//Extention                
            }
        }     

       


        private void Timer_Elapsed(object sender, ElapsedEventArgs e)//it happens every 16 secs.
        {            
            // Time to get new one.           
            ChangePicture();            
        }

        private void textBox_answer_Click(object sender, EventArgs e)
        {
            textBox_answer.Text = "";
            textBox_answer.ForeColor = Color.Black;
            pictureBox_correct.Visible = false;
            pictureBox_incorrect.Visible = false;
        }

        private void pictureBox_iDontKnow_Click(object sender, EventArgs e)
        {            
            folderName = directoryInfo.Name.Split('.');

            //答案錯誤
            pictureBox_incorrect.Visible = true;
            pictureBox_correct.Visible = false;
            textBox_answer.ForeColor = Color.Red;
            textBox_answer.Text = folderName[0];
        }

       

        private void menu_timerMode_Click(object sender, EventArgs e)
        {            
            label_setTimer.Visible = true;            

            //選擇計時模式，才啟動計時器
            timeLeft = 15;
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Elapsed += Timer2_Elapsed;
            label_setTimer.Text = "15 seconds";
            /* Timer 啟動 */
            timer2.Start();


            //以計時方式來更換顯示圖片
           List<string> temp= GetRandomImages();
        }

        private void menu_manualMode_Click(object sender, EventArgs e)
        {
            pictureBox_next.Visible = true;                   
        }

        private void pictureBox_next_Click(object sender, EventArgs e)
        {
            // 將此路徑下全部的檔案，儲存到Files陣列         

            files = Directory.GetFiles($@"C:\Users\ching\source\repos\A20200615\Vocabulary", "*.jpg", 
                SearchOption.AllDirectories).ToList();

            //將圖片隨機放入PictureBox容器裡

            Random rand = new Random();
            int index = rand.Next(0, files.Count - 1);
            using (var fs = new FileStream(files[index],
                              FileMode.Open, FileAccess.Read))
            {
                myPictureBox.Image = Image.FromStream(fs);
            }
            singleFile = files[index];////////從這裡取得當前圖片路徑/////////           
            directoryInfo = new DirectoryInfo(singleFile);//檔名


        }
    }
}



   

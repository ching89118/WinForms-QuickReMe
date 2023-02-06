namespace _A20200615
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.pictureBox_iDontKnow = new System.Windows.Forms.PictureBox();
            this.label_score = new System.Windows.Forms.Label();
            this.pictureBox_showScore = new System.Windows.Forms.PictureBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.pictureBox_incorrect = new System.Windows.Forms.PictureBox();
            this.pictureBox_correct = new System.Windows.Forms.PictureBox();
            this.label_setTimer = new System.Windows.Forms.Label();
            this.pictureBox_timeUp = new System.Windows.Forms.PictureBox();
            this.pictureBox_next = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menu_timerMode = new System.Windows.Forms.MenuItem();
            this.menu_manualMode = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iDontKnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_incorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(118, 42);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(445, 375);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox.TabIndex = 14;
            this.myPictureBox.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(113, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(453, 382);
            this.listBox1.TabIndex = 15;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_answer.Location = new System.Drawing.Point(73, 445);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(493, 31);
            this.textBox_answer.TabIndex = 16;
            this.textBox_answer.Text = "Enter the answer, press \"submit\" button when finished";
            this.textBox_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_answer.Click += new System.EventHandler(this.textBox_answer_Click);
            // 
            // pictureBox_iDontKnow
            // 
            this.pictureBox_iDontKnow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_iDontKnow.Image")));
            this.pictureBox_iDontKnow.Location = new System.Drawing.Point(606, 492);
            this.pictureBox_iDontKnow.Name = "pictureBox_iDontKnow";
            this.pictureBox_iDontKnow.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_iDontKnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_iDontKnow.TabIndex = 17;
            this.pictureBox_iDontKnow.TabStop = false;
            this.pictureBox_iDontKnow.Click += new System.EventHandler(this.pictureBox_iDontKnow_Click);
            // 
            // label_score
            // 
            this.label_score.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_score.ForeColor = System.Drawing.Color.Indigo;
            this.label_score.Location = new System.Drawing.Point(721, 72);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(48, 37);
            this.label_score.TabIndex = 19;
            this.label_score.Text = "0";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_showScore
            // 
            this.pictureBox_showScore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_showScore.Image")));
            this.pictureBox_showScore.Location = new System.Drawing.Point(688, 4);
            this.pictureBox_showScore.Name = "pictureBox_showScore";
            this.pictureBox_showScore.Size = new System.Drawing.Size(112, 122);
            this.pictureBox_showScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_showScore.TabIndex = 20;
            this.pictureBox_showScore.TabStop = false;
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_submit.Location = new System.Drawing.Point(581, 425);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(104, 64);
            this.button_submit.TabIndex = 21;
            this.button_submit.Text = "submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // pictureBox_incorrect
            // 
            this.pictureBox_incorrect.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_incorrect.Image")));
            this.pictureBox_incorrect.Location = new System.Drawing.Point(522, 490);
            this.pictureBox_incorrect.Name = "pictureBox_incorrect";
            this.pictureBox_incorrect.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_incorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_incorrect.TabIndex = 22;
            this.pictureBox_incorrect.TabStop = false;
            // 
            // pictureBox_correct
            // 
            this.pictureBox_correct.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_correct.Image")));
            this.pictureBox_correct.Location = new System.Drawing.Point(470, 492);
            this.pictureBox_correct.Name = "pictureBox_correct";
            this.pictureBox_correct.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_correct.TabIndex = 22;
            this.pictureBox_correct.TabStop = false;
            // 
            // label_setTimer
            // 
            this.label_setTimer.AutoSize = true;
            this.label_setTimer.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_setTimer.Location = new System.Drawing.Point(578, 20);
            this.label_setTimer.Name = "label_setTimer";
            this.label_setTimer.Size = new System.Drawing.Size(49, 18);
            this.label_setTimer.TabIndex = 23;
            this.label_setTimer.Text = "0 sec";
            // 
            // pictureBox_timeUp
            // 
            this.pictureBox_timeUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_timeUp.Image")));
            this.pictureBox_timeUp.Location = new System.Drawing.Point(572, 20);
            this.pictureBox_timeUp.Name = "pictureBox_timeUp";
            this.pictureBox_timeUp.Size = new System.Drawing.Size(110, 106);
            this.pictureBox_timeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_timeUp.TabIndex = 24;
            this.pictureBox_timeUp.TabStop = false;
            // 
            // pictureBox_next
            // 
            this.pictureBox_next.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_next.Image")));
            this.pictureBox_next.Location = new System.Drawing.Point(599, 216);
            this.pictureBox_next.Name = "pictureBox_next";
            this.pictureBox_next.Size = new System.Drawing.Size(57, 57);
            this.pictureBox_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_next.TabIndex = 25;
            this.pictureBox_next.TabStop = false;
            this.pictureBox_next.Click += new System.EventHandler(this.pictureBox_next_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_timerMode,
            this.menu_manualMode});
            this.menuItem1.Text = "Mode";
            // 
            // menu_timerMode
            // 
            this.menu_timerMode.Index = 0;
            this.menu_timerMode.Text = "Timer Mode";
            this.menu_timerMode.Click += new System.EventHandler(this.menu_timerMode_Click);
            // 
            // menu_manualMode
            // 
            this.menu_manualMode.Index = 1;
            this.menu_manualMode.Text = "Manual Mode";
            this.menu_manualMode.Click += new System.EventHandler(this.menu_manualMode_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.pictureBox_next);
            this.Controls.Add(this.label_setTimer);
            this.Controls.Add(this.pictureBox_timeUp);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.pictureBox_correct);
            this.Controls.Add(this.pictureBox_incorrect);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.pictureBox_showScore);
            this.Controls.Add(this.pictureBox_iDontKnow);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.listBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iDontKnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_incorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.PictureBox pictureBox_iDontKnow;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.PictureBox pictureBox_showScore;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.PictureBox pictureBox_incorrect;
        private System.Windows.Forms.PictureBox pictureBox_correct;
        private System.Windows.Forms.Label label_setTimer;
        private System.Windows.Forms.PictureBox pictureBox_timeUp;
        private System.Windows.Forms.PictureBox pictureBox_next;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menu_timerMode;
        private System.Windows.Forms.MenuItem menu_manualMode;
    }
}
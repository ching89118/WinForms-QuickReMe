using System;

namespace _A20200615
{
    partial class QuickReMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickReMe));
            this.pictureBox_ShowIMG = new System.Windows.Forms.PictureBox();
            this.button_flip = new System.Windows.Forms.Button();
            this.label_explanation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menu_Add = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menu_startQuiz = new System.Windows.Forms.MenuItem();
            this.menu_CloseApp = new System.Windows.Forms.MenuItem();
            this.menu_close = new System.Windows.Forms.MenuItem();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.pictureBox_speaker = new System.Windows.Forms.PictureBox();
            this.pictureBox_speaker2 = new System.Windows.Forms.PictureBox();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.strMatchesCtl1 = new StrMatchesCtl.StrMatchesCtl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ShowIMG
            // 
            this.pictureBox_ShowIMG.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ShowIMG.Location = new System.Drawing.Point(38, 96);
            this.pictureBox_ShowIMG.Name = "pictureBox_ShowIMG";
            this.pictureBox_ShowIMG.Size = new System.Drawing.Size(360, 325);
            this.pictureBox_ShowIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShowIMG.TabIndex = 11;
            this.pictureBox_ShowIMG.TabStop = false;
            // 
            // button_flip
            // 
            this.button_flip.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_flip.Location = new System.Drawing.Point(358, 31);
            this.button_flip.Name = "button_flip";
            this.button_flip.Size = new System.Drawing.Size(76, 40);
            this.button_flip.TabIndex = 9;
            this.button_flip.Text = "flip";
            this.button_flip.UseVisualStyleBackColor = true;
            this.button_flip.Click += new System.EventHandler(this.button_flip_Clicked);
            // 
            // label_explanation
            // 
            this.label_explanation.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.label_explanation.Location = new System.Drawing.Point(401, 96);
            this.label_explanation.Name = "label_explanation";
            this.label_explanation.Size = new System.Drawing.Size(360, 325);
            this.label_explanation.TabIndex = 7;
            this.label_explanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(728, 329);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.textBox_Search.Location = new System.Drawing.Point(685, 0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(100, 31);
            this.textBox_Search.TabIndex = 5;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menu_CloseApp});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_Add});
            this.menuItem1.Text = "Add";
            // 
            // menu_Add
            // 
            this.menu_Add.Index = 0;
            this.menu_Add.Text = "New Word";
            this.menu_Add.Click += new System.EventHandler(this.menu_Add_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_startQuiz});
            this.menuItem2.Text = "Quiz";
            // 
            // menu_startQuiz
            // 
            this.menu_startQuiz.Index = 0;
            this.menu_startQuiz.Text = "Start";
            this.menu_startQuiz.Click += new System.EventHandler(this.menu_startQuiz_Click);
            // 
            // menu_CloseApp
            // 
            this.menu_CloseApp.Index = 2;
            this.menu_CloseApp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_close});
            this.menu_CloseApp.Text = "Exit";
            // 
            // menu_close
            // 
            this.menu_close.Index = 0;
            this.menu_close.Text = "Close App";
            this.menu_close.Click += new System.EventHandler(this.menu_close_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.BackColor = System.Drawing.Color.White;
            this.pictureBox_search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_search.Image")));
            this.pictureBox_search.Location = new System.Drawing.Point(169, 31);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_search.TabIndex = 20;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // pictureBox_speaker
            // 
            this.pictureBox_speaker.BackColor = System.Drawing.Color.White;
            this.pictureBox_speaker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_speaker.Image")));
            this.pictureBox_speaker.Location = new System.Drawing.Point(38, 361);
            this.pictureBox_speaker.Name = "pictureBox_speaker";
            this.pictureBox_speaker.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_speaker.TabIndex = 21;
            this.pictureBox_speaker.TabStop = false;
            this.pictureBox_speaker.Click += new System.EventHandler(this.pictureBox_speaker_Click);
            // 
            // pictureBox_speaker2
            // 
            this.pictureBox_speaker2.BackColor = System.Drawing.Color.White;
            this.pictureBox_speaker2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_speaker2.Image")));
            this.pictureBox_speaker2.Location = new System.Drawing.Point(401, 361);
            this.pictureBox_speaker2.Name = "pictureBox_speaker2";
            this.pictureBox_speaker2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_speaker2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_speaker2.TabIndex = 22;
            this.pictureBox_speaker2.TabStop = false;
            this.pictureBox_speaker2.Click += new System.EventHandler(this.pictureBox_speaker2_Click);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(664, 37);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Search.TabIndex = 23;
            this.comboBox_Search.TextUpdate += new System.EventHandler(this.comboBox_Search_TextUpdate);
            // 
            // strMatchesCtl1
            // 
            this.strMatchesCtl1.Location = new System.Drawing.Point(36, 35);
            this.strMatchesCtl1.Name = "strMatchesCtl1";
            this.strMatchesCtl1.Size = new System.Drawing.Size(131, 35);
            this.strMatchesCtl1.TabIndex = 24;
            // 
            // QuickReMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.strMatchesCtl1);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.pictureBox_speaker2);
            this.Controls.Add(this.pictureBox_speaker);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.pictureBox_ShowIMG);
            this.Controls.Add(this.button_flip);
            this.Controls.Add(this.label_explanation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Search);
            this.Menu = this.mainMenu1;
            this.Name = "QuickReMe";
            this.Text = "QuickReMe[Main]";
            this.Load += new System.EventHandler(this.QuickReMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speaker2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ShowIMG;
        private System.Windows.Forms.Button button_flip;
        private System.Windows.Forms.Label label_explanation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menu_Add;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menu_CloseApp;
        private System.Windows.Forms.MenuItem menu_startQuiz;
        private System.Windows.Forms.MenuItem menu_close;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.PictureBox pictureBox_speaker;
        private System.Windows.Forms.PictureBox pictureBox_speaker2;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private StrMatchesCtl.StrMatchesCtl strMatchesCtl1;
    }
}


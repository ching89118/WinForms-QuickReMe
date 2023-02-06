namespace _A20200615
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CSV_label = new System.Windows.Forms.Label();
            this.Image_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showImagePath = new System.Windows.Forms.TextBox();
            this.textBox_importNewWord = new System.Windows.Forms.TextBox();
            this.button_saveIMG = new System.Windows.Forms.Button();
            this.button_exportCSV = new System.Windows.Forms.Button();
            this.pictureBox_UploadIMG = new System.Windows.Forms.PictureBox();
            this.richTextBox_meaning = new System.Windows.Forms.RichTextBox();
            this.drawImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UploadIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(728, 329);
            this.dataGridView1.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CSV_label
            // 
            this.CSV_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CSV_label.Location = new System.Drawing.Point(268, 74);
            this.CSV_label.Name = "CSV_label";
            this.CSV_label.Size = new System.Drawing.Size(356, 36);
            this.CSV_label.TabIndex = 20;
            // 
            // Image_label
            // 
            this.Image_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Image_label.Location = new System.Drawing.Point(13, 542);
            this.Image_label.Name = "Image_label";
            this.Image_label.Size = new System.Drawing.Size(356, 39);
            this.Image_label.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "(請輸入要新增的單字)";
            // 
            // showImagePath
            // 
            this.showImagePath.Location = new System.Drawing.Point(12, 487);
            this.showImagePath.Name = "showImagePath";
            this.showImagePath.Size = new System.Drawing.Size(357, 29);
            this.showImagePath.TabIndex = 17;
            // 
            // textBox_importNewWord
            // 
            this.textBox_importNewWord.Location = new System.Drawing.Point(19, 17);
            this.textBox_importNewWord.Name = "textBox_importNewWord";
            this.textBox_importNewWord.Size = new System.Drawing.Size(154, 29);
            this.textBox_importNewWord.TabIndex = 15;
            this.textBox_importNewWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_importNewWord_KeyDown);
            // 
            // button_saveIMG
            // 
            this.button_saveIMG.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold);
            this.button_saveIMG.Location = new System.Drawing.Point(466, 482);
            this.button_saveIMG.Name = "button_saveIMG";
            this.button_saveIMG.Size = new System.Drawing.Size(124, 32);
            this.button_saveIMG.TabIndex = 13;
            this.button_saveIMG.Text = "SaveIMG";
            this.button_saveIMG.UseVisualStyleBackColor = true;
            this.button_saveIMG.Click += new System.EventHandler(this.saveIMG_Clicked);
            // 
            // button_exportCSV
            // 
            this.button_exportCSV.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold);
            this.button_exportCSV.Location = new System.Drawing.Point(270, 15);
            this.button_exportCSV.Name = "button_exportCSV";
            this.button_exportCSV.Size = new System.Drawing.Size(159, 56);
            this.button_exportCSV.TabIndex = 14;
            this.button_exportCSV.Text = "ExportCSV";
            this.button_exportCSV.UseVisualStyleBackColor = true;
            this.button_exportCSV.Click += new System.EventHandler(this.exportCSV_Clicked);
            // 
            // pictureBox_UploadIMG
            // 
            this.pictureBox_UploadIMG.BackColor = System.Drawing.Color.White;
            this.pictureBox_UploadIMG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_UploadIMG.Image")));
            this.pictureBox_UploadIMG.Location = new System.Drawing.Point(393, 471);
            this.pictureBox_UploadIMG.Name = "pictureBox_UploadIMG";
            this.pictureBox_UploadIMG.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_UploadIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UploadIMG.TabIndex = 19;
            this.pictureBox_UploadIMG.TabStop = false;
            this.pictureBox_UploadIMG.Click += new System.EventHandler(this.pictureBox_UploadIMG_Click);
            // 
            // richTextBox_meaning
            // 
            this.richTextBox_meaning.Location = new System.Drawing.Point(376, 117);
            this.richTextBox_meaning.Name = "richTextBox_meaning";
            this.richTextBox_meaning.Size = new System.Drawing.Size(360, 325);
            this.richTextBox_meaning.TabIndex = 23;
            this.richTextBox_meaning.Text = "(輸入完成，請按下ExportCSV按鈕)";
            // 
            // drawImage
            // 
            this.drawImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawImage.Image = ((System.Drawing.Image)(resources.GetObject("drawImage.Image")));
            this.drawImage.Location = new System.Drawing.Point(13, 117);
            this.drawImage.Name = "drawImage";
            this.drawImage.Size = new System.Drawing.Size(360, 325);
            this.drawImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drawImage.TabIndex = 22;
            this.drawImage.TabStop = false;
            this.drawImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.drawImage_DragDrop);
            this.drawImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.drawImage_DragEnter);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 591);
            this.Controls.Add(this.richTextBox_meaning);
            this.Controls.Add(this.drawImage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CSV_label);
            this.Controls.Add(this.Image_label);
            this.Controls.Add(this.pictureBox_UploadIMG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showImagePath);
            this.Controls.Add(this.textBox_importNewWord);
            this.Controls.Add(this.button_saveIMG);
            this.Controls.Add(this.button_exportCSV);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.Click += new System.EventHandler(this.Add_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UploadIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;     
        private System.Windows.Forms.Label CSV_label;
        private System.Windows.Forms.Label Image_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox showImagePath;    
        private System.Windows.Forms.TextBox textBox_importNewWord;
        private System.Windows.Forms.Button button_saveIMG;
        private System.Windows.Forms.Button button_exportCSV;
       
        private System.Windows.Forms.PictureBox pictureBox_UploadIMG;
        private System.Windows.Forms.RichTextBox richTextBox_meaning;
        private System.Windows.Forms.PictureBox drawImage;
    }
}
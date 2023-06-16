
namespace pr2_zad1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.savelist_btn = new System.Windows.Forms.Button();
            this.loadList_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name1_txt = new System.Windows.Forms.TextBox();
            this.lastname1_txt = new System.Windows.Forms.TextBox();
            this.nph_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.remove_btn);
            this.tabPage1.Controls.Add(this.find_btn);
            this.tabPage1.Controls.Add(this.lastname_txt);
            this.tabPage1.Controls.Add(this.name_txt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.savelist_btn);
            this.tabPage1.Controls.Add(this.loadList_btn);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список контактов";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.nph_txt);
            this.tabPage2.Controls.Add(this.lastname1_txt);
            this.tabPage2.Controls.Add(this.name1_txt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "добавить контакт";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(290, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 408);
            this.listBox1.TabIndex = 1;
            // 
            // savelist_btn
            // 
            this.savelist_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.savelist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savelist_btn.Location = new System.Drawing.Point(70, 250);
            this.savelist_btn.Name = "savelist_btn";
            this.savelist_btn.Size = new System.Drawing.Size(132, 25);
            this.savelist_btn.TabIndex = 2;
            this.savelist_btn.Text = "сохранить";
            this.savelist_btn.UseVisualStyleBackColor = false;
            this.savelist_btn.Click += new System.EventHandler(this.savelist_btn_Click);
            // 
            // loadList_btn
            // 
            this.loadList_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.loadList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadList_btn.Location = new System.Drawing.Point(69, 219);
            this.loadList_btn.Name = "loadList_btn";
            this.loadList_btn.Size = new System.Drawing.Size(132, 25);
            this.loadList_btn.TabIndex = 0;
            this.loadList_btn.Text = "загрузить";
            this.loadList_btn.UseVisualStyleBackColor = false;
            this.loadList_btn.Click += new System.EventHandler(this.loadList_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "имя";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(70, 44);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(132, 23);
            this.name_txt.TabIndex = 4;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(70, 90);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(132, 23);
            this.lastname_txt.TabIndex = 5;
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find_btn.Location = new System.Drawing.Point(70, 139);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(132, 23);
            this.find_btn.TabIndex = 7;
            this.find_btn.Text = "поиск";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_btn.Location = new System.Drawing.Point(70, 168);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(131, 45);
            this.remove_btn.TabIndex = 8;
            this.remove_btn.Text = "удалить 1 номер человека";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "номер телефона(без +7)";
            // 
            // name1_txt
            // 
            this.name1_txt.Location = new System.Drawing.Point(53, 58);
            this.name1_txt.Name = "name1_txt";
            this.name1_txt.Size = new System.Drawing.Size(168, 23);
            this.name1_txt.TabIndex = 3;
            // 
            // lastname1_txt
            // 
            this.lastname1_txt.Location = new System.Drawing.Point(53, 104);
            this.lastname1_txt.Name = "lastname1_txt";
            this.lastname1_txt.Size = new System.Drawing.Size(168, 23);
            this.lastname1_txt.TabIndex = 4;
            // 
            // nph_txt
            // 
            this.nph_txt.Location = new System.Drawing.Point(53, 150);
            this.nph_txt.Name = "nph_txt";
            this.nph_txt.Size = new System.Drawing.Size(168, 23);
            this.nph_txt.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(53, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "добавить ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(71, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "обновить список";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(610, 423);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button savelist_btn;
        private System.Windows.Forms.Button loadList_btn;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nph_txt;
        private System.Windows.Forms.TextBox lastname1_txt;
        private System.Windows.Forms.TextBox name1_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace Capital_Bank
{
    partial class ГлавнаяФорма
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ГлавнаяФорма));
            this.Разделы = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discord = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcBtn = new System.Windows.Forms.Button();
            this.verLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.skoba = new System.Windows.Forms.Label();
            this.drobTxt = new System.Windows.Forms.Label();
            this.sNum = new System.Windows.Forms.TextBox();
            this.sLbl = new System.Windows.Forms.Label();
            this.mNum = new System.Windows.Forms.TextBox();
            this.pNum = new System.Windows.Forms.TextBox();
            this.xNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Разделы.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Разделы
            // 
            this.Разделы.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.Разделы.Location = new System.Drawing.Point(0, 0);
            this.Разделы.Name = "Разделы";
            this.Разделы.Size = new System.Drawing.Size(800, 24);
            this.Разделы.TabIndex = 0;
            this.Разделы.Text = "Раздел";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discord});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // discord
            // 
            this.discord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(114, 22);
            this.discord.Text = "Discord";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(709, 368);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Просчитать";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Location = new System.Drawing.Point(728, 9);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(16, 13);
            this.verLbl.TabIndex = 2;
            this.verLbl.Text = "v.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 423);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.skoba);
            this.tabPage1.Controls.Add(this.drobTxt);
            this.tabPage1.Controls.Add(this.sNum);
            this.tabPage1.Controls.Add(this.sLbl);
            this.tabPage1.Controls.Add(this.mNum);
            this.tabPage1.Controls.Add(this.pNum);
            this.tabPage1.Controls.Add(this.xNum);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.calcBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аннуитетный";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // skoba
            // 
            this.skoba.AutoSize = true;
            this.skoba.Location = new System.Drawing.Point(627, 65);
            this.skoba.Name = "skoba";
            this.skoba.Size = new System.Drawing.Size(35, 13);
            this.skoba.TabIndex = 13;
            this.skoba.Text = "label4";
            // 
            // drobTxt
            // 
            this.drobTxt.AutoSize = true;
            this.drobTxt.Location = new System.Drawing.Point(627, 23);
            this.drobTxt.Name = "drobTxt";
            this.drobTxt.Size = new System.Drawing.Size(35, 13);
            this.drobTxt.TabIndex = 12;
            this.drobTxt.Text = "label4";
            // 
            // sNum
            // 
            this.sNum.Location = new System.Drawing.Point(274, 110);
            this.sNum.Name = "sNum";
            this.sNum.Size = new System.Drawing.Size(100, 20);
            this.sNum.TabIndex = 11;
            this.sNum.Text = "1500000";
            // 
            // sLbl
            // 
            this.sLbl.AutoSize = true;
            this.sLbl.Location = new System.Drawing.Point(8, 113);
            this.sLbl.Name = "sLbl";
            this.sLbl.Size = new System.Drawing.Size(76, 13);
            this.sLbl.TabIndex = 10;
            this.sLbl.Text = "Сумма займа";
            // 
            // mNum
            // 
            this.mNum.Location = new System.Drawing.Point(274, 58);
            this.mNum.Name = "mNum";
            this.mNum.Size = new System.Drawing.Size(100, 20);
            this.mNum.TabIndex = 7;
            this.mNum.Text = "0,5";
            // 
            // pNum
            // 
            this.pNum.Location = new System.Drawing.Point(274, 34);
            this.pNum.Name = "pNum";
            this.pNum.Size = new System.Drawing.Size(100, 20);
            this.pNum.TabIndex = 6;
            this.pNum.Text = "0,01";
            // 
            // xNum
            // 
            this.xNum.Location = new System.Drawing.Point(274, 8);
            this.xNum.Name = "xNum";
            this.xNum.Size = new System.Drawing.Size(100, 20);
            this.xNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок кредитования (в месяцах)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1/100 доля процентной ставки (в месяц)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ежемесячный платеж (X)";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дифференцированный";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(11, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 243);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчет ставки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ГлавнаяФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.verLbl);
            this.Controls.Add(this.Разделы);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Разделы;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ГлавнаяФорма";
            this.Text = "Программа расчета Capital.Bank";
            this.Разделы.ResumeLayout(false);
            this.Разделы.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Разделы;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discord;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label verLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mNum;
        private System.Windows.Forms.TextBox pNum;
        private System.Windows.Forms.TextBox xNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sNum;
        private System.Windows.Forms.Label sLbl;
        private System.Windows.Forms.Label drobTxt;
        private System.Windows.Forms.Label skoba;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}


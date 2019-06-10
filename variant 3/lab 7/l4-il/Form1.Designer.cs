namespace l4_il
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.построитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гиперболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синусоидаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тонкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утолщеннаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.циклоидаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьToolStripMenuItem,
            this.форматироватьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // построитьToolStripMenuItem
            // 
            this.построитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.осиToolStripMenuItem,
            this.прямаяToolStripMenuItem,
            this.параболаToolStripMenuItem,
            this.гиперболаToolStripMenuItem,
            this.синусоидаToolStripMenuItem,
            this.циклоидаToolStripMenuItem});
            this.построитьToolStripMenuItem.Name = "построитьToolStripMenuItem";
            this.построитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.построитьToolStripMenuItem.Text = "Построить";
            // 
            // осиToolStripMenuItem
            // 
            this.осиToolStripMenuItem.Name = "осиToolStripMenuItem";
            this.осиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.осиToolStripMenuItem.Text = "Оси";
            this.осиToolStripMenuItem.Click += new System.EventHandler(this.осиToolStripMenuItem_Click);
            // 
            // прямаяToolStripMenuItem
            // 
            this.прямаяToolStripMenuItem.Name = "прямаяToolStripMenuItem";
            this.прямаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прямаяToolStripMenuItem.Text = "Прямая";
            this.прямаяToolStripMenuItem.Click += new System.EventHandler(this.прямаяToolStripMenuItem_Click);
            // 
            // параболаToolStripMenuItem
            // 
            this.параболаToolStripMenuItem.Name = "параболаToolStripMenuItem";
            this.параболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параболаToolStripMenuItem.Text = "Парабола";
            this.параболаToolStripMenuItem.Click += new System.EventHandler(this.параболаToolStripMenuItem_Click);
            // 
            // гиперболаToolStripMenuItem
            // 
            this.гиперболаToolStripMenuItem.Name = "гиперболаToolStripMenuItem";
            this.гиперболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гиперболаToolStripMenuItem.Text = "Гипербола";
            this.гиперболаToolStripMenuItem.Click += new System.EventHandler(this.гиперболаToolStripMenuItem_Click);
            // 
            // синусоидаToolStripMenuItem
            // 
            this.синусоидаToolStripMenuItem.Name = "синусоидаToolStripMenuItem";
            this.синусоидаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.синусоидаToolStripMenuItem.Text = "Синусоида";
            this.синусоидаToolStripMenuItem.Click += new System.EventHandler(this.синусоидаToolStripMenuItem_Click);
            // 
            // форматироватьToolStripMenuItem
            // 
            this.форматироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборЦветаToolStripMenuItem,
            this.толщинаЛинииToolStripMenuItem});
            this.форматироватьToolStripMenuItem.Name = "форматироватьToolStripMenuItem";
            this.форматироватьToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.форматироватьToolStripMenuItem.Text = "Форматировать";
            // 
            // выборЦветаToolStripMenuItem
            // 
            this.выборЦветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зеленыйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.черныйToolStripMenuItem,
            this.желтыйToolStripMenuItem});
            this.выборЦветаToolStripMenuItem.Name = "выборЦветаToolStripMenuItem";
            this.выборЦветаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.выборЦветаToolStripMenuItem.Text = "Выбор цвета";
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.черныйToolStripMenuItem.Text = "Черный";
            this.черныйToolStripMenuItem.Click += new System.EventHandler(this.черныйToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            this.желтыйToolStripMenuItem.Click += new System.EventHandler(this.желтыйToolStripMenuItem_Click);
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            this.толщинаЛинииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тонкаяToolStripMenuItem,
            this.средняяToolStripMenuItem,
            this.утолщеннаяToolStripMenuItem});
            this.толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            this.толщинаЛинииToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            this.толщинаЛинииToolStripMenuItem.Click += new System.EventHandler(this.толщинаЛинииToolStripMenuItem_Click);
            // 
            // тонкаяToolStripMenuItem
            // 
            this.тонкаяToolStripMenuItem.Name = "тонкаяToolStripMenuItem";
            this.тонкаяToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.тонкаяToolStripMenuItem.Text = "Тонкая";
            this.тонкаяToolStripMenuItem.Click += new System.EventHandler(this.тонкаяToolStripMenuItem_Click);
            // 
            // средняяToolStripMenuItem
            // 
            this.средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            this.средняяToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.средняяToolStripMenuItem.Text = "Средняя";
            this.средняяToolStripMenuItem.Click += new System.EventHandler(this.средняяToolStripMenuItem_Click);
            // 
            // утолщеннаяToolStripMenuItem
            // 
            this.утолщеннаяToolStripMenuItem.Name = "утолщеннаяToolStripMenuItem";
            this.утолщеннаяToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.утолщеннаяToolStripMenuItem.Text = "Утолщенная";
            this.утолщеннаяToolStripMenuItem.Click += new System.EventHandler(this.утолщеннаяToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 410);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // циклоидаToolStripMenuItem
            // 
            this.циклоидаToolStripMenuItem.Name = "циклоидаToolStripMenuItem";
            this.циклоидаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.циклоидаToolStripMenuItem.Text = "Циклоида";
            this.циклоидаToolStripMenuItem.Click += new System.EventHandler(this.циклоидаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem построитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гиперболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синусоидаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тонкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem утолщеннаяToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem циклоидаToolStripMenuItem;
    }
}


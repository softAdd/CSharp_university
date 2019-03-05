namespace WFlab1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(211, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Срочно";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(211, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Доставка на дом";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(9, 8);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(104, 13);
            this.productsLabel.TabIndex = 4;
            this.productsLabel.Text = "Перечень изделий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Доп. услуги";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(211, 285);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(115, 81);
            this.accept.TabIndex = 8;
            this.accept.Text = "Заказать";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сложность";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "Пошив женской одежды - 1000",
            "Пошив мужской одежды - 1000",
            "Пошив вечерних платьев - 2000",
            "Пошив изделий из кожи - 1200"});
            this.productList.Location = new System.Drawing.Point(12, 37);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(190, 368);
            this.productList.TabIndex = 11;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(211, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 430);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Ателье мод";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.ListBox listBox1;
    }
}


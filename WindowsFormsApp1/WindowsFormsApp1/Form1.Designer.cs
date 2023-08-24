namespace WindowsFormsApp1
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
            this.h1 = new System.Windows.Forms.Label();
            this.text_box_name = new System.Windows.Forms.TextBox();
            this.text_box_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_box_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_button_man = new System.Windows.Forms.RadioButton();
            this.radio_button_woman = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button_test2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_test1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.PeachPuff;
            this.h1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.h1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.h1.Location = new System.Drawing.Point(57, 9);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(558, 93);
            this.h1.TabIndex = 2;
            this.h1.Text = "Вас приветсвует приложение по помощи в выборе хобби. Заполните поля и пройдите те" +
    "ст";
            this.h1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_box_name
            // 
            this.text_box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_box_name.Location = new System.Drawing.Point(123, 190);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.Size = new System.Drawing.Size(100, 23);
            this.text_box_name.TabIndex = 3;
            this.text_box_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_box_surname
            // 
            this.text_box_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_box_surname.Location = new System.Drawing.Point(123, 228);
            this.text_box_surname.Name = "text_box_surname";
            this.text_box_surname.Size = new System.Drawing.Size(100, 23);
            this.text_box_surname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(27, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // text_box_age
            // 
            this.text_box_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_box_age.Location = new System.Drawing.Point(123, 270);
            this.text_box_age.Name = "text_box_age";
            this.text_box_age.Size = new System.Drawing.Size(100, 23);
            this.text_box_age.TabIndex = 7;
            this.text_box_age.TextChanged += new System.EventHandler(this.text_box_age_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(27, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Возраст";
            // 
            // radio_button_man
            // 
            this.radio_button_man.AutoSize = true;
            this.radio_button_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_button_man.Location = new System.Drawing.Point(140, 309);
            this.radio_button_man.Name = "radio_button_man";
            this.radio_button_man.Size = new System.Drawing.Size(83, 21);
            this.radio_button_man.TabIndex = 9;
            this.radio_button_man.TabStop = true;
            this.radio_button_man.Text = "Мужской";
            this.radio_button_man.UseVisualStyleBackColor = true;
            this.radio_button_man.CheckedChanged += new System.EventHandler(this.radio_button_man_CheckedChanged);
            // 
            // radio_button_woman
            // 
            this.radio_button_woman.AutoSize = true;
            this.radio_button_woman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_button_woman.Location = new System.Drawing.Point(140, 333);
            this.radio_button_woman.Name = "radio_button_woman";
            this.radio_button_woman.Size = new System.Drawing.Size(85, 21);
            this.radio_button_woman.TabIndex = 10;
            this.radio_button_woman.TabStop = true;
            this.radio_button_woman.Text = "Женский";
            this.radio_button_woman.UseVisualStyleBackColor = true;
            this.radio_button_woman.CheckedChanged += new System.EventHandler(this.radio_button_woman_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(94, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(98, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(498, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вы ищите первое хобби или хотите превратить хобби в работу?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton3.Location = new System.Drawing.Point(27, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 24);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Хобби";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton4.Location = new System.Drawing.Point(27, 49);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(82, 24);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Работа";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button_test2
            // 
            this.button_test2.BackColor = System.Drawing.Color.Silver;
            this.button_test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_test2.Location = new System.Drawing.Point(497, 518);
            this.button_test2.Name = "button_test2";
            this.button_test2.Size = new System.Drawing.Size(125, 54);
            this.button_test2.TabIndex = 15;
            this.button_test2.Text = "Пройти тест на работу ▶";
            this.button_test2.UseVisualStyleBackColor = false;
            this.button_test2.Visible = false;
            this.button_test2.Click += new System.EventHandler(this.button_test2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(141, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 54);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_test1
            // 
            this.button_test1.BackColor = System.Drawing.Color.Silver;
            this.button_test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_test1.Location = new System.Drawing.Point(497, 461);
            this.button_test1.Name = "button_test1";
            this.button_test1.Size = new System.Drawing.Size(125, 51);
            this.button_test1.TabIndex = 18;
            this.button_test1.Text = "Пройти тест на хобби ▶";
            this.button_test1.UseVisualStyleBackColor = false;
            this.button_test1.Visible = false;
            this.button_test1.Click += new System.EventHandler(this.button_test1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(114, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(432, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 113);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(329, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 125);
            this.label7.TabIndex = 21;
            this.label7.Text = "Пока вы не выберете \"Первое хобби\" или \"Работа\" вы не сможете пройти тест!!! ";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(231, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 44);
            this.label8.TabIndex = 22;
            this.label8.Text = "<--  Вводите целые числа больше нуля";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(232, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 45);
            this.label9.TabIndex = 23;
            this.label9.Text = "<-- Вы не выбрали ваш пол!";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_test1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_test2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radio_button_woman);
            this.Controls.Add(this.radio_button_man);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_box_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_box_surname);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.h1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор хобби";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.TextBox text_box_name;
        private System.Windows.Forms.TextBox text_box_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_box_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_button_man;
        private System.Windows.Forms.RadioButton radio_button_woman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button_test2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_test1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Test_hobbi trying = new Test_hobbi();
        private void button2_Click(object sender, EventArgs e)
        {
            trying.Add_age(text_box_age.Text);
            int n;
            bool isNumeric = int.TryParse(trying.age, out n); 

            trying.Add_name(text_box_name.Text);
            trying.Add_surname(text_box_surname.Text);

            //защита 
            string s = "";
            if (trying.name == "" && trying.surname == "" && trying.age == "")
            {
                label6.Text = "Вы не заполнили графы с именем, фамилией и возрастом!!!";
            }
            if (trying.name != "" || trying.surname != "" || trying.age != "")
            {
                if (trying.name != "")
                {
                    s = s + "1";
                }
                if (trying.surname != "")
                {
                    s = s + "2";
                }
                if (trying.age != "")
                {
                    s = s + "3";
                }
                    if (s == "1")
                    {
                        label6.Text = "Вы не заполнили поле фамилии и возраста!";
                    }
                    if (s == "2")
                    {
                        label6.Text = "Вы не заполнили поле имени и возраста!";
                    }
                    if (s == "3")
                    {
                        label6.Text = "Вы не заполнили поле имени и фамилии!";
                    }
                        if ((s == "123" || s == "132" || s == "312" || s == "321" || s == "213" || s == "231") && (radioButton3.Checked == true || radioButton4.Checked == true) && (isNumeric == true) && (n > 0) && (radio_button_man.Checked == true || radio_button_woman.Checked == true))
                        {
                            label6.Text = "Данные корректны!";
                            label7.Visible = false;
                        }
                        if (s == "12" || s == "21")
                        {
                            label6.Text = "Вы не заполнили графу возраста!";
                        }
                        if (s == "13" || s == "31")
                        {
                            label6.Text = "Вы не заполнили графу фамилии!";
                        }
                        if (s == "23" || s == "32")
                        {
                            label6.Text = "Вы не заполнили графу имени!";
                        }
            }
            
            int x = 0;
            if (trying.name != "") 
            {
                x = x + 1;
            }
            if (trying.surname != "")
            {
                x = x + 1;
            }
            if (trying.age != "")
            {
                x = x + 1;
            }
            //
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                label7.Visible = true;
                button_test1.Visible = false;
                button_test2.Visible = false;
            }
            if (x == 3 && radioButton3.Checked == true && isNumeric == true && (n > 0) && (radio_button_man.Checked == true || radio_button_woman.Checked == true))
            { 
                button_test1.Visible = true;
                button_test2.Visible = false;
            }
            if (x == 3 && radioButton4.Checked == true && isNumeric == true && (n > 0) && (radio_button_man.Checked == true || radio_button_woman.Checked == true))
            {
                button_test2.Visible = true;
                button_test1.Visible = false;
            }
            
            if (isNumeric == true)
            {
                label8.Visible = false;
                if (n <= 0) 
                {
                    label8.Visible = true;
                }
            }
            if (n < 0)
            {
                label8.Visible = true;
                label8.Text = "Надо вводить целые числа больше 0!!!";
            }
            if (isNumeric == false && trying.age != "")
            {
                trying.Add_age("");
                label8.Text = "Вы ввели не число!";
                label8.Visible = true;
                button_test2.Visible = false;
                button_test1.Visible = false;
            }
            if (radio_button_man.Checked == false && radio_button_woman.Checked == false)
            {
                label9.Visible = true;
            }
        }

        private void radio_button_man_CheckedChanged(object sender, EventArgs e)
        {
            trying.Add_pol("man");
            label9.Visible = false;
        }

        private void radio_button_woman_CheckedChanged(object sender, EventArgs e)
        {
            trying.Add_pol("woman");
            label9.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            trying.Add_test("hobbi");
            label7.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            trying.Add_test("work");
            label7.Visible=false;
        }

        private void groupBox1_Enter(object sender, EventArgs e){}

        private void button_test1_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = true;
            button_test1.Visible = false;
            button_test2.Visible = true;
            button2.Visible = false;
            radioButton3.Checked = false;
            trying.test = "";
            Form2 fr2 = new Form2(trying.name, trying.surname, trying.age, trying.pol);
            fr2.StartPosition = FormStartPosition.CenterScreen;
            fr2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e){}

        private void button_test2_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = false;
            radioButton3.Checked = true;
            button_test1.Visible = true;
            button_test2.Visible = false;
            Form5 fr5 = new Form5(trying.name, trying.surname);
            fr5.ShowDialog();
            fr5.StartPosition = FormStartPosition.CenterScreen;
        }

        private void text_box_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

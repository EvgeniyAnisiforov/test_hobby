using MyClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Person trying = new Person();

        string new_name = "";
        string new_surname = "";
        string new_age = "";
        string new_pol = "";

        int new_q_pl = 0;

        int new_w_pl = 0;

        int new_e_pl = 0;

        int new_r_pl = 0;

        int new_t_pl = 0;

        string kolok_do18 = "КОЛЛЕКЦИОНИРОВАНИЕ: монет, марок, фантиков от конфет, часов, картины, статуэтки, книги, значки, куклы, брелки, цветы, мыло, парфюмерию, свечи";
        string kolok_posle18 = "алкоголь, машины, оружие, сигары";

        string rykodel_man = ", резьба по дереву, ремонт машин, производство ножей, моделирование, литье металла, выжигание по дереву";
        string rykodel_woman = ", плетение бисером, выращивание цветов, роспись, гончарное искусство, мыловарение, ландшафтный дизайн";
        string rykodel_vse = "РУКОДЕЛИЕ: вышивание, кулинария, рисование, оригами";

        string activ = "АКТИВНЫЕ: прыжки с парашутом, бег по утрам, собирание грибов/растений, паркур, охота/рыбалка, катание на лошедях, волонтерство, танцы, путешествия, фокусы";

        string sport_do12 = "гимнастика, плаванье, теннис, баскетбол, хоккей, катание на роликах, шахматы, ходожественная гимнастика";
        string sport_13_18 = "бокс, борьба, волейбол, баскетбол, хоккей, гандбол, футбол, тяжелая атлетика, теннис";
        string sport_18 = "бег, плаванье, единоборства, армрестлинг, легкая атлетика, лыжи, гольф";

        string gymonitar = "ГУМАНИТАРНЫЕ: изучение языков, освоение новых программ, чтение книг, квесты, гадание, кино и театр, философия, интеллектуальные игры, игра на инструментах";


        public Form4(string newname, string newsurname, string newage, string newpol, int newq_pl, int neww_pl, int newe_pl, int newr_pl, int newt_pl)
        {
            new_name = newname + " ";
            new_surname = newsurname;
            new_age = newage;
            new_pol = newpol;

            new_q_pl = new_q_pl + newq_pl;

            new_w_pl = new_w_pl + neww_pl;

            new_e_pl = new_e_pl + newe_pl;

            new_r_pl = new_r_pl + newr_pl;

            new_t_pl = new_t_pl + newt_pl;

            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            string aaa = new_name.ToLower();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCase1 = textInfo.ToTitleCase(aaa);

            string bbb = new_surname.ToLower();
            TextInfo textInfo2 = CultureInfo.CurrentCulture.TextInfo;
            string titleCase2 = textInfo.ToTitleCase(bbb);

            label2.Text = (titleCase1) + (titleCase2);
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            label10.Text = Convert.ToString(new_q_pl);
            label11.Text = Convert.ToString(new_w_pl);
            label12.Text = Convert.ToString(new_e_pl);
            label13.Text = Convert.ToString(new_r_pl);
            label14.Text = Convert.ToString(new_t_pl);

            int[] numbers = new int[5]; 
            numbers[0] = new_q_pl; // Добавляем первый элемент
            numbers[1] = new_w_pl; ; // Добавляем второй элемент
            numbers[2] = new_e_pl; ; // Добавляем третий элемент
            numbers[3] = new_r_pl; ; // Добавляем четвертый элемент
            numbers[4] = new_t_pl; ; // Добавляем пятый элемент

            int num = numbers.Max();
            string xxx = "";
            
            int n;
            bool isNumeric = int.TryParse(new_age, out n);

            
            if (num == (new_q_pl))
            {
                if (isNumeric == true)
                {
                    if (n >= 18)
                    {
                        xxx = xxx + (kolok_do18 + ", " + kolok_posle18) + "\n";
                    }
                    if (n < 18)
                    {
                        xxx = xxx + kolok_do18 + "\n";
                    }
                }
                if (isNumeric == false)
                {
                    xxx = xxx + (kolok_do18 + kolok_posle18) + "\n";
                }
            }
            if (num == (new_w_pl))
            {
                if (new_pol == "man")
                {
                    xxx = xxx + (rykodel_vse + rykodel_man) + "\n";
                }
                if (new_pol == "woman")
                {
                    xxx = xxx + (rykodel_vse + rykodel_woman) + "\n";
                }
                if (new_pol == "")
                {
                    xxx = xxx + (rykodel_vse + rykodel_woman + rykodel_man) + "\n";
                }
            }
            if (num == (new_e_pl))
            {
                xxx = xxx + activ + "\n";
            }
            if (num == (new_r_pl))
            {
                if (isNumeric == true)
                {
                    if (n >= 18)
                    {
                        xxx = xxx + "СПОРТ: " + sport_18 + "\n";
                    }
                    if (n >= 13 && n < 18)
                    {
                        xxx = xxx + "СПОРТ: " + sport_13_18 + "\n";
                    }
                    if (n <= 12)
                    {
                        xxx = xxx + "СПОРТ: " + sport_do12 + "\n";
                    }
                }
                if (isNumeric == false)
                {
                    xxx = xxx + "СПОРТ: " + (sport_18 + ", " + sport_13_18 + ", " + sport_do12) + "\n";
                }
            }
            if (num == (new_t_pl))
            {
                xxx = xxx + gymonitar + "\n";
            }

            if (num == 0)
            {
                xxx = "Вы везде ответили 'НЕТ'";
            }
            label16.Text = xxx;
        }
        
        private void label4_Click(object sender, EventArgs e) {}

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}

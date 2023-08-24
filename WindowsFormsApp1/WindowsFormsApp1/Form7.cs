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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string new_name = "";
        string new_surname = "";
        int new_test_pl = 0;


        public Form7(string newname, string newsurname, int newtestpl)
        {
            new_name = newname + " ";
            new_surname = newsurname;
            new_test_pl = newtestpl;

            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
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

            label1.Text = titleCase1 + titleCase2;
            label1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = Convert.ToString(new_test_pl) + "/10";
            label6.Visible = true;
            label7.Visible = true;

            if (new_test_pl >= 7) 
            {
                label7.BackColor = Color.Green;
                label6.Text = "Поздравляем вас с успешным прохождением теста и готовностью превратить своё хобби в настоящую работу! Очень важно находить удовольствие в том, что мы делаем, и мы рады, что вы нашли своё призвание в хобби. Однако помните, что работа в своем хобби может быть трудной и требовать много усилий. Но если вы нацелены на успех и уверены в своих способностях, то вы обязательно сможете добиться большого успеха в своей новой работе.";
            }
            if (new_test_pl >= 4 && new_test_pl < 7)
            {
                label7.BackColor = Color.Yellow;
                label6.Text = "Поздравляем вас с успешным прохождением теста! Это замечательно, что вы уже рассматриваете возможность превратить свое хобби в работу. Но не спешите с этим, важно принимать решения осознанно и не ставить под угрозу своё увлекательное хобби. Развивайте свое увлечение, находите новые идеи, учите новые техники и будьте уверены, что когда придет время - вы будете готовы стать профессионалом в своей области.";
            }
            if (new_test_pl < 4)
            {
                label7.BackColor = Color.Red;
                label6.Text = "Поздравляем вас с успешным прохождением теста! Но помните, что иногда слишком рано начинать превращать любимое хобби в работу. Не стоит спешить и забывать, что заниматься любимым делом можно и без постоянного стресса и ожиданий. Желаем вам сохранять свою страсть к хобби и продолжать радоваться простым моментам, которые оно приносит в вашу жизнь.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Close();
        }
    }
}

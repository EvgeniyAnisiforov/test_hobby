using MyClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Test_work trying = new Test_work();
        string new_name = "";
        string new_surname = "";
        

        public Form5(string newname, string newsurname)
        {
            new_name = newname;
            new_surname = newsurname;

            InitializeComponent();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (radioButton3.Checked == true || radioButton4.Checked == true) && (radioButton5.Checked == true || radioButton6.Checked == true) && (radioButton7.Checked == true || radioButton8.Checked == true) && (radioButton9.Checked == true || radioButton10.Checked == true)) 
            {
                if (radioButton1.Checked == true)
                {
                    trying.Add_test_pl(1);
                }
                if (radioButton4.Checked == true)
                {
                    trying.Add_test_pl(1);
                }
                if (radioButton6.Checked == true)
                {
                    trying.Add_test_pl(1);
                }
                if (radioButton8.Checked == true)
                {
                    trying.Add_test_pl(1);
                }
                if (radioButton10.Checked == true)
                {
                    trying.Add_test_pl(1);
                }

                Form6 fr6 = new Form6(new_name, new_surname, trying.test_pl);
                fr6.ShowDialog();
                fr6.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Вы ответили не на все вопросы!";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e) {}

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        Test_hobbi trying = new Test_hobbi();

        string new_name = "";
        string new_surname = "";
        string new_age = "";
        string new_pol = "";

        public Form2(string newname, string newsurname, string newage, string newpol)
        {
            new_name = newname;
            new_surname = newsurname;
            new_age = newage;
            new_pol = newpol;

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (radioButton3.Checked == true || radioButton4.Checked == true) && (radioButton5.Checked == true || radioButton6.Checked == true) && (radioButton7.Checked == true || radioButton8.Checked == true) && (radioButton9.Checked == true || radioButton10.Checked == true) && (radioButton11.Checked == true || radioButton12.Checked == true) && (radioButton13.Checked == true || radioButton14.Checked == true) && (radioButton15.Checked == true || radioButton16.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    trying.Add_w(1);
                }
                if (radioButton4.Checked == true)
                {
                    trying.Add_r(1);
                }
                if (radioButton6.Checked == true)
                {
                    trying.Add_w(1);
                }
                if (radioButton8.Checked == true)
                {
                    trying.Add_e(1);
                }
                if (radioButton10.Checked == true)
                {
                    trying.Add_t(1);
                }
                if (radioButton12.Checked == true)
                {
                    trying.Add_t(1);
                }
                if (radioButton14.Checked == true)
                {
                    trying.Add_w(1);
                }
                if (radioButton16.Checked == true)
                {
                    trying.Add_q(1);
                }
                Form3 fr3 = new Form3(new_name, new_surname, new_age, new_pol, trying.q_pl, trying.w_pl, trying.e_pl, trying.r_pl, trying.t_pl);
                fr3.ShowDialog();
                fr3.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Вы ответили не на все вопросы!";
            }  
        }

        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string new_name = "";
        string new_surname = "";
        string new_age = "";
        string new_pol = "";

        int new_q_pl = 0;

        int new_w_pl = 0;

        int new_e_pl = 0;

        int new_r_pl = 0;

        int new_t_pl = 0;
        public Form3(string newname, string newsurname, string newage, string newpol, int newq_pl, int neww_pl, int newe_pl, int newr_pl, int newt_pl)
        {
            new_name = newname;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (radioButton3.Checked == true || radioButton4.Checked == true) && (radioButton5.Checked == true || radioButton6.Checked == true) && (radioButton7.Checked == true || radioButton8.Checked == true) && (radioButton9.Checked == true || radioButton10.Checked == true) && (radioButton11.Checked == true || radioButton12.Checked == true) && (radioButton13.Checked == true || radioButton14.Checked == true)) 
            {
                if (radioButton1.Checked == true)
                {
                    new_e_pl = new_e_pl + 1;
                }
                if (radioButton4.Checked == true)
                {
                    new_r_pl = new_r_pl + 1;
                }
                if (radioButton6.Checked == true)
                {
                    new_e_pl = new_e_pl + 1;
                }
                if (radioButton8.Checked == true)
                {
                    new_q_pl = new_q_pl + 1;
                }
                if (radioButton10.Checked == true)
                {
                    new_t_pl = new_t_pl + 1;
                }
                if (radioButton12.Checked == true)
                {
                    new_r_pl = new_r_pl + 1;
                }
                if (radioButton14.Checked == true)
                {
                    new_q_pl = new_q_pl + 1;
                }
                Form4 fr4 = new Form4(new_name, new_surname, new_age, new_pol, new_q_pl, new_w_pl, new_e_pl, new_r_pl, new_t_pl);
                fr4.ShowDialog();
                fr4.StartPosition = FormStartPosition.CenterScreen;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e){ }
        private void button18_Click_1(object sender, EventArgs e){}

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }  
}

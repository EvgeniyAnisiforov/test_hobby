using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string new_name = "";
        string new_surname = "";
        int new_test_pl = 0;

        public Form6(string newname, string newsurname, int newtestpl)
        {
            new_name = newname;
            new_surname = newsurname;
            new_test_pl = newtestpl;
            
            InitializeComponent();
        }
        

        private void button21_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (radioButton3.Checked == true || radioButton4.Checked == true) && (radioButton5.Checked == true || radioButton6.Checked == true) && (radioButton7.Checked == true || radioButton8.Checked == true) && (radioButton9.Checked == true || radioButton10.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    new_test_pl = new_test_pl + 1;
                }
                if (radioButton4.Checked == true)
                {
                    new_test_pl = new_test_pl + 1;
                }
                if (radioButton6.Checked == true)
                {
                    new_test_pl = new_test_pl + 1;
                }
                if (radioButton8.Checked == true)
                {
                    new_test_pl = new_test_pl + 1;
                }
                if (radioButton10.Checked == true)
                {
                    new_test_pl = new_test_pl + 1;
                }
                Form7 fr7 = new Form7(new_name, new_surname, new_test_pl);
                fr7.ShowDialog();
                fr7.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Вы ответили не на все вопросы!";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}

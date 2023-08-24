using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public class Person
    {
        public string name = "";
        public string surname = "";
        public string age = "";
        public string pol = "";
        public string test = "";
        public void Add_name(string xz)
        {
            name =  xz;
        }
        public void Add_surname(string xz)
        {
            surname = xz;
        }
        public void Add_age(string xz)
        {
            age = xz;
        }
        public void Add_pol(string xz)
        {
            pol = xz;
        }
        public void Add_test(string xz)
        {
            test = test + xz;
        }
    }
    public class Test_hobbi : Person
    {
        public int q_pl = 0;
        public int w_pl = 0;
        public int e_pl = 0;
        public int r_pl = 0;
        public int t_pl = 0;
        //метод добавления очков за тест по категории q - коллекционирование
        public void Add_q(int qp)
        {
            q_pl = q_pl + qp;
        }
        //метод добавления очков за тест по категории w - мастерить
        public void Add_w(int wp)
        {
            w_pl = w_pl + wp;
        }
        //метод добавления очков за тест по категории e - активные
        public void Add_e(int ep)
        {
            e_pl = e_pl + ep;
        }
        //метод добавления очков за тест по категории r - спорт
        public void Add_r(int rp)
        {
            r_pl = r_pl + rp;
        }
        //метод добавления очков за тест по категории t - гумманитарные
        public void Add_t(int tp)
        {
            t_pl = t_pl + tp;
        }
    }
    public class Test_work : Person
    {
        //подсчет баллов 2 тест
        public int test_pl = 0;
        public void Add_test_pl(int pet)
        {
            test_pl = test_pl + pet;
        }
    }

}
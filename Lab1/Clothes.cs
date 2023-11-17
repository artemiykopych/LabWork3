using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal abstract class Clothes
    {
        public string clothes;

        public abstract string Show();
        public abstract double Expenses();
    }

    internal class Coat : Clothes
    {
        int v = 0;

        public Coat(int v)
        {
            this.v = v;
            clothes = "Пальто.";
        }

        public override double Expenses() 
        {
            return v / 6.5 + 0.5;
        }

        public override string Show() {
            return "Одяг - " + clothes + " Розмір = " + v;
        }
    }

    internal class Suit : Clothes
    {
        int h = 0;

        public Suit(int h)
        {
            this.h = h;
            clothes = "Костюм.";
        }

        public override double Expenses()
        {
            return 2 * h + 0.3;
        }

        public override string Show()
        {
            return "Одяг - " + clothes + " Зріст = " + h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Lab1
{
    internal class Table
    {
        string name = "Стіл";
        double s;

        public Table() {
            name = "Стіл";
            s = 50;
        }

        public Table(string name, double s) { 
            this.name = name; this.s = s;
        }

        public double S
        {
            get { return s; }
            set { s = value; }
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public virtual double C()
        {
            return s / 3;
        }
    }

    internal class WritingTable : Table
    {
        string material = "Дерево";
        double proc;

        public WritingTable(string material, string name, double s)
        {
            this.material = material;
            this.Name = name;
            this.S = s;
            this.proc = Proc();
        }

        public WritingTable(string name, double s)
        {
            this.Name = name;
            this.S = s;
            this.proc = Proc();
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public override double C()
        {
            return S / 3 + 6;
        }

        public double Proc()
        {
            return C() * 0.1;
        }

        public double Full()
        {
            return Proc() + C();
        }
    }
}

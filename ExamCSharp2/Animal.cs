using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCSharp2
{
    internal class Animal
    {

        protected double weight;
        protected string name;

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
        }
    }

    class Lion : Animal
    {
        public Lion(double weight, string name)
        {
            base.SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine("Lion Characteristics:");
            base.Show();
        }
    }

    class Tiger : Animal
    {
        public Tiger(double weight, string name)
        {
            base.SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine("Tiger Characteristics:");
            base.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");

            lion.Show();
            Console.WriteLine();

            tiger.Show();
            Console.ReadLine();
        }
    }
}

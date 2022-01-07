using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Labovkin
{
    struct Equation
    {
        private const int zero = 0; /* неизменяемое поле*/
        public double k;
        public double b;
        public Equation(double k, double b) /*создание конструктора структуры*/
        {
            this.k = k;
            this.b = b;
        }
        //пишем метод решения линейного уравнение
        public double Root()
        {
            return zero - b / k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation(-5.7, 13.4); /*создание экземляра струтуры*/
            Console.WriteLine("Корень уравнения x равен");
            Console.WriteLine(equation.Root());
            Console.ReadKey();
        }
    }
}

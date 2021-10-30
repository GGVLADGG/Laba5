using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Laba5Work2
{
    class Conoid : Cone
    {
        public Conoid()
        {
            VConoid();
        }
        private void VConoid()
        {
            V = p * h * (R * R + R * r + r * r) / 3;
            Console.WriteLine("Об'єм зрізаного конуса: " + V);
        }
        public static void Input1()
        {
            Console.WriteLine("Введіть висоту конуса: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть радіус більшої основи конуса: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть радіус меншої основи конуса: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Висота конуса: " + h);
            Console.WriteLine("Радіус більшої основи: " + R);
            Console.WriteLine("Радіус меншої основи: " + r);
        }
    }
}

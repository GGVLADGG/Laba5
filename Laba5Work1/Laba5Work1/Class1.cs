using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba5Work1
{
    class RemoveSquare
    {
        public static int x, y, length, RemoveOrRotate;
        public static Rectangle rect = new Rectangle();
        public static Point l1 = new Point();
        public static Point l2 = new Point();
        public static Point r1 = new Point();
        public static Point r2 = new Point();
        public RemoveSquare()
        {
            if (RemoveOrRotate == 1)
            {
                RectangleInfo();
                Console.WriteLine("Нажмите стрелку вправо - чтобы передвинуть квадрат вправо, или стрелку влево - чтобы передвинуть влево");
            }
            while (RemoveOrRotate == 1)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    l1.X++;
                    l2.X++;
                    r1.X++;
                    r2.X++;
                    ShowPlace();
                }
                else if (button == "LeftArrow")
                {
                    Remove();
                }
            }
        }
        public static void Input()
        {
            Console.WriteLine("Введите верхний левый угол квадрата (координаты), и его длинну");
            Console.WriteLine("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите '1', если хотите передвинуть квадрат, введите '2', если хотите вращать");
            RemoveOrRotate = Convert.ToInt32(Console.ReadLine());
        }
        private void Remove()
        {
            l1.X--;
            l2.X--;
            r1.X--;
            r2.X--;
            ShowPlace();
        }
        protected void RectangleInfo()
        {
            l1.X = x;
            l1.Y = y;
            l2.X = x;
            l2.Y = y - length;
            r1.X = x + length;
            r1.Y = y;
            r2.X = x + length;
            r2.Y = y - length;
            rect.X = l1.X;
            rect.Y = l1.Y;
            rect.Width = length;
            rect.Height = length;
            ShowPlace();
            Console.WriteLine("Параметры квадрата: " + rect);
        }
        protected void ShowPlace()
        {
            Console.WriteLine("");
            Console.WriteLine("Координаты верхнего левого угла: " + l1);
            Console.WriteLine("Координаты нижнего левого угла: " + l2);
            Console.WriteLine("Координаты верхнего правого угла: " + r1);
            Console.WriteLine("Координаты нижнего правого угла: " + r2);
            Console.WriteLine("");
            Console.WriteLine("=========================================");
            Console.WriteLine("");
        }
    }
}

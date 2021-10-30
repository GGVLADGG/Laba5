using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba5Work1
{
    class RotateSquare : RemoveSquare
    {
        public static Point p = new Point();
        public RotateSquare()
        {
            if (RemoveOrRotate == 2)
            {
                RectangleInfo();
                Console.WriteLine("Нажмите стрелку вправо - чтобы перевернуть квадрат вправо, или стрелку влево - чтобы перевернуть влево");
            }
            while (RemoveOrRotate == 2)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    p = l1;
                    l1 = l2;
                    l2 = r2;
                    r2 = r1;
                    r1 = p;
                    ShowPlace();
                }
                else if (button == "LeftArrow")
                {
                    LeftArrow();
                }
            }
        }
        private void LeftArrow()
        {
            p = l2;
            l2 = l1;
            l1 = r1;
            r1 = r2;
            r2 = p;
            ShowPlace();
        }
    }
}

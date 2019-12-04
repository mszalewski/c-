using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Liczba
    {
        int X;

        Liczba(int x)
        {
            this.X = x;
        }
        /*public static Liczba operator +(Liczba x, Liczba y)
        {
            Liczba a = new Liczba(x.X);
            a.X += y.X * 3;
            return a;
        }*/
        public static implicit operator Liczba(int x)
        {
            return new Liczba(x+1);
        }
        public int GetX()
        {
            return X;
        }
        public override String ToString()
        {
            return X.ToString();
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Liczba x = 2;
            Liczba y = 3;
            Liczba a = x.GetX();
            Liczba b = y.GetX();
            Console.WriteLine("a:{0} c:{1}", a, b);
            //Liczba z = x + y + 1;
            //Console.WriteLine("x:{0} y:{1} z:{2}", x, y, z); // 2 4 20
            Console.ReadKey();
        }
    }
}

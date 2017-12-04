using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacNhat
{
    public class ptbn
    {
        public bool BatLoi(string x)
        {
            try
            {
                float a = float.Parse(x);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public float Doi(string x)
        {
            return float.Parse(x);
        }
        public string GPT(float a, float b)
        {
            if (a != 0)
            {
                return "co nghiem: " + (-b/a);
            }
            else
            {
                if (b == 0)
                {
                    return "vo so nghiem";
                }
                else
                {
                    return "vo nghiem";
                }
            }
        }
        string a, b;
        float _a, _b;
        static void Main(string[] args)
        {
            ptbn pt = new ptbn();
            nhaplai:
            Console.Write(" - Nhap he so a: ");
            pt.a = Console.ReadLine();
            Console.Write(" - Nhap he so b: ");
            pt.b = Console.ReadLine();
            if (!pt.BatLoi(pt.a)||!pt.BatLoi(pt.b))
            {
                Console.WriteLine("\t:( Nhap sai he so!");
                goto nhaplai;
            }
            else
            {
                pt._a = pt.Doi(pt.a);
                pt._b = pt.Doi(pt.b);
                Console.WriteLine("Phuong trinh "+pt.GPT(pt._a, pt._b));
            }
            Console.Read();
        }
    }
}

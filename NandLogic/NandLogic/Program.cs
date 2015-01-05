using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NandLogic
{
    class Program
    {
        
        static Func<bool, bool, bool> Nand = (a, b) => !(a && b);
        static Action<bool> write = c => Console.WriteLine(c.ToString());


        static void Main(string[] args)
        {
            Console.WriteLine("Nand");
            //Nand Truth Table 
            write(Nand(false, false)); //True
            write(Nand(false, true)); //True
            write(Nand(true, false)); //True
            write(Nand(true, true)); //False

            Console.WriteLine("Or");
            write(false || false); //false
            write(false || true); //true
            write(true || false);//true
            write(true || true);//true

            Console.WriteLine("Not");
            write(!true); //false
            write(!false); //true

            Console.WriteLine("And");
            write(false && false);//false
            write(false && true);//false
            write(true && false);//false
            write(true && true);//true

            write(false && false);//false
            write(false && true);//false
            write(true && false);//false
            write(true && true);//true
            
            Console.ReadLine();

        }

        //public static bool operator &(bool a, bool b)
        //{
        //    return Nand(Nand(Nand(Nand(a, a), Nand(a, a)), b), Nand(Nand(Nand(a, a), Nand(b, b)), a));
        //}

        //public static bool operator |(bool a, bool b)
        //{
        //    return Nand(Nand(a, a), Nand(b, b));
        //}

        //public static bool operator !(bool a)
        //{
        //    return Nand(a, a);
        //}

        public static bool Or(bool a, bool b)
        {
            return Nand(Nand(a, a), Nand(b, b));
        }

        public static bool And(bool a, bool b)
        {
            return Nand(Nand(Or(a, a), b), Nand(Or(b, b), a));
        }

        public static bool Not(bool a)
        {
            return Nand(a, a);
        }

    }
}

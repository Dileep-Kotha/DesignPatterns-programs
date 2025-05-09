using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance=null;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public void display()
        {
            Console.WriteLine("Singleton Pattern");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s=Singleton.GetInstance();
            s.display();
            //Singleton s = Singleton.GetInstance();
            //s.display();

        }
    }
}

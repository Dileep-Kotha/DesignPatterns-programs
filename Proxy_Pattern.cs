using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    internal class Program
    {
        public interface IBankserver//interface
        {
            void withdraw(int amount);
        }
        public class RBankserver:IBankserver//Real object
        {
            public void  withdraw(int amount)
            {
                Console.WriteLine($"{amount} of money is withdrawed");
            }
        }
        public class Proxy : IBankserver//proxy it verifies and provides security
        {
            public RBankserver r;
            public void withdraw(int amount) {
                if(r == null)
                {
                    r = new RBankserver();
                }
                Console.WriteLine("validating");
                r.withdraw(amount);
            }
            

        }
        static void Main(string[] args)
        {
            IBankserver i = new RBankserver();//creating  bank object
            i.withdraw(5000);
        }
    }
}

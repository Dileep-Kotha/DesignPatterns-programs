using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public interface command
    {
        void Execute();
    }
    class Lighton : command
    {
        public void Execute()
        {
            Console.WriteLine("Light On");
        }
    }
    class Lightoff : command
    {
        public void Execute()
        {
            Console.WriteLine("Light OFF");
        }
    }
    public class Remote//Invoker
    {
        public void pressbutton(command c)
        {
            c.Execute();
        }
    }
    internal class Program
    {
        static void Main(string[] args)//Client
        {
            Remote remote = new Remote();
            remote.pressbutton(new Lighton());
            remote.pressbutton(new Lightoff());


        }
    }
}

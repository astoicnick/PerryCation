using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Console : IConsole
    {
        public string Readline()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            System.Console.WriteLine();
        }
    }
    public class MockConsole : IConsole
    {
        public string Readline()
        {
            return "expected string";
        }

        public void WriteLine(string message)
        {
            return;
        }
    }

    public interface IConsole
    {
        void WriteLine(string message);
        string Readline();
    }
}

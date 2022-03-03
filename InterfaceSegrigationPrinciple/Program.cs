using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class HPPrinter : IPrintTask, IFaxTask
    {
        public void Fax(string content)
        {
            Console.WriteLine("Fax done!");
        }

        public void Photocopy(string content)
        {
            Console.WriteLine("Photocopy done!");
        }

        public void Print(string content)
        {
            Console.WriteLine("Print done!");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan done!");
        }
    }

    public class CannonPrinter : IPrintTask
    {
        public void Photocopy(string content)
        {
            Console.WriteLine("Photocopy done!");
        }

        public void Print(string content)
        {
            Console.WriteLine("Print done!");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan done!");
        }
    }

    public interface IPrintTask
    {
        void Print(string content);
        void Photocopy(string content);
        void Scan(string content);
    }

    public interface IFaxTask
    {
        void Fax(string content);
    }
}

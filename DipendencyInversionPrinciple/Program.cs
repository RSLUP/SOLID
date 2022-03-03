using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipendencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class UserBusinessLayer
    {
        private readonly IDBAccess dBAccess;
        public UserBusinessLayer(IDBAccess _dBAccess)
        {
            dBAccess = _dBAccess;
        }
        public void ManageUser()
        {
            dBAccess.SaveUser();
        }
    }

    public class DBAccess: IDBAccess
    {
        public void SaveUser()
        {
            Console.WriteLine("Save user");
        }
    }

    public interface IDBAccess 
    {
        void SaveUser();
    }
}

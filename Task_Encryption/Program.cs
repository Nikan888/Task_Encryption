using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Task_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "TestString1";
            Encryption.RSA(text);
            Console.ReadKey();
        }
    }
}

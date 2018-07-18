using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            if ((args.Length == 3) && (args[0].Equals("k")))
            {
                // Generate a new key pair               
                Encryption.GenerateKeys(args[1], args[2]);
            }

            else if ((args.Length == 4) && (args[0].Equals("e")))
            {
                // Encrypt a file
                Encryption.Encrypt(args[1], args[2], args[3]);
            }

            else if ((args.Length == 4) && (args[0].Equals("d")))
            {
                // Decrypt a file
                Encryption.Decrypt(args[1], args[2], args[3]);
            }

            else
            {
                // Show usage
                Console.WriteLine("Usage:");
                Console.WriteLine("   - New key pair: EncryptDecrypt k public_key_file private_key_file");
                Console.WriteLine("   - Encrypt:      EncryptDecrypt e public_key_file plain_file encrypted_file");
                Console.WriteLine("   - Decrypt:      EncryptDecrypt d private_key_file encrypted_file plain_file");
            }

            // Exit
            Console.WriteLine("\n<< Press any key to continue >>");
            Console.ReadKey();
            return;
        }
    }
}

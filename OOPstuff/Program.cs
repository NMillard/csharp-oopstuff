using System;
using System.Security.Cryptography;
using System.Text;

namespace OOPstuff {

    class Program {

        static void Main(string[] args) {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            byte[] data = new byte[32];
            rng.GetBytes(data);

            var base64 = Convert.ToBase64String(data);

            Console.Read();
        }
    }
}

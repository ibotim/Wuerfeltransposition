using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Würfeltransposition
{
    public static class Decryptor
    {
        public static string DecryptString(string cipher, int blockLength)
        {
            return Transposition.Algorithmus(cipher, blockLength, false);
        }

        public static void DecryptFileContent(string inFilePath, string outFilePath, int blockLength)
        {
            string cipher = File.ReadAllText(inFilePath);
            string plainText = DecryptString(cipher, blockLength);
            File.WriteAllText(outFilePath, plainText);
        }

        public static void DecryptFileContent(string filePath, int blockLength)
        {
            DecryptFileContent(filePath, filePath, blockLength);
        }

        public static void DecryptFile(string inFilePath, string outFilePath, int blockLength)
        {
            throw new NotImplementedException();
        }

        public static void DecryptFile(string filePath, int blockLength)
        {
            throw new NotImplementedException();
        }

    }
}

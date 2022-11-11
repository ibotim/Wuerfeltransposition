using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Würfeltransposition
{
    public static class Encryptor
    {
        public static string EncryptString(string plaintext, int blockLength)
        {
            return Transposition.Algorithmus(plaintext, blockLength, true);
        }

        public static void EncryptFileContent(string inFilePath, string outFilePath, int blockLength)
        {
            string plaintext = File.ReadAllText(inFilePath);
            string cipher = EncryptString(plaintext, blockLength);
            File.WriteAllText(outFilePath, cipher);
        }

        public static void EncryptFileContent(string filePath, int blockLength)
        {
            EncryptFileContent(filePath, filePath, blockLength);
        }

        public static void EncryptFile(string inFilePath, string outFilePath, int blockLength)
        {
            throw new NotImplementedException();
        }

        public static void EncryptFile(string FilePath, int blockLength)
        {
            throw new NotImplementedException();
        }
    }
}

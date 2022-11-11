using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Würfeltransposition
{
    public static class Transposition
    {
                                                                     // true  --> encrypt
                                                                     // false --> decrypt
        public static string Algorithmus(string text, int blockLength, bool mode)
        {
            int blockCount;
            char[] result = new char[text.Length];
            int counter = 0;

            if (text.Length % blockLength != 0)
                blockCount = (text.Length / blockLength) + 1;
            else
                blockCount = text.Length / blockLength;

            for (int i = 0; i < blockLength; i++)
            {
                for (int j = 0; j < blockCount; j++)
                {
                    int index = i + j * blockLength;
                    try
                    {
                        if (mode)
                            result[counter] = text[index];
                        else
                            result[index] = text[counter];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                    counter++;
                }
            }
            return new string(result);
        }
    }
}

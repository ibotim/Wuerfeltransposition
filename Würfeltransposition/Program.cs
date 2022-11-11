// See https://aka.ms/new-console-template for more information

using Würfeltransposition;

namespace Würfeltransposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wollen Sie die Operation an einer Datei [f], oder einem String [s] durchführen");
            string fileMode = Console.ReadLine().ToLower();

            Console.WriteLine("Geben Sie die Blocklänge ein");
            int blockLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wollen Sie verschlüsseln [e], oder entschlüsseln [d]");
            string encryptioMode = Console.ReadLine().ToLower();

            switch (fileMode)
            {
                case "f":
                    Console.WriteLine("Bitte geben sie den Dateinamen der Input-Datei ein");
                    string inFilePath = Console.ReadLine();

                    Console.WriteLine("Bitte geben sie den Dateinamen der Output-Datei ein, um das Ergebnis in die gleiche Datei zu schreiben lassen Sie dieses Feld leer");
                    string outFilePath = Console.ReadLine();

                    try
                    {
                        switch (encryptioMode)
                        {
                            case "e":
                                if (!string.IsNullOrEmpty(outFilePath))
                                    Encryptor.EncryptFileContent(inFilePath, outFilePath, blockLength);
                                else
                                    Encryptor.EncryptFileContent(inFilePath, blockLength);
                                break;
                            case "d":
                                if (!string.IsNullOrEmpty(outFilePath))
                                    Decryptor.DecryptFileContent(inFilePath, outFilePath, blockLength);
                                else
                                    Decryptor.DecryptFileContent(inFilePath, blockLength);
                                break;
                            default:
                                Exit("Fehler: Bitte überprüfen Sie den Dateinamen");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Exit();
                    }
                    
                    break;
                case "s":
                    Console.WriteLine("Geben Sie den Text ein, den Sie ver- oder entschlüsseln wollen.");
                    string text = Console.ReadLine();

                    switch (encryptioMode)
                    {
                        case "e":
                            string encrypted = Encryptor.EncryptString(text, blockLength);
                            Console.WriteLine($"Der verschlüsselte Text lautet: {encrypted}");
                            break;
                        case "d":
                            string decrypted = Decryptor.DecryptString(text, blockLength);
                            Console.WriteLine($"Der entschlüsselte Text lautet: {decrypted}");
                            break;
                        default:
                            Exit();
                            break;
                    }
                    break;
                default:
                    Exit();
                    break;
            }
        }

        static void Exit()
        {
            Console.WriteLine("Fehler, Programm wird beendet");
            Environment.Exit(0);
        }
        static void Exit(string message)
        {
            Console.WriteLine($"{message}. Programm wird beendet");
            Environment.Exit(1);
        }
    }
}
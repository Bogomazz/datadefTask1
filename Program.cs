using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {

        public static int Xor(int a,int b){
            return a & ~b | ~a & b; 
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Charachter frequency----------");

            string fileContent;

            using (StreamReader reader = File.OpenText("./texts/artistic.txt"))
            {
                fileContent = reader.ReadToEnd();
            }

            var frequency = Calculator.CalculateFriquency(fileContent);

            foreach (var pair in frequency.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            

            Console.WriteLine("-----------------Cesar encrypting--------------");
            Alphabet latinAlphabet = new Alphabet("abcdefghijklmnopqrstuvwxyz");
            string text = "text encrypted by cesar method";
            int shift = -2;

            Console.WriteLine($"Text: {text}, shift: {shift}");
            Console.WriteLine(Encryptor.Cesar(text, shift, latinAlphabet));
            
            Console.WriteLine("---------------XOR-------------");
            Console.WriteLine(Xor(1, 1));
            Console.WriteLine(Xor(1, 0));
            Console.WriteLine(Xor(0, 1));
            Console.WriteLine(Xor(0, 0));

            var encryptKey =  Encryptor.Verrnam("Hallo, world!");
            
            string encryptedText = encryptKey.Item1;
            string key = encryptKey.Item2;
            
            Console.WriteLine("----------Verrnam encrypting-----------");
            Console.WriteLine("Encrypted text: " + encryptedText);
            Console.WriteLine("Key text: " + key);
            Console.WriteLine("Decrypted text: " + Decryptor.Verrnam(encryptedText, key));
            
        }
    }
}

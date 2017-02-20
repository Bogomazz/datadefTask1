using System;
using System.Text;

namespace ConsoleApplication
{
    public class Encryptor
    {
        public static int Xor(int a,int b){
            return a & ~b | ~a & b; 
        }
        public static string Cesar(string fullText, int shift, Alphabet alphabet)
        {
            string[] chunks = fullText.Split(' ');
            string encryptedText = "";
            foreach(string text in chunks){
                foreach (char i in text)
                {
                    int index;
                    if (alphabet[i] + shift > 0){
                        index = alphabet[i] + shift;
                    }
                    else {
                        index = alphabet.Length - alphabet[i] + shift;
                    }
                    encryptedText += alphabet[ index % alphabet.Length];                
                }
                encryptedText += " ";
            }
        
            return encryptedText;
        }

        public static Tuple<string, string> Verrnam(string text){
            byte[] bytes = Encoding.Unicode.GetBytes(text);

            byte[] key = new byte[bytes.Length];
            Random r = new Random();
            r.NextBytes(key);

            byte[] result = new byte[bytes.Length];

            for (int i = 0; i < bytes.Length; i++){
                result[i] = (byte) Xor((int)bytes[i],(int)key[i]);
            }

            return new Tuple<string, string>
            (
                Encoding.Unicode.GetString(result),
                Encoding.Unicode.GetString(key)
            );

        }
    }
}

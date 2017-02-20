using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    public class Decryptor
    {
        public static int Xor(int a,int b){
            return a & ~b | ~a & b; 
        }

        public static string Verrnam(string encryptedText, string key){
            byte[] bytes = Encoding.Unicode.GetBytes(encryptedText);
            byte[] keyBytes = Encoding.Unicode.GetBytes(key);

            byte[] result = new byte[bytes.Length];

            for (int i = 0; i < bytes.Length; i++){
                result[i] = (byte) Xor((int)keyBytes[i],(int)bytes[i]);
            }

            return Encoding.Unicode.GetString(result);

        }
    }
}

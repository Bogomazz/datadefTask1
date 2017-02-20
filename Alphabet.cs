using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Alphabet
    {
        private string alphabet;

        public Alphabet(string alphabet){
            this.alphabet = alphabet;
        }

        public int this[char i]{
            get {
                int res = alphabet.IndexOf(i);
                if (res == -1)
                {
                    throw new IndexOutOfRangeException();
                }
                return res;
            }
        }

        public char this[int i]{
            get {
                return alphabet[i];
            }
        }

        public int Length
        {
            get 
            {
                return alphabet.Length;
            }
        }
    }
}

using System;
using System.Linq;

namespace HoloalphabeticSentence{
    public class HoloalphabeticSentence{
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz"){
            bool[] check = new bool[26]; // For checking 26 letters
            int len = input.Length;
            int index = 0;
            for (int i = 0; i<len; i++){
                if ('A' <= input[i] && input[i] <= 'Z')
                    index = input[i] - 'A';
                else if('a' <= input[i] && input[i] <= 'z')
                    index = input[i] - 'a';
                check[index] = true; // Marking found character
            }
            for (int i=0; i<=25; i++)
                if (check[i] == false)
                    return false;
            return true; // If all characters were present
        }
    }
}

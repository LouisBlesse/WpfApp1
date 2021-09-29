using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace WpfApp1
{
    public class Io
    {
        public static char OnClick(string text)
        {
            char input = text [1];
            return input;
        }
        
        public static string Decalage(string text)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var NewText= new List<char>();
            text=text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                var index = alphabet.IndexOf(text[i]);
                if (index == 25)
                {
                    NewText.Add(alphabet[0]);
                }
                else
                {
                    NewText.Add(alphabet[index + 1]);
                }
                
            }

            string NewString = string.Join("", NewText.ToArray());
            return NewString;
        }

        public static string Binary(string text)
        {
            StringBuilder Binaire = new StringBuilder();

            foreach (char carca in text)
            {
                Binaire.Append(Convert.ToString(carca, 2).PadLeft(8, '0'));
            }
            return Binaire.ToString();
        }
        
        /*public static string 3eme encryption(string text)
        {
            TODO AYMERIC
            return A string;
        }*/
    }
}
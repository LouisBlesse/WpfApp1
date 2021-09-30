using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //La fonction va décalé tous les caractères de 1 en ASCII
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(text);
            var NewText= new List<char>();
            foreach(var value in ASCIIvalues)
            {
                int NewVal = value + 1;
                char c = (char) NewVal;
                NewText.Add(c);
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
        
        public static string VigenèreCipher(string text, string key)
        {
            //Ici la clé sera l'alhpabet latin.
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            text=text.ToLower();
            var NewText= new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                int ValLettre = alphabet.IndexOf(text[i]);//valeur de la lettre

                int ValInKey = alphabet.IndexOf(key[i]); //lettre dans la clée

                int ValFinale = (ValLettre + ValInKey) % 26;
                NewText.Add(alphabet[ValFinale]);
            }

            string NewString = string.Join("", NewText.ToArray());
            return NewString;
        }
    }
}
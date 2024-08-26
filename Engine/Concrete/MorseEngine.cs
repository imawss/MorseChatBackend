using Engine.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Concrete
{
    public class MorseEngine : IMorseEngine
    {
        private static readonly Dictionary<char, string> alphabetToMorse = new Dictionary<char, string>
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
            {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
            {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
            {'8', "---.."}, {'9', "----."},
            {' ', "/"} 
         };

        private static readonly Dictionary<string, char> morseToAlphabet = new Dictionary<string, char>();

        static MorseEngine()
        {
            foreach(var element in alphabetToMorse)
            {
                morseToAlphabet[element.Value] = element.Key;
            }
        }

        public string MorseToText(string morseCode)
        {
            StringBuilder textBuilder = new StringBuilder();
            string[] codes = morseCode.Split(' ');
            foreach (string code in codes)
            {
                if (morseToAlphabet.ContainsKey(code))
                {
                    char textValue = morseToAlphabet[code];
                    textBuilder.Append(textValue);
                }
                else
                {
                    textBuilder.Append('?');
                }
            }
            return textBuilder.ToString().Trim();
        }

        public string TextToMorse(string text)
        {
            StringBuilder morseBuilder = new StringBuilder();
            foreach (char c in text.ToUpper())
            {
                if (alphabetToMorse.ContainsKey(c))
                {
                    morseBuilder.Append(alphabetToMorse[c] + " ");
                }
                else
                {
                    morseBuilder.Append("?");
                }
            }
            return morseBuilder.ToString().Trim();
        }
    }
}

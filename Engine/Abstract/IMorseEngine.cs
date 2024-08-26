using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Abstract
{
    public interface IMorseEngine
    {
        public string TextToMorse(string text);
        public string MorseToText(string morseCode);
    }
}

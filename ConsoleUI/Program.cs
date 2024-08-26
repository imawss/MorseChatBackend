using Engine.Concrete;
MorseEngine morseEngine = new MorseEngine();
string morseCode = morseEngine.MorseToText("... . .-.. .- --");
Console.WriteLine(morseCode);
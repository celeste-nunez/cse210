using System.Runtime.CompilerServices;

class Word 
{
    private static List<string> ScriptureList()
    {
        return new List<string>
        {
            "In",
            "the",
            "world",
            "ye",
            "shall",
            "have",
            "tribulation",
            ":",
            "but",
            "be",
            "of",
            "good",
            "cheer",
            ";",
            "I",
            "have",
            "overcome",
            "the",
            "world.",
        };
    }

    private static void DisplayAllWords()
    {
        List<string> ScriptureWords = ScriptureList();
        foreach (string word in ScriptureList())
        {
            Console.Write(word + " ");
        } 
    }

    
}
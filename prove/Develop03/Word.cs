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
            "tribulation:",
            "but",
            "be",
            "of",
            "good",
            "cheer;",
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

    private static List<int> GetRandomWords()
    {
        List<string> ScriptureWords = ScriptureList();
        List<int> RandomWordInts = new List<int>{};
        int loopCount = 0;

        while (loopCount < 3)
        {
            Random random = new Random();
            int index = random.Next(ScriptureWords.Count);
            RandomWordInts.Add(index);
            loopCount ++;
        }

        return RandomWordInts;
    }

    
}
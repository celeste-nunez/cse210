using System.Runtime.CompilerServices;
class Word 
{
    private static List<int> hiddenIndexes = new List<int>();
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

    public static void DisplayAllWords()
    {
        foreach (string word in ScriptureList())
        {
            Console.Write(word + " ");
        } 
    }

    private static List<int> GetRandomWords()
    {
        List<string> ScriptureWords = ScriptureList();
        Random random = new Random();
        List<int> newIndexes = new List<int>{};

        while (newIndexes.Count < 3 && hiddenIndexes.Count + newIndexes.Count < ScriptureWords.Count)
        {   
            int index = random.Next(ScriptureWords.Count);
            if (!hiddenIndexes.Contains(index) && !newIndexes.Contains(index))
            {
                newIndexes.Add(index);
            }
        }

        return newIndexes;
    }

    public static void HideWords() 
    {
        List<string> words =  ScriptureList();
        List<int> NewIndexes = GetRandomWords();
        hiddenIndexes.AddRange(NewIndexes);

        foreach (int index in hiddenIndexes)
        {
            words[index] = new string('_', words[index].Length);
        }
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
    }  
}
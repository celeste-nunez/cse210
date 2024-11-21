class Reference 
{
    
    private static List<string> CreateReference()
    {
        return new List<string> 
        {
            "John",
            "16:33"
        };
    }
    public static void DisplayReference()
    {
        List<string> reference = CreateReference();
        foreach (string word in reference)
        {
            Console.Write(word + " ");
        }
    }
}